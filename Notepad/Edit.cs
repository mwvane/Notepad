using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    class Edit : IEdit
    {
        public string CopiedText { get; private set; } // inaxavs dakopirebul texts
        public void Copy(RichTextBox text) // dakopirebis punqcia
        {
            if(text.SelectedText != "")
            {
                this.CopiedText = text.SelectedText;
            }
        }

        public void Cut(RichTextBox text) // amochris punqcia
        {
            if(text.SelectedText != "")
            {
                this.CopiedText = text.SelectedText;
                text.SelectedText = "";
            }
        }

        public string Paste(int index, string text) // Paste punqcia
        {
            string temp = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (i == index)
                {
                    for (int j = 0; j < this.CopiedText.Length; j++)
                    {
                        temp += this.CopiedText[j];
                    }
                }
                temp += text[i];
            }
            return temp;
        }
    }
}
