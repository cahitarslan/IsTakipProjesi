﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using CahitYazilim.Todo.DTO.DTOs.RaporDtos;

namespace CahitYazilim.Todo.Business.ValidationRules.FluentValidation
{
    public class RaporUpdateValidator : AbstractValidator<RaporUpdateDto>
    {
        public RaporUpdateValidator()
        {
            RuleFor(I => I.Tanim).NotNull().WithMessage("Tanım alanı boş bırakılamaz");
            RuleFor(I => I.Detay).NotNull().WithMessage("Detay alanı boş bırakılamaz");
        }
    }
}
