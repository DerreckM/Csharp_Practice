using System;
using System.Collections.Generic;

namespace list_tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
           
		var names = new List<string> { "Luke", "Father", "One with the force" };
		foreach (var name in names)
		{
		 	Console.WriteLine($"Hello {name.ToUpper()}!");
		}
        }
    }
}
