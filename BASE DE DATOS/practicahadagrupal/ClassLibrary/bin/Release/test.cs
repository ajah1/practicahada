using System;
using System.IO;

class Test 
{
    public static void Main() 
    {
        try 
        {
            // Get the current directory.
            string path = Directory.GetCurrentDirectory();
            Console.WriteLine("The current directory is {0}", path);
		}
        catch (Exception e) 
        {
            Console.WriteLine("The process failed: {0}", e.ToString());
        }
    }
}