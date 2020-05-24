using Godot;
using System;

public class NullTest : WAT.Test
{
	public override String GetTitle()
	{
		return "Null Assertions";
	}
	
	[Test]
	public void WhenCallingNullIsNull()
	{
		Assert.IsNull(null, "Then it passes");
	}
	
	[Test]
	public void WhenCallingNodeIsNotNull()
	{
		Node N = new Node();
		Assert.IsNotNull(N, "Then it passes");
		N.Free();
	}
	
	[Test]
	public void WhenCallingFreedObjectIsNull()
	{
		// This doesn't work the same as in GDScript which would still
		// count this as an object
		Node N = new Node();
		N.Free();
		Assert.IsNull(N, "Then it passes");
	}
}
