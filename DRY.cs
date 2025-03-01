// DRY Don't Repeat Yourself
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Principles
{
    
    // Duplicate Logic Code   
   /*public class UserProcessor
    {
        public void ProcessUser1(string name, int age)
        {
            if (age < 18)
                Console.WriteLine($"{name} is a minor");
            else
                Console.WriteLine($"{name} is a adult");

        }

        public void ProcessUser2(string name, int age)
        {
            if(age<18)
                Console.WriteLine($"{name} is a minor");
            else
                Console.WriteLine($"{name} is a adult");
        }

        public void ProcessUser3(string name, int age)
        {
            if(age<18)
                Console.WriteLine($"{name} is a minor");
            else
                Console.WriteLine($"{name} is a adult");
        }
    }
  */

    // Using DRY Principle

    public class UserProcessor
    {
        public void ProcessUser(string name, int age)
        {
            PrintAgeMessage(name, age);
        }

        private void PrintAgeMessage(string name, int age)
        {
            if(age<18)
                Console.WriteLine($"{name} is a minor.");
            else
                Console.WriteLine($"{name} is an adult.");
        }
    }
    class DRY
    {
        public static void DRYMain()
        {
            UserProcessor userProcessor = new UserProcessor();

            userProcessor.ProcessUser("Tanmay", 13);
            userProcessor.ProcessUser("Sanket", 47);
            userProcessor.ProcessUser("Vivek", 41);
        }
    }
}
