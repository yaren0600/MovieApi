using MovieApi.Application.Features.CQRSDesignPattern.Commands.MovieCommands;
using MovieApi.Domain.Entities;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// CQRS yapısında yeni bir film oluşturma işlemini gerçekleştiren Command Handler'dır.
/// CreateMovieCommand ile gelen film bilgilerini alır, Movie entity'si oluşturur 
/// ve veritabanına kaydeder.

namespace MovieApi.Application.Features.CQRSDesignPattern.Handlers.MovieHandlers
{
    public class CreateMovieCommandHandler
    {
        private readonly MovieContext _context;

        public CreateMovieCommandHandler(MovieContext context)
        {
            _context = context;
        }
        public async void Handler(CreateMovieCommand command)
        {
            _context.Movies.Add(new Movie
            {
                CoverImageUrl = command.CoverImageUrl,
                CreatedYear = command.CreatedYear,
                Description = command.Description,
                Duration = command.Duration,
                Rating = command.Rating,
                RealseDate = command.RealseDate,
                Status = command.Status,
                Title = command.Title,

            });
            await _context.SaveChangesAsync();

        }
    }
}
