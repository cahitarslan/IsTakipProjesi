using CahitYazilim.Todo.DTO.DTOs.AciliyetDtos;
using FluentValidation;

namespace CahitYazilim.Todo.Business.ValidationRules.FluentValidation
{
    public class AciliyetUpdateValidator : AbstractValidator<AciliyetUpdateDto>
    {
        public AciliyetUpdateValidator()
        {
            RuleFor(I => I.Tanim).NotNull().WithMessage("Tanım alanı boş bırakılamaz");
        }
    }
}
