using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Notepad
{
    interface IEdit // interfeisi romlitac vaidzuleb Edit klass rom implementacia gauketos chamotvlil punqciebs
    {
        string CopiedText { get; }
        void Copy(RichTextBox text);
        string Paste(int index, string text);
        void Cut(RichTextBox text);
    }
}
