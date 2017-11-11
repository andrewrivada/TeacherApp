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

                //Calculates the total grade then initializes the List
                Form1.Student_list[i].total_grade = ((decimal)(.70) * Form1.Student_list[i].assignment_total_grade)
                    + ((decimal)(.15) * Form1.Student_list[i].midterm_grade) 
                    + ((decimal)(.15) * Form1.Student_list[i].final_grade);

                ListViewItem list = new ListViewItem("" + Form1.Student_list[i].profesor_id);
                list.SubItems.Add("" + Form1.Student_list[i].course_id);
                list.SubItems.Add("" + Form1.Student_list[i].student_id);
                list.SubItems.Add("" + Form1.Student_list[i].name);
                list.SubItems.Add("" + Form1.Student_list[i].attendance);
                list.SubItems.Add("" + Form1.Student_list[i].total_grade);
                listView1.Items.Add(list);
            }

            proff_pick.Text = "";
            student_pick.Text = "";
            class_pick.Text = "";
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
            int numList = Form1.Student_list.Count();
            string fail_student = "";

            for (int i = 0; i < numList; i++)
            {
                if ((Form1.Student_list[i].total_grade) < 70)
                {
                    fail_student = fail_student + Form1.Student_list[i].name + " ";
                }
            }

            MessageBox.Show("Failing Students: " + fail_student);

        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
             
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        //Filter Class Button
        private void button2_Click(object sender, EventArgs e)
        {
            if (!(proff_pick.Text == "" || class_pick.Text == "" || student_pick.Text == ""))
            {
                //Clears the List 
                listView1.Items.Clear();

                //Adds matching Class ID to the list
                int numList = Form1.Student_list.Count();

                for (int i = 0; i < numList; i++)
                {
                    if (Form1.Student_list[i].profesor_id == Convert.ToInt32(proff_pick.Text) &&
                        Form1.Student_list[i].course_id == Convert.ToInt32(class_pick.Text) &&
                        Form1.Student_list[i].student_id == student_pick.Text)
                    {
                        ListViewItem list = new ListViewItem("" + Form1.Student_list[i].profesor_id);
                        list.SubItems.Add("" + Form1.Student_list[i].course_id);
                        list.SubItems.Add("" + Form1.Student_list[i].student_id);
                        list.SubItems.Add("" + Form1.Student_list[i].name);
                        list.SubItems.Add("" + Form1.Student_list[i].attendance);
                        list.SubItems.Add("" + Form1.Student_list[i].total_grade);
                        listView1.Items.Add(list);
                    } /*else if (Form1.Student_list[i].profesor_id == Convert.ToInt32(proff_pick.Text) &&
                        Form1.Student_list[i].course_id == Convert.ToInt32(class_pick.Text) &&
                        student_pick.Text == "")
                    {
                        ListViewItem list = new ListViewItem("" + Form1.Student_list[i].profesor_id);
                        list.SubItems.Add("" + Form1.Student_list[i].course_id);
                        list.SubItems.Add("" + Form1.Student_list[i].student_id);
                        list.SubItems.Add("" + Form1.Student_list[i].name);
                        list.SubItems.Add("" + Form1.Student_list[i].attendance);
                        list.SubItems.Add("" + Form1.Student_list[i].Grades);
                        listView1.Items.Add(list);
                    } else if (Form1.Student_list[i].profesor_id == Convert.ToInt32(proff_pick.Text) &&
                        class_pick.Text == "" &&
                        Form1.Student_list[i].student_id == student_pick.Text)
                    {
                        ListViewItem list = new ListViewItem("" + Form1.Student_list[i].profesor_id);
                        list.SubItems.Add("" + Form1.Student_list[i].course_id);
                        list.SubItems.Add("" + Form1.Student_list[i].student_id);
                        list.SubItems.Add("" + Form1.Student_list[i].name);
                        list.SubItems.Add("" + Form1.Student_list[i].attendance);
                        list.SubItems.Add("" + Form1.Student_list[i].Grades);
                        listView1.Items.Add(list);
                    } else if (Form1.Student_list[i].profesor_id == Convert.ToInt32(proff_pick.Text) &&
                        class_pick.Text == "" &&
                        student_pick.Text == "")
                    {
                        ListViewItem list = new ListViewItem("" + Form1.Student_list[i].profesor_id);
                        list.SubItems.Add("" + Form1.Student_list[i].course_id);
                        list.SubItems.Add("" + Form1.Student_list[i].student_id);
                        list.SubItems.Add("" + Form1.Student_list[i].name);
                        list.SubItems.Add("" + Form1.Student_list[i].attendance);
                        list.SubItems.Add("" + Form1.Student_list[i].Grades);
                        listView1.Items.Add(list);
                    } else if (proff_pick.Text == "" &&
                        Form1.Student_list[i].course_id == Convert.ToInt32(class_pick.Text) &&
                        Form1.Student_list[i].student_id == student_pick.Text)
                    {
                        ListViewItem list = new ListViewItem("" + Form1.Student_list[i].profesor_id);
                        list.SubItems.Add("" + Form1.Student_list[i].course_id);
                        list.SubItems.Add("" + Form1.Student_list[i].student_id);
                        list.SubItems.Add("" + Form1.Student_list[i].name);
                        list.SubItems.Add("" + Form1.Student_list[i].attendance);
                        list.SubItems.Add("" + Form1.Student_list[i].Grades);
                        listView1.Items.Add(list);
                    } else if (proff_pick.Text == "" &&
                        Form1.Student_list[i].course_id == Convert.ToInt32(class_pick.Text) &&
                        student_pick.Text == "")
                    {
                        ListViewItem list = new ListViewItem("" + Form1.Student_list[i].profesor_id);
                        list.SubItems.Add("" + Form1.Student_list[i].course_id);
                        list.SubItems.Add("" + Form1.Student_list[i].student_id);
                        list.SubItems.Add("" + Form1.Student_list[i].name);
                        list.SubItems.Add("" + Form1.Student_list[i].attendance);
                        list.SubItems.Add("" + Form1.Student_list[i].Grades);
                        listView1.Items.Add(list);
                    } else if (proff_pick.Text == "" &&
                        class_pick.Text == "" &&
                        Form1.Student_list[i].student_id == student_pick.Text)
                    {
                        ListViewItem list = new ListViewItem("" + Form1.Student_list[i].profesor_id);
                        list.SubItems.Add("" + Form1.Student_list[i].course_id);
                        list.SubItems.Add("" + Form1.Student_list[i].student_id);
                        list.SubItems.Add("" + Form1.Student_list[i].name);
                        list.SubItems.Add("" + Form1.Student_list[i].attendance);
                        list.SubItems.Add("" + Form1.Student_list[i].Grades);
                        listView1.Items.Add(list);
                    } */
                }
                //Reset entry
                proff_pick.Text = "";
                class_pick.Text = "";
                student_pick.Text = "";
            }
        }

        //Reset Button
        private void button2_Click_1(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            int numList = Form1.Student_list.Count();

            for (int i = 0; i < numList; i++)
            {
                ListViewItem list = new ListViewItem("" + Form1.Student_list[i].profesor_id);
                list.SubItems.Add("" + Form1.Student_list[i].course_id);
                list.SubItems.Add("" + Form1.Student_list[i].student_id);
                list.SubItems.Add("" + Form1.Student_list[i].name);
                list.SubItems.Add("" + Form1.Student_list[i].attendance);
                list.SubItems.Add("" + Form1.Student_list[i].total_grade);
                listView1.Items.Add(list);
            }
        }

        private void class_pick_label_Click(object sender, EventArgs e)
        {

        }

        private void filter_prof_Click(object sender, EventArgs e)
        {
            if (!(proff_pick.Text == ""))
            {
                //Clears the List 
                listView1.Items.Clear();

                //Adds matching Class ID to the list
                int numList = Form1.Student_list.Count();

                for (int i = 0; i < numList; i++)
                {
                    if (Form1.Student_list[i].profesor_id == Convert.ToInt32(proff_pick.Text))
                    {
                        ListViewItem list = new ListViewItem("" + Form1.Student_list[i].profesor_id);
                        list.SubItems.Add("" + Form1.Student_list[i].course_id);
                        list.SubItems.Add("" + Form1.Student_list[i].student_id);
                        list.SubItems.Add("" + Form1.Student_list[i].name);
                        list.SubItems.Add("" + Form1.Student_list[i].attendance);
                        list.SubItems.Add("" + Form1.Student_list[i].total_grade);
                        listView1.Items.Add(list);
                    }
                }

                //Reset Entry 
                proff_pick.Text = "";
            }
        }

        private void filter_class_Click(object sender, EventArgs e)
        {
            if (!(class_pick.Text == ""))
            {
                //Clears the List 
                listView1.Items.Clear();

                //Adds matching Class ID to the list
                int numList = Form1.Student_list.Count();

                for (int i = 0; i < numList; i++)
                {
                    if (Form1.Student_list[i].course_id == Convert.ToInt32(class_pick.Text))
                    {
                        ListViewItem list = new ListViewItem("" + Form1.Student_list[i].profesor_id);
                        list.SubItems.Add("" + Form1.Student_list[i].course_id);
                        list.SubItems.Add("" + Form1.Student_list[i].student_id);
                        list.SubItems.Add("" + Form1.Student_list[i].name);
                        list.SubItems.Add("" + Form1.Student_list[i].attendance);
                        list.SubItems.Add("" + Form1.Student_list[i].total_grade);
                        listView1.Items.Add(list);
                    }
                }

                //Reset Entry 
                class_pick.Text = "";
            }
        }

        private void filter_stud_Click(object sender, EventArgs e)
        {
            if (!(student_pick.Text == ""))
            {
                //Clears the List 
                listView1.Items.Clear();

                //Adds matching Class ID to the list
                int numList = Form1.Student_list.Count();

                for (int i = 0; i < numList; i++)
                {
                    if (Form1.Student_list[i].student_id == student_pick.Text)
                    {
                        ListViewItem list = new ListViewItem("" + Form1.Student_list[i].profesor_id);
                        list.SubItems.Add("" + Form1.Student_list[i].course_id);
                        list.SubItems.Add("" + Form1.Student_list[i].student_id);
                        list.SubItems.Add("" + Form1.Student_list[i].name);
                        list.SubItems.Add("" + Form1.Student_list[i].attendance);
                        list.SubItems.Add("" + Form1.Student_list[i].total_grade);
                        listView1.Items.Add(list);
                    }
                }

                //Reset Entry 
                student_pick.Text = "";
            }
        }
    }
}
