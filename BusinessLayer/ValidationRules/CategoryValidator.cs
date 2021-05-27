﻿using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori adı boş geçilemez");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("açıklama boş geçilemez");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("lütfen en az 3 karakter girişi yapınız");
            RuleFor(x => x.CategoryName).MaximumLength(20).WithMessage("lütfen en fazla 20 karakter giriniz");

        }
    }
}
