using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndSearches
{
    internal class AtmBalance
    {

        public void ATMSYSTEM()

        {
            Console.WriteLine("Welcome To Cash Counter\n");
            Console.WriteLine("Enter Bank Account");
            int amount = Convert.ToInt32(Console.ReadLine());
            QueueDequeue<string> queue = new QueueDequeue<string>();
            Console.WriteLine("Enter of length of queue");
            int length = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < length; i++)
            {
                string name = Console.ReadLine();
                queue.Enqueue(name);
            }
            while (length > 0)
            {
                Console.WriteLine("choose an option" + "\n" + "1.Deposite" + "\n" + "2.withdraw");
                int option = Convert.ToInt32((Console.ReadLine()));
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter Amount To Deposite");
                        int deposite = Convert.ToInt32(Console.ReadLine());
                        amount += deposite;
                        break;
                    case 2:
                        Console.WriteLine("Enter Amount To Withdraw");
                        int withdraw = Convert.ToInt32((Console.ReadLine()));
                        if (withdraw > amount)
                        {
                            Console.WriteLine("Insufficient Money");
                        }
                        else
                            amount -= withdraw;
                        break;
                    default:
                        Console.WriteLine("Please Choose correct option");
                        break;
                }
                queue.Dequeue();
                length--;
            }
        }
    }
}


