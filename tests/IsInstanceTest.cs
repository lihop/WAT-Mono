using Godot;
using System;

public class IsInstanceTest : WAT.Test
{
	public override string Title()
	{
		return "Is Instance ( class / type ) Assertions";
	}
	
	[Test]
	public void IsAABB()
	{
		Assert.IsAABB(new AABB());
	}
	
	[Test]
	public void IsArray()
	{
		Godot.Collections.Array array = new Godot.Collections.Array();
		Assert.IsArray(array);
	}
	
	[Test]
	public void IsBasis()
	{
		Assert.IsBasis(new Basis());
	}
	
	[Test]
	public void IsBool()
	{
		Assert.IsBool(true);
	}
	
	[Test]
	public void IsColor()
	{
		Assert.IsColor(new Color());
	}
	
	[Test]
	public void IsDictionary()
	{
		Godot.Collections.Dictionary dictionary = new Godot.Collections.Dictionary();
		Assert.IsDictionary(dictionary);
	}
	
	[Test]
	public void IsFloat()
	{
		Assert.IsFloat(3.0F);
	}
	
	[Test]
	public void IsInt()
	{
		Assert.IsInt(1);
	}
	
	[Test]
	public void IsNodePath()
	{
		NodePath nodepath = new NodePath();
		Assert.IsNodePath(nodepath);
	}
	
	[Test]
	public void IsObject()
	{
		Node N = new Node();
		Assert.IsObject(N);
		N.Free();
	}
	
	[Test]
	public void IsPlane()
	{
		Plane Plain = new Plane();
		Assert.IsPlane(Plain);
	}
	
	[Test]
	public void IsQuat()
	{
		Assert.IsQuat(new Quat());
	}
	
	[Test]
	public void IsRect2()
	{
		Assert.IsRect2(new Rect2());
	}
	
	[Test]
	public void IsRid()
	{
		Assert.IsRID(new RID(this));
	}
	
	[Test]
	public void IsString()
	{
		Assert.IsString("strs");
	}
	
	
	[Test]
	public void IsTransform()
	{
		Assert.IsTransform(new Transform());
	}
	
	[Test]
	public void IsTransform2D()
	{
		Assert.IsTransform2D(new Transform2D());
	}
	
	[Test]
	public void IsVector2()
	{
		Assert.IsVector2(new Vector2());
	}
	
	[Test]
	public void IsVector3()
	{
		Assert.IsVector3(new Vector3());
	}
}
