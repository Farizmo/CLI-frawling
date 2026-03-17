using System;

namespace HelloWorld
{
  class Program
  {
        static void Main(string[] args)
        {
      if ( argc > 1)
            {
                int lengths = 0;
                for (int i = 1; i < args; ++i)
                {
                    lengths += (string)args[i].length();
                }
                Console.WriteLine("You entered  " + args - 1 + " command line arguments");
                Console.WriteLine("The average number of characters per argument is " + (double) lengths / (argc - 1) + "." );
            } else
            {
                Console.WriteLine("No command line arguments were given.");
            }
    }
  }
}