using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            // set color of game 

            Console.ForegroundColor = ConsoleColor.Red;



            // prints game name

            Console.WriteLine("magic 8-ball by Lee Dilworth");

            while (true)
            {
                Console.Write("enter question here:");
                String question = Console.ReadLine();
                if (question.ToLower() == "quit");

                List<String> Answers = new List<string>();
                Answers.Add("yes");
                Answers.Add("no");
                Answers.Add("you should reconsider");
                Answers.Add("LOL of Course not");

                Random Ranstri = new Random();
                int index = Ranstri.Next( Answers.Count );
                string randomString = Answers [ index ];

                Console.WriteLine(randomString);

                
                }
            }
        }
    }
