using ImageMagick;
using System;
using System.IO;
using System.Linq;

namespace HEICConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var file in Directory.EnumerateFiles(@"C:\Users\clark\Downloads\Job site photos -20211111T173846Z-001\Job site photos"))
            {
                var extenstion = file.Split('.').Last().ToLower();

                if (extenstion != "heic") continue;

                using (MagickImage image = new MagickImage(new FileInfo(file)))
                {
                    image.Write(new FileInfo($"{file.Split('.').First()}.jpg"), MagickFormat.Jpg);
                    Console.WriteLine($"{file.Split('.').First()}.jpg");
                }
            }

            Console.Read();

        }
    }
}
