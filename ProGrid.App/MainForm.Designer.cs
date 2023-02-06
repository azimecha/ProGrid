namespace ProGrid.App {
    partial class MainForm {
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
            this.MainSplit = new System.Windows.Forms.SplitContainer();
            this.SidebarLayout = new System.Windows.Forms.TableLayoutPanel();
            this.AttachButton = new System.Windows.Forms.Button();
            this.ProcessTree = new System.Windows.Forms.TreeView();
            this.CreateButton = new System.Windows.Forms.Button();
            this.InfoTextBox = new System.Windows.Forms.RichTextBox();
            this.DetailContainerPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplit)).BeginInit();
            this.MainSplit.Panel1.SuspendLayout();
            this.MainSplit.Panel2.SuspendLayout();
            this.MainSplit.SuspendLayout();
            this.SidebarLayout.SuspendLayout();
            this.DetailContainerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainSplit
            // 
            this.MainSplit.BackColor = System.Drawing.Color.Black;
            this.MainSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSplit.Location = new System.Drawing.Point(0, 0);
            this.MainSplit.Margin = new System.Windows.Forms.Padding(5);
            this.MainSplit.Name = "MainSplit";
            // 
            // MainSplit.Panel1
            // 
            this.MainSplit.Panel1.Controls.Add(this.SidebarLayout);
            // 
            // MainSplit.Panel2
            // 
            this.MainSplit.Panel2.Controls.Add(this.DetailContainerPanel);
            this.MainSplit.Size = new System.Drawing.Size(791, 433);
            this.MainSplit.SplitterDistance = 262;
            this.MainSplit.SplitterWidth = 6;
            this.MainSplit.TabIndex = 0;
            // 
            // SidebarLayout
            // 
            this.SidebarLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.SidebarLayout.ColumnCount = 2;
            this.SidebarLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SidebarLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SidebarLayout.Controls.Add(this.AttachButton, 0, 1);
            this.SidebarLayout.Controls.Add(this.ProcessTree, 0, 0);
            this.SidebarLayout.Controls.Add(this.CreateButton, 0, 1);
            this.SidebarLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SidebarLayout.Location = new System.Drawing.Point(0, 0);
            this.SidebarLayout.Margin = new System.Windows.Forms.Padding(5);
            this.SidebarLayout.Name = "SidebarLayout";
            this.SidebarLayout.RowCount = 2;
            this.SidebarLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SidebarLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.SidebarLayout.Size = new System.Drawing.Size(262, 433);
            this.SidebarLayout.TabIndex = 1;
            // 
            // AttachButton
            // 
            this.AttachButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.AttachButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AttachButton.FlatAppearance.BorderSize = 0;
            this.AttachButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AttachButton.Location = new System.Drawing.Point(134, 388);
            this.AttachButton.Name = "AttachButton";
            this.AttachButton.Size = new System.Drawing.Size(125, 42);
            this.AttachButton.TabIndex = 2;
            this.AttachButton.Text = "Attach";
            this.AttachButton.UseVisualStyleBackColor = false;
            this.AttachButton.Click += new System.EventHandler(this.AttachButton_Click);
            // 
            // ProcessTree
            // 
            this.ProcessTree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ProcessTree.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SidebarLayout.SetColumnSpan(this.ProcessTree, 2);
            this.ProcessTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProcessTree.ForeColor = System.Drawing.Color.White;
            this.ProcessTree.Location = new System.Drawing.Point(0, 0);
            this.ProcessTree.Margin = new System.Windows.Forms.Padding(0);
            this.ProcessTree.Name = "ProcessTree";
            this.ProcessTree.Size = new System.Drawing.Size(262, 385);
            this.ProcessTree.TabIndex = 0;
            this.ProcessTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.ProcessTree_AfterSelect);
            // 
            // CreateButton
            // 
            this.CreateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.CreateButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CreateButton.FlatAppearance.BorderSize = 0;
            this.CreateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateButton.Location = new System.Drawing.Point(3, 388);
            this.CreateButton.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(128, 42);
            this.CreateButton.TabIndex = 1;
            this.CreateButton.Text = "Start New";
            this.CreateButton.UseVisualStyleBackColor = false;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // InfoTextBox
            // 
            this.InfoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.InfoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InfoTextBox.ForeColor = System.Drawing.Color.White;
            this.InfoTextBox.Location = new System.Drawing.Point(17, 0);
            this.InfoTextBox.Margin = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.InfoTextBox.Name = "InfoTextBox";
            this.InfoTextBox.ReadOnly = true;
            this.InfoTextBox.Size = new System.Drawing.Size(506, 433);
            this.InfoTextBox.TabIndex = 0;
            this.InfoTextBox.Text = "";
            // 
            // DetailContainerPanel
            // 
            this.DetailContainerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.DetailContainerPanel.Controls.Add(this.InfoTextBox);
            this.DetailContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DetailContainerPanel.Location = new System.Drawing.Point(0, 0);
            this.DetailContainerPanel.Name = "DetailContainerPanel";
            this.DetailContainerPanel.Size = new System.Drawing.Size(523, 433);
            this.DetailContainerPanel.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(791, 433);
            this.Controls.Add(this.MainSplit);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainForm";
            this.Text = "Pro Grid";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainSplit.Panel1.ResumeLayout(false);
            this.MainSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainSplit)).EndInit();
            this.MainSplit.ResumeLayout(false);
            this.SidebarLayout.ResumeLayout(false);
            this.DetailContainerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer MainSplit;
        private System.Windows.Forms.TreeView ProcessTree;
        private System.Windows.Forms.RichTextBox InfoTextBox;
        private System.Windows.Forms.TableLayoutPanel SidebarLayout;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Button AttachButton;
        private System.Windows.Forms.Panel DetailContainerPanel;
    }
}

