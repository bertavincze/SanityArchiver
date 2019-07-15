using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SanityArchiver
{
    public partial class SanityArchiver : Form
    {
        public SanityArchiver()
        {
            InitializeComponent();
        }

        private void BrowseFilesButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new OpenFileDialog().ShowDialog();
        }
    }
}
