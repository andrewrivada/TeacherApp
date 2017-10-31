using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teacher_App
{
    public class Student
    {
        
        public string name;
        public string student_id;
        public int profesor_id;
        public int course_id;
        public int Gindex;
        public List<int> Grades= new List<int>();
        public int attendance;

        //default constructor
        public Student()
        {

        }
        //New constructor for creating a Student Object
        //Safer to use than default constructor if adding to list
        public Student(string name,string sID, int pID, int cID, int Gi, int att, List<int> g)
        {
            this.name = name;
            this.student_id = sID;
            this.profesor_id = pID;
            this.course_id = cID;
            this.Gindex = Gi;
            this.Grades = g;
            this.attendance = att;

        }



    }
}
