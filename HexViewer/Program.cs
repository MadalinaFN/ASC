using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexViewer
{
    class Program
    {
        private static BinaryDocument document;

        static void Main(string[] args)
        {
            // Scrieti un program C# care sa functioneze ca un viewer hexazecimal pentru continutul unui fisier.
        }

        public class HexViewer
        {
            public override void Load(string filename)
            {
                Console.WriteLine("Loading " + filename);

                byte[] buffer;
                FileStream fileStream = new FileStream(filename, FileMode.Open, FileAccess.Read);
                try
                {
                    int length = (int)fileStream.Length;  // get file length
                    buffer = new byte[length];            // create buffer
                    int count;                            // actual number of bytes read
                    int sum = 0;                          // total number of bytes read

                    // read until Read method returns 0 (end of the stream has been reached)
                    while ((count = fileStream.Read(buffer, sum, length - sum)) > 0)
                    {
                        sum += count;  // sum is a buffer offset for next reading
                    }

                    document = new BinaryDocument(buffer);
                }
                finally
                {
                    fileStream.Close();
                }

                base.Hex(filename);
            }
        }
    }
}
