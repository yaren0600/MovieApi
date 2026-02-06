using MovieApi.Application.Features.CQRSDesignPattern.Commands.CategoryCommands;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Kategori id'sine göre silme işlemini gerçekleştirir ve veri tabanına kaydeder

namespace MovieApi.Application.Features.CQRSDesignPattern.Handlers.CategoryHandlers
{
    public class RemoveCategoryCommandHandler
    {
        private readonly MovieContext _context;
        public RemoveCategoryCommandHandler(MovieContext context)
        {
            _context = context;
        }
        public async void Handler(RemoveCategoryCommand command)
        {
            var value=await _context.Movies.FindAsync(command.CategoryId);
            _context.Movies.Remove(value);
            await _context.SaveChangesAsync();
        }
    }
}
