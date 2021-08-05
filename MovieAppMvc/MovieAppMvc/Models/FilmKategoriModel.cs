using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace MovieAppMvc.Models
{
    public class FilmKategoriModel
    {
        public Film Film { get; set; }
        public IEnumerable<Film> Films { get; set; }
        public IEnumerable<Kategori> Kategoris { get; set; }

    }
}
