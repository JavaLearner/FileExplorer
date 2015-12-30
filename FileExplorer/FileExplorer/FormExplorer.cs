using System;
using System.Windows.Forms;

namespace FileExplorer
{
    public partial class FileExplorer : Form
    {
        public FileExplorer()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBD = new FolderBrowserDialog() { Description = "Select path." })
            {
                if (folderBD.ShowDialog() == DialogResult.OK)
                {
                    webBrowser.Url = new Uri(folderBD.SelectedPath);
                    textPath.Text = folderBD.SelectedPath;
                }
            }


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (webBrowser.CanGoBack)
            {
                webBrowser.GoBack();
            }
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            if(webBrowser.CanGoForward)
            {
                webBrowser.GoForward();
            }
        }
    }
}
