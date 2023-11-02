using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VDap.Task3.GenericCollections
{
    public class RegisterAuser_List
    {
        private static List<string> user { get; set; }
        private static List<string> pass { get; set; }
        public RegisterAuser_List()
        {
            user = new List<string>();
            pass = new List<string>();
        }
        public static void Register(string name,string password)
        {
            user.Add(name);
            pass.Add(password);
        }
        public static void GetAllUsers()
        {
            user.ForEach(a => Console.WriteLine(a));
        }
    }
}
