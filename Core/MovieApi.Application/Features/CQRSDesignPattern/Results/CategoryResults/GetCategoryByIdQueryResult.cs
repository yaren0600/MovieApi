using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// CQRS yapısında Id bilgisine göre getirilen kategori sorgusunun sonucunu temsil eder.
/// Kategorinin Id ve ad bilgilerini taşır.
/// 
namespace MovieApi.Application.Features.CQRSDesignPattern.Results.CategoryResults
{
    public class GetCategoryByIdQueryResult
    {
        public int CategoryId { get; set; }
        public int CategoryName { get; set; }
    }
}
