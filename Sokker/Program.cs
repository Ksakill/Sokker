using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        // borrowed the Dictionary from another coding project i got
        Dictionary<string, int> sockskuffe = new Dictionary<string, int>
        {
            { "RedSock", 10 }, // name and value
            { "BlueSock", 15 }, // name and value
            { "GreenSock", 8 } // name and value
        };

        while (true) // a while loop that is true
        {
            // writes the sock name and value
            Console.WriteLine("\nAvailable Sokker:");
            foreach (var sock in sockskuffe)
            {
                Console.WriteLine($"{sock.Key} - {sock.Value}");
            }
            // tells you to enture the name of one of socks you want to have and makes your anwser an input  
            Console.Write("\nSkriv sok navn (eller 'exit' for at quitte): ");
            string input = Console.ReadLine();
            //makes and if statemnt that says if exit is written break
            if (input.ToLower() == "exit")
            {
                break;
            }
            // an if that will write the sock name and number of them depending on what you wrote in the top 
            if (sockskuffe.ContainsKey(input))
            {
                Console.WriteLine($"Der er {sockskuffe[input]} {input} Sokker.");
            }
            else // an else that tells if the name is not found aka its not an actual input wirte sock not found
            {
                Console.WriteLine("Der er 0 sokker.");
            }
        }
    }
}
