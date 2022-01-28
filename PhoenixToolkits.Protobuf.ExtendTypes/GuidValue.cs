using Google.Protobuf;

namespace PhoenixToolkits.Protobuf.ExtendTypes;

public partial class GuidValue
{
	public GuidValue(Guid guid)
	{
		Value = ByteString.CopyFrom(guid.ToByteArray());
	}

	public static GuidValue FromGuid(Guid guid)
	{
		var result = new GuidValue
		{
			Value = ByteString.CopyFrom(guid.ToByteArray())
		};

		return result;
	}

	public static implicit operator Guid?(GuidValue? guidValue) => guidValue?.ToGuid();

	public static implicit operator Guid(GuidValue? guidValue) => guidValue?.ToGuid() ?? default;

	public static implicit operator GuidValue(Guid guid) => FromGuid(guid);

	public static implicit operator GuidValue?(Guid? guid) => guid != null ? FromGuid(guid.Value) : null;

	public Guid ToGuid()
	{
		return new Guid(Value.ToByteArray());
	}
}
