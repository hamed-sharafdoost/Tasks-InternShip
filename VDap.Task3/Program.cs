using System;
using VDap.Task3.OverLoading_Overriding;
using VDap.Task3.Events_Delegates;
using VDap.Task3.LambdaExpressions;
using VDap.Task3.GenericCollections;
using VDap.Task3.GenericMethods_Classes;
using VDap.Task3.Reflection;
using VDap.Task3.AsynchronousProgramming;
using VDap.Task3.Threading;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace VDap.Task3
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*Overloading-Overriding
            Time time = new Time(2, 17);
            Time time2 = new Time(3, 18);
            Console.WriteLine((time - time2).ToString());
            Console.WriteLine((time + time2).ToString());*/

            /*Events-delegates
            Dice dice = new Dice();
            dice.sixInaRow += Dice_OnSixInaRow;
            dice.moreThan3 += Dice_MoreThan3;
            dice.Roll();
            dice.Roll();
            dice.Roll();
            dice.Roll();
            dice.Roll();
            Point point = new Point() { X =2,Y =10};
            Point point2 = new Point() { X =5.6,Y =3.4};
            Compare compare = Compare_x;
            Compare compare2 = Compare_y;
            Compare compare3 = Compare_Coordinate_Origin;
            Console.WriteLine("Comparison is done based on x coordinate(point1.x > point2.x)? :"+point.IsGreater(compare,point2));
            Console.WriteLine("Comparison is done based on y coordinate(point1.y > point2.y)? :" + point.IsGreater(compare2, point2));
            Console.WriteLine("Comparison is done based on distance from coordinate origin(point1 > point2)? :" 
                                + point.IsGreater(compare3, point2));*/

            /*Lambda Expressions
            Console.WriteLine(Calculator.Add(3.4, 2));
            Console.WriteLine(Calculator.Subtract(6,2));
            Console.WriteLine(Calculator.Multiply(1.2,4));
            Console.WriteLine(Calculator.Divide(25, 2));
            Console.WriteLine("Please Enter a number :");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number + " Is even? " + Calculator.IsEven(number));*/

            /*Exception handling
            Exception formatException = new FormatException("Enter the number in a correct format");
            Exception castException = new InvalidCastException("This type doesn't implement IConvertible interface");
            Exception OverflowException = new OverflowException("The number is out of range of double type");
            try
            {
                Convert.ToDouble("hhhh");
            }
            catch
            {
                Console.WriteLine(formatException.Message);
                throw formatException;
            }

            try
            {
                Convert.ToDouble('2');
            }
            catch
            {
                Console.WriteLine(castException.Message);
                throw castException;
            }

            try
            {
                Convert.ToDouble("20000e10000");
            }
            catch
            {
                Console.WriteLine(OverflowException.Message);
                throw OverflowException;
            }*/
            ExtractJson_Dictionary.ExtractAndShow();
            /*Generic Collections
            ExtractJson_Dictionary.ExtractAndShow();
            SortedList_Students students = new SortedList_Students();
            students.Add("Ali Shahriari", 13);
            students.Add("Bita sobhani", 12);
            students.Add("Akbar naraghi", 19);
            students.Add("Dara Shajari", 20);
            students.ShowTop3();
            HashSet_Students hashSet = new HashSet_Students(new string[] { "Math", "Literature", "Physics", "History" },
                                                            new string[] { "Math", "Geometry", "History", "Electronic" });
            Console.WriteLine("Common lessons between classes are :");
            hashSet.ShowCommonLessons();

            Queue_BFS queue = new Queue_BFS();
            queue.DoSearch();
            Stack_DFS stack = new Stack_DFS();
            stack.DoSearch();*/

            /*GenericMethods-GenericClasses
            Pair<string, int> customVariable1 = new Pair<string, int>("Ali", 5);
            Pair<string, double> customVariable2 = new Pair<string, double>("Hamed", 3.4);
            Pair<string,int>[] customArray = new Pair<string, int>[5];
            for(int i = 0; i < customArray.Length; i++)
            {
                customArray[i] = new Pair<string, int>("Hi"+i, i);
            }
            foreach (var pair in customArray)
                Console.WriteLine(pair.ToString());
            Pair<Pair<int, int>, string> customVariable3 = new Pair<Pair<int, int>, string>(new Pair<int, int>(2, 3), "Mohammad");
            Console.WriteLine(customVariable3.ToString());
            Console.WriteLine("This generic function returns all numbers which are greater than 12 :");
            GenericFunction<int>(new List<int> { 12,32,15,6,7},12).ForEach(x => Console.WriteLine(x));*/

            /*Reflection
            Company company = new Company();
            ShowReflectedData(company);*/

            /*Asynchronous Programming
            Sample.SlowFunctionAsync();
            Sample.FastFunction();*/

            /*Threading
            int[,] matrix1 = { { 2, 3, 4 }, { 4, 5, 6 }, { 6, 7, 8,}};
            int[,] matrix2 = { { 2, 3, 4,12 }, { 4, 5, 6,10 }, { 6, 7, 8,9} };
            MatrixMultiplication_Thread multiply = new MatrixMultiplication_Thread(matrix1,matrix2);
            Console.WriteLine("The result of multiplication using thread is :");
            multiply.MultiplyMatrices();
            MatrixMultiplication_Task multiplyTask = new MatrixMultiplication_Task(matrix1 , matrix2);
            Console.WriteLine("The result of multiplication using task is :");
            multiplyTask.MultiplyMatrices();*/

            Console.ReadKey();
        }
        public static bool Compare_x(Point point1,Point point2)
        {
            if (point1.X > point2.X)
                return true;
            return false;
        }
        public static bool Compare_y(Point point1,Point point2)
        {
            if (point1.Y > point2.Y)
                return true;
            return false;
        }
        public static bool Compare_Coordinate_Origin(Point point1, Point point2)
        {
            double distance_point1 = Math.Sqrt(Math.Pow(point1.X, 2) + Math.Pow(point2.Y, 2));
            double distance_point2 = Math.Sqrt(Math.Pow(point2.X, 2) + Math.Pow(point1.Y, 2));
            if(distance_point1 > distance_point2)
                return true;
            return false;
        }
        static void Dice_OnSixInaRow(object sender,CustomArgs e)
        {
            Console.WriteLine($"Number 6 is showed {e.SixInARow} in a row");
        }
        static void Dice_MoreThan3(object sender,CustomArgs e)
        {
            Console.WriteLine($"Number {e.MoreThan3} is greater than 3");
        }
        static List<T> GenericFunction<T>(List<T> list,T variable) where T : struct
        {
            switch(typeof(T).Name)
            {
                case "Int32":
                case "Double":
                case "Single":
                case "Int64":
                    return list.Where(t => (dynamic)t > (dynamic)variable).ToList();
                    break;
                default:
                    return new List<T>();
            } 
        }
        static void ShowReflectedData(object obj)
        {
            Type myobject = obj.GetType();
            PropertyInfo[] properties = myobject.GetProperties();
            MethodInfo[] methods = myobject.GetMethods();

            Console.WriteLine("Properties of company class are :");
            foreach(var property in properties)
                Console.WriteLine(property.Name);

            Console.WriteLine("\nMethods of company class are :");
            foreach(var method in methods)
                Console.WriteLine(method.Name);

            Console.WriteLine("\nCall ToString method for object :");
            Console.WriteLine(obj.ToString());
        }
    }
}