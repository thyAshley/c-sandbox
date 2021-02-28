using System;
using System.IO;

namespace LocalFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            //var path = @"C:\temp\myfile.jpg";
            //var targetPath = @"D:\myfile.jpg";
            //File.Copy(path, targetPath, true);
            //File.Delete(targetPath);

            //var fileInfo = new FileInfo(path);
            //fileInfo.CopyTo(targetPath);

            //Directory.CreateDirectory(@"D:\temp");
            //foreach (var file in Directory.GetFiles(@"D:\temp", "*.jpg", SearchOption.TopDirectoryOnly))
            //{
            //    Console.WriteLine(file);
            //}

            //var directoryinfo = new DirectoryInfo(@"D:\temp");
            //directoryinfo.GetFiles();

            var path = @"C:\temp\myfile.jpg";
            Console.WriteLine(Path.GetExtension(path));
            Console.WriteLine(Path.GetFileNameWithoutExtension(path));

        }
    }
}
