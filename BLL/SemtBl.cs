using DAL;
using MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SemtBl
    {
        public bool SemtEkle(Semt sm)
        {
            if (sm == null)
            {
                throw new NullReferenceException("İlan Eklenirken Referans Null Geldi");
            }
            try
            {
                Helper hlp = new Helper();
                int sonuc = hlp.ExecuteNonQuery($"Insert Into tblSemt (SemtAdi,Ilce) values ('{sm.SemtAdi}','{sm.Ilce}')");
                return sonuc > 0;
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
