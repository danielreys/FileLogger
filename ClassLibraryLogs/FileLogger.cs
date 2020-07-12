using System;
using System.IO;
using System.Reflection;
using System.Text;

namespace ClassLibraryLogs
{
    public static class FileLogger
    {
        private static string name = "";
        private static string testName = "testName"; //name setted for testing porpuses

        private static string path = Path.GetDirectoryName(
            Assembly.GetExecutingAssembly(). // .exe path
            Location);

        public static void setName(string n) {
            name = n;
        }
        public static void start() // Program starts
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                sb.Append(DateTime.Now + ": "+ name + " Started Successfully");
                sb.Append(Environment.NewLine);
                File.AppendAllText(path + "/" + "logs.txt", sb.ToString()); 
            }
            catch (Exception ex)
            {
                throw new LogException(ex.Message, path, name);
            }
            finally
            {
                sb.Clear();
            }
        }
        public static void close() // Program closed
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                sb.Append(DateTime.Now + ": " + name + " Closed Successfully");
                sb.Append(Environment.NewLine);
                File.AppendAllText(path + "/" + "logs.txt", sb.ToString());     
            }
            catch (Exception ex)
            {
                throw new LogException(ex.Message, path, name);
            }
            finally
            {
                sb.Clear();
            }
        }
        public static void test() { // throw LogException test
            if (1 == 1) {
                throw new LogException("Log", path, testName);
            }    
        }
    }
}
