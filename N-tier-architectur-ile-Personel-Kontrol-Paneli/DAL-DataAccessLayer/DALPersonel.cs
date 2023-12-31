﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayerr;
using System.Data.SqlClient;//
using System.Data;//if şartındaki connectionstate yi kullanabilmek için

namespace DAL_DataAccessLayer
{
    public class DALPersonel//public yapmayı unutma!!
    {
        public static List<EntityPersonel> PersonelListesi()
        {
            List<EntityPersonel> degerler = new List<EntityPersonel>();
            SqlCommand komut = new SqlCommand("select * from TBLBILGI", Baglantı.bgl);
            //STATİC TANIMLAMA YAPTIGIMIZ İÇİN YENİDEN BIR NESNE OLUŞTURMAK ZORUNDA KALMADIK YANİ ŞUNU YAZMAMIZA GEREK KALMADI
            //Baglantı bgl = new Baglantı()
            if (komut.Connection.State!=ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityPersonel ent = new EntityPersonel();
                ent.Id = int.Parse(dr["ID"].ToString());
                ent.Ad = dr["AD"].ToString();
                ent.Soyad = dr["SOYAD"].ToString();
                ent.Sehir = dr["SEHIR"].ToString();
                ent.Gorev = dr["GOREV"].ToString();
                ent.Ad = dr["AD"].ToString();
                ent.Maas = short.Parse(dr["MAAS"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        } 
        public static int PersonelEkle(EntityPersonel p)
        {
            SqlCommand komut2 = new SqlCommand("insert into TBLBILGI (AD,SOYAD,GOREV,SEHIR,MAAS) VALUES (@P1,@P2,@P3,@P4,@P5)", Baglantı.bgl);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            komut2.Parameters.AddWithValue("@P1",p.Ad);
            komut2.Parameters.AddWithValue("@P2", p.Soyad);
            komut2.Parameters.AddWithValue("@P3", p.Gorev);
            komut2.Parameters.AddWithValue("@P4", p.Sehir);
            komut2.Parameters.AddWithValue("@P5", p.Maas);
            return komut2.ExecuteNonQuery();
        }
        public static bool PersonelSil(int p)
        {
            SqlCommand komut3 = new SqlCommand("DELETE FROM TBLBILGI WHERE ID=@P1", Baglantı.bgl);
            if (komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@P1", p);
            return komut3.ExecuteNonQuery() > 0; //bool tanımladığımız için >0; dedik
        }
        public static bool PersonelGuncelle(EntityPersonel ent)
        {
            SqlCommand komut4 = new SqlCommand("UPDATE TBLBILGI SET AD=@P1,SOYAD=@P2,MAAS=@P3,SEHIR=@P4,GOREV=@P5 WHERE ID=@P6",Baglantı.bgl);
            if (komut4.Connection.State != ConnectionState.Open)
            {
                komut4.Connection.Open();
            }
            komut4.Parameters.AddWithValue("@P1", ent.Ad);
            komut4.Parameters.AddWithValue("@P2", ent.Soyad);
            komut4.Parameters.AddWithValue("@P3", ent.Maas);
            komut4.Parameters.AddWithValue("@P4", ent.Sehir);
            komut4.Parameters.AddWithValue("@P5", ent.Gorev);
            komut4.Parameters.AddWithValue("@P6", ent.Id);
            return komut4.ExecuteNonQuery() > 0;
        }

    }


}
