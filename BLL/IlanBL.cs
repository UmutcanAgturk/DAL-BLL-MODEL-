using DAL;
using MODEL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class IlanBL
    {
        public bool IlanEkle(Ilan il)
        {
            if (il == null)
            {
                throw new NullReferenceException("İlan Eklenirken Referans Null Geldi");
            }
            try
            {
                Helper hlp = new Helper();
                int sonuc = hlp.ExecuteNonQuery($"Insert Into tblIlan (IlanNo,OdaSayisi,KatNo,Alan,SemtId) values ({il.IlanNo},'{il.OdaSayisi}','{il.KatNo}','{il.Alan}',{il.SemtId})");
                return sonuc > 0;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool IlanGuncelle(Ilan il)
        {
            if (il == null)
            {
                throw new NullReferenceException("İlan Güncellenirken Referans Null Geldi");
            }
            try
            {
                Helper hlp = new Helper();
                int sonuc = hlp.ExecuteNonQuery($"Update tblIlan set IlanNo = {il.IlanNo}, OdaSayisi = '{il.OdaSayisi}', KatNo = '{il.KatNo}', Alan = '{il.Alan}', SemtId = {il.SemtId} Where IlanId = {il.IlanId}");
                return sonuc > 0;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool IlanSil(int id)
        {
            try
            {
                Helper hlp = new Helper();
                int sonuc = hlp.ExecuteNonQuery($"Delete From tblIlan where IlanId = {id}");
                return sonuc > 0;
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public Ilan IlanGetir(string numara)
        {
            Ilan il = null;
            Helper hlp = new Helper();
            SqlDataReader dr = hlp.ExecuteReader($"Select * From tblIlan where IlanNo = {numara}");
            if (dr.Read())
            {
                il = new Ilan();
                il.IlanId = Convert.ToInt32(dr["IlanId"]);
                il.SemtId = Convert.ToInt32(dr["SemtId"]);
                il.IlanNo = Convert.ToInt32(dr["IlanNo"]);
                il.KatNo = dr["KatNo"].ToString();
                il.OdaSayisi = dr["OdaSayisi"].ToString();
                il.Alan = dr["Alan"].ToString();
               
            }
            dr.Close();
            return il;
        }
    }
}
