using Factorial;
using System;

namespace std
{
    class Calc
    {
        static void Main()
        {
            DataBaseHandler dbhandler = new DataBaseHandler();

            Console.WriteLine(dbhandler.GetUserNames().Count+"summary names");

            
        }
    }
}