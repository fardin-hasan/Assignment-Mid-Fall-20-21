using System;
using System.Collections.Generic;
using System.Text;

namespace Mid_Project
{
    class Depertment
    {

        private string name;
        private int NumberOFCourse;
        public Courses[] courselist;

        public int NOC
        {
            set { NumberOFCourse = value; }
            get { return NumberOFCourse; }
        }

        public string NameofDpt
        {
            set { name = value; }
            get { return name; }
        }




        public void showDeptInfo()
        {
            Console.WriteLine(" The name of the Dept : " + name);
            Console.WriteLine(" Total coueses are " + NumberOFCourse);

        }


    }
}