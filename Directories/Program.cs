using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.AccessControl;
//using System.IO.FileSystem.AccessControl;

/*
File and Directories classes
File  - It has static methods
FileInfo  - it has instance methods
Directory
DirectoryInfo
Path
FileSecurity 
DirectorySecurity

dotnet add package System.IO.FileSystem.AccessControl --version 4.7.0

 */

namespace CSharpS7_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"/tmp/test.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("The file exists, removing file...");
                File.Delete(path);
                Console.WriteLine("The file has been deleted.");
            }
            File.Create(path).Close();
            Directory.CreateDirectory(Path.GetDirectoryName(path) + "/dir");

            //File.Move(path, @"c:\tmp\dir\test.txt");

            //FileSecurity fs = File.GetAccessControl(path);
            FileSecurity fs = new FileSecurity(path, AccessControlSections.Owner |
                AccessControlSections.Group |
                AccessControlSections.Access);

            fs.AddAccessRule(new FileSystemAccessRule(@"Eric-PC3\Eric", FileSystemRights.ReadAndExecute, AccessControlType.Allow));

            //File.SetAccessControl(path, fs);
        }
    }
}
