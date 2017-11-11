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
        private int chosen_class_id;
        private int chosen_prof_id;

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
                //get the first student with matching ids
                for (index = 0; index < Form1.Student_list.Count; ++index)
                {
                    if(Form1.Student_list[index].course_id == chosen_class_id &&
                        Form1.Student_list[index].profesor_id == chosen_prof_id)
                    {
                        break;//matching ids have been found
                    }
                }
                label1.Text = "Student Name: " + Form1.Student_list[index].name;
            }
            catch(ArgumentOutOfRangeException)
            {
                label1.Text = "Error: no students in the class";
                label1.Visible = true;
                button1.Visible = true;
                button2.Visible = false;
                button3.Visible = false;
                button7.Visible = false;
                return;
            }

            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button7.Visible = false;
            label1.Visible = true;
            button4.Visible = true;
            label2.Visible = true;
            numericUpDown1.Visible = true;
            
            assignment_number = Form1.Student_list[index].Grades.Count;
            label4.Text = "Assignment Number: " + (assignment_number + 1);
            label4.Visible = true;
        }

        //Grade Final Button
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                //get the first student with matching ids
                for (index = 0; index < Form1.Student_list.Count; ++index)
                {
                    if (Form1.Student_list[index].course_id == chosen_class_id &&
                        Form1.Student_list[index].profesor_id == chosen_prof_id)
                    {
                        break;//matching ids have been found
                    }
                }
                label1.Text = "Student Name: " + Form1.Student_list[index].name;
            }
            catch (ArgumentOutOfRangeException)
            {
                label1.Text = "Error: no students in the class";
                label1.Visible = true;
                button1.Visible = true;
                button2.Visible = false;
                button3.Visible = false;
                button7.Visible = false;
                button8.Visible = false;
                button9.Visible = false;
                return;
            }

            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button7.Visible = false;
            label1.Visible = true;
            button9.Visible = true;
            label2.Visible = true;
            numericUpDown1.Visible = true;
            
            label4.Text = "Final Exam";
            label4.Visible = true;
        }

        private void Grades_Load(object sender, EventArgs e)
        {
            numericUpDown1.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            label4.Visible = false;
            textBox1.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;

            label1.Text = "Course ID:";
            label2.Text = "Prof ID:";
            button2.Visible = false;
            button3.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
        }

        //Student: Label
        private void label1_Click(object sender, EventArgs e) { }

        //Next Student Button
        private void button4_Click(object sender, EventArgs e)
        {
            //save grade of last student
            Form1.Student_list[index].Grades.Add( numericUpDown1.Value);

            //update that student's total assignment grade
            decimal total = 0;
            foreach(decimal value in Form1.Student_list[index].Grades)
            {
                total += value;
            }
            total /= Form1.Student_list[index].Grades.Count;
            Form1.Student_list[index].assignment_total_grade = total;
            ///label3.Text = "" + Form1.Student_list[index].assignment_total_grade;///

            //get ready for next student, if there is one
            ++index;
            //get the next student with matching ids
            for ( ; index < Form1.Student_list.Count; ++index)
            {
                if (Form1.Student_list[index].course_id == chosen_class_id &&
                    Form1.Student_list[index].profesor_id == chosen_prof_id)
                {
                    break;//matching ids have been found
                }
            }
            ///label3.Text = ""+index;///

            ///label3.Text = "" + Form1.Student_list.Count;///
            if (index >= Form1.Student_list.Count)
            {
                //last student is graded, finish
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
            Steven.course_id = 1235;
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

        //Textbox for classID
        private void textBox1_TextChanged(object sender, EventArgs e) { }

        //Textbox for ProfessorID
        private void textBox2_TextChanged(object sender, EventArgs e) { }

        //Next Button
        private void button6_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            numericUpDown1.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            label4.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            button2.Visible = true;
            button3.Visible = true;
            button6.Visible = false;
            button7.Visible = true;
            label2.Text = "Student's Assignment Score:";

            //save class+prof ID, exit if incorrect
            try
            {
                chosen_class_id = Int32.Parse(textBox1.Text);
                chosen_prof_id = Int32.Parse(textBox2.Text);
            }
            catch (Exception)
            {
                this.Hide();
                Form1 F2 = new Form1();
                F2.ShowDialog();
                this.Close();
            }
        }

        //Grade Midterm Button
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                //get the first student with matching ids
                for (index = 0; index < Form1.Student_list.Count; ++index)
                {
                    if (Form1.Student_list[index].course_id == chosen_class_id &&
                        Form1.Student_list[index].profesor_id == chosen_prof_id)
                    {
                        break;//matching ids have been found
                    }
                }
                label1.Text = "Student Name: " + Form1.Student_list[index].name;
            }
            catch (ArgumentOutOfRangeException)
            {
                label1.Text = "Error: no students in the class";
                label1.Visible = true;
                button1.Visible = true;
                button2.Visible = false;
                button3.Visible = false;
                button7.Visible = false;
                button8.Visible = false;
                button9.Visible = false;
                return;
            }

            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button7.Visible = false;
            label1.Visible = true;
            button8.Visible = true;
            label2.Visible = true;
            numericUpDown1.Visible = true;
            
            label4.Text = "Midterm Exam";
            label4.Visible = true;
        }

        //Next Midterm Button
        private void button8_Click(object sender, EventArgs e)
        {
            //save grade of last student
            Form1.Student_list[index].midterm_grade = numericUpDown1.Value;

            //get ready for next student, if there is one
            ++index;
            //get the next student with matching ids
            for (; index < Form1.Student_list.Count; ++index)
            {
                if (Form1.Student_list[index].course_id == chosen_class_id &&
                    Form1.Student_list[index].profesor_id == chosen_prof_id)
                {
                    break;//matching ids have been found
                }
            }
            
            if (index >= Form1.Student_list.Count)
            {
                //last student is graded, finish
                button8.Visible = false;
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

        //Next Final Button
        private void button9_Click(object sender, EventArgs e)
        {
            //save grade of last student
            Form1.Student_list[index].final_grade = numericUpDown1.Value;

            //get ready for next student, if there is one
            ++index;
            //get the next student with matching ids
            for (; index < Form1.Student_list.Count; ++index)
            {
                if (Form1.Student_list[index].course_id == chosen_class_id &&
                    Form1.Student_list[index].profesor_id == chosen_prof_id)
                {
                    break;//matching ids have been found
                }
            }

            if (index >= Form1.Student_list.Count)
            {
                //last student is graded, finish
                button9.Visible = false;
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
    }
}
