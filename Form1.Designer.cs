namespace AlgodooSceneThumbnailEditor
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
            this.OpenScenePackageDialog = new System.Windows.Forms.OpenFileDialog();
            this.FindScenePackageButton = new System.Windows.Forms.Button();
            this.ScenePackageLabel = new System.Windows.Forms.Label();
            this.FindThumbnailImageButton = new System.Windows.Forms.Button();
            this.ThumbnailImageLabel = new System.Windows.Forms.Label();
            this.OpenThumbnailImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveNewScenePackageDialog = new System.Windows.Forms.SaveFileDialog();
            this.ThumbnailImagePictureBox = new System.Windows.Forms.PictureBox();
            this.SaveNewScenePackageButton = new System.Windows.Forms.Button();
            this.SaveNewScenePackageResultLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ThumbnailImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenScenePackageDialog
            // 
            this.OpenScenePackageDialog.Filter = "Algodoo scene packages|*.phz";
            this.OpenScenePackageDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenScenePackageDialog_FileOk);
            // 
            // FindScenePackageButton
            // 
            this.FindScenePackageButton.Location = new System.Drawing.Point(12, 12);
            this.FindScenePackageButton.Name = "FindScenePackageButton";
            this.FindScenePackageButton.Size = new System.Drawing.Size(127, 23);
            this.FindScenePackageButton.TabIndex = 0;
            this.FindScenePackageButton.Text = "Find scene package";
            this.FindScenePackageButton.UseVisualStyleBackColor = true;
            this.FindScenePackageButton.Click += new System.EventHandler(this.FindScenePackageButton_Click);
            // 
            // ScenePackageLabel
            // 
            this.ScenePackageLabel.AutoSize = true;
            this.ScenePackageLabel.Location = new System.Drawing.Point(145, 17);
            this.ScenePackageLabel.Name = "ScenePackageLabel";
            this.ScenePackageLabel.Size = new System.Drawing.Size(35, 13);
            this.ScenePackageLabel.TabIndex = 1;
            this.ScenePackageLabel.Text = "label1";
            // 
            // FindThumbnailImageButton
            // 
            this.FindThumbnailImageButton.Location = new System.Drawing.Point(12, 41);
            this.FindThumbnailImageButton.Name = "FindThumbnailImageButton";
            this.FindThumbnailImageButton.Size = new System.Drawing.Size(127, 23);
            this.FindThumbnailImageButton.TabIndex = 2;
            this.FindThumbnailImageButton.Text = "Find thumbnail image";
            this.FindThumbnailImageButton.UseVisualStyleBackColor = true;
            this.FindThumbnailImageButton.Click += new System.EventHandler(this.FindThumbnailImageButton_Click);
            // 
            // ThumbnailImageLabel
            // 
            this.ThumbnailImageLabel.AutoSize = true;
            this.ThumbnailImageLabel.Location = new System.Drawing.Point(145, 46);
            this.ThumbnailImageLabel.Name = "ThumbnailImageLabel";
            this.ThumbnailImageLabel.Size = new System.Drawing.Size(35, 13);
            this.ThumbnailImageLabel.TabIndex = 3;
            this.ThumbnailImageLabel.Text = "label1";
            // 
            // OpenThumbnailImageDialog
            // 
            this.OpenThumbnailImageDialog.FileName = "openFileDialog1";
            this.OpenThumbnailImageDialog.Filter = "Bitmap images|*.bmp|GIF images|*.gif|JPEG images|*.jpg; *.jpeg; *.jpe; *.jif; *.j" +
    "fif; *.jfi|PNG images|*.png|TIFF images|*.tiff; *.tif|All files|*.*";
            this.OpenThumbnailImageDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenThumbnailImageDialog_FileOk);
            // 
            // SaveNewScenePackageDialog
            // 
            this.SaveNewScenePackageDialog.DefaultExt = "phz";
            this.SaveNewScenePackageDialog.Filter = "Algodoo scene packages|*.phz";
            this.SaveNewScenePackageDialog.Title = "Save the new scene";
            this.SaveNewScenePackageDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveNewScenePackageDialog_FileOk);
            // 
            // ThumbnailImagePictureBox
            // 
            this.ThumbnailImagePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ThumbnailImagePictureBox.Location = new System.Drawing.Point(12, 70);
            this.ThumbnailImagePictureBox.Name = "ThumbnailImagePictureBox";
            this.ThumbnailImagePictureBox.Size = new System.Drawing.Size(168, 116);
            this.ThumbnailImagePictureBox.TabIndex = 4;
            this.ThumbnailImagePictureBox.TabStop = false;
            // 
            // SaveNewScenePackageButton
            // 
            this.SaveNewScenePackageButton.Location = new System.Drawing.Point(12, 192);
            this.SaveNewScenePackageButton.Name = "SaveNewScenePackageButton";
            this.SaveNewScenePackageButton.Size = new System.Drawing.Size(168, 23);
            this.SaveNewScenePackageButton.TabIndex = 5;
            this.SaveNewScenePackageButton.Text = "Save new scene package";
            this.SaveNewScenePackageButton.UseVisualStyleBackColor = true;
            this.SaveNewScenePackageButton.Click += new System.EventHandler(this.SaveNewScenePackageButton_Click);
            // 
            // SaveNewScenePackageResultLabel
            // 
            this.SaveNewScenePackageResultLabel.AutoSize = true;
            this.SaveNewScenePackageResultLabel.Location = new System.Drawing.Point(12, 218);
            this.SaveNewScenePackageResultLabel.Name = "SaveNewScenePackageResultLabel";
            this.SaveNewScenePackageResultLabel.Size = new System.Drawing.Size(35, 13);
            this.SaveNewScenePackageResultLabel.TabIndex = 6;
            this.SaveNewScenePackageResultLabel.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 248);
            this.Controls.Add(this.SaveNewScenePackageResultLabel);
            this.Controls.Add(this.SaveNewScenePackageButton);
            this.Controls.Add(this.ThumbnailImagePictureBox);
            this.Controls.Add(this.ThumbnailImageLabel);
            this.Controls.Add(this.FindThumbnailImageButton);
            this.Controls.Add(this.ScenePackageLabel);
            this.Controls.Add(this.FindScenePackageButton);
            this.Name = "Form1";
            this.Text = "Algodoo Scene Thumbnail Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ThumbnailImagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog OpenScenePackageDialog;
        private System.Windows.Forms.Button FindScenePackageButton;
        private System.Windows.Forms.Label ScenePackageLabel;
        private System.Windows.Forms.Button FindThumbnailImageButton;
        private System.Windows.Forms.Label ThumbnailImageLabel;
        private System.Windows.Forms.OpenFileDialog OpenThumbnailImageDialog;
        private System.Windows.Forms.SaveFileDialog SaveNewScenePackageDialog;
        private System.Windows.Forms.PictureBox ThumbnailImagePictureBox;
        private System.Windows.Forms.Button SaveNewScenePackageButton;
        private System.Windows.Forms.Label SaveNewScenePackageResultLabel;
    }
}

