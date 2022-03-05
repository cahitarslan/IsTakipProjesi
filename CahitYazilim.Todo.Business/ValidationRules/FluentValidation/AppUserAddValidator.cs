using CahitYazilim.Todo.DTO.DTOs.AppUserDtos;
using FluentValidation;

namespace CahitYazilim.Todo.Business.ValidationRules.FluentValidation
{
    public class AppUserAddValidator : AbstractValidator<AppUserAddDto>
    {
        public AppUserAddValidator()
        {
            RuleFor(I => I.UserName).NotNull().WithMessage("Kullanıcı Adı boş bırakılamaz");

            RuleFor(I => I.Password).NotNull().WithMessage("Parola alanı boş bırakılamaz");

            RuleFor(I => I.ConfirmPassword).NotNull().WithMessage("Parola onay alanı boş bırakılamaz");

            RuleFor(I => I.ConfirmPassword).Equal(I => I.Password).WithMessage("Parolalarınız eşleşmiyor");

            RuleFor(I => I.Email).NotNull().WithMessage("Email alanı boş bırakılamaz").EmailAddress().WithMessage("Geçersiz email adresi");

            RuleFor(I => I.Name).NotNull().WithMessage("Ad alanı boş bırakılamaz");

            RuleFor(I => I.Surname).NotNull().WithMessage("Soyad alanı boş bırakılamaz");
        }
    }
}
