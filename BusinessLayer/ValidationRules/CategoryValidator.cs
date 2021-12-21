using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator: AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryDescription).NotEmpty()
             .WithMessage("Kategori açıklama alanını boş bırakmayınız");

            RuleFor(x => x.CategoryName).NotEmpty()
                .WithMessage("Kategori adı alanını boş bırakmayınız")
                .MinimumLength(2).WithMessage("Kategori adı alanı en az 2 karakter olmalıdır");


        }
    }
}
