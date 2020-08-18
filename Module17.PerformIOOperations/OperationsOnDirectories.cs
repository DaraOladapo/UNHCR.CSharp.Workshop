using System.IO;

namespace Module17.PerformIOOperations
{
    public static class OperationsOnDirectories
    {
        public static void GetExample()
        {
            var myDirectoryName = "directory";
            var anotherDirectoryName = "another_directory";

            if (!Directory.Exists(myDirectoryName))
            {
                Directory.CreateDirectory(myDirectoryName);
            }

            if (!Directory.Exists(anotherDirectoryName))
            {
                Directory.CreateDirectory(anotherDirectoryName);
            }

            Directory.Move(myDirectoryName, $"{anotherDirectoryName}//{myDirectoryName}");

            Directory.Delete($"{anotherDirectoryName}//{myDirectoryName}");
        }
    }
}
