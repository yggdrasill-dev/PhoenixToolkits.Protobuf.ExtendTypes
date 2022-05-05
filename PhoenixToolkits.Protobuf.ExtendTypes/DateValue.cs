namespace PhoenixToolkits.Protobuf.ExtendTypes;

public partial class DateValue
{
	public DateValue(int year, int month, int day)
	{
		Year = year;
		Month = month;
		Day = day;
	}

	public static DateValue FromDateOnly(DateOnly value)
	{
		return new DateValue(value.Year, value.Month, value.Day);
	}

	public static implicit operator DateValue(DateOnly value) => FromDateOnly(value);

	public static implicit operator DateOnly(DateValue value) => value?.ToDateOnly() ?? default;

	public static implicit operator DateOnly?(DateValue? value) => value?.ToDateOnly();

	public static implicit operator DateValue?(DateOnly? value) => value != null ? FromDateOnly(value.Value) : null;

	public DateOnly? ToDateOnly() => new(Year, Month, Day);
}
