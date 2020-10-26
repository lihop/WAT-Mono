using Godot;
using System;

public class IsNotInstanceTest : WAT.Test
{
	public override String Title()
	{
		return "IsNotInstanceTest";
	}
	
	[Test]
	public void IsNotAABB()
	{
		Assert.IsNotAABB(null);
	}
	
	[Test]
	public void IsNotArray()
	{
		Assert.IsNotArray(null);
	}
	
	[Test]
	public void IsNotBasis()
	{
		Assert.IsNotBasis(null);
	}
	
	[Test]
	public void IsNotBool()
	{
		Assert.IsNotBool(null);
	}
	
	[Test]
	public void IsNotColor()
	{
		Assert.IsNotColor(null);
	}
	
	[Test]
	public void IsNotDictionary()
	{
		Assert.IsNotDictionary(null);
	}
	
	[Test]
	public void IsNotFloat()
	{
		Assert.IsNotFloat(null);
	}
	
	[Test]
	public void IsNotInt()
	{
		Assert.IsNotInt(null);
	}
	
	[Test]
	public void IsNotNodePath()
	{
		Assert.IsNotNodePath(null);
	}
	
	[Test]
	public void IsNotObject()
	{
		Assert.IsNotObject(null);
	}
	
	[Test]
	public void IsNotPlane()
	{
		Assert.IsNotPlane(null);
	}
	
	[Test]
	public void IsNotQuat()
	{
		Assert.IsNotQuat(null);
	}
	
	[Test]
	public void IsNotRect2()
	{
		Assert.IsNotRect2(null);
	}
	
	[Test]
	public void IsNotRID()
	{
		Assert.IsNotRID(null);
	}
	
	[Test]
	public void IsNotString()
	{
		Assert.IsNotString(null);
	}
	
	[Test]
	public void IsNotTransform()
	{
		Assert.IsNotTransform(null);
	}
	
	[Test]
	public void IsNotTransform2D()
	{
		Assert.IsNotTransform2D(null);
	}
	
	[Test]
	public void IsNotVector2()
	{
		Assert.IsNotVector2(null);
	}
	
	[Test]
	public void IsNotVector3()
	{
		Assert.IsNotVector3(null);
	}
}
