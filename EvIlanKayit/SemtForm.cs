using BLL;
using MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvIlanKayit
{
    public partial class SemtForm : Form
    {
        public SemtForm()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtSemtAd.Text == "" || txtIlce.Text == "")
            {
                MessageBox.Show("Lütfen Boşluları Doldurunuz");
            }
            else
            {
                try
                {
                    SemtBl ilan = new SemtBl();
                    MessageBox.Show(ilan.SemtEkle(new Semt { SemtAdi = txtSemtAd.Text, Ilce = txtIlce.Text }) ? "Ekleme Başarılı" : "Ekleme Başarısız");
                    this.Close();
                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show(ex.Message);

                }
                catch (SqlException)
                {
                    MessageBox.Show("Veritabanı Hatası");
                }
                catch (Exception)
                {

                    MessageBox.Show("Hata Oluştu");
                }
            }

        }

        private void SemtForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
        }
    }
}
