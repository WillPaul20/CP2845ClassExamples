using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Chapter17_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowCurrentDirectory_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Directory.GetCurrentDirectory(), "Current Working Dir");
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            string userFileName = txtFileName.Text;

            if (File.Exists(userFileName))
            {
                using (StreamReader reader = new StreamReader(new FileStream(userFileName, FileMode.Open)))
                {
                    string text = reader.ReadToEnd();
                    rtbFileContent.Text = text;
                }
            }
            else
            {
                MessageBox.Show($"File {userFileName} Not Found", 
                    "File not found error", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string userFileName = txtFileName.Text;
            using (StreamWriter writer = new StreamWriter(new FileStream(userFileName, FileMode.Create)))
            {
                writer.Write(rtbFileContent.Text);
            }
        }

        private void btnBinFileOpen_Click(object sender, EventArgs e)
        {
            string userFileName = txtBinFileName.Text;

            if (File.Exists(userFileName))
            {
                using (BinaryReader reader = new BinaryReader(new FileStream(userFileName, FileMode.Open)))
                {
                    string text = reader.ReadString();
                    rtbBinFile.Text = text;
                }
            }
            else
            {
                MessageBox.Show($"File {userFileName} Not Found",
                    "File not found error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void txtBinFileSave_Click(object sender, EventArgs e)
        {
            string userFileName = txtFileName.Text;
            using (BinaryWriter writer = new BinaryWriter(new FileStream(userFileName, FileMode.Create)))
            {
                writer.Write("Test");
            }
        }
    }
}
