using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Console;

namespace ConsoleApp3
{
    internal class cyberbot
    {
        private string name;
        private SpeechSynthesizer voice;
        private Dictionary<string, string> responses;


        public cyberbot(string name)
        {
            this.name = name;
            voice = new SpeechSynthesizer();
            responses = new Dictionary<string, string>()
            {
                {"how are you", "im doing great thanks for asking " + name + "! always ready to help you stay safe online."},
                {"whats your purpose","my purpose is to help you stay safe online! i can teach you about phishing, safe browsing, password safety and more. just ask me anything!" },
                {"what can i ask you about","well"+" " + name + "! you can ask me about: phishing, safe browsing, password safety. just type any of those topics and ill explain them!"  },
                {"phishing","Phishing is a type of online scam where someone pretends to be a trusted person or company to trick you into giving away sensitive information" },
                {"safe browsing","Safe browsing means using the internet in a way that protects your personal information, device, and accounts from threats like hackers, scams, and viruses." },
                {"password safety","Password safety is the practice of creating, managing, and protecting your passwords so that other people (like hackers) can't access your accounts." },
                {"bye","Goodbye " + name + " stay safe online!" }
            };
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

        //divider to separite 
        static void Divider(char symbol = '=', int length = 50)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            WriteLine(new string(symbol, length));
            ResetColor();

        }

        //Greeting for the chatbot
        public void Greet()
        {
            ForegroundColor = ConsoleColor.Yellow;
            string message = " Hello welcome to CyberSecurityAwarenessbot. I'm here to help you stay safe online";
            ResetColor();
            ForegroundColor = ConsoleColor.Green;
            TypeText("hi " + name + "\n" + message);
            ResetColor();
            voice.Speak(message);
        }

        //the start of the chatbot
        public void StartChat()
        {
            ForegroundColor = ConsoleColor.Cyan;
            Divider();
            TypeText("simple chatbot (type 'bye' to exit)");
            Divider();
            ResetColor();

            while (true)
            {

                TypeText(this.name + ": ");
                string input = Console.ReadLine()?.ToLower().Trim();

                if (string.IsNullOrEmpty(input))
                {
                    TypeText("bot: sorry i didnt catch that.");
                    continue;
                }

                if (responses.TryGetValue(input, out string reply))
                {
                    TypeText("bot: " + reply);
                    voice.Speak(reply);
                }
                else
                {
                    TypeText("bot: i didnt quit understand that. Could you rephrase?");
                }

                if (input == "bye") break;
            }
        }



    }
}

