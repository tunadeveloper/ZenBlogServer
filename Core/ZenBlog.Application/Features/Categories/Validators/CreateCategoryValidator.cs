using FluentValidation;
using ZenBlog.Application.Features.Categories.Commands;

namespace ZenBlog.Application.Features.Categories.Validators;

public class CreateCategoryValidator : AbstractValidator<CreateCategoryCommand>
{
    public CreateCategoryValidator()
    {
        RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori Adı Boş Geçilmez!");
    }
}