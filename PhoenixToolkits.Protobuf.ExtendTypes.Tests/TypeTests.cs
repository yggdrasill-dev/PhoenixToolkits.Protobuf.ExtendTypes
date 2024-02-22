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

	[TestMethod]
	public void DateOnly_Assign()
	{
		var expected = DateOnly.FromDateTime(DateTime.Now);

		var value = (DateValue)expected;
		var actual = value.ToDateOnly();

		Assert.AreEqual(expected, actual);
	}

	[TestMethod]
	public void Nullable_DateOnly_Assign()
	{
		var value = (DateValue?)null;

		DateOnly? actual = value;

		Assert.IsNull(actual);
	}

	[TestMethod]
	public void DateOnly_Serialize()
	{
		var expected = DateOnly.FromDateTime(DateTime.Now);

		var actual = DateValue.FromDateOnly(expected).ToDateOnly();

		Assert.AreEqual(expected, actual);
	}

	[TestMethod]
	public void TimeOnly_Assign()
	{
		var expected = TimeOnly.FromDateTime(DateTime.Now);

		var value = (TimeValue)expected;
		var actual = value.ToTimeOnly();

		Assert.AreEqual(expected, actual);
	}

	[TestMethod]
	public void Nullable_TimeOnly_Assign()
	{
		var value = (TimeValue?)null;

		TimeOnly? actual = value;

		Assert.IsNull(actual);
	}

	[TestMethod]
	public void TimeOnly_Serialize()
	{
		var expected = TimeOnly.FromDateTime(DateTime.Now);

		var actual = TimeValue.FromTimeOnly(expected).ToTimeOnly();

		Assert.AreEqual(expected, actual);
	}
}
