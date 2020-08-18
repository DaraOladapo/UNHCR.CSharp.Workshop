using System;
using System.IO;

namespace Module17.PerformIOOperations
{
    public static class ListIterateDirectories
    {
        public static void GetExample()
        {
            var myDirectory = @"../../FileToCompress";

            var myDirectoryInfo = new DirectoryInfo(myDirectory);
            Console.WriteLine($"Sub-directories for: {myDirectoryInfo.Name}:");

            foreach (var subDirectoryInfo in myDirectoryInfo.GetDirectories())
            {
                Console.WriteLine($"- {subDirectoryInfo.FullName}");
            }

            var directoriesContainingMore = myDirectoryInfo.GetDirectories("*more*");

            Console.WriteLine("Directories containing 'more' word:");

            foreach (var subDirectoryInfo in directoriesContainingMore)
            {
                Console.WriteLine($"- {subDirectoryInfo.FullName}");
            }
        }
    }
}
