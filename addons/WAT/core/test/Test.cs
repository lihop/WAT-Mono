using Godot;
using System;
using Godot.Collections;
using GodotArray = Godot.Collections.Array;
using System.Reflection;
using System.Threading.Tasks;

namespace WAT {
	
	public class Test : Node
	{
		
		[AttributeUsage(AttributeTargets.Method)]
		public class TestAttribute : Attribute {}
		
		public const String YIELD = "finished";
		const bool TEST = true;
		protected Assertions Assert;
		private Reference Testcase;
		public Timer Yielder;
		public bool RerunMethod = false;
		
		public virtual void Start() {}
		public virtual void Pre() {}
		public virtual void Post() {}
		public virtual void End() {}
		
		public void SetUp(Reference testcase)
		{

			Assert = new Assertions();
			Testcase = testcase;
			
			Script yielder = (Script)ResourceLoader.Load("res://addons/WAT/core/test/yielder.gd");
			Yielder = (Timer)yielder.Call("new");
		}
		
		public override void _Ready()
		{
			Assert.assertions.Call("connect", "asserted", Testcase, "_on_asserted");
		}
		
		public virtual String GetTitle()
		{
			return "Untitled Test";
		}
		
		public virtual String GetFilePath()
		{
			return "Undefined Script Path";
		}
		
		public GodotArray GetMethods()
		{
			GodotArray Methods = new GodotArray();
			foreach(MethodInfo m in GetType().GetMethods())
			{
				if(m.IsDefined(typeof(TestAttribute)))
				{
					Methods.Add(m.Name);
				}
			}
			return Methods;
		}
		
		public bool IsTestSuite()
		{
			return true;
		}
		
		static public String get_instance_base_type()
		{
			return "WAT.Test";
		}
		
		public Timer UntilSignal(Godot.Object Emitter, String Event, double TimeLimit)
		{
			return (Timer)Yielder.Call("until_signal", TimeLimit, Emitter, Event);
		}
		
		public Timer UntilTimeout(double TimeLimit)
		{
			return (Timer)Yielder.Call("until_timeout", TimeLimit);
		}
	}
}
