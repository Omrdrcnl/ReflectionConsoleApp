using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Microsoft.Win32;

namespace ReflectionConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            user user = new user();
            var type = user.GetType();

            foreach (var property in type.GetProperties())
            {
                Console.WriteLine($"{property.PropertyType}/{property.Name}");
            }
            Console.ReadLine();
        }

    }
    public class user
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}

