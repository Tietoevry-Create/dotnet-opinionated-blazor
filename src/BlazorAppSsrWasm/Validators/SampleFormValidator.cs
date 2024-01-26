using BlazorAppSsrWasm.Models;
using FluentValidation;

namespace BlazorAppSsrWasm.Validators;

public class SampleFormValidator : AbstractValidator<SampleForm>
{
    public SampleFormValidator()
    {
        this.RuleFor(x => x.Email)
            .Cascade(CascadeMode.Stop)
            .NotEmpty()
            .WithMessage("E-mail is a required field.")
            .EmailAddress()
            .WithMessage("E-mail needs to be filled out correctly.");

        this.RuleFor(x => x.AcceptTermsForStoringContactDetails).Equal(true)
            .WithMessage("Terms & conditions needs to be accepted.");
    }
}
