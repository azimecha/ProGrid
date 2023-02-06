using ProGrid.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProGrid.App {
    public partial class MainForm : Form {
        private IProcessCreationMonitor _monitor;
        private ProcessStartForm _dlgCreateProcess;
        private ProcessListForm _dlgRunningProcessList;

        public MainForm() {
            InitializeComponent();

            _monitor = new WMIProcessMonitor();
            _monitor.ProcessCreated += Monitor_ProcessCreated;
            _monitor.ProcessTerminated += Monitor_ProcessTerminated;

            _dlgCreateProcess = new ProcessStartForm();
            _dlgRunningProcessList = new ProcessListForm();
        }

        private void MainForm_Load(object sender, EventArgs e) { }

        private void CreateButton_Click(object sender, EventArgs e) {
            if (_dlgCreateProcess.ShowDialog() == DialogResult.OK) {
                SystemProcess proCreated;

                try {
                    proCreated = SystemProcess.Create(_dlgCreateProcess.ExecutablePath, _dlgCreateProcess.Arguments,
                        _dlgCreateProcess.WorkingDirectory);
                } catch (Exception ex) {
                    MessageBox.Show(this, ex.ToString(), "Error creating process", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                BasicProcessInfo infProcess = new BasicProcessInfo() {
                    CommandLine = _dlgCreateProcess.Arguments,
                    ExecutablePath = _dlgCreateProcess.ExecutablePath,
                    ID = proCreated.ID,
                    ProcessObject = proCreated,
                    ParentProcessObject = SystemProcess.Current
                };

                if (TryAddProcess(infProcess, true))
                    proCreated.Resume();
                else
                    proCreated.Terminate(-1);
            }
        }

        private void AttachButton_Click(object sender, EventArgs e) {
            if (_dlgRunningProcessList.ShowDialog() == DialogResult.OK)
                TryAddProcess(_dlgRunningProcessList.SelectedProcess.Value, true);
        }

        private bool TryAddProcess(BasicProcessInfo infProcess, bool bAddIfParentUnmonitored) {
            try {
                _monitor.MonitorProcess(infProcess.ProcessObject);

                TreeNode nodeNew = new TreeNode() {
                    Text = '#' + infProcess.ID.ToString() + ' ' + System.IO.Path.GetFileName(infProcess.ExecutablePath),
                    Tag = infProcess
                };

                TreeNode nodeParent = TryFindProcessNode(infProcess.ParentProcessObject.ID);
                if (nodeParent is null) {
                    if (bAddIfParentUnmonitored)
                        ProcessTree.Nodes.Add(nodeNew);
                } else {
                    nodeParent.Nodes.Add(nodeNew);
                }

                return true;
            } catch (Exception ex) {
                MessageBox.Show(this, ex.ToString(), "Error monitoring process", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            return false;
        }

        private void MarkProcessTerminated(BasicProcessInfo infProcess) {
            TreeNode nodeDead = TryFindProcessNode(infProcess.ID);
            if (nodeDead != null)
                nodeDead.Text = "[DEAD] " + nodeDead.Text;
        }

        private void Monitor_ProcessCreated(IProcessCreationMonitor monitor, BasicProcessInfo infNewProcess)
            => BeginInvoke((Func<BasicProcessInfo, bool, bool>)TryAddProcess, infNewProcess, false);

        private void Monitor_ProcessTerminated(IProcessCreationMonitor monitor, BasicProcessInfo infDeadProcess)
            => BeginInvoke((Action<BasicProcessInfo>)MarkProcessTerminated, infDeadProcess);

        private TreeNode TryFindProcessNode(int nProcessID)
            => TryFindProcessNode(nProcessID, ProcessTree.Nodes);

        private TreeNode TryFindProcessNode(int nProcessID, TreeNodeCollection collNodes) {
            foreach (TreeNode nodeCur in collNodes)
                if (TryFindProcessNode(nProcessID, nodeCur) is TreeNode nodeFound)
                    return nodeFound;

            return null;
        }

        private TreeNode TryFindProcessNode(int nProcessID, TreeNode nodeRoot) {
            if ((nodeRoot.Tag as BasicProcessInfo?)?.ID == nProcessID)
                return nodeRoot;

            foreach (TreeNode nodeCur in nodeRoot.Nodes)
                if (TryFindProcessNode(nProcessID, nodeCur) is TreeNode nodeFound)
                    return nodeFound;

            return null;
        }
    }
}
