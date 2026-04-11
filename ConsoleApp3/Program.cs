using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Speech.Synthesis;
using System.Threading;
using static System.Console;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ForegroundColor = ConsoleColor.Red;
            WriteLine(" ██████╗██╗   ██╗██████╗ ███████╗██████╗ ██████╗  ██████╗ ████████╗\r\n██╔════╝╚██╗ ██╔╝██╔══██╗██╔════╝██╔══██╗██╔══██╗██╔═══██╗╚══██╔══╝\r\n██║      ╚████╔╝ ██████╔╝█████╗  ██████╔╝██████╔╝██║   ██║   ██║   \r\n██║       ╚██╔╝  ██╔══██╗██╔══╝  ██╔══██╗██╔══██╗██║   ██║   ██║   \r\n╚██████╗   ██║   ██████╔╝███████╗██║  ██║██████╔╝╚██████╔╝   ██║   \r\n ╚═════╝   ╚═╝   ╚═════╝ ╚══════╝╚═╝  ╚═╝╚═════╝  ╚═════╝    ╚═╝   \r\n  ");
            TypeText("what is your name?");
            string name = ReadLine();

            cyberbot bot = new cyberbot(name);
            bot.Greet();
            bot.StartChat();

        }

        static void TypeText(string text, int delay = 30)
        {
            foreach (char c in text)
            {
                Write(c);
                //delays writting the chaacters 
                Thread.Sleep(delay);
            }
            WriteLine();
        }
    }
    }

