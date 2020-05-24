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
		public Reference Watcher;
		private Script recorder;
		public bool RerunMethod = false;
		
		[Signal]
		delegate void Described(String MethodDescription);
		
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
			
			Script watcher = (Script)ResourceLoader.Load("res://addons/WAT/core/test/watcher.gd");
			Watcher = (Reference)watcher.Call("new");
			
			recorder = (Script)ResourceLoader.Load("res://addons/WAT/core/test/recorder.gd");

		}
		
		public override void _Ready()
		{
			Assert.assertions.Call("connect", "asserted", Testcase, "_on_asserted");
			Connect("Described", Testcase, "_on_test_method_described");
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
		
		protected void Describe(String MethodDescription)
		{
			EmitSignal("Described", MethodDescription);
		}
		
		public void Watch(Godot.Object Emitter, String Event)
		{
			Watcher.Call("watch", Emitter, Event);
		}
		
		public void UnWatch(Godot.Object Emitter, String Event)
		{
			Watcher.Call("unwatch", Emitter, Event);
		}
		
		public Godot.Node Record(Godot.Object Who, GodotArray Properties) 
		{
			Godot.Node Recorder = (Godot.Node)recorder.Call("new");
			Recorder.Call("record", Who, Properties);
			AddChild(Recorder);
			return Recorder;

		}

		public Timer UntilSignal(Godot.Object Emitter, String Event, double TimeLimit)
		{
			Watcher.Call("watch", Emitter, Event);
			return (Timer)Yielder.Call("until_signal", TimeLimit, Emitter, Event);
		}
		
		public Timer UntilTimeout(double TimeLimit)
		{
			return (Timer)Yielder.Call("until_timeout", TimeLimit);
		}
	}
}
