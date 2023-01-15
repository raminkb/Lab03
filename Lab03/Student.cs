using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    internal class Student
    {
        private string name;
        private string _id;
        private int _birthYear;
        private int _height;
        private double _gpa;
        private string _major;

        public string Name
        {
            get { return this.name; }
        }
        public string ID
        {
            get { return this._id; }
        }
        public int Birthyear
        {
            get { return this._birthYear; }
        }
        public int Height
        {
            get { return this._height; }
        }
        public double GPA
        {
            get { return this._gpa; }
        }
        public string Major
        {
            get { return this._major; }
        }
        //constructor
        public Student(string name, string id, int birthYear, int height, double gpa, string major)
        {
            this.name = name;
            this._id = id;
            this._birthYear = birthYear;
            this._height = height;
            this._gpa = gpa ;
            this._major = major;
        }
    }
}
   
    