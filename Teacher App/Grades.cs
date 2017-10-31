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
    public partial class Grades : Form
    {
        private int index;
        private int assignment_number;

        public Grades()
        {
            InitializeComponent();
        }

        //Back Button
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 F2 = new Form1();
            F2.ShowDialog();
            this.Close();
        }

        //New Assignment Button
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                label1.Text = "Student Name: " + Form1.Student_list[0].name;
            }
            catch(ArgumentOutOfRangeException)
            {
                label1.Text = "Error: no students in the class";
                label1.Visible = true;
                button1.Visible = true;
                button2.Visible = false;
                button3.Visible = false;
                return;
            }

            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            label1.Visible = true;
            button4.Visible = true;
            label2.Visible = true;
            numericUpDown1.Visible = true;

            index = 0;
            assignment_number = Form1.Student_list[0].Grades.Count;
            label4.Text = "Assignment Number: " + (assignment_number + 1);
            label4.Visible = true;
        }

        //Edit Old Assignment Button
        private void button3_Click(object sender, EventArgs e)
        {
            //not done yet
        }

        private void Grades_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            numericUpDown1.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            label4.Visible = false;
        }

        //Student: Label
        private void label1_Click(object sender, EventArgs e) { }

        //Next Student Button
        private void button4_Click(object sender, EventArgs e)
        {
            //save grade of last student
            Form1.Student_list[index].Grades.Add( Convert.ToInt32(numericUpDown1.Value) );
            ///label3.Text = Form1.Student_list[index].name;///
            ///label3.Text = "" + Form1.Student_list[index].Grades[assignment_number];///

            //get ready for next student, if there is one
            index++;
            ///label3.Text = "" + Form1.Student_list.Count;///
            if (index >= Form1.Student_list.Count)
            {
                //last student is graded, finish
                //label1.Visible = false;
                button4.Visible = false;
                label2.Visible = false;
                numericUpDown1.Visible = false;
                button5.Visible = true;
                label1.Text = "All students have been graded, please return";
            }
            else
            {
                numericUpDown1.Value = 0;
                label1.Text = "Student Name: " + Form1.Student_list[index].name;
            }
        }

        //Student's Assignment Score: Label
        private void label2_Click(object sender, EventArgs e) { }

        //Assignment Score
        private void numericUpDown1_ValueChanged(object sender, EventArgs e) { }
        
        //test label
        private void label3_Click(object sender, EventArgs e)
        {
            Student Steven = new Student();
            Steven.name = "Steven";
            Steven.student_id = "Steven01";
            Steven.profesor_id = 123;
            Steven.course_id = 1234;
            Steven.Gindex = 0;
            Steven.attendance = 5;
            Form1.Student_list.Add(Steven);
        }
        
        //Finish Grading Button
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 F2 = new Form1();
            F2.ShowDialog();
            this.Close();
        }

        //Assignment Number Label
        private void label4_Click(object sender, EventArgs e) { }
    }
}
