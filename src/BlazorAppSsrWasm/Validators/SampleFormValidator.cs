using BlazorAppSsrWasm.Models;
using FluentValidation;

namespace BlazorAppSsrWasm.Validators;

public class SampleFormValidator : AbstractValidator<SampleForm>
{
    public SampleFormValidator()
    {
        this.RuleFor(x => x.Email).NotEmpty()
            .WithMessage("E-mail is a required field.");

        this.RuleFor(x => x.AcceptTermsForStoringContactDetails).Equal(true)
            .WithMessage("Terms needs to be accepted.");
    }
}
