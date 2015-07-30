using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;  //because we are using files


namespace PCS23_5._1
{
    class TextFileHelper
    {
        public string FileName { get; set; }
        public TextFileHelper(string filename)
        {
            FileName = filename;
        }
        public TextFileHelper()
        {
        }
        public void SaveToString(List<string> lines)
        {
            FileStream fs = null;
            StreamWriter sw = null;

            try
            {
                fs = new FileStream(FileName, FileMode.Append, FileAccess.Write);
                //try for FileMode : Open, Create, Truncate, Append
                sw = new StreamWriter(fs);
                foreach (string l in lines)
                {
                    sw.WriteLine(l + "\n");
                }
            }
            catch (Exception)
            {
                //richTextBox1.A
                //   ("something went wrong, IOException was thrown");
            }
            finally
            {
                if (sw != null) sw.Close();
                if (fs != null) fs.Close();
            }



        }


        public List<string> LoadFromFile()
        {
            List<string> AllLines = new List<string>();
            FileStream fs = null;
            StreamReader sr = null;

            fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);
            sr = new StreamReader(fs);
            String s;
            s = sr.ReadLine();
            while (s != null)
            {
                AllLines.Add(s);
                s = sr.ReadLine();

            }
            return AllLines;


        }
    }
}
