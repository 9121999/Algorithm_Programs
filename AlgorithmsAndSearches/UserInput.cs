using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndSearches
{
    internal class UserInput
    {
        public class MessageDemonstration
    {
        public void ReplaceString()
         {
            string input = "Hello << name >> We have your fullname as << fullname >> in our system. your contact number is 91 - xxxxxxxxxx.Please,let us know in case of any clarification.Thank you BridgeLabz" ;
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            input = input.Replace("<< name >>", name);

            Console.WriteLine("Enter your Full name");
            string fullname = Console.ReadLine();
            input = input.Replace("<< fullname >>",fullname);

            Console.WriteLine("Enter your Phone Number");
            string PhoneNo = Console.ReadLine();
            input = input.Replace("xxxxxxxxxx", PhoneNo);

                Console.WriteLine(input);
        }
         
        }
    
    }
   
}

