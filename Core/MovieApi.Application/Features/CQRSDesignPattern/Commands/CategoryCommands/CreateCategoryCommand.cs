using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// CQRS yapısında yeni bir kategori oluşturma isteğini temsil eden Command sınıfıdır.
/// Handler'a gönderilecek kategori bilgilerini taşır.
/// 
namespace MovieApi.Application.Features.CQRSDesignPattern.Commands.CategoryCommands
{
    public class CreateCategoryCommand
    {
        public int CategoryName { get; set; }
    }
}
