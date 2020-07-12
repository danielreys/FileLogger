using ClassLibraryLogs;
using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace MyApp
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
            FileLogger.setName("FormHome"); 
            FileLogger.start();
        }
        private string getParentDirectory()
        {
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
            return projectDirectory;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            FileLogger.close();
        }
    }
}
