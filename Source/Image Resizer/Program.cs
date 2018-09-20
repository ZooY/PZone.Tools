using PZone.Drawing;
using System;


namespace PZone.Tools
{
   public class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine(@"The program creates a copy of the image with a reduced size.");
                Console.WriteLine(@"");
                Console.WriteLine(@"ImageResizer.exe s=<filename> r=<filename> [w=<number>] [h=<number>]");
                Console.WriteLine(@"");
                Console.WriteLine(@"s=<filename>   Image source file.");
                Console.WriteLine(@"r=<filename>   Image destination file.");
                Console.WriteLine(@"w=<number>     Width of the resulting image.");
                Console.WriteLine(@"h=<number>     Height of the resulting image.");
                Console.WriteLine(@"");
                Console.WriteLine(@"The names of the files that have spaces must be enclosed in quotes, i.e.:");
                Console.WriteLine(@"s=""c:\My Documents\Image.jpg""");
                Console.WriteLine(@"To proportionally change the size, you must specify either the width or the height of the image.");
                return;
            }

            try
            {
                var properties = CommandLineConvert.DeserializeObject<ResizeProperties>(args);
                var resizer = new ImageResizer();
                resizer.ResizeFile(properties.SourceFileName, properties.ResultFileName, properties.Width, properties.Height);
            }
            catch (Exception ee)
            {
                Console.WriteLine($"Failed to resize file. {ee.Message}");
            }
        }
    }
}