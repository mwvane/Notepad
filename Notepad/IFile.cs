using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notepad
{
    interface IFile
    {
        string Text { get; }
        string Open(string path);
        bool Save(string tesxt);
    }
}
