namespace OricExplorer.User_Controls
{
    partial class frmMainView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainView));
            this.fctSourceCode = new FastColoredTextBoxNS.FastColoredTextBox();
            this.tabMainView = new FarsiLibrary.Win.FATabStrip();
            this.tabpHexDump = new FarsiLibrary.Win.FATabStripItem();
            this.hxbDump = new Be.Windows.Forms.HexBox();
            this.tabpSourceCode = new FarsiLibrary.Win.FATabStripItem();
            this.tabpDataViewer = new FarsiLibrary.Win.FATabStripItem();
            ((System.ComponentModel.ISupportInitialize)(this.fctSourceCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabMainView)).BeginInit();
            this.tabMainView.SuspendLayout();
            this.tabpHexDump.SuspendLayout();
            this.tabpSourceCode.SuspendLayout();
            this.SuspendLayout();
            // 
            // fctSourceCode
            // 
            this.fctSourceCode.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fctSourceCode.AutoScrollMinSize = new System.Drawing.Size(10, 22);
            this.fctSourceCode.BackBrush = null;
            this.fctSourceCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.fctSourceCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fctSourceCode.CharHeight = 14;
            this.fctSourceCode.CharWidth = 7;
            this.fctSourceCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctSourceCode.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctSourceCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fctSourceCode.Font = new System.Drawing.Font("Consolas", 9F);
            this.fctSourceCode.ForeColor = System.Drawing.Color.Gainsboro;
            this.fctSourceCode.IsReplaceMode = false;
            this.fctSourceCode.Location = new System.Drawing.Point(0, 0);
            this.fctSourceCode.Name = "fctSourceCode";
            this.fctSourceCode.Paddings = new System.Windows.Forms.Padding(4);
            this.fctSourceCode.ReadOnly = true;
            this.fctSourceCode.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctSourceCode.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctSourceCode.ServiceColors")));
            this.fctSourceCode.ShowLineNumbers = false;
            this.fctSourceCode.Size = new System.Drawing.Size(835, 504);
            this.fctSourceCode.TabIndex = 0;
            this.fctSourceCode.Zoom = 100;
            this.fctSourceCode.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.fctSourceCode_TextChanged);
            // 
            // tabMainView
            // 
            this.tabMainView.AlwaysShowClose = false;
            this.tabMainView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMainView.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMainView.Items.AddRange(new FarsiLibrary.Win.FATabStripItem[] {
            this.tabpHexDump,
            this.tabpSourceCode,
            this.tabpDataViewer});
            this.tabMainView.Location = new System.Drawing.Point(0, 0);
            this.tabMainView.Name = "tabMainView";
            this.tabMainView.SelectedItem = this.tabpHexDump;
            this.tabMainView.Size = new System.Drawing.Size(837, 525);
            this.tabMainView.TabIndex = 0;
            // 
            // tabpHexDump
            // 
            this.tabpHexDump.CanClose = false;
            this.tabpHexDump.Controls.Add(this.hxbDump);
            this.tabpHexDump.Image = ((System.Drawing.Image)(resources.GetObject("tabpHexDump.Image")));
            this.tabpHexDump.IsDrawn = true;
            this.tabpHexDump.Name = "tabpHexDump";
            this.tabpHexDump.Selected = true;
            this.tabpHexDump.Size = new System.Drawing.Size(835, 504);
            this.tabpHexDump.TabIndex = 0;
            this.tabpHexDump.Title = "Hex Dump";
            // 
            // hxbDump
            // 
            this.hxbDump.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.hxbDump.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hxbDump.ColumnInfoVisible = true;
            this.hxbDump.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hxbDump.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hxbDump.ForeColor = System.Drawing.Color.White;
            this.hxbDump.GroupSize = 2;
            this.hxbDump.InfoForeColor = System.Drawing.Color.Teal;
            this.hxbDump.LineInfoPrefix = "$";
            this.hxbDump.LineInfoVisible = true;
            this.hxbDump.LineInfoWidth = 4;
            this.hxbDump.Location = new System.Drawing.Point(0, 0);
            this.hxbDump.Name = "hxbDump";
            this.hxbDump.ReadOnly = true;
            this.hxbDump.SelectionBackColor = System.Drawing.Color.Red;
            this.hxbDump.SelectionForeColor = System.Drawing.Color.Yellow;
            this.hxbDump.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.hxbDump.Size = new System.Drawing.Size(835, 504);
            this.hxbDump.StringViewColour = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.hxbDump.StringViewVisible = true;
            this.hxbDump.TabIndex = 0;
            this.hxbDump.UseFixedBytesPerLine = true;
            this.hxbDump.VScrollBarVisible = true;
            // 
            // tabpSourceCode
            // 
            this.tabpSourceCode.CanClose = false;
            this.tabpSourceCode.Controls.Add(this.fctSourceCode);
            this.tabpSourceCode.Image = ((System.Drawing.Image)(resources.GetObject("tabpSourceCode.Image")));
            this.tabpSourceCode.IsDrawn = true;
            this.tabpSourceCode.Name = "tabpSourceCode";
            this.tabpSourceCode.Size = new System.Drawing.Size(835, 504);
            this.tabpSourceCode.TabIndex = 1;
            this.tabpSourceCode.Title = "Source Code";
            // 
            // tabpDataViewer
            // 
            this.tabpDataViewer.CanClose = false;
            this.tabpDataViewer.Image = ((System.Drawing.Image)(resources.GetObject("tabpDataViewer.Image")));
            this.tabpDataViewer.IsDrawn = true;
            this.tabpDataViewer.Name = "tabpDataViewer";
            this.tabpDataViewer.Size = new System.Drawing.Size(835, 504);
            this.tabpDataViewer.TabIndex = 2;
            this.tabpDataViewer.Title = "Data Viewer";
            // 
            // frmMainView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(837, 525);
            this.Controls.Add(this.tabMainView);
            this.DockAreas = WeifenLuo.WinFormsUI.Docking.DockAreas.Document;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmMainView";
            this.ShowHint = WeifenLuo.WinFormsUI.Docking.DockState.Document;
            ((System.ComponentModel.ISupportInitialize)(this.fctSourceCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabMainView)).EndInit();
            this.tabMainView.ResumeLayout(false);
            this.tabpHexDump.ResumeLayout(false);
            this.tabpSourceCode.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FastColoredTextBoxNS.FastColoredTextBox fctSourceCode;
        private FarsiLibrary.Win.FATabStrip tabMainView;
        private FarsiLibrary.Win.FATabStripItem tabpHexDump;
        private FarsiLibrary.Win.FATabStripItem tabpSourceCode;
        private FarsiLibrary.Win.FATabStripItem tabpDataViewer;
        //private System.Windows.Forms.Label label6;
        private Be.Windows.Forms.HexBox hxbDump;
    }
}
