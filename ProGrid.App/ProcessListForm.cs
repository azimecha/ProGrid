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
    public partial class ProcessListForm : Form {
        private IProcessListProvider _provProcessList;
        private int _nPIDWidth, _nHorizSpacing;
        private Brush _brListForeground;
        private bool _bMonitoringRequested = false;

        private static readonly StringFormat FORMAT_TABLE_ENTRY = new StringFormat() {
            Alignment = StringAlignment.Near,
            LineAlignment = StringAlignment.Center,
            Trimming = StringTrimming.None,
            FormatFlags = StringFormatFlags.NoWrap
        };

        public ProcessListForm() {
            InitializeComponent();
            _provProcessList = new ToolhelpProcessListProvider();
        }

        public BasicProcessInfo? SelectedProcess => ProcessListBox.SelectedItem as BasicProcessInfo?;

        private void ProcessListBox_DrawItem(object sender, DrawItemEventArgs e) {
            Rectangle rectPID = e.Bounds;
            rectPID.Width = _nPIDWidth;

            Rectangle rectExecutable = e.Bounds;
            rectExecutable.X += _nPIDWidth + _nHorizSpacing;

            e.DrawBackground();

            BasicProcessInfo infProcess = (BasicProcessInfo)ProcessListBox.Items[e.Index];
            Graphics gfx = e.Graphics;

            gfx.DrawString(infProcess.ID.ToString(), ProcessListBox.Font, _brListForeground, rectPID, FORMAT_TABLE_ENTRY);
            gfx.DrawString(infProcess.ExecutablePath, ProcessListBox.Font, _brListForeground, rectExecutable, FORMAT_TABLE_ENTRY);
        }

        private void ProcessListForm_VisibleChanged(object sender, EventArgs e) {
            if (Visible)
                RefreshProcessList();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
            => RefreshProcessList();

        public void RefreshProcessList() {
            ProcessListBox.Items.Clear();

            // dumbest C# code ever
            BasicProcessInfo[] arrProcesses = _provProcessList.CaptureProcessList();
            object[] arrBoxedProcesses = new object[arrProcesses.Length];
            for (int i = 0; i < arrProcesses.Length; i++)
                arrBoxedProcesses[i] = arrProcesses[i];

            ProcessListBox.Items.AddRange(arrBoxedProcesses);
        }

        private void ProcessListBox_ForeColorChanged(object sender, EventArgs e)
            => UpdateListColor();

        private void ProcessListBox_FontChanged(object sender, EventArgs e)
            => UpdateListFont();

        private void UpdateListColor() {
            Brush brPrev = _brListForeground;
            _brListForeground = null;
            brPrev?.Dispose();

            _brListForeground = new SolidBrush(ProcessListBox.ForeColor);
        }

        private void UpdateListFont() {
            using (Graphics gfx = Graphics.FromHwnd(((IWin32Window)this).Handle)) {
                _nPIDWidth = (int)Math.Ceiling(gfx.MeasureString("MMMMMMMM", ProcessListBox.Font).Width);
                _nHorizSpacing = (int)Math.Ceiling(gfx.MeasureString("M", ProcessListBox.Font).Width);
            }

            ProcessListBox.ItemHeight = Font.Height * 5 / 4;
        }

        private void MonitorButton_Click(object sender, EventArgs e) {
            if (SelectedProcess.HasValue) {
                _bMonitoringRequested = true;
                Close();
            }
        }

        private void ProcessListForm_FormClosed(object sender, FormClosedEventArgs e) {
            DialogResult = _bMonitoringRequested ? DialogResult.OK : DialogResult.Cancel;
            _bMonitoringRequested = false;
        }

        private void ProcessListBox_SelectedValueChanged(object sender, EventArgs e) {
            MonitorButton.Enabled = ProcessListBox.SelectedItem is BasicProcessInfo;
        }

        private void ProcessListForm_Load(object sender, EventArgs e) {
            UpdateListColor();
            UpdateListFont();
        }
    }
}
