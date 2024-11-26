using FluentValidation;
using FluentValidation.Results;

namespace BlazorApp.Models;

public class SampleForm
{
    public static readonly InlineValidator<SampleForm> Validator = new()
    {
        v => v.RuleFor(x => x.Email)
            .Cascade(CascadeMode.Stop)
            .NotEmpty()
            .WithMessage("E-mail is a required field.")
            .EmailAddress()
            .WithMessage("E-mail needs to be filled out correctly."),

        v => v.RuleFor(x => x.AcceptTermsForStoringContactDetails).Equal(true)
        .WithMessage("Terms & conditions needs to be accepted."),
    };

    public string? Email { get; set; }

    public bool AcceptTermsForStoringContactDetails { get; set; }

    public ValidationResult Validate()
    {
        return Validator.Validate(this);
    }
}
