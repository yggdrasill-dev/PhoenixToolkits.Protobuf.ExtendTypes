using System;
using Google.Protobuf;

namespace PhoenixToolkits.Protobuf.ExtendTypes
{
	public partial class GuidValue
	{
		public GuidValue(Guid guid)
		{
			Value = ByteString.CopyFrom(guid.ToByteArray());
		}

		public static GuidValue FromGuid(Guid guid)
		{
			var result = new GuidValue();
			result.Value = ByteString.CopyFrom(guid.ToByteArray());

			return result;
		}

		public static implicit operator Guid(GuidValue guidValue) => guidValue.ToGuid();

		public static implicit operator GuidValue(Guid guid) => FromGuid(guid);

		public Guid ToGuid()
		{
			return new Guid(Value.ToByteArray());
		}
	}
}
