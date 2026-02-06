using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// CQRS yapısında mevcut bir kategoriyi güncelleme isteğini temsil eden Command sınıfıdır.
/// Güncellenecek kategorinin Id ve yeni kategori adını Handler'a taşır.

namespace MovieApi.Application.Features.CQRSDesignPattern.Commands.CategoryCommands
{
    public class UpdateCategoryCommand
    {
        public int CategoryId { get; set; }
        public int CategoryName { get; set; }
    }
}
