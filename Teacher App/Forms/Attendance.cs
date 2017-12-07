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
    public partial class N_Attendance_label : Form
    {
        public N_Attendance_label()
        {
            InitializeComponent();

        }

        private void Attendance_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            global_status.List_changed = true;
            this.Hide();
            Form1 F2 = new Form1();
            F2.ShowDialog();
            this.Close();
        }
        //these varialbes are used to count the total number and current numbers of students
        //index2 is used to increment the start value of loops
        int index2 = 0, studenttotal = 0, studentcounter=0;
        // student1 boolean is used to check if there is a student in that class 
        // student2 boolean is used to find the student in that class 
        bool student1 = false, student2 = false;
       //This function is for the Enter button
        private void Enter_button_Click(object sender, EventArgs e)
      {
            present_button.Checked = false;
            absent_button.Checked = false;
            // This loop counts the total number of students in that class
            for (int j = 0; j < Form1.index; j++)
            {
                if (Convert.ToInt32(course_id_box.Text) == Form1.Student_list[j].course_id)
                {
                    studenttotal++;
                }
            }
            //This loop is used to find the first student in that class
            //if there was a student with that course_ ID, the name of the student would be shown in the text box
            for (int i= index2; i < Form1.index; i++)
        {
                if (Convert.ToInt32(course_id_box.Text) == Form1.Student_list[i].course_id)
                {
                    studentcounter++;
                    student_name_box.Text = Form1.Student_list[i].name;
                    cAttendance_label.Text = Form1.Student_list[i].name + " Current Attendance is: " + Form1.Student_list[i].attendance;
                    index2 = i;
                    numerOfStudent.Text = studentcounter + " of " + studenttotal + " students. ";
                    i = Form1.index;
                    student1 = true;
                }       
        }
            //if the above loop doesn't find any student with provided course_Id, this message will be shown
            if (student1 == false)
                MessageBox.Show("There is not any student enrolled in this course.");

      }
        //This function is for the next Button
        private void Next_button_Click(object sender, EventArgs e)
        {
            student2 = false;
            //if the absent button is clicked, the attendance of that student will ne incremented by one.
            //in fact, the attendance of that student is the number of times that student was absent.
            if (absent_button.Checked == true)
                Form1.Student_list[index2].attendance = Form1.Student_list[index2].attendance + 1;
            //this label shows the new attendance of that student
            nattendance_label.Text = Form1.Student_list[index2].name + " New Attendance is: " + Form1.Student_list[index2].attendance;
          //this loop is used to find the rest of students in that class
              for (int i = index2+1; i < Form1.index; i++)
                {
                    if (Convert.ToInt32(course_id_box.Text) == Form1.Student_list[i].course_id)
                    {
                    //this variable shows the current number of students in that class
                        studentcounter++;
                        student_name_box.Text = Form1.Student_list[i].name;
                        cAttendance_label.Text = Form1.Student_list[i].name + " Current Attendance is: " + Form1.Student_list[i].attendance;
                        index2 = i;
                    //this label show the current number and total number of students
                        numerOfStudent.Text = studentcounter + " of " + studenttotal + " students. ";
                        i = Form1.index;
                        student2 = true;
                }
                
            }
              //if there was not any other student in that class, when the user clicks next, this meesaage will be shown.
            if (student2 == false)
                MessageBox.Show("This is the last student in this class.");
            present_button.Checked = false;
            absent_button.Checked = false;

            global_status.List_changed = true;
        }



        private void student_id_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void present_button_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void course_id_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            //these three lines of codes are from a tutorial at www.youtube.com/watch?v=EcZQghn88vE
            //it is used to avoid the user's errors
            //using this function, the user can only enter a number in the course_id text box.
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
                e.Handled = true;
        }

        private void absent_button_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
