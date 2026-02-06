using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// CQRS yapısında bir kategoriyi silme isteğini temsil eden Command sınıfıdır.
/// Silinecek kategorinin Id bilgisini Handler'a taşır.
/// 
namespace MovieApi.Application.Features.CQRSDesignPattern.Commands.CategoryCommands
{
    public class RemoveCategoryCommand
    {
        public int CategoryId { get; set; }


    }
}
