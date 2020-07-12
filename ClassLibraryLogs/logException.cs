using System;
using System.IO;
using System.Text;

namespace ClassLibraryLogs
{
    class LogException : Exception
    {
        public LogException()
        {
            // Not Implemented
        }

        public LogException(string message, string parentDirectory, string name) : base(message)
        {
            string path = parentDirectory;
            StringBuilder sb = new StringBuilder();
            try
            {
                sb.Append(DateTime.Now + ":" + name + " Crashed" + ": " + message);
                sb.Append(Environment.NewLine);
                File.AppendAllText(path + "/" + "logs.txt", sb.ToString());
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            finally
            {
                sb.Clear();
            }
        }
    }
}
