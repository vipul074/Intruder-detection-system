using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Diagnostics;

namespace FileSplitter
{
    public partial class Master : Form
    {
        private int childFormNumber = 0;

        public Master(string name)
        {
            InitializeComponent();
            label1.Text = name;
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void splitMultimediaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            splitnjoin join = new splitnjoin(label1.Text);
            join.Show();
        }

        private void folderLockToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
        private void compressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void encryptToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void shareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            share f = new share(label1.Text);
            f.Show();
        }

        private void downloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Download d = new Download(label1.Text);
            d.Show();
        }

        private void signoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        static DirectoryInfo exeFolder, projectFolder, sampleImagesFolder;
        private void zipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string codebase = Assembly.GetExecutingAssembly().Location;
            exeFolder = new DirectoryInfo(Path.GetDirectoryName(codebase));
            projectFolder = exeFolder.Parent.Parent;
            sampleImagesFolder = new DirectoryInfo(Path.Combine(projectFolder.FullName, "ZipUnzip.exe"));
            Process.Start("ZipUnzip.exe");
        }

        private void sharetootherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shareOld old = new shareOld();
            old.Show();
        }

        private void downloadReceivedFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Downloadold old = new Downloadold(label1.Text);           
            old.Show();
        }

        private void encryptToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            howto_crypt_file.Form2 f = new howto_crypt_file.Form2(label1.Text);
            f.Show();
            
        }
    }
}
