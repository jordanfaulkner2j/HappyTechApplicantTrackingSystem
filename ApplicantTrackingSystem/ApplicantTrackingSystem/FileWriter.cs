using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Text;
using System.Threading.Tasks;
using System.CodeDom.Compiler;

namespace ApplicantTrackingSystem
{
    class FileWriter
    {
        // constant name of temporary file
        private const string TEMP_FILE = "temp.txt";
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

        /// <summary>
        /// create and write to a PDF file
        /// </summary>
        /// <param name="fileName">name of the file without file type</param>
        /// <param name="splitText">array of strings (paragraphs split into sections)</param>
        /// <reference link="https://www.c-sharpcorner.com/UploadFile/f4f047/generating-pdf-file-using-C-Sharp/">Generating PDF File Using C#</reference>
        public static void GeneratePDF(string fileName, string[] splitText)
        {
            // create document of A4 size with margin of 30 pixels from left, right, top, bottom
            using (Document document = new Document(PageSize.A4, 30, 30, 30, 30))
            using (FileStream fileStream = File.Create(fileName + ".pdf"))
            using (PdfWriter writer = PdfWriter.GetInstance(document, fileStream))
            {
                document.Open();

                // paragraph formatting
                Paragraph paragraph = new Paragraph
                {
                    SpacingBefore = 10,
                    SpacingAfter = 10,
                    Alignment = Element.ALIGN_LEFT,
                    Font = FontFactory.GetFont(FontFactory.HELVETICA, 15f, BaseColor.BLACK)
                };

                // add each section to be written to the file and separate them with blank line
                foreach (string section in splitText)
                {
                    paragraph.Add(section);
                    paragraph.Add(Chunk.NEWLINE);
                    paragraph.Add(Chunk.NEWLINE);
                }

                // add sections to file and close
                document.Add(paragraph);
                document.Close();
            }
        }
    }
}
