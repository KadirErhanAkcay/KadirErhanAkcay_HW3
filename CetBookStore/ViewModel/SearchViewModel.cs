using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CetBookStore.ViewModel
{
    public class SearchViewModel
    {
        [Display(Name = "Arama Metni")]
        public string SearchText { get; set; }
        [Display(Name = "Açıklamalarda Ara")]
        public bool SearchInDescription { get; set; }
        [Display(Name = "Kategori Seçimi")]
        public int? CategoryId { get; set; }
        [Display(Name = "Minimum Fiyatı Girin")]
        public decimal? MinPrice { get; set; }
        [Display(Name = "Maksimum Fiyatı Girin")]
        public decimal? MaxPrice { get; set; }

        public List<Models.Book> Results { get; set; }
    }
}
