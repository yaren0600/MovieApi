using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// CQRS yapısında Id bilgisine göre kategori getirme isteğini temsil eden Query sınıfıdır.
/// Getirilecek kategorinin Id bilgisini Handler'a taşır.

namespace MovieApi.Application.Features.CQRSDesignPattern.Queries.CategoryQueries
{
    public class GetCategoryByIdQuery
    {
        public int CategoryId { get; set; }
    }
}
