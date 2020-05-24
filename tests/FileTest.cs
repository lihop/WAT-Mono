using Godot;
using System;

public class FileTest : WAT.Test
{
	public override String GetTitle()
	{
		return "File Assertions";
	}
	
	[Test]
	public void ThisFileExists()
	{
		Assert.FileExists("res://tests/FileTest.cs");
	}
	
	[Test]
	public void ImaginaryFileDoesNotExist()
	{
		Assert.FileDoesNotExist("res://somefile.gd");
	}
	
	[Test]
	public void EmptyPathDoesNotExist()
	{
		Assert.FileDoesNotExist("");
	}
}
