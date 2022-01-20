using BLL;
using MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvIlanKayit
{
    public partial class Ilan2 : Form
    {
        string aln;
        string katno;
        int ilanno;
        string odasay;
        int semtid;
        int ilanid;
        
        public Ilan2()
        {
            InitializeComponent();
            
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            IlanBL bl = new IlanBL();
            Ilan il = bl.IlanGetir(txtBul.Text);
            if (il == null)
            {
                MessageBox.Show("Kayıt Bulunamadı");
            }
            else if(Convert.ToInt32(txtBul.Text) == il.IlanNo)
            {
                    aln = il.Alan;
                    katno = il.KatNo;
                    ilanno = il.IlanNo;
                    odasay = il.OdaSayisi;
                    semtid = il.SemtId;
                    ilanid = il.IlanId;
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen Doğru ilan Kodunu Giriniz");
            }
        }

        private void Ilan2_FormClosing(object sender, FormClosingEventArgs e)
        {
         
                MainForm main = new MainForm(aln, katno, ilanno, odasay, semtid, ilanid);
                main.Show();

        }
    }
}
