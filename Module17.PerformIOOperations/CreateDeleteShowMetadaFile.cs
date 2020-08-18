using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module17.PerformIOOperations
{
    public static class CreateDeleteShowMetadaFile
    {
        public static void GetExample()
        {
            var myFile = @"../../Directory/file_5.txt";

            if (!File.Exists(myFile))
            {
                File.CreateText(myFile);
            }

            var fileInfo = new FileInfo(myFile);

            Console.WriteLine($"File name: {fileInfo.FullName}, Size: {fileInfo.Length}, Last Update: {fileInfo.LastWriteTimeUtc}");

            File.Delete(myFile);
        }
    }
}
