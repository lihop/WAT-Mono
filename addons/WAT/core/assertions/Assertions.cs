using Godot;
using System;
using System.CodeDom;
using System.Collections.Generic;
using GDArray = Godot.Collections.Array;
using Object = Godot.Object;

namespace WAT {
		
	public class Assertions : Reference
	{
		[Signal]
		public delegate void Asserted();

		public Reference assertions;
	
		public Assertions()
		{
			const string path = "res://addons/WAT/core/assertions/assertions.gd";
			var script = ResourceLoader.Load<Script>(path);
			assertions = script.Call("new") as Reference;
		}

		private void Output(object result) => EmitSignal(nameof(Asserted), result);
		
		public void IsTrue(bool a, string context = "")
		{
			Output(Boolean.IsTrue(a, context));
		}
		
		public void IsFalse(bool a, string context = "")
		{
			Output(Boolean.IsFalse(a, context));
		}
		
		public void IsEqual(object a, object b, string context = "")
		{
			Output(Equality.IsEqual(a, b, context));
		}
		
		public void IsNotEqual(object a, object b, string context = "")
		{
			Output(Equality.IsNotEqual(a, b, context));
		}
		
		public void IsGreaterThan(float a, float b, string context = "")
		{
			Output(Equality.IsGreaterThan(a, b, context));
		}
		
		public void IsLessThan(float a, float b, string context = "")
		{
			Output(Equality.IsLessThan(a, b, context));
		}
		
		public void IsEqualOrGreaterThan(float a, float b, string context = "")
		{
			Output(Equality.IsEqualOrGreaterThan(a, b, context));
		}
		
		public void IsEqualOrLessThan(float a, float b, string context = "")
		{
			Output(Equality.IsEqualOrLessThan(a, b, context));
		}

		public void SignalWasEmitted(Godot.Object emitter, string signal, string context = "")
		{
			Output(Signal.WasEmitted(emitter, signal, context));
		}
		
		public void SignalWasEmittedXTimes(Godot.Object emitter, string signal, int times, string context = "")
		{
			Output(Signal.WasEmittedXTimes(emitter, signal, times, context));
		}
		
		public void SignalWasNotEmitted(Godot.Object emitter, string signal, string context = "")
		{
			Output(Signal.WasNotEmitted(emitter, signal, context));
		}
	
		public void SignalWasEmittedWithArguments(Godot.Object emitter, string signal, GDArray args, string context = "")
		{
			//assertions.Call("signal_was_emitted_with_arguments", emitter, signal, args, context);
			Output(Signal.WasEmittedWithArgs(emitter, signal, args, context));
		}
		
		public void IsInRange(double a, double b, double c, string context = "")
		{
			Output(Range.IsInRange(a, b, c, context));
		}
		
		public void IsNotInRange(double a, double b, double c, string context = "")
		{
			Output(Range.IsNotInRange(a, b, c, context));
		}

		public void Contains<T>(object value, T container, string context = "")
		{
			Output(Property.Contains(value, container, context));
		}

		public void DoesNotContain<T>(object value, T container, string context = "")
		{
			Output(Property.DoesNotContain(value, container, context));
		}
		
		public void IsClassInstance(object a, object b, string context = "")
		{
			assertions.Call("is_class_instance", a,  b, context);
		}
		
		public void IsNotClassInstance(object a, object b, string context = "")
		{
			assertions.Call("is_not_class_instance", a,  b, context);
		}
		
		public void IsBuiltInType(object a, object b, string context = "")
		{
			assertions.Call("is_built_in_type", a,  b, context);
		}
		
		public void IsNotBuiltInType(object a, object b, string context = "")
		{
			assertions.Call("is_not_built_in_type", a,  b, context);
		}
		
		public void IsNull(object a, string context = "")
		{
			assertions.Call("is_null", a, context);
		}
		
		public void IsNotNull(object a, string context = "")
		{
			assertions.Call("is_not_null", a, context);
		}
		
		public void StringContains(string value, string str, string context = "")
		{
			Output(StringX.Contains(value, str, context));
		}
		
		public void StringDoesNotContain(string value, string str, string context = "")
		{
			Output(StringX.DoesNotContain(value, str, context));
		}
		
		public void StringBeginsWith(string value, string str, string context = "")
		{
			Output(StringX.BeginsWith(value, str, context));
		}
		
		public void StringDoesNotBeginWith(string value, string str, string context = "")
		{
			Output(StringX.DoesNotBeginWith(value, str, context));
		}
		
		public void StringEndsWith(string value, string str, string context = "")
		{
			Output(StringX.EndsWith(value, str, context));
		}
		
		public void StringDoesNotEndWith(string value, string str, string context = "")
		{
			Output(StringX.DoesNotEndWith(value, str, context));
		}
		
		public void WasCalled(object a, object b, string context = "")
		{
			assertions.Call("was_called", a,  b, context);
		}
		
		public void WasNotCalled(object a, object b, string context = "")
		{
			assertions.Call("was_not_called", a,  b, context);
		}
		
		public void WasCalledWithArguments(object a, object b, object c, string context = "")
		{
			assertions.Call("was_called_with_arguments", a,  b,  c, context);
		}
		
		public void FileExists(string path, string context = "")
		{
			Output(File.Exists(path, context));
		}
		
		public void FileDoesNotExist(string path, string context = "")
		{
			Output(File.DoesNotExist(path, context));
		}
		
		public void That(object a, object b, object c, object d, object e, string context = "")
		{
			assertions.Call("that", a,  b,  c,  d,  e, context);
		}
		
		public void ObjectHasMeta(Godot.Object obj, string meta, string context = "")
		{
			Output(ObjectX.HasMeta(obj, meta, context));
		}
		
		public void ObjectDoesNotHaveMeta(Godot.Object obj, string meta, string context = "")
		{
			Output(ObjectX.DoesNotHaveMeta(obj, meta, context));
		}
		
		public void ObjectHasMethod(Godot.Object obj, string method, string context = "")
		{
			Output(ObjectX.HasMethod(obj, method, context));
		}
		
		public void ObjectDoesNotHaveMethod(Godot.Object obj, string method, string context = "")
		{
			Output(ObjectX.DoesNotHaveMethod(obj, method, context));
		}
		
		public void ObjectIsQueuedForDeletion(Godot.Object obj, string context = "")
		{
			Output(ObjectX.IsQueuedForDeletion(obj, context));
		}
		
		public void ObjectIsNotQueuedForDeletion(Godot.Object obj, string context = "")
		{
			Output(ObjectX.IsNotQueuedForDeletion(obj, context));
		}
		
		public void ObjectIsConnected(Object sender, string signal, Object receiver, string method, string context = "")
		{
			Output(ObjectX.IsConnected(sender, signal, receiver, method, context));
		}
		
		public void ObjectIsNotConnected(Object sender, string signal, Object receiver, string method, string context = "")
		{
			Output(ObjectX.IsNotConnected(sender, signal, receiver, method, context));
		}
		
		public void ObjectIsBlockingSignals(Object obj, string context = "")
		{
			Output(ObjectX.IsBlockingSignals(obj, context));
		}
		
		public void ObjectIsNotBlockingSignals(Object obj, string context = "")
		{
			Output(ObjectX.IsNotBlockingSignals(obj, context));
		}
		
		public void ObjectHasUserSignal(Object obj, string signal, string context = "")
		{
			Output(ObjectX.HasUserSignal(obj, signal, context));
		}
		
		public void ObjectDoesNotHaveUserSignal(Object obj, string signal, string context = "")
		{
			Output(ObjectX.DoesNotHaveUserSignal(obj, signal, context));
		}
		
		public void IsFreed(object obj, string context = "")
		{
			Output(ObjectX.IsFreed(obj, context));
		}
		
		public void IsNotFreed(object obj, string context = "")
		{
			Output(ObjectX.IsNotFreed(obj, context));
		}
		

		public void IsType<T>(object value, string context = "")
		{
			Output(Is.IsType<T>(value, context));
		}

		public void IsNotType<T>(object value, string context = "")
		{
			Output(Is.IsNotType<T>(value, context));
		}
		
		public void Fail(string context = "")
		{
			assertions.Call("fail",context);
		}
	}
}
