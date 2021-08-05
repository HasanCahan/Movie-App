using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MovieAppMvc.Models
{
    public class Film
    {
        public int Id { get; set;}

        [Required(ErrorMessage = "Film adı alanı boş bırakılamaz!")]
        [StringLength(50, ErrorMessage = "Film adı 50 karakterden uzun olamaz!")]
        public string FilmAdı { get; set; }

        [Required(ErrorMessage = "Açıklama alanı boş bırakılamaz!")]
        public string Açıklama { get; set; }
        public string Yönetmen { get; set; }
        public string Oyuncular { get; set; }

        [Required(ErrorMessage = "Görsel alanı boş bırakılamaz!")]
        public string ImageUrl { get; set; }
        public int KategoriId { get; set; }


    }
}
