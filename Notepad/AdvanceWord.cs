using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class AdvanceWord : Form
    {
        public AdvanceWord()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e) // aplikaciis daxurvis punqcia
        {
            this.Hide();
        }

        private void btnMinimase_Click(object sender, EventArgs e) // chakecvis punqcia
        {
            WindowState = FormWindowState.Minimized;
        }
        public void StartCount(string text) 
        {
            if (text != null)
            {
                lblLineCounter.Text = Word.LineCount(text).ToString(); // idaxebs xazebis datvlis punqcias da parametrad awvdis texts
                lblWordCounter.Text = Word.WordCount(text).ToString(); //idaxebs  sityvebis datvlis punqcias da parametrad awvdis texts
                lblNumberCounter.Text = Word.NumberCount(text).ToString(); // idaxebs  ciprebis datvlis punqcias da parametrad awvdis texts
                lblSymbolCOunter.Text = Word.SymbolCount(text).ToString(); // idaxebs  simboloebis datvlis punqcias da parametrad awvdis texts
            }
        }
    }
}
