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
        // constant name of temporary file
        private static string TEMP_FILE = "temp.txt";
        // constant name of log file
        private const string LOG_FILE = "eventLog.csv";

        /// <summary>
        /// write a line to specified file by its name
        /// </summary>
        /// <param name="fileName">name of the file</param>
        /// <param name="line">string containing single line</param>
        public static void Write(string fileName, string line)
        {
            using (StreamWriter writer = new StreamWriter(fileName, true))
            {
                writer.WriteLine(line);
            }
        }

        /// <summary>
        /// write an error message to log file
        /// </summary>
        /// <param name="errorEvent">error or event to note</param>
        public static void WriteLog(string errorEvent)
        {
            using (StreamWriter writer = new StreamWriter(LOG_FILE, true))
            {
                writer.WriteLine(string.Format(errorEvent, DateTime.Now.ToString("hh:mm dd/mm/yyyy")));
                // add user to the error entries (preferably without having to pass it as a variable)
            }
        }

        /// <summary>
        /// insert line before specified line number and specified file
        /// </summary>
        /// <param name="fileName">name of the file</param>
        /// <param name="line">string containing single line</param>
        /// <param name="beforeLineNumber">line number before which to insert the included line</param>
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

        /// <summary>
        /// insert line at the beginning of specified file
        /// </summary>
        /// <param name="fileName">name of the file</param>
        /// <param name="line">string containing single line</param>
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

        /// <summary>
        /// return line at specified line from specified file
        /// </summary>
        /// <param name="fileName">name of the file</param>
        /// <param name="lineNumber">line number</param>
        /// <returns>string containing single line</returns>
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

        /// <summary>
        /// delete specified line in specified file
        /// </summary>
        /// <param name="fileName">name of the file</param>
        /// <param name="lineNumber">line number</param>
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

        /// <summary>
        /// delete the last line in specified file
        /// </summary>
        /// <param name="fileName">name of the file</param>
        public static void DropLine(string fileName)
        {
            DeleteLine(fileName, File.ReadLines(fileName).Count());
        }
    }
}
