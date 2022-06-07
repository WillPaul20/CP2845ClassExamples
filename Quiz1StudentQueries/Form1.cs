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

namespace Quiz1StudentQueries
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //int[] ints = new int[3] { 5,2,6 };
            //Debug.WriteLine(ints[0]);
            //ints[0] = 20;
            //Debug.WriteLine(ints.Length);

            //for (int i = 0; i < ints.Length; i++)
            //{
            //    Debug.WriteLine(ints[i]);
            //}

            //foreach (int i in ints)
            //{
            //    Debug.WriteLine(i);
            //}

            //int[,] twodArr = new int[3, 2];
            //twodArr[1, 0] = 40;

            //int[] ints_2 = ints;
            //ints_2[0] = 100;
            //int[] ints_3 = new int[ints.Length];
            //Array.Copy(ints, ints_3, ints.Length);
            //Debug.WriteLine(ints[0]); 

            SortedList<int, string> students = new SortedList<int, string>();
            students.Add(1, "anna");
            students.Add(2, "bob");

            foreach(KeyValuePair<int, string> student in students)
            {
                MessageBox.Show($"{student.Key} -> {student.Value}");
            }
                
        }
    }
}
