namespace A290___Final___Marksman
{
    partial class frmEditor
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
            this.lblBanner = new System.Windows.Forms.Label();
            this.lblUrl = new System.Windows.Forms.Label();
            this.lblComments = new System.Windows.Forms.Label();
            this.tbBanner = new System.Windows.Forms.TextBox();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.tbComment = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pbDisplay = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBanner
            // 
            this.lblBanner.AutoSize = true;
            this.lblBanner.Location = new System.Drawing.Point(12, 9);
            this.lblBanner.Name = "lblBanner";
            this.lblBanner.Size = new System.Drawing.Size(44, 13);
            this.lblBanner.TabIndex = 0;
            this.lblBanner.Text = "Banner:";
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(12, 62);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(32, 13);
            this.lblUrl.TabIndex = 1;
            this.lblUrl.Text = "URL:";
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Location = new System.Drawing.Point(12, 117);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(59, 13);
            this.lblComments.TabIndex = 2;
            this.lblComments.Text = "Comments:";
            // 
            // tbBanner
            // 
            this.tbBanner.Location = new System.Drawing.Point(15, 25);
            this.tbBanner.Name = "tbBanner";
            this.tbBanner.Size = new System.Drawing.Size(177, 20);
            this.tbBanner.TabIndex = 3;
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(15, 78);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(177, 20);
            this.tbUrl.TabIndex = 4;
            this.tbUrl.Leave += new System.EventHandler(this.tbUrl_Leave);
            // 
            // tbComment
            // 
            this.tbComment.Location = new System.Drawing.Point(15, 133);
            this.tbComment.Multiline = true;
            this.tbComment.Name = "tbComment";
            this.tbComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbComment.Size = new System.Drawing.Size(177, 107);
            this.tbComment.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(225, 217);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(306, 217);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pbDisplay
            // 
            this.pbDisplay.BackColor = System.Drawing.Color.Black;
            this.pbDisplay.Location = new System.Drawing.Point(216, 25);
            this.pbDisplay.Name = "pbDisplay";
            this.pbDisplay.Size = new System.Drawing.Size(177, 177);
            this.pbDisplay.TabIndex = 9;
            this.pbDisplay.TabStop = false;
            // 
            // frmEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(411, 264);
            this.Controls.Add(this.pbDisplay);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbComment);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.tbBanner);
            this.Controls.Add(this.lblComments);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.lblBanner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximumSize = new System.Drawing.Size(427, 302);
            this.MinimumSize = new System.Drawing.Size(427, 302);
            this.Name = "frmEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Editor";
            ((System.ComponentModel.ISupportInitialize)(this.pbDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBanner;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.TextBox tbBanner;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.TextBox tbComment;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pbDisplay;
    }
}