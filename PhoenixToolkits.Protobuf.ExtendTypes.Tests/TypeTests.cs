using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PhoenixToolkits.Protobuf.ExtendTypes.Tests;

[TestClass]
public class TypeTests
{
	[TestMethod]
	public void Decimal_Assign()
	{
		var expected = 12345.6789M;

		var value = (DecimalValue)expected;

		var actual = value.ToDecimal();

		Assert.AreEqual(expected, actual);
	}

	[TestMethod]
	public void Nullable_Decimal_Assign()
	{
		var value = (DecimalValue?)null;

		decimal? actual = value;

		Assert.IsNull(actual);
	}

	[TestMethod]
	public void Decimal_Serialize()
	{
		var expected = 12345.6789M;

		var actual = DecimalValue.FromDecimal(expected).ToDecimal();

		Assert.AreEqual(expected, actual);
	}

	[TestMethod]
	public void Guid_Assign()
	{
		var expected = Guid.NewGuid();

		var value = (GuidValue)expected;
		var actual = value.ToGuid();

		Assert.AreEqual(expected, actual);
	}

	[TestMethod]
	public void Nullable_Guid_Assign()
	{
		var value = (GuidValue?)null;

		Guid? actual = value;

		Assert.IsNull(actual);
	}

	[TestMethod]
	public void Guid_Serialize()
	{
		var expected = Guid.NewGuid();

		var actual = GuidValue.FromGuid(expected).ToGuid();

		Assert.AreEqual(expected, actual);
	}
}
