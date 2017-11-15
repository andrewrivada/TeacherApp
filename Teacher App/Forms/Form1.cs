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
    public partial class Form1 : Form
    {
        public static List<Student> Student_list = new List<Student>();
        public static int index;
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {

            //reading data from textfile
            if (File.Exists("students.dat") && global_status.First_load) // loads from file for only the first time
            {
                //Check if File exists 

                using (BinaryReader reader = new BinaryReader(File.Open("students.dat", FileMode.Open)))
                {
                    while (reader.PeekChar() != -1)
                    {

                        string name = reader.ReadString();
                        string student_id = reader.ReadString();
                        int profesor_id = reader.ReadInt32();
                        int course_id = reader.ReadInt32();
                        int Gindex = reader.ReadInt32();
                        int attendance = reader.ReadInt32();

                        List<decimal> Grades = new List<decimal>();

                        //using Gindex to keep track of how many grades in Grades list
                        for (int i = 0; i < Gindex; i++)
                        {
                            int grade = reader.ReadInt32();
                            Grades.Add(grade);
                        }


                        Student student = new Student(name, student_id, profesor_id, course_id, Gindex, attendance, Grades);
                        Student_list.Add(student);
                        index++;



                    }
                    global_status.First_load = false;
                }
               
            } // end of data reading from file
            // if the list has been changed save the changes
            if (global_status.List_changed) 
                {
                    //writing data to textfile
                    using (BinaryWriter writer = new BinaryWriter(File.Open("students.dat", FileMode.Create)))
                    {
                        foreach (Student student in Student_list)
                        {
                            writer.Write(student.name);
                            writer.Write(student.student_id);
                            writer.Write(student.profesor_id);
                            writer.Write(student.course_id);
                            writer.Write(student.Gindex);
                            writer.Write(student.attendance);
                            foreach (int grade in student.Grades)
                            {
                                writer.Write(grade);
                            }

                        }
                    }// end of writing */
                    global_status.List_changed = false; // ensures that only changes get saved once
                }

        }
        
        private void button1_Click(object sender, EventArgs e) // add drop students
        {
            
            this.Hide();
            Add_Drop F2 = new Add_Drop();
            F2.ShowDialog();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e) // alter attendance
        {
            this.Hide();
            N_Attendance_label F2 = new N_Attendance_label();
            F2.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) // enter grades
        {
            this.Hide();
            Grades F2 = new Grades();
            F2.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e) // view the classroom
        {
            this.Hide();
            Students F2 = new Students();
            F2.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Export F2 = new Export();
            F2.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        

        //example adding student to list for testing
        private void Add_Click(object sender, EventArgs e)
        {
            List<decimal> exGrades = new List<decimal>();
            exGrades.Add(1);
            Student student = new Student("Ryan","RyanOune01",123,1234,1,10,exGrades);
           
            Student_list.Add(student);
            index++;
            
        }



    }
}
