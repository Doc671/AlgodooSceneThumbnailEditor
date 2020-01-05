using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Windows.Forms;

namespace AlgodooSceneThumbnailEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string _originalScenePackagePath;

        private readonly string _tempDirectory = Path.Combine(Path.GetTempPath(), "AlgodooSceneThumbnailEditor");

        private void DeleteAllFilesInDirectory(string directory)
        {
            foreach (var filePath in Directory.GetFiles(directory))
            {
                File.Delete(filePath);
            }

            foreach (var subdirectory in Directory.EnumerateDirectories(directory))
            {
                DeleteAllFilesInDirectory(subdirectory);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DeleteAllFilesInDirectory(_tempDirectory);
            SaveNewScenePackageResultLabel.Text = "";
            ScenePackageLabel.Text = "";
            ThumbnailImageLabel.Text = "";
        }

        private void FindScenePackageButton_Click(object sender, EventArgs e)
        {
            OpenScenePackageDialog.ShowDialog();
        }

        private void OpenScenePackageDialog_FileOk(object sender, CancelEventArgs e)
        {
            string[] splitFileName = OpenScenePackageDialog.FileName.Split(Path.DirectorySeparatorChar);
            ScenePackageLabel.Text = splitFileName.Last();
            _originalScenePackagePath = OpenScenePackageDialog.FileName;
            SaveNewScenePackageDialog.InitialDirectory = Path.Combine(splitFileName.Take(splitFileName.Length - 1).ToArray());
        }

        private void FindThumbnailImageButton_Click(object sender, EventArgs e)
        {
            OpenThumbnailImageDialog.ShowDialog();
        }

        private void OpenThumbnailImageDialog_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                ThumbnailImagePictureBox.BackgroundImage = Image.FromFile(OpenThumbnailImageDialog.FileName);
                ThumbnailImagePictureBox.Width = (int)Math.Round(116f * ThumbnailImagePictureBox.BackgroundImage.Width / ThumbnailImagePictureBox.BackgroundImage.Height);
            }
#pragma warning disable CA1031 // Do not catch general exception types
            catch (OutOfMemoryException)
            {
                ThumbnailImageLabel.Text = "This is not a valid image!";
            }
#pragma warning restore CA1031 // Do not catch general exception types
            ThumbnailImageLabel.Text = OpenThumbnailImageDialog.FileName.Split(Path.DirectorySeparatorChar).Last();
        }

        private void SaveNewScenePackageButton_Click(object sender, EventArgs e)
        {
            if (ScenePackageLabel.Text.Length == 0 || ThumbnailImageLabel.Text.Length == 0)
            {
                SaveNewScenePackageResultLabel.Text = "Please select a scene package and image.";
                return;
            }

            SaveNewScenePackageDialog.ShowDialog();
        }

        private void SaveNewScenePackageDialog_FileOk(object sender, CancelEventArgs e)
        {
            using (var scenePackage = ZipFile.Open(_originalScenePackagePath, ZipArchiveMode.Update))
            {
                scenePackage.GetEntry("thumb.png").Delete();
                scenePackage.CreateEntryFromFile(OpenThumbnailImageDialog.FileName, "thumb.png");
                scenePackage.ExtractToDirectory(_tempDirectory);
            }

            if (File.Exists(SaveNewScenePackageDialog.FileName))
            {
                using (var zipFileStream = ZipFile.Open(SaveNewScenePackageDialog.FileName, ZipArchiveMode.Update))
                {
                    foreach (var entry in zipFileStream.Entries.ToArray())
                    {
                        entry.Delete();
                    }

                    foreach (var file in Directory.GetFiles(_tempDirectory))
                    {
                        zipFileStream.CreateEntryFromFile(file, file.Split(Path.DirectorySeparatorChar).Last());
                    }
                }
            }
            else
            {
                using (var zipFileStream = ZipFile.Open(SaveNewScenePackageDialog.FileName, ZipArchiveMode.Create))
                {
                    foreach (var file in Directory.GetFiles(_tempDirectory))
                    {
                        zipFileStream.CreateEntryFromFile(file, file.Split(Path.DirectorySeparatorChar).Last());
                    }
                }
            }

            SaveNewScenePackageResultLabel.Text = "Scene successfully saved.";
            DeleteAllFilesInDirectory(_tempDirectory);
        }
    }
}
