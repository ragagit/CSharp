using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/*
Streams
They are not thread safe, include async methods

Stream Adapters
A stream deals only in bytes; to read or write data types such as strings, integers,
Or XML elements, you must plug in an adapter.

FileStream r/w files
IsolatedStorageFileStream 
MemoryStream r/w In memory
BufferedStream for improving r.w performance
NetworkStream r/w network sockets
PipeStream. Pipes don’t rely on network which improves performance and avoid firewall issues.
	Anonymous
		Communication parent child in the same computer 
	name pipes
		Communication between arbitrary processes on the same computer or
		different computer across windows network.
CryptoStream data streams transformation
StringReader and StringWriter
StreamReader and StreamWriter

 */
namespace CSharpS7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream fs = File.OpenWrite(@"/tmp/test.txt"))
            {
                byte[] text;
                text = new UTF8Encoding(true).GetBytes(@"This is a test string");
                fs.Write(text, 0, text.Length);
            }

            using (FileStream fs = File.OpenRead(@"/tmp/test.txt"))
            {
                byte[] text = new byte[1024];
                UTF8Encoding str = new UTF8Encoding(true);
                while (fs.Read(text, 0, text.Length) > 0)
                {
                    Console.WriteLine(str.GetString(text));
                }
            }

            // using (StreamWriter sw = new StreamWriter(@"c:\tmp\test.txt"))
            // {
            //     sw.WriteLine("This is our second line");
            // }

            // using (StreamReader sr = new StreamReader(@"c:\tmp\test.txt"))
            // {
            //     Console.WriteLine(sr.ReadLine());
            // }
        }
    }
}
