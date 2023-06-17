namespace LW21
{
    partial class blank
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusBarAmount = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBarTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmenuCut = new System.Windows.Forms.ToolStripMenuItem();
            this.cmenuCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.cmenuPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.cmenuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmenuSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(800, 450);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBarAmount,
            this.statusBarTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusBarAmount
            // 
            this.statusBarAmount.Name = "statusBarAmount";
            this.statusBarAmount.Size = new System.Drawing.Size(118, 17);
            this.statusBarAmount.Text = "toolStripStatusLabel1";
            // 
            // statusBarTime
            // 
            this.statusBarTime.Name = "statusBarTime";
            this.statusBarTime.Size = new System.Drawing.Size(118, 17);
            this.statusBarTime.Text = "toolStripStatusLabel2";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmenuCut,
            this.cmenuCopy,
            this.cmenuPaste,
            this.cmenuDelete,
            this.toolStripMenuItem1,
            this.cmenuSelectAll});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(165, 120);
            // 
            // cmenuCut
            // 
            this.cmenuCut.Name = "cmenuCut";
            this.cmenuCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cmenuCut.Size = new System.Drawing.Size(180, 22);
            this.cmenuCut.Text = "&Cut";
            this.cmenuCut.Click += new System.EventHandler(this.cmenuCut_Click);
            // 
            // cmenuCopy
            // 
            this.cmenuCopy.Name = "cmenuCopy";
            this.cmenuCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.cmenuCopy.Size = new System.Drawing.Size(180, 22);
            this.cmenuCopy.Text = "&Copy";
            this.cmenuCopy.Click += new System.EventHandler(this.cmenuCopy_Click);
            // 
            // cmenuPaste
            // 
            this.cmenuPaste.Name = "cmenuPaste";
            this.cmenuPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.cmenuPaste.Size = new System.Drawing.Size(180, 22);
            this.cmenuPaste.Text = "&Paste";
            this.cmenuPaste.Click += new System.EventHandler(this.cmenuPaste_Click);
            // 
            // cmenuDelete
            // 
            this.cmenuDelete.Name = "cmenuDelete";
            this.cmenuDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.cmenuDelete.Size = new System.Drawing.Size(180, 22);
            this.cmenuDelete.Text = "&Delete";
            this.cmenuDelete.Click += new System.EventHandler(this.cmenuDelete_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // cmenuSelectAll
            // 
            this.cmenuSelectAll.Name = "cmenuSelectAll";
            this.cmenuSelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.cmenuSelectAll.Size = new System.Drawing.Size(180, 22);
            this.cmenuSelectAll.Text = "&Select All";
            this.cmenuSelectAll.Click += new System.EventHandler(this.cmenuSelectAll_Click);
            // 
            // blank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "blank";
            this.Text = "blank";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.blank_FormClosing);
            this.Load += new System.EventHandler(this.blank_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusBarAmount;
        private System.Windows.Forms.ToolStripStatusLabel statusBarTime;
        public System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cmenuCut;
        private System.Windows.Forms.ToolStripMenuItem cmenuCopy;
        private System.Windows.Forms.ToolStripMenuItem cmenuPaste;
        private System.Windows.Forms.ToolStripMenuItem cmenuDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cmenuSelectAll;
    }
}