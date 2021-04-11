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
    public partial class Notepad : Form
    {
        public Notepad()
        {
            InitializeComponent();
            rtbText.Focus();
        }
        File file = new File(); // iqmneba File klasis obieqti
        Edit edit = new Edit(); // iqmneba Edit klasis obieqti
        AdvanceWord advanceWord = new AdvanceWord();//iqmneba AdvanceWord klasis obieqti
        public  string TextboxText { get; private set; } // eqsesori romelic inaxavs textboxshi akrefil texts
        private void btnClose_Click(object sender, EventArgs e) // aplikaciis daxurvis punqcia
        {

            if (rtbText.Text != "") // daxurvis dros tu texboxi carielia egreve daxuravs , tu ara da shegvekitxeba shvinaxot tu ara
            {
                DialogResult dialog = MessageBox.Show("Do you want to save?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    btnSaveAs_Click(sender, e);
                }
            }
            this.Close();
        }
        private void btnMaximase_Click(object sender, EventArgs e) // panjris maximase  punkcia
        {
            if (WindowState == FormWindowState.Maximized)//tu panjris zoma aris gadidebuli mashin maiximase gilakze dacheris dros zoma gaxdeba normal zomis.
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Maximized;// tu ara da zoma gaxdema maximasirebuli
            }
        }

        private void btnMinimase_Click(object sender, EventArgs e) // chakecvis punqcia
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMenu_Click_1(object sender, EventArgs e) // menius punqcia
        {
            if(pnlMenu.Width <= 40)//tu menius panelis zoma < an = 40-is mashin chairtoba timeMenuSlider punqcia tu ara da menius panelis zoma gaxdeba 40 piqseli
            {
                timeMenuSlider.Enabled = true;
            }
            else
            {
                pnlMenu.Width = 40;
                rtbText.Focus();
                rtbText.SelectionStart = rtbText.Text.Length;
            }
        }

        private void timeMenuSlider_Tick(object sender, EventArgs e) // menius slaideris punqcia
        {
            if (pnlMenu.Width < 205)
            {
                pnlMenu.Width += 16;
            }
            else
            {
                timeMenuSlider.Enabled = false;
            }
        }

        private void pnlDrag_DoubleClick(object sender, EventArgs e)// dgag panelis ormagi daqliqebis punqcia
        {
            btnMaximase_Click(sender, e);//idzaxebs maximase punqcias
        }

        private void btnSearch_Click(object sender, EventArgs e) //serchze daqliqebis punqcia
        {
            if (pnlSearch.Width <= 40)
            {
                timeSearchSlider.Enabled = true;
                txtSearch.Focus();
            }
            else
            {
                pnlSearch.Width = 40;
                rtbText.Focus();
            }
            
        }

        private void timeSearchSlider_Tick(object sender, EventArgs e)//serchis slideris punqcia
        {
            if (pnlSearch.Width == 240)//tu dzebnis paneli gaixsneba bolomde mashin gamoirtoba timer punqcia
            {
                timeSearchSlider.Enabled = false;
            }
            else
            {
                pnlSearch.Width += 20;//tu ara da dzebnis panelis sigane moimatebs , am shemtxvevashi wamis meatasedshi 20 piqselit
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)//failis gaxsnis dakliqebis punqcia
        {
            OpenFileDialog open = new OpenFileDialog();//diloguri panjaris obieqtis sheqmna
            open.Filter = "TXT|*.txt";//failis formatis filtracia, rom gvicenos mxolod txt faili
            if (open.ShowDialog() == DialogResult.OK)//dialoguri panjaris gamodzaxeba
            {
                rtbText.Text = file.Open(open.FileName);//filedan textis amokitxvis punqcia
                rtbText.SelectionStart = rtbText.Text.Length;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)//textboxshi textis cvlilebis metodi
        {
            Word.Search(rtbText, txtSearch.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)//shenaxvis daqliqebis metodi
        {

            if (file.Save(rtbText.Text))//tu textboxi carieli ar aris failshi chaiwereba texti da sheinaxeba
            {
                lblResult.Text = "Saved";
            }
            else
            {
                lblResult.Text = "Textbox is empty";
            }
        }

        private void rTxtText_TextChanged(object sender, EventArgs e)//textboxis textis cvlilebis punqcia
        {
            lblResult.Text = null;
            TextboxText = rtbText.Text;
            advanceWord.StartCount(TextboxText);


        }
        private void btnSaveAs_Click(object sender, EventArgs e)//save es ze dakliqebis punqcia
        {
            var save = new SaveFileDialog();
            save.Filter = "TXT|*.txt";
            if (save.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(save.FileName, rtbText.Text);
            }
            else
            {
                
                MessageBox.Show("This texd was descarded","Warning", MessageBoxButtons.OK);
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)//kopirebis qliqis punqcia
        {
            edit.Copy(rtbText);
        }

        private void btnCounter_Click(object sender, EventArgs e)//counter qliqis punqcia
        {
            advanceWord.Show();//idzaaxebs meore formas "advanceWord"
            advanceWord.StartCount(TextboxText);
        }

        private void btnCut_Click(object sender, EventArgs e)//amochris daqliqebis punqcia
        {
            edit.Cut(rtbText);//amochris punqcias parametrad vawvdit string amosachrel sityvas
        }

        private void btnPaste_Click(object sender, EventArgs e)//chasmis gilakze daqliqebis punqcia
        {
            rtbText.Text = edit.Paste(rtbText.SelectionStart, rtbText.Text);// chasmis punqcias parametrad vawvdit int tipis sawyis indeqss da string tipis texts
        }

        private void rTxtText_Click(object sender, EventArgs e)// textboxsze fdaqliqebis punqcia
        {
            pnlMenu.Width = 40;//im shemtxvevashi tu menus paneneli gaxsnilia , mashin textboqsze daqliqebis dros menius paneli daixureba
        }

        private void btnNew_Click(object sender, EventArgs e)// axali teqstis kaketebis gilakze daqliqebis punqcia
        {
            if (rtbText.Text != "") // tu textboxi carieli ar aris gvtavazobs shvinaxot tu ara
            {
                DialogResult dialog = MessageBox.Show("Do you want to save?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    btnSaveAs_Click(sender, e);
                }
            }
            rtbText.Text = null;
            rtbText.Focus();
        }

        private void rtbText_Enter(object sender, EventArgs e)
        {
            pnlMenu.Width = 40;// roca textboqshi texti shemova text filidan, mashin menius paneli daixuraba
        }
    }
}
