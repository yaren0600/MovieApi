using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// CQRS yapısında Id bilgisine göre film getirme isteğini temsil eden Query sınıfıdır.
/// Getirilecek filmin Id bilgisini Handler'a taşır.

namespace MovieApi.Application.Features.CQRSDesignPattern.Queries.MovieQueries
{
    public class GetMovieByIdQuery
    {
        public int MovieId { get; set; }

    }
}
