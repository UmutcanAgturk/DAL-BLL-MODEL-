using BLL;
using MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvIlanKayit
{
    public partial class MainForm : Form
    {
        
        string aln;
        string katno;
        int ilanno;
        string odasay;
        int semtid;
        int ilanid;

        public MainForm(string Alan, string KatNo, int IlanNo, string OdaSayisi, int SemtId, int IlanId)
        {
            InitializeComponent();

            aln = Alan;
            katno = KatNo;
            ilanno = IlanNo;
            odasay = OdaSayisi;
            semtid = SemtId;
            ilanid = IlanId;

        }
        public MainForm()
        {
            InitializeComponent();
        }
       
        public MainForm(string semtad, int semtid)
        {
            InitializeComponent();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            try
            {
                IlanBL ilan = new IlanBL();
                MessageBox.Show(ilan.IlanEkle(new Ilan { Alan = txtAlan.Text, IlanNo = Convert.ToInt32(txtIlanNo.Text), KatNo = txtKatNo.Text, OdaSayisi = txtOdaSay.Text, SemtId = (int)cBSemt.SelectedValue }) ? "Ekleme Başarılı" : "Ekleme Başarısız");

            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);

            }
            catch (SqlException)
            {
                MessageBox.Show("Aynı İlan numarasında bir kayıt var");
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu");
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            txtId.Visible = false;

            SqlConnection cn = null;

            txtAlan.Text = aln;
            txtId.Text = ilanid.ToString();
            txtIlanNo.Text = ilanno.ToString();
            txtKatNo.Text = katno;
            txtOdaSay.Text = odasay;
            cBSemt.SelectedValue = semtid;

            if (txtAlan.Text == "")
            {
                btnGuncelle.Enabled = false;
                btnSil.Enabled = false;
            }
            else
            {
                btnSil.Enabled = true;
                btnGuncelle.Enabled = true;
            }

            try
            {
                using (cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cstr"].ConnectionString))
                {
                    if (cn != null)
                    {
                        cn.Open();
                    }
                    SqlCommand cmd = new SqlCommand($"Select SemtId,SemtAdi,Ilce from tblSemt",cn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    List<Semt> semtler = new List<Semt>();
                    while (dr.Read())
                    {
                        semtler.Add(new Semt{ SemtId = Convert.ToInt32(dr["SemtId"]), SemtAdi = dr["SemtAdi"].ToString(), Ilce = dr["Ilce"].ToString() });
                    }
                    dr.Close();
                    cBSemt.DisplayMember = "SemtAdi";
                    cBSemt.ValueMember = "SemtId";
                    cBSemt.DataSource = semtler;
                
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (cn != null && cn.State != ConnectionState.Closed)
                {
                    cn.Close();
                    cn.Dispose();
                }
            }
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            Ilan2 ilann = new Ilan2();
            ilann.Show();
            this.Hide();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (ilanid == Convert.ToInt32(txtId.Text))
            {
                try
                {
                    IlanBL ilan = new IlanBL();
                    MessageBox.Show(ilan.IlanGuncelle(new Ilan { Alan = txtAlan.Text, IlanNo = Convert.ToInt32(txtIlanNo.Text), KatNo = txtKatNo.Text, OdaSayisi = txtOdaSay.Text, SemtId = (int)cBSemt.SelectedValue, IlanId = Convert.ToInt32(txtId.Text) })? "Güncelleme Başarılı": "Güncelleme Başarısız");

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Lütfen doğru ilan numarası giriniz");
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                IlanBL ilan = new IlanBL();
                MessageBox.Show(ilan.IlanSil(Convert.ToInt32(txtId.Text)) ? "Silme İşlemi Başarılı": "Kayıt Bulunamadı");
                
            }
            catch (Exception)
            {
                throw;
            }

            
        }

        private void btnSemtEkle_Click(object sender, EventArgs e)
        {
            SemtForm smt = new SemtForm();
            smt.Show();
            this.Hide();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
