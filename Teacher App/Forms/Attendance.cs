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
    public partial class Attendance : Form
    {
        public Attendance()
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
    
        private void Enter_button_Click(object sender, EventArgs e)
      {
            present_button.Checked = false;
            absent_button.Checked = false;
          
           for (int i= index2; i < Form1.index; i++)
        {
                if (Convert.ToInt32(course_id_box.Text) == Form1.Student_list[i].course_id)
                {
                    student_name_box.Text = Form1.Student_list[i].name;
                 
                    index2 = i+1;
                    i = Form1.index;  
                }
        }
      }
        private void Next_button_Click(object sender, EventArgs e)
        {


            if (absent_button.Checked == true)
            {
                Form1.Student_list[index2].attendance = Form1.Student_list[index2].attendance + 1; // increment attendance
                
            }

            label1.Text = "Student Attendance: " + Form1.Student_list[index2].attendance;// go to next student to display
            for (int i = index2; i < Form1.index; i++)
            {
                if (Convert.ToInt32(course_id_box.Text) == Form1.Student_list[i].course_id)
                {
                    student_name_box.Text = Form1.Student_list[i].name;
                    //  Next_button_Click(sender, e);
                    index2 = i+1;
                    i = Form1.index;
                }
            }
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

   
    }
}
