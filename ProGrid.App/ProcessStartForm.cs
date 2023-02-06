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
    public partial class ProcessStartForm : Form {
        private bool _bInitialized = false;
        private bool _bRunRequested = false;

        public ProcessStartForm() {
            InitializeComponent();

            ExecutablePathBox.Text = Properties.Settings.Default.NewProcessExecutablePath;
            ArgumentsBox.Text = Properties.Settings.Default.NewProcessArguments;
            WorkingDirBox.Text = Properties.Settings.Default.NewProcessWorkingDir;
            _bInitialized = true;
        }

        public string ExecutablePath {
            get => ExecutablePathBox.Text;
            set => ExecutablePathBox.Text = value ?? string.Empty;
        }

        public string Arguments {
            get => ArgumentsBox.Text;
            set => ArgumentsBox.Text = value ?? string.Empty;
        }

        public string WorkingDirectory {
            get => WorkingDirBox.Text;
            set => WorkingDirBox.Text = value ?? string.Empty;
        }

        private void ExecutablePathChooseButton_Click(object sender, EventArgs e) {
            if (ExecutableDialog.ShowDialog() == DialogResult.OK)
                ExecutablePathBox.Text = ExecutableDialog.FileName;
        }

        private void WorkingDirChooseButton_Click(object sender, EventArgs e) {
            if (WorkingDirDialog.ShowDialog() == DialogResult.OK)
                WorkingDirBox.Text = WorkingDirDialog.SelectedPath;
        }

        private void ExecutablePathBox_TextChanged(object sender, EventArgs e) {
            if (_bInitialized)
                Properties.Settings.Default.NewProcessExecutablePath = ExecutablePathBox.Text;
        }

        private void ArgumentsBox_TextChanged(object sender, EventArgs e) {
            if (_bInitialized)
                Properties.Settings.Default.NewProcessArguments = ArgumentsBox.Text;
        }

        private void WorkingDirBox_TextChanged(object sender, EventArgs e) {
            if (_bInitialized)
                Properties.Settings.Default.NewProcessWorkingDir = ArgumentsBox.Text;
        }

        private void RunButton_Click(object sender, EventArgs e) {
            _bRunRequested = true;
            Close();
        }

        private void ProcessStartForm_FormClosed(object sender, FormClosedEventArgs e) {
            DialogResult = _bRunRequested ? DialogResult.OK : DialogResult.Cancel;
            _bRunRequested = false;
            Properties.Settings.Default.Save();
        }
    }
}
