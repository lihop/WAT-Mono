using Godot;
using System;
using System.Collections.Generic;


public class Assertions : Reference
{
	
	public Reference assertions;
	
	public Assertions()
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
	
	public List<String> get_words()
	{
		List<String> x = new List<String>();
		x.Add("10");
		x.Add("5");
		return x; 
	}
}
