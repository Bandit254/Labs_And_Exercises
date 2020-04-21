using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace ISTA421___20200425___ZSilvis___EX_5A
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a password cracking program (single and multi-thread) and time how long it takes to crack passwords of varying length.");
            SingleThreadCrackerTimer();
            MultiThreadTimer();
        }
        public static string SingleThreadCracker(string password)
        {
            char[] crackedPasswordArray = new char[password.Length];
            string crackedPassword = "";
            Random cR = new Random();
            for (int i = 0; i < password.Length; i++)
            {
                char nextChar = Convert.ToChar(cR.Next(32, 128));
                crackedPasswordArray[i] = nextChar;
                while (password[i] != crackedPasswordArray[i])
                {
                    nextChar++;
                    crackedPasswordArray[i]= nextChar;
                }
            }
            foreach (char c in crackedPasswordArray)
            {
                crackedPassword += c;
            }
            return crackedPassword;
        }
        public static void SingleThreadCrackerTimer()
        {
            Stopwatch stopWatch = new Stopwatch();
            Console.WriteLine("Enter the password to be cracked:\n");
            string password = Console.ReadLine();
            stopWatch.Start();
            string crackedPassword = AllAtOnceSTCracker(password);
            stopWatch.Stop();
            long time = stopWatch.ElapsedMilliseconds;
            Console.WriteLine($"The given password was '{password}', the cracked password is '{crackedPassword}', and the time it took (milliseconds) to crack the password using a single thread was {time}.");
        }
        public static string AllAtOnceSTCracker(string password)
        {
            char[] crackedArray = new char[password.Length];
            string crackedPassword = "";
            Random cR = new Random();
            while (!String.Equals(password,crackedPassword))
            {
                crackedPassword = "";
                for (int i = 0; i < password.Length; i++)
                {
                    crackedArray[i]= Convert.ToChar(cR.Next(32, 128));
                }
                foreach (char c in crackedArray)
                {
                    crackedPassword += c;
                }
            }
            return crackedPassword;
        }
        public static string MultiThreadCracker(string password)
        {
            string crackedPassword = "";
            string passwordFirst = "";
            string passwordSecond = "";
            string crackedFirst = "";
            string crackedSecond = "";
            int x = password.Length / 2;
            int y = password.Length / 2 + 1;
            for (int i = 0; i <= x; i++)
            {
                passwordFirst += password[i];
            }
            for (int i = y; i < password.Length; i++)
            {
                passwordSecond += password[i];
            }
            Task<string> firstHalf = Task<string>.Run(() => AllAtOnceSTCracker(passwordFirst));
            Task<string> secondHalf = Task<string>.Run(() => AllAtOnceSTCracker(passwordSecond));
            Task.WaitAll(firstHalf, secondHalf);
            crackedFirst = firstHalf.Result;
            crackedSecond = secondHalf.Result;
            foreach (var s in crackedFirst)
            {
                crackedPassword += s;
            }
            foreach (var s in crackedSecond)
            {
                crackedPassword += s;
            }
            return crackedPassword;
        }
        public static void MultiThreadTimer()
        {
            Stopwatch stopWatch = new Stopwatch();
            Console.WriteLine("Enter the password to be cracked:\n");
            string password = Console.ReadLine();
            stopWatch.Start();
            string crackedPassword = MultiThreadCracker(password);
            stopWatch.Stop();
            long time = stopWatch.ElapsedMilliseconds;
            Console.WriteLine($"The given password was '{password}', the cracked password is '{crackedPassword}', and the time it took (milliseconds) to crack the password using two threads was {time}.");
        }
    }
}
