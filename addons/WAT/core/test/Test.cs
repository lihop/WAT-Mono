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
		public Timer _yielder;
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
			_yielder = (Timer)yielder.Call("new");
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
		
//		public Timer until_signal(Godot.Object Emitter, String Event, float TimeLimit)
//		{
//			return (Timer)_yielder.Call("until_signal", TimeLimit, Emitter, Event);
//		}
		
		public Timer until_timeout(double TimeLimit)
		{
			return (Timer)_yielder.Call("until_timeout", TimeLimit);
		}
	}
}
