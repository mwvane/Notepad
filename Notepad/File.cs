using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Notepad
{
    class File : IFile
    {
        public string Text { get; private set; }
        public int SaveIndex { get; private set; }//inaxavs shesanaxi failebis indeqsebs  unikalurobistvis
        public string SaveIndexPath { get; } // ineqsebis misamarti
        public File() // uparametro konstruqtori
        {
            this.SaveIndexPath = "SaveIndex.txt"; //shenaxvis indeqsaciis misamarti
            if (System.IO.File.Exists(this.SaveIndexPath))
            {
                FileStream file = new FileStream(this.SaveIndexPath, FileMode.OpenOrCreate);
                BinaryReader read = new BinaryReader(file);
                this.SaveIndex = read.ReadInt32();
                read.Close();
            }
        }
        public string Open(string path) // failis gaxsnis metodi
        {
            FileStream file = new FileStream(path, FileMode.Open);
            StreamReader sr = new StreamReader(file);
            string text = sr.ReadToEnd();
            sr.Close();
            return text;
        }

        public bool Save(string text)// textis shenaxvis metodi
        {
            if (text.Length == 0)
            {
                return false;
            }

            try
            {
                this.SaveIndex++;
                string pcName = Environment.UserName;
                StreamWriter sw = new StreamWriter(new FileStream($"C:\\Users\\{pcName}\\Desktop\\text{this.SaveIndex}.txt", FileMode.Create));
                sw.Write(text);
                sw.Close();
                BinaryWriter write = new BinaryWriter(new FileStream(this.SaveIndexPath, FileMode.Create));
                write.Write(this.SaveIndex);
                write.Close();
                return true;
            }
            catch
            {
                this.SaveIndex--;
                return false;
            }

        }
    }
}
