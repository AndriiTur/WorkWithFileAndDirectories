using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkWithFileAndDirectories
{
    public partial class Form1 : Form
    {
        public static long maxValue;
        public static string nameMaxValueFile;
        public static string PathToFile;
        public static string resultMesage;
        public static string Atribute;
        public Form1()
        {
            InitializeComponent();
        }

        private static void WorkWithFile(string PathIn, string searchingFile)
        {
            DirectoryInfo diTop = new DirectoryInfo(PathIn);
                try
                {
                   
                    foreach (var di in diTop.EnumerateDirectories("*"))
                    {
                        try
                        {
                            foreach (var fil in di.EnumerateFiles(searchingFile, SearchOption.AllDirectories))
                            {
                                try
                                {
                                    if (fil.Length > maxValue)
                                    {
                                    maxValue = fil.Length;
                                    nameMaxValueFile = fil.Name;
                                    PathToFile = fil.DirectoryName;
                                    Atribute = fil.Attributes.ToString();
                                    }
                                }
                                catch (UnauthorizedAccessException UnAuthFile)
                                {
                                resultMesage = "errormesage" + UnAuthFile.Message; 
                                }
                                catch (FileNotFoundException FileNotFound)
                                {
                                resultMesage = "errormesage" + FileNotFound.Message;
                                }
                            }
                            resultMesage = string.Format("{0}\r\n{1} kb\r\n{2}\r\n{3}",
                                           nameMaxValueFile, (maxValue / 1024).ToString(), PathToFile, Atribute);
                    }
                        catch (UnauthorizedAccessException UnAuthSubDir)
                        {
                        resultMesage = "errormesage" + UnAuthSubDir.Message;
                        }
                    }
                }
                catch (DirectoryNotFoundException DirNotFound)
                {
                resultMesage = "errormesage" + DirNotFound.Message;
                }
                catch (UnauthorizedAccessException UnAuthDir)
                {
                resultMesage = "errormesage" + UnAuthDir.Message;
                }
                catch (PathTooLongException LongPath)
                {
                resultMesage = "errormesage" + LongPath.Message;
                }
            resultMesage = string.Format("{0}\r\n{1} kb\r\n{2}\r\n{3}",
                nameMaxValueFile, (maxValue / 1000).ToString(), PathToFile, Atribute);
        }
        
        
        private void FindMaxSizeFileButton_Click(object sender, EventArgs e)
        {
           
            WorkWithFile(TextBoxPath.Text, MaskTextBox.Text);
            OutTextBox.Clear();
            OutTextBox.Text = resultMesage;
            
        }

      
    }
}
