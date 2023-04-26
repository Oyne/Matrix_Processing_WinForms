using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixProcessing
{
    public partial class Author : Form
    {
        public Author()
        {
            InitializeComponent();
        }

        private void GitHubPicture_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/Oyne") { UseShellExecute = true });
        }

        private void TelegramPicture_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://t.me/Andreoyne") { UseShellExecute = true });
        }

        private void GmailPicture_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("mailto:a.a.litvinov@student.csn.khai.edu") { UseShellExecute = true });
        }

        private void AuthorPicture_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://www.instagram.com/andreoyne_litvinov/") { UseShellExecute = true });
        }
    }
}
