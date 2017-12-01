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

namespace Teacher_App
{
    public partial class Students : Form
    {
        //Filtered list used for exporting students on the listview
        public static List<Student> Filtered_students = new List<Student>();
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
                
                Filtered_students.Add(Form1.Student_list[i]);
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
                    fail_student = fail_student + Form1.Student_list[i].name + "\n";
                }
            }

            MessageBox.Show("Warning Following Students Are Failing:\n" + fail_student);

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
                Filtered_students.Clear();
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
                        Filtered_students.Add(Form1.Student_list[i]);
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
            Filtered_students.Clear();
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
                Filtered_students.Add(Form1.Student_list[i]);
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
                Filtered_students.Clear();
                //Adds matching Class ID to the list
                int numList = Form1.Student_list.Count();

                Filtered_students = new List<Student>();
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
                        Filtered_students.Add(Form1.Student_list[i]);
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
                Filtered_students.Clear();
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
                        Filtered_students.Add(Form1.Student_list[i]);
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
                Filtered_students.Clear();
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
                        Filtered_students.Add(Form1.Student_list[i]);
                    }
                }

                //Reset Entry 
                student_pick.Text = "";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            if(String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please enter the name of your file in the textbox.");
            }
            else
            {
                //Build the CSV file data as a Comma separated string.
                string csv = string.Empty;

                //Add the Header row for CSV file.
                csv += "Profesor Id,Course Id,StudentId,Name,Attendance Score,Grade";


                //Add new line.
                csv += "\r\n";

                //Adding the Rows
                foreach (Student student in Filtered_students)
                {
                    csv += student.profesor_id + "," + student.course_id + "," + student.student_id + "," + student.name + "," + student.attendance + "," + student.total_grade;

                    //Add new line.
                    csv += "\r\n";
                }

                FolderBrowserDialog fbd = new FolderBrowserDialog();


                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show(Path.Combine(fbd.SelectedPath, textBox1.Text + ".csv"));
                    File.WriteAllText(Path.Combine(fbd.SelectedPath, textBox1.Text + ".csv"), csv);
                }
            }
        }

        private void proff_pick_TextChanged(object sender, EventArgs e)
        {

        }

        private void proff_pick_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void class_pick_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
    }
}
