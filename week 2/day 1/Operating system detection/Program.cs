using System;
using System.Runtime.InteropServices;

namespace Operating_system_detection
{
    class Program
    { 
        
       
        static void Main(string[] args)
        {
            string OSV = System.Environment.OSVersion.VersionString;
            Console.WriteLine(OSV.Contains("Windows"));
            Console.WriteLine(OSV);


            Console.WriteLine(RuntimeInformation.IsOSPlatform(OSPlatform.Windows));





        }
    }
}
