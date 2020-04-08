using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Collections.Generic;

namespace ISTA421___20200411___ZSilvis___EX_3A__Encrypting_Passwords_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating a user authentication system with encrypted passwords.\n");
            PasswordManager();
        }
        public static PasswordRegister passwordRegister = new PasswordRegister();
        public static void PasswordManager()
        {
            Console.WriteLine("#################################################################");
            Console.WriteLine("\n");
            Console.WriteLine("Z-PASS PASSWORD AUTHENTICATION SYSTEM");
            Console.WriteLine("\n");
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Test Password Encryption");
            Console.WriteLine("2. Create User Account");
            Console.WriteLine("3. Authenticate User Account");
            Console.WriteLine("4. Exit The Program");
            Console.WriteLine("\n");
            Console.WriteLine("#################################################################");
            Console.WriteLine("\n");
            Console.Write("Enter your selection here: ");
            int selection = Convert.ToInt32(Console.ReadLine());
            OptionManager(selection);
        }
        public static void OptionManager(int selection)
        {
            switch (selection)
            {
                case 1:
                    TestEncryption();
                    break;
                case 2:
                    CreateUserAccount();
                    break;
                case 3:
                    AuthenticateUser();
                    break;
                case 4:
                    Console.WriteLine("Thanks for using Z-PASS! See you next time!");
                    break;
                case 5:
                    PasswordManager();
                    break;
                default:
                    Console.WriteLine("Thanks for using Z-PASS! See you next time!");
                    break;
            }
        }
        public static void TestEncryption()
        {
            Console.WriteLine("#################################################################");
            Console.WriteLine("\n");
            Console.WriteLine("Z-PASS: Demonstration of password Encryption");
            Console.WriteLine("\n");
            Console.WriteLine("Enter an example password. The program will compute the SHA256 hash of the password and display the hash.");
            Console.Write("Enter Password Here: ");
            string passwordPT = Console.ReadLine();
            byte[] passwordHash = GenerateHash(passwordPT);
            Console.WriteLine("\n");
            Console.WriteLine($"The password you entered was '{passwordPT}' and the hash of that password is: \n");
            foreach (var b in passwordHash)
            {
                Console.Write($"{b}");
            }
            Console.WriteLine("\n");
            Console.WriteLine("As you can see, the SHA256 hash of a password looks nothing like your actual password. The hash is the only thing related to your password that the system stores.");
            Console.WriteLine("Because the hash algorithm is a one-way function, there is no way to figure out what your password is by examining the hash of the password.");
            Console.WriteLine("Each time to log in to the system, the program will re-compute the hash of the password you enter. If the resulting hash matches the hash of the password you entered at the time you made your account," +
                " then the program knows you are using the correct password.\n");
            Console.WriteLine("#################################################################");
            Console.WriteLine("\n");
            Console.Write("Press 5 to return to the main menu or 4 to exit the program: ");
            int selection = Convert.ToInt32(Console.ReadLine());
            OptionManager(selection);
        }
        public static void CreateUserAccount()
        {
            Console.WriteLine("#################################################################");
            Console.WriteLine("\n");
            Console.WriteLine("Z-PASS: Create an Account.");
            Console.WriteLine("\n");
            Console.WriteLine("First, enter a username.");
            Console.Write("Username: ");
            string username = Console.ReadLine();
            while (passwordRegister.CheckUsername(username)==true)
            {
                Console.WriteLine("Error, that username is already taken. Pick a different username.\n");
                Console.Write("Username: ");
                username = Console.ReadLine();
            }
            Console.WriteLine("\n");
            Console.WriteLine("Next, enter your password.");
            Console.Write("Password: ");
            string passwordPT = Console.ReadLine();
            byte[] passwordHash = GenerateHash(passwordPT);
            passwordRegister[username]= passwordHash;
            Console.WriteLine("\nThank you for creating an account! Return to the main menu to log in (Authenticate).\n");
            Console.WriteLine("\n");
            Console.WriteLine("#################################################################");
            Console.WriteLine("\n");
            Console.Write("Press 5 to return to the main menu or 4 to exit the program: ");
            int selection = Convert.ToInt32(Console.ReadLine());
            OptionManager(selection);
        }
        public static void AuthenticateUser()
        {
            Console.WriteLine("#################################################################");
            Console.WriteLine("\n");
            Console.WriteLine("Z-PASS: Authenticate an Account.");
            Console.WriteLine("\n");
            Console.Write("Enter your username:");
            string username = Console.ReadLine();
            Console.WriteLine("\n");
            Console.Write("Enter Your Password: ");
            string passwordPT = Console.ReadLine();
            byte[] passwordHash = GenerateHash(passwordPT);
            byte[] storedPasswordHash = passwordRegister[username];
            if (ComparePasswordHashes(passwordHash,storedPasswordHash)==true)
            {
                Console.WriteLine("Congratulations! You have sucessfully authenticated your username/password! See for yourself:\n");
                Console.WriteLine("This is the hash of the password you just entered:\n ");
                foreach (var b in passwordHash)
                {
                    Console.Write($"{b}");
                }
                Console.WriteLine("\n And this is the hash of the password stored in the system:\n ");
                foreach (var s in storedPasswordHash)
                {
                    Console.Write($"{s}");
                }
            }
            else
            {
                Console.WriteLine("Error! Incorrect username/password combination! See for yourself:\n");
                Console.WriteLine("This is the hash of the password you just entered:\n ");
                foreach (var b in passwordHash)
                {
                    Console.Write($"{b}");
                }
                Console.WriteLine("\n");
                Console.WriteLine("\n And this is the hash of the password stored in the system:\n "); 
                foreach (var s in storedPasswordHash)
                {
                    Console.Write($"{s}");
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("#################################################################");
            Console.WriteLine("\n");
            Console.Write("Press 5 to return to the main menu or 4 to exit the program: ");
            int selection = Convert.ToInt32(Console.ReadLine());
            OptionManager(selection);
        }
        public static byte[] GenerateHash(string passwordPT)
        {
            //This method received from Chris Smith
            byte[] passwordHash;
            using (SHA256 mySHA256 = SHA256.Create())
            {
                UnicodeEncoding ue = new UnicodeEncoding();
                byte[] passwordBytes = ue.GetBytes(passwordPT);
                passwordHash = mySHA256.ComputeHash(passwordBytes);
            }
            return passwordHash;
        }
        public class PasswordRegister
        {
            private Dictionary<string, byte[]> passwordRegister; 
            public PasswordRegister()
            {
                this.passwordRegister= new Dictionary<string, byte[]>();
            }
            public bool CheckUsername(string username)
            {
                return passwordRegister.ContainsKey(username);
            }

            public byte[] this [string username]
            {
                get { return FindPasswordHash(username); }
                set
                {
                    if (passwordRegister.ContainsKey(username) != true)
                    {
                        PostNewUsernamePassword(username, value);
                    }
                    else
                    {
                        UpdatePassword(username, value);
                    }
                }
            }
            public byte[] FindPasswordHash(string username)
            {
                if (passwordRegister.ContainsKey(username)==true)
                {
                    byte[] passwordHash = passwordRegister[username];
                    return passwordHash;
                }
                else
                {
                    Console.WriteLine("Error: Username not found.");
                    byte[] passwordHash = new byte[1];
                    return passwordHash;
                }
            }
            public void PostNewUsernamePassword(string username, byte[] passwordHash)
            {
                passwordRegister.Add(username, passwordHash);
            }
            public void UpdatePassword(string username, byte[] passwordHash)
            {
                passwordRegister[username] = passwordHash;
            }
        }
        public static bool ComparePasswordHashes(byte[] passwordHash, byte[] storedPasswordHash)
        {
            if (passwordHash.Length!=storedPasswordHash.Length)
            {
                return false;
            }
            for (int i = 0; i < passwordHash.Length; i++)
            {
                if (passwordHash[i]!=storedPasswordHash[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
