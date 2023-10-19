

using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Jazani.Infrastructure.Cores.Converters
{
    public class DateTimeToDateTimeOffset : ValueConverter<DateTime, DateTimeOffset>
    {
        public DateTimeToDateTimeOffset() : base
            (
             dateTime => DateTimeOffset.UtcNow,
             dateTimeOffSet => dateTimeOffSet.DateTime
            )
        { }
    }
}
