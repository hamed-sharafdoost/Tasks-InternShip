using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VDap.Task1.EleventhQuestion
{
    public class Student
    {
        Lesson lesson = new Lesson();
        public void InsertGrades(double math,double geometry,double history)
        {
            lesson.Math = math;
            lesson.Geometry = geometry;
            lesson.History = history;
        }
        public void DisplayGrades()
        {
            Console.WriteLine("Grade of math is :"+lesson.Math);
            Console.WriteLine("Grade of geometry is :" + lesson.Geometry);
            Console.WriteLine("Grade of history is :" + lesson.History);
        }

    }
    internal struct Lesson
    {
        public double Math;
        public double Geometry;
        public double History;
    }
}
