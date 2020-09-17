using Godot;
using System;
using Object = Godot.Object;

public class IsInstanceTest : WAT.Test
{
	public override string Title()
	{
		return "Is Instance ( class / type ) Assertions";
	}
	
	[Test]
	public void IsAABB()
	{
		Assert.IsType<AABB>(new AABB());
	}
	
	[Test]
	public void IsArray()
	{
		var array = new Godot.Collections.Array();
		Assert.IsType<Godot.Collections.Array>(array);
	}
	
	[Test]
	public void IsBasis()
	{
		Assert.IsType<Basis>(new Basis());
	}
	
	[Test]
	public void IsBool()
	{
		Assert.IsType<bool>(true);
	}
	
	[Test]
	public void IsColor()
	{
		Assert.IsType<Color>(new Color());
	}
	
	[Test]
	public void IsDictionary()
	{
		var dictionary = new Godot.Collections.Dictionary();
		Assert.IsType<Godot.Collections.Dictionary>(dictionary);
	}
	
	[Test]
	public void IsFloat()
	{
		Assert.IsType<float>(3.0F);
	}
	
	[Test]
	public void IsInt()
	{
		Assert.IsType<int>(1);
	}
	
	[Test]
	public void IsNodePath()
	{
		var nodepath = new NodePath();
		Assert.IsType<NodePath>(nodepath);
	}
	
	[Test]
	public void IsObject()
	{
		var o = new Node();
		Assert.IsType<Object>(o);
	}
	
	[Test]
	public void IsPlane()
	{
		var plane = new Plane();
		Assert.IsType<Plane>(plane);
	}
	
	[Test]
	public void IsQuat()
	{
		Assert.IsType<Quat>(new Quat());
	}
	
	[Test]
	public void IsRect2()
	{
		Assert.IsType<Rect2>(new Rect2());
	}
	
	[Test]
	public void IsRid()
	{
		Assert.IsType<RID>(new RID(this));
	}
	
	[Test]
	public void IsString()
	{
		Assert.IsType<string>("strs");
	}
	
	
	[Test]
	public void IsTransform()
	{
		Assert.IsType<Transform>(new Transform());
	}
	
	[Test]
	public void IsTransform2D()
	{
		Assert.IsType<Transform2D>(new Transform2D());
	}
	
	[Test]
	public void IsVector2()
	{
		Assert.IsType<Vector2>(new Vector2());
	}
	
	[Test]
	public void IsVector3()
	{
		Assert.IsType<Vector3>(new Vector3());
	}
}
