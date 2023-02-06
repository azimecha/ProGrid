namespace ProGrid.App {
    partial class ProcessListForm {
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
            this.MonitorButton = new System.Windows.Forms.Button();
            this.ProcessListBox = new System.Windows.Forms.ListBox();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 8, 8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Process List";
            // 
            // MonitorButton
            // 
            this.MonitorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.MonitorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.MonitorButton.Enabled = false;
            this.MonitorButton.FlatAppearance.BorderSize = 0;
            this.MonitorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MonitorButton.Location = new System.Drawing.Point(362, 334);
            this.MonitorButton.Margin = new System.Windows.Forms.Padding(8, 12, 8, 8);
            this.MonitorButton.Name = "MonitorButton";
            this.MonitorButton.Size = new System.Drawing.Size(162, 29);
            this.MonitorButton.TabIndex = 11;
            this.MonitorButton.Text = "Monitor Process";
            this.MonitorButton.UseVisualStyleBackColor = false;
            this.MonitorButton.Click += new System.EventHandler(this.MonitorButton_Click);
            // 
            // ProcessListBox
            // 
            this.ProcessListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProcessListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ProcessListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProcessListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ProcessListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ProcessListBox.FormattingEnabled = true;
            this.ProcessListBox.Location = new System.Drawing.Point(25, 63);
            this.ProcessListBox.Margin = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.ProcessListBox.Name = "ProcessListBox";
            this.ProcessListBox.Size = new System.Drawing.Size(499, 247);
            this.ProcessListBox.TabIndex = 12;
            this.ProcessListBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ProcessListBox_DrawItem);
            this.ProcessListBox.SelectedValueChanged += new System.EventHandler(this.ProcessListBox_SelectedValueChanged);
            this.ProcessListBox.FontChanged += new System.EventHandler(this.ProcessListBox_FontChanged);
            this.ProcessListBox.ForeColorChanged += new System.EventHandler(this.ProcessListBox_ForeColorChanged);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RefreshButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.RefreshButton.FlatAppearance.BorderSize = 0;
            this.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshButton.Location = new System.Drawing.Point(25, 334);
            this.RefreshButton.Margin = new System.Windows.Forms.Padding(8, 12, 8, 8);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(105, 29);
            this.RefreshButton.TabIndex = 13;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = false;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // ProcessListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(548, 391);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.ProcessListBox);
            this.Controls.Add(this.MonitorButton);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeBox = false;
            this.Name = "ProcessListForm";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.Text = "Pro Grid: Open Existing Process";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProcessListForm_FormClosed);
            this.Load += new System.EventHandler(this.ProcessListForm_Load);
            this.VisibleChanged += new System.EventHandler(this.ProcessListForm_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MonitorButton;
        private System.Windows.Forms.ListBox ProcessListBox;
        private System.Windows.Forms.Button RefreshButton;
    }
}