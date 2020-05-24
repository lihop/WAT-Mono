using Godot;
using System;
using System.Collections.Generic;
using GDArray = Godot.Collections.Array;

namespace WAT {
		
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
		
		public void IsEqual(System.Object a, System.Object b, String context = "")
		{
			assertions.Call("is_equal", a, b, context);
		}
		
		public void IsLessThan(System.Object a, System.Object b, String Context = "")
		{
			assertions.Call("is_less_than", a, b, Context);
		}
		
		public void SignalWasEmitted(Godot.Object Emitter, String Event, String Context = "")
		{
			assertions.Call("signal_was_emitted", Emitter, Event, Context);
		}
		
		public void SignalWasEmittedXTimes(Godot.Object Emitter, String Event, int Times, String Context = "")
		{
			assertions.Call("signal_was_emitted_x_times", Emitter, Event, Times, Context);
		}
		
		public void SignalWasNotEmitted(Godot.Object Emitter, String Event, String Context = "")
		{
			assertions.Call("signal_was_not_emitted", Emitter, Event, Context);
		}
	
		public void SignalWasEmittedWithArguments(Godot.Object Emitter, String Event, GDArray Args, String Context = "")
		{
			assertions.Call("signal_was_emitted_with_arguments", Emitter, Event, Args, Context);
		}
	}
}
