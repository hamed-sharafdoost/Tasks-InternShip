using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VDap.Task1.FourthQuestion
{
    public class ConditionalStatements
    {
        public int _Age;
        public string _AgeGroup;
        public string SpecifyAgeGroup(int Age)
        {
            _Age = Age;
            switch(_Age)
            {
                case int d when d < 13 && d >= 1:
                    _AgeGroup = "Children";
                    break;
                case int a when a < 18 && a >= 13:
                    _AgeGroup = "Teenage";
                    break;
                case int b when b >= 18 && b < 65:
                    _AgeGroup = "Adult";
                    break;
                case int c when c >= 65:
                    _AgeGroup = "Older Adult";
                    break;
                default:
                    _AgeGroup = "Undefined";
                    break;
            }
            return _AgeGroup;
        }
        public void HealthAdvice()
        {
            if (_AgeGroup == "Older Adult")
            {
                Console.WriteLine("You have to be very careful about your meals");
                Console.WriteLine("How much is your blood sugar ?");
                int bloodsugar = Convert.ToInt32(Console.ReadLine());
                string state = bloodsugar > 100 ? "Unhealthy" : "Healthy" ;
                Console.WriteLine(state);
            } 
            else
                Console.WriteLine("Don't forget to exercise at least 30 minutes a day");
        }
    }
}
