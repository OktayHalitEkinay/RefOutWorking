using ClassLibrary.Business;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            AuthManager authManager = new AuthManager();
            Console.WriteLine(authManager.Register()); 
        }
    }
}
