namespace A290___Final___Marksman
{
    partial class form1
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
            this.lbBrowser = new System.Windows.Forms.ListBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.gbControls = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.ofdAddBrowser = new System.Windows.Forms.OpenFileDialog();
            this.pbDisplay = new System.Windows.Forms.PictureBox();
            this.lbBookmarks = new System.Windows.Forms.ListBox();
            this.gbControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // lbBrowser
            // 
            this.lbBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBrowser.FormattingEnabled = true;
            this.lbBrowser.Items.AddRange(new object[] {
            "(none)"});
            this.lbBrowser.Location = new System.Drawing.Point(373, 14);
            this.lbBrowser.Name = "lbBrowser";
            this.lbBrowser.ScrollAlwaysVisible = true;
            this.lbBrowser.Size = new System.Drawing.Size(79, 30);
            this.lbBrowser.TabIndex = 1;
            // 
            // btnPlus
            // 
            this.btnPlus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlus.Location = new System.Drawing.Point(317, 14);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(24, 32);
            this.btnPlus.TabIndex = 2;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinus.Location = new System.Drawing.Point(343, 14);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(24, 32);
            this.btnMinus.TabIndex = 3;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // gbControls
            // 
            this.gbControls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbControls.Controls.Add(this.btnClose);
            this.gbControls.Controls.Add(this.btnDelete);
            this.gbControls.Controls.Add(this.btnAdd);
            this.gbControls.Controls.Add(this.btnOpen);
            this.gbControls.Location = new System.Drawing.Point(317, 49);
            this.gbControls.Name = "gbControls";
            this.gbControls.Size = new System.Drawing.Size(135, 142);
            this.gbControls.TabIndex = 4;
            this.gbControls.TabStop = false;
            this.gbControls.Text = "Controls";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(26, 106);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(26, 77);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(26, 48);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(26, 19);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // ofdAddBrowser
            // 
            this.ofdAddBrowser.FileName = "Add Browser";
            this.ofdAddBrowser.Filter = "Application|*.exe";
            // 
            // pbDisplay
            // 
            this.pbDisplay.BackColor = System.Drawing.Color.Black;
            this.pbDisplay.Location = new System.Drawing.Point(126, 12);
            this.pbDisplay.Name = "pbDisplay";
            this.pbDisplay.Size = new System.Drawing.Size(177, 177);
            this.pbDisplay.TabIndex = 10;
            this.pbDisplay.TabStop = false;
            // 
            // lbBookmarks
            // 
            this.lbBookmarks.BackColor = System.Drawing.Color.Black;
            this.lbBookmarks.ForeColor = System.Drawing.Color.White;
            this.lbBookmarks.FormattingEnabled = true;
            this.lbBookmarks.Items.AddRange(new object[] {
            "(none)"});
            this.lbBookmarks.Location = new System.Drawing.Point(12, 14);
            this.lbBookmarks.Name = "lbBookmarks";
            this.lbBookmarks.Size = new System.Drawing.Size(98, 173);
            this.lbBookmarks.TabIndex = 11;
            this.lbBookmarks.SelectedIndexChanged += new System.EventHandler(this.lbBookmarks_SelectedIndexChanged);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(464, 217);
            this.Controls.Add(this.lbBookmarks);
            this.Controls.Add(this.pbDisplay);
            this.Controls.Add(this.gbControls);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.lbBrowser);
            this.MaximumSize = new System.Drawing.Size(480, 255);
            this.MinimumSize = new System.Drawing.Size(480, 255);
            this.Name = "form1";
            this.Text = "A290 - Final - Marksman";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gbControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbBrowser;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.GroupBox gbControls;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.OpenFileDialog ofdAddBrowser;
        private System.Windows.Forms.PictureBox pbDisplay;
        private System.Windows.Forms.ListBox lbBookmarks;
    }
}

