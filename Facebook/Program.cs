using System;
using Facebook.Exception;

namespace Facebook
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new System.Exception("Message");
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.StackTrace);
                foreach (var line in e.GetBaseException().StackTrace)
                {
                    Console.WriteLine(line);
                    
                }
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Hello Facebook!");
        }
    }
}