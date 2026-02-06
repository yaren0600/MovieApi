using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// CQRS yapısında kategori listeleme/sorgulama işlemleri sonucunda döndürülen veri modelidir.
/// Kategorinin Id ve ad bilgilerini taşır.
/// 
namespace MovieApi.Application.Features.CQRSDesignPattern.Results.CategoryResults
{
    public class GetCategoryQueryResult
    {
        public int CategoryId { get; set; }
        public int CategoryName { get; set; }
    }
}
