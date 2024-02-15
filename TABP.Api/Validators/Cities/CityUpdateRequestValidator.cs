﻿using FluentValidation;
using TABP.Api.Dtos.Cities;
using TABP.Application.Extensions.Validation;

namespace TABP.Api.Validators.Cities;

public class CityUpdateRequestValidator : AbstractValidator<CityUpdateRequest>
{
  public CityUpdateRequestValidator()
  {
    RuleFor(c => c.Name)
      .NotEmpty()
      .ValidName(3, 30);

    RuleFor(c => c.Country)
      .NotEmpty()
      .ValidName(3, 30);

    RuleFor(c => c.PostOffice)
      .NotEmpty()
      .ValidNumericString(5);
  }
}