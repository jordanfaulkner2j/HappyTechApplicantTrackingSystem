using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.CodeDom.Compiler;

namespace ApplicantTrackingSystem
{
    class FileWriter
    {
        // constant value for temporary file name
        private static string TEMP_FILE = "temp.txt";

        public static void Write(string fileName, string line)
        {
            using (StreamWriter writer = new StreamWriter(fileName, true))
            {
                writer.WriteLine(line);
            }
        }

        public static void Insert(string fileName, string line, int beforeLineNumber)
        {
            if (!File.Exists(fileName) || File.ReadLines(fileName).Count() == 0)
            {
                Write(fileName, line);
                return;
            }
            else if (beforeLineNumber < 1)
            {
                InsertAtBeginning(fileName, line);
                return;
            }

            using (StreamReader reader = new StreamReader(fileName))
            {
                using (StreamWriter writer = new StreamWriter(TEMP_FILE, true))
                {
                    int index = 1;
                    while (!reader.EndOfStream)
                    {
                        if (index == beforeLineNumber)
                        {
                            writer.WriteLine(line);
                        }
                        writer.WriteLine(reader.ReadLine());
                        index++;
                    }
                }
            }

            File.Delete(fileName);
            File.Move(TEMP_FILE, fileName);

            if (File.Exists(TEMP_FILE))
            {
                File.Delete(TEMP_FILE);
            }
        }

        public static void InsertAtBeginning(string fileName, string line)
        {
            Insert(fileName, line, 1);
        }

        public static int ContainsLine(string fileName, string line)
        {
            if (!File.Exists(fileName))
            {
                return 0;
            }

            using (StreamReader reader = new StreamReader(fileName))
            {
                int index = 1;
                while (!reader.EndOfStream)
                {
                    if (line == reader.ReadLine())
                    {
                        return index;
                    }
                    index++;
                }
            }
            return 0;
        }

        public static string GetLine(string fileName, int lineNumber)
        {
            if (!File.Exists(fileName) || lineNumber < 1)
            {
                return null;
            }

            using (StreamReader reader = new StreamReader(fileName))
            {
                for (int i = 1; i < lineNumber; i++)
                {
                    if (!reader.EndOfStream)
                    {
                        reader.ReadLine();
                    }
                }
                return reader.ReadLine();
            }
        }

        public static void DeleteLine(string fileName, int lineNumber)
        {
            if (!File.Exists(fileName) || lineNumber < 1)
            {
                return;
            }

            Boolean editFlag = false;

            using (StreamReader reader = new StreamReader(fileName))
            {
                using (StreamWriter writer = new StreamWriter(TEMP_FILE, true))
                {
                    int index = 1;
                    while (!reader.EndOfStream)
                    {
                        if (index != lineNumber)
                        {
                            writer.WriteLine(reader.ReadLine());
                        }
                        else
                        {
                            reader.ReadLine();
                            editFlag = true;
                        }
                        index++;
                    }
                }
            }

            if (editFlag)
            {
                /*
                using (StreamReader reader = new StreamReader(TEMP_FILE))
                {
                    using (StreamWriter writer = new StreamWriter(fileName))
                    {
                        while (!reader.EndOfStream)
                        {
                            writer.WriteLine(reader.ReadLine());
                        }
                    }
                }
                */

                File.Delete(fileName);
                File.Move(TEMP_FILE, fileName);
            }

            if (File.Exists(TEMP_FILE))
            {
                File.Delete(TEMP_FILE);
            }
        }

        public static void DropLine(string fileName)
        {
            DeleteLine(fileName, File.ReadLines(fileName).Count());
        }
    }
}
