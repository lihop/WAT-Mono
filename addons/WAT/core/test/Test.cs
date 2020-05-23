using Godot;
using System;
using Godot.Collections;
using GodotArray = Godot.Collections.Array;

namespace WAT {
	
	public class Test : Node
	{
		const bool TEST = true;
		protected Assertions Assert;
		private Reference Testcase;
		public bool RerunMethod = false;
		
		public virtual void Start() {}
		public virtual void Pre() {}
		public virtual void Post() {}
		public virtual void End() {}
		
		public void SetUp(Reference testcase)
		{

			Assert = new Assertions();
			Testcase = testcase;			
		}
		
		public override void _Ready()
		{
			Assert.assertions.Call("connect", "asserted", Testcase, "_on_asserted");
		}
		
		public virtual String GetTitle()
		{
			return "Untitled Test";
		}
		
		public GodotArray GetMethods()
		{
			return new GodotArray();
		}
	}
}
