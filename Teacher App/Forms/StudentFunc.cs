using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teacher_App
{
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
            int numList = Form1.Student_list.Count();

            for (int i = 0; i < numList; i++)
            {
                ListViewItem list = new ListViewItem("" + Form1.Student_list[i].student_id);
                list.SubItems.Add("" + Form1.Student_list[i].course_id);
                list.SubItems.Add("" + Form1.Student_list[i].name);
                list.SubItems.Add("" + Form1.Student_list[i].Grades);
                listView1.Items.Add(list);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 F2 = new Form1();
            F2.ShowDialog();
            this.Close();
        }

        private void Students_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void warningmessage_students(object sender, EventArgs e)
        {
            MessageBox.Show("Failing Students: ");
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
             
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        //Select Class Button
        private void button2_Click(object sender, EventArgs e)
        {
            //Clears the List 
            listView1.Items.Clear();

            //Adds matching Class ID to the list
            int numList = Form1.Student_list.Count();

            for (int i = 0; i < numList; i++)
            {
                if (Form1.Student_list[i].course_id == Convert.ToInt32(class_pick.Text))
                {
                    ListViewItem list = new ListViewItem("" + Form1.Student_list[i].student_id);
                    list.SubItems.Add("" + Form1.Student_list[i].course_id);
                    list.SubItems.Add("" + Form1.Student_list[i].name);
                    list.SubItems.Add("" + Form1.Student_list[i].Grades);
                    listView1.Items.Add(list);
                }
            }
            //Reset entry
            class_pick.Text = "";
        }

        //Reset Button
        private void button2_Click_1(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            int numList = Form1.Student_list.Count();

            for (int i = 0; i < numList; i++)
            {
                ListViewItem list = new ListViewItem("" + Form1.Student_list[i].student_id);
                list.SubItems.Add("" + Form1.Student_list[i].course_id);
                list.SubItems.Add("" + Form1.Student_list[i].name);
                list.SubItems.Add("" + Form1.Student_list[i].Grades);
                listView1.Items.Add(list);
            }
        }

        //Add Comment Button
        private void button9_Click(object sender, EventArgs e)
        {
           
        }
    }
}
