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
            this.Hide();
            Form1 F2 = new Form1();
            F2.ShowDialog();
            this.Close();
        }
        
        int index2=0 ;
        bool student1 = false, student2 = false;
    
        private void Enter_button_Click(object sender, EventArgs e)
      {
            present_button.Checked = false;
            absent_button.Checked = false;
          
           for (int i= index2; i < Form1.index; i++)
        {
                if (Convert.ToInt32(course_id_box.Text) == Form1.Student_list[i].course_id)
                {
                    student_name_box.Text = Form1.Student_list[i].name;
                    studentID.Text = Convert.ToString(Form1.Student_list[i].student_id);
                    cAttendance_label.Text = Form1.Student_list[i].name + " Current Attendance is: " + Form1.Student_list[i].attendance;
                    index2 = i;
                    i = Form1.index;
                    student1 = true;
                }       
        }
            if (student1 == false)
                MessageBox.Show("There is not any student enrolled in this course.");

      }
        private void Next_button_Click(object sender, EventArgs e)
        {

            student2 = false;
            if (absent_button.Checked == true)
                Form1.Student_list[index2].attendance = Form1.Student_list[index2].attendance + 1;
            nattendance_label.Text = Form1.Student_list[index2].name + " New Attendance is: " + Form1.Student_list[index2].attendance;
         
              for (int i = index2+1; i < Form1.index; i++)
                {
                    if (Convert.ToInt32(course_id_box.Text) == Form1.Student_list[i].course_id)
                    {
                        student_name_box.Text = Form1.Student_list[i].name;
                        studentID.Text = Convert.ToString(Form1.Student_list[i].student_id);
                        cAttendance_label.Text = Form1.Student_list[i].name + " Current Attendance is: " + Form1.Student_list[i].attendance;
                        index2 = i;
                        i = Form1.index;
                    student2 = true;
                }
                
            }
            if (student2 == false)
                MessageBox.Show("This is the last student in this class.");
            present_button.Checked = false;
            absent_button.Checked = false;

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
