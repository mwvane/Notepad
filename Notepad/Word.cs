using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Notepad
{
    static class Word
    {
        static public int WordCount(string text) // itvlis textshi arsebul sityvebis raodenobas
        {
            int wordCounter = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ' || text[i] == '\r' || text[i] == '\n')
                {
                    continue;
                }
                wordCounter++;
                while (true)
                {
                    if (i == text.Length)
                    {
                        break;
                    }
                    if (text[i] != ' ')
                    {
                        if (text[i] == '\r' || text[i] == '\n')
                        {
                            break;
                        }
                        i++;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return wordCounter;
        }

        static public int NumberCount(string text) // itvlis textshi arsebul ricxvebis raodenobas
        {
            int numberCounter = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if ((int)text[i] >= (int)'0' && (int)text[i] <= (int)'9')
                {
                    numberCounter++;
                }
            }
            return numberCounter;
        }
        static public int LineCount(string text) //itvlis textshi arsebul xazebis raodenobas
        {
            int counter = 1;
            if (text == "")
            {
                counter = 0;
            }
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '\n')
                {
                    counter++;
                }
            }
            return counter;
        }

        static public int SymbolCount(string text) // itvlis textshi arsebul yvela simbolos raodenobas raodenobas
        {
            int counter = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != ' ' && text[i] != '\r' && text[i] != '\n') 
                {
                    counter++;
                }
            }
            return counter;
        }

        static public void Search(RichTextBox text, string word) // dzebnis punqcia
        {
            text.SelectAll();
            text.SelectionColor = text.ForeColor;
            int start = 0;
            int end = text.Text.LastIndexOf(word);
            while (start <= end && word != "")
            {
                text.Find(word, start, text.Text.Length, RichTextBoxFinds.MatchCase);
                text.SelectionColor = Color.Orange;
                start = text.Text.IndexOf(word, start) + 1;
            }
        }
    }
}
