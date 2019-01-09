namespace UserInterfaceExtension
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl2
            // 
            this.helpMaster.SetShowHelp(this.tabControl2, true);
            this.tabControl2.Size = new System.Drawing.Size(794, 328);
            // 
            // imgListForm
            // 
            this.imgListForm.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListForm.ImageStream")));
            this.imgListForm.Images.SetKeyName(0, "");
            this.imgListForm.Images.SetKeyName(1, "");
            this.imgListForm.Images.SetKeyName(2, "");
            this.imgListForm.Images.SetKeyName(3, "");
            this.imgListForm.Images.SetKeyName(4, "");
            this.imgListForm.Images.SetKeyName(5, "");
            this.imgListForm.Images.SetKeyName(6, "");
            // 
            // panel2
            // 
            this.helpMaster.SetShowHelp(this.panel2, true);
            this.panel2.Size = new System.Drawing.Size(800, 500);
            // 
            // panelBottom
            // 
            this.panelBottom.Location = new System.Drawing.Point(0, 525);
            this.helpMaster.SetShowHelp(this.panelBottom, true);
            this.panelBottom.Size = new System.Drawing.Size(800, 30);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 555);
            this.IsToolBarVisible = true;
            this.Name = "Form1";
            this.ShowDoc = true;
            this.ShowFilter = true;
            this.helpMaster.SetShowHelp(this, true);
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}

