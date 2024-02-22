namespace PhoenixToolkits.Protobuf.ExtendTypes;

public partial class TimeValue
{
	public TimeValue(long ticks)
	{
		Ticks = ticks;
	}

	public static TimeValue FromTimeOnly(TimeOnly value) => new(value.Ticks);

	public static implicit operator TimeValue(TimeOnly value) => FromTimeOnly(value);

	public static implicit operator TimeOnly(TimeValue value) => value?.ToTimeOnly() ?? default;

	public static implicit operator TimeOnly?(TimeValue? value) => value?.ToTimeOnly();

	public static implicit operator TimeValue?(TimeOnly? value) => value != null ? FromTimeOnly(value.Value) : null;

	public TimeOnly? ToTimeOnly() => new(Ticks);
}
