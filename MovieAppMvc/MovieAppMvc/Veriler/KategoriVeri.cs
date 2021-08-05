using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieAppMvc.Models;

namespace MovieAppMvc.Veriler
{
    public class KategoriVeri
    {
        private static List<Kategori> _kategoris = null;
        static KategoriVeri()
        {
            _kategoris = new List<Kategori>()
            {
                new Kategori(){Id=1,KategoriTürü="Bilim Kurgu"},
                new Kategori(){Id=2,KategoriTürü="Macera"},
                new Kategori(){Id=3,KategoriTürü="Savaş"},
                new Kategori(){Id=4,KategoriTürü="Korku"},
                new Kategori(){Id=5,KategoriTürü="Gerilim"},
                new Kategori(){Id=6,KategoriTürü="Komedi"},
                new Kategori(){Id=7,KategoriTürü="Animasyon"},
                new Kategori(){Id=8,KategoriTürü="Romantik"},
                new Kategori(){Id=9,KategoriTürü="Aile"},
                new Kategori(){Id=10,KategoriTürü="Aksiyon"}
            };
        }

        public static List<Kategori> Kategoris
        {
            get
            {
                return _kategoris;
            }
        }

        public static void KategoriEkle(Kategori yenifilm)
        {
            _kategoris.Add(yenifilm);
        }

        public static Kategori GetById(int id)
        {
            return _kategoris.FirstOrDefault(i => i.Id == id);
        }
    }

}
