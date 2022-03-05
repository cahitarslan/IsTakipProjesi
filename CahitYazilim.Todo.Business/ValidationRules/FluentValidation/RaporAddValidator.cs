using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using CahitYazilim.Todo.DTO.DTOs.RaporDtos;

namespace CahitYazilim.Todo.Business.ValidationRules.FluentValidation
{
    public class RaporAddValidator : AbstractValidator<RaporAddDto>
    {
        public RaporAddValidator()
        {
            RuleFor(I => I.Tanim).NotNull().WithMessage("Tanım alanı boş bırakılamaz");
            RuleFor(I => I.Detay).NotNull().WithMessage("Detay alanı boş bırakılamaz");
        }

    }
}
