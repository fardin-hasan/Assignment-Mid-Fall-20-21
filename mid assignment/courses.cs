using System;
using System.Collections.Generic;
using System.Text;

namespace Mid_Project
{

    public class Courses
    {
        private string Name;
        internal section[] Section;
        internal Faculty[] faculty;
        private double Hour;
        private int NumberOfSection;



        public string name
        {
            set { Name = value; }
            get { return Name; }
        }
        public double Hour
        {
            set { Hour = value; }
            get { return Hour; }
        }

        public int numOfSec
        {
            set { NumberOfSection = value; }
            get { return NumberOfSection; }
        }

        public void showCourseInfo()
        {
            Console.WriteLine("The name of the course : " + Name);
            Console.WriteLine("Total Hour: " + Hour);
            Console.WriteLine("Number of section :" + NumberOfSection);


        }
    }
}