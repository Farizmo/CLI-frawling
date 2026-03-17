using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      if ( args.Length > 1)
      {
      for (int i = 0; i < args.Length; ++i)
      {
          Console.WriteLine($"Argument {i}: {args[i]}");
      }
      } else
      {
          Console.WriteLine("No command line arguments were given.");
      }
    }
  }
}