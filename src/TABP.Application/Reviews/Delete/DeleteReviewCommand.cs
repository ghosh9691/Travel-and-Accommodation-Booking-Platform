﻿using MediatR;

namespace TABP.Application.Reviews.Delete;

public class DeleteReviewCommand : IRequest
{
  public Guid GuestId { get; init; }
  public Guid HotelId { get; init; }
  public Guid ReviewId { get; init; }
}