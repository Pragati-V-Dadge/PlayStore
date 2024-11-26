using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayStore
{
    public class User
    {
        public int a;//Variable
        public int Id { get; set; }//properties
        public string Name { get; set; }
        public string Email { get; set; }       
        public string Password { get; set; }
        public int Mobile { get; set; }
        private int UserKey { get; set; } = 217;
        //Functions
        // Syntax: public return/no-return type MethodName(){}
        public void CreateUser() 
        {
            Console.Write("User Registration");
            //How to read input from keyboard
            //Name = "Ram";
            Console.WriteLine("Enter Name");
            Name = Console.ReadLine(); //To read user inputs 
            Console.WriteLine("Enter Mobile Num");
            //Change string to long TYPECASTING
            Mobile = Convert.ToInt32(Console.ReadLine());//ToInt32(String, type)
           Console.WriteLine("Hello " + Name);



        }
    }
}
