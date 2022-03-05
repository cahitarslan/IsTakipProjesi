using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using CahitYazilim.Todo.DTO.DTOs.AppUserDtos;

namespace CahitYazilim.Todo.Business.ValidationRules.FluentValidation
{
    public class AppUserSignInValidator : AbstractValidator<AppUserSignInDto>
    {
        public AppUserSignInValidator()
        {
            RuleFor(I => I.UserName).NotNull().WithMessage("Kullanıcı adı boş bırakılamaz");
            RuleFor(I => I.Password).NotNull().WithMessage("Şifre alanı boş bırakılamaz");
        }
    }
}
