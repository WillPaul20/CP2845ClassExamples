using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter8_Part2
{
    public partial class Form1 : Form
    {

        private List<string> names = new List<string>();
        private SortedList<int, string> students = new SortedList<int, string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            names.Add(txtData.Text);
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            rtbOutput.Text = "";
            foreach (string name in names)
            {
                rtbOutput.Text += name + "\n";
            }
        }

        private void btnAddStu_Click(object sender, EventArgs e)
        {
            int sid = Convert.ToInt32(txtID.Text);
            string name = txtStuName.Text;

            students.Add(sid, name);
        }

        private void btnDisplayEverything_Click(object sender, EventArgs e)
        {
            rtbStudents.Text = "";
            foreach(KeyValuePair<int, string> student in students)
            {
                rtbStudents.Text += $"ID = {student.Key} : Name = {student.Value}{Environment.NewLine}";
            }
        }
    }
}
