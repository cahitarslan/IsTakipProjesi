using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using CahitYazilim.Todo.DTO.DTOs.GorevDtos;

namespace CahitYazilim.Todo.Business.ValidationRules.FluentValidation
{
    public class GorevUpdateValidator : AbstractValidator<GorevUpdateDto>
    {
        public GorevUpdateValidator()
        {
            RuleFor(I => I.Ad).NotNull().WithMessage("Ad alanı gereklidir");
            RuleFor(I => I.AciliyetId).ExclusiveBetween(0, int.MaxValue).WithMessage("Lütfen bir aciliyet durumu seçiniz");
        }
    }
}
