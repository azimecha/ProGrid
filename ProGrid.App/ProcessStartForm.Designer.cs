namespace ProGrid.App {
    partial class ProcessStartForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ExecutablePathBox = new System.Windows.Forms.TextBox();
            this.ExecutablePathChooseButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ArgumentsBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.WorkingDirChooseButton = new System.Windows.Forms.Button();
            this.WorkingDirBox = new System.Windows.Forms.TextBox();
            this.RunButton = new System.Windows.Forms.Button();
            this.ExecutableDialog = new System.Windows.Forms.OpenFileDialog();
            this.WorkingDirDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 8, 8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Start New Process";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 12, 8, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Executable path:";
            // 
            // ExecutablePathBox
            // 
            this.ExecutablePathBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ExecutablePathBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ExecutablePathBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ExecutablePathBox.Location = new System.Drawing.Point(24, 99);
            this.ExecutablePathBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.ExecutablePathBox.Name = "ExecutablePathBox";
            this.ExecutablePathBox.Size = new System.Drawing.Size(323, 29);
            this.ExecutablePathBox.TabIndex = 3;
            this.ExecutablePathBox.TextChanged += new System.EventHandler(this.ExecutablePathBox_TextChanged);
            // 
            // ExecutablePathChooseButton
            // 
            this.ExecutablePathChooseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ExecutablePathChooseButton.FlatAppearance.BorderSize = 0;
            this.ExecutablePathChooseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExecutablePathChooseButton.Location = new System.Drawing.Point(367, 99);
            this.ExecutablePathChooseButton.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.ExecutablePathChooseButton.Name = "ExecutablePathChooseButton";
            this.ExecutablePathChooseButton.Size = new System.Drawing.Size(127, 29);
            this.ExecutablePathChooseButton.TabIndex = 4;
            this.ExecutablePathChooseButton.Text = "Choose...";
            this.ExecutablePathChooseButton.UseVisualStyleBackColor = false;
            this.ExecutablePathChooseButton.Click += new System.EventHandler(this.ExecutablePathChooseButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 12, 8, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Command line arguments:";
            // 
            // ArgumentsBox
            // 
            this.ArgumentsBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ArgumentsBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ArgumentsBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ArgumentsBox.Location = new System.Drawing.Point(24, 180);
            this.ArgumentsBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.ArgumentsBox.Name = "ArgumentsBox";
            this.ArgumentsBox.Size = new System.Drawing.Size(323, 29);
            this.ArgumentsBox.TabIndex = 6;
            this.ArgumentsBox.TextChanged += new System.EventHandler(this.ArgumentsBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 229);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 12, 8, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Working directory:";
            // 
            // WorkingDirChooseButton
            // 
            this.WorkingDirChooseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.WorkingDirChooseButton.FlatAppearance.BorderSize = 0;
            this.WorkingDirChooseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WorkingDirChooseButton.Location = new System.Drawing.Point(367, 261);
            this.WorkingDirChooseButton.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.WorkingDirChooseButton.Name = "WorkingDirChooseButton";
            this.WorkingDirChooseButton.Size = new System.Drawing.Size(127, 29);
            this.WorkingDirChooseButton.TabIndex = 9;
            this.WorkingDirChooseButton.Text = "Choose...";
            this.WorkingDirChooseButton.UseVisualStyleBackColor = false;
            this.WorkingDirChooseButton.Click += new System.EventHandler(this.WorkingDirChooseButton_Click);
            // 
            // WorkingDirBox
            // 
            this.WorkingDirBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.WorkingDirBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WorkingDirBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.WorkingDirBox.Location = new System.Drawing.Point(24, 261);
            this.WorkingDirBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.WorkingDirBox.Name = "WorkingDirBox";
            this.WorkingDirBox.Size = new System.Drawing.Size(323, 29);
            this.WorkingDirBox.TabIndex = 8;
            this.WorkingDirBox.TextChanged += new System.EventHandler(this.WorkingDirBox_TextChanged);
            // 
            // RunButton
            // 
            this.RunButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.RunButton.FlatAppearance.BorderSize = 0;
            this.RunButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RunButton.Location = new System.Drawing.Point(24, 314);
            this.RunButton.Margin = new System.Windows.Forms.Padding(3, 16, 0, 3);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(162, 29);
            this.RunButton.TabIndex = 10;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = false;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // ExecutableDialog
            // 
            this.ExecutableDialog.Filter = "Windows executables|*.exe|All files|*.*";
            // 
            // WorkingDirDialog
            // 
            this.WorkingDirDialog.Description = "Choose the initial current working directory for the process.";
            // 
            // ProcessStartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(538, 369);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.WorkingDirChooseButton);
            this.Controls.Add(this.WorkingDirBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ArgumentsBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ExecutablePathChooseButton);
            this.Controls.Add(this.ExecutablePathBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "ProcessStartForm";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.Text = "Pro Grid: Start Process";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProcessStartForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ExecutablePathBox;
        private System.Windows.Forms.Button ExecutablePathChooseButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ArgumentsBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button WorkingDirChooseButton;
        private System.Windows.Forms.TextBox WorkingDirBox;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.OpenFileDialog ExecutableDialog;
        private System.Windows.Forms.FolderBrowserDialog WorkingDirDialog;
    }
}