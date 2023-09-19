using Final.Application.Common.Interfaces;

namespace Final.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
