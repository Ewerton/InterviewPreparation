using System;
using System.Collections.Generic;
using System.Linq;

namespace Events_and_Delegates
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MyFileSearch mfs = new MyFileSearch();

            // Multicast delegate permite que multiplos metodos se sejam subscribers de um publisher.
            mfs.Publisher += Receiver1; 
            mfs.Publisher += Receiver1;

            // Delegates deixam o método publisher muito exposto, pois permitem setar nulo no método, por exemplo.
            // Uma opção é usar Eventos que encapsulam o comportamento de delegates.
            //mfs.SendData = null;

            Console.WriteLine("*** Search started ***");
            
            mfs.Search("C:\\GIT\\InterviewQuestions");

            Console.WriteLine("*** Search ended ***");
            Console.ReadLine();
        }

        private static void Receiver1(string strReceived)
        {
            Console.WriteLine("Receiver1: " + strReceived);
        }

        private static void Receiver2(string strReceived)
        {
            Console.WriteLine("Receiver1: " + strReceived);
        }
    }
}