using Godot;
using System;

namespace System.Runtime.CompilerServices
{
    public class ExtensionAttribute : Attribute { }
}

public class Asserts : Reference
{
	
	public Reference assertions;
	
	public Asserts()
	{
		String path = "res://addons/WAT/core/assertions/assertions.gd";
		Godot.Script script = (Godot.Script)ResourceLoader.Load(path);
		assertions = (Reference)script.Call("new");
	}
	
	public void IsTrue(bool a, String context = "")
	{
		assertions.Call("is_true", a, context);
	}
	
	public void IsFalse(bool a, String context = "")
	{
		assertions.Call("is_false", a, context);
	}
	
	public void IsEqual(dynamic a, dynamic b, String context = "")
	{
		assertions.Call("is_equal", a, b, context);
	}
}
