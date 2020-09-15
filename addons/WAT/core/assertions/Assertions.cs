using Godot;
using System;
using System.CodeDom;
using System.Collections.Generic;
using GDArray = Godot.Collections.Array;

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
		
		public void IsTrue(bool a, string Context = "")
		{
			Output(Boolean.IsTrue(a, Context));
		}
		
		public void IsFalse(bool a, string Context = "")
		{
			Output(Boolean.IsFalse(a, Context));
		}
		
		public void IsEqual(object a, object b, string Context = "")
		{
			Output(Equality.IsEqual(a, b, Context));
		}
		
		public void IsNotEqual(object a, object b, string Context = "")
		{
			Output(Equality.IsNotEqual(a, b, Context));
		}
		
		public void IsGreaterThan(float a, float b, string Context = "")
		{
			Output(Equality.IsGreaterThan(a, b, Context));
		}
		
		public void IsLessThan(float a, float b, string Context = "")
		{
			Output(Equality.IsLessThan(a, b, Context));
		}
		
		public void IsEqualOrGreaterThan(float a, float b, string Context = "")
		{
			Output(Equality.IsEqualOrGreaterThan(a, b, Context));
		}
		
		public void IsEqualOrLessThan(float a, float b, string Context = "")
		{
			Output(Equality.IsEqualOrLessThan(a, b, Context));
		}

		public void SignalWasEmitted(Godot.Object Emitter, string Event, string Context = "")
		{
			assertions.Call("signal_was_emitted", Emitter, Event, Context);
		}
		
		public void SignalWasEmittedXTimes(Godot.Object Emitter, string Event, int Times, string Context = "")
		{
			assertions.Call("signal_was_emitted_x_times", Emitter, Event, Times, Context);
		}
		
		public void SignalWasNotEmitted(Godot.Object Emitter, string Event, string Context = "")
		{
			assertions.Call("signal_was_not_emitted", Emitter, Event, Context);
		}
	
		public void SignalWasEmittedWithArguments(Godot.Object Emitter, string Event, GDArray Args, string Context = "")
		{
			assertions.Call("signal_was_emitted_with_arguments", Emitter, Event, Args, Context);
		}
		
		public void IsInRange(double a, double b, double c, string Context = "")
		{
			Output(Range.IsInRange(a, b, c, Context));
		}
		
		public void IsNotInRange(double a, double b, double c, string Context = "")
		{
			Output(Range.IsNotInRange(a, b, c, Context));
		}

		public void Contains<T>(object value, T container, string Context = "")
		{
			Output(Property.Contains(value, container, Context));
		}

		public void DoesNotContain<T>(object value, T container, string Context = "")
		{
			Output(Property.DoesNotContain(value, container, Context));
		}
		
		public void IsClassInstance(object a, object b, string Context = "")
		{
			assertions.Call("is_class_instance", a,  b, Context);
		}
		
		public void IsNotClassInstance(object a, object b, string Context = "")
		{
			assertions.Call("is_not_class_instance", a,  b, Context);
		}
		
		public void IsBuiltInType(object a, object b, string Context = "")
		{
			assertions.Call("is_built_in_type", a,  b, Context);
		}
		
		public void IsNotBuiltInType(object a, object b, string Context = "")
		{
			assertions.Call("is_not_built_in_type", a,  b, Context);
		}
		
		public void IsNull(object a, string Context = "")
		{
			assertions.Call("is_null", a, Context);
		}
		
		public void IsNotNull(object a, string Context = "")
		{
			assertions.Call("is_not_null", a, Context);
		}
		
		public void StringContains(string value, string str, string Context = "")
		{
			Output(StringX.Contains(value, str, Context));
		}
		
		public void StringDoesNotContain(string value, string str, string Context = "")
		{
			Output(StringX.DoesNotContain(value, str, Context));
		}
		
		public void StringBeginsWith(string value, string str, string Context = "")
		{
			Output(StringX.BeginsWith(value, str, Context));
		}
		
		public void StringDoesNotBeginWith(string value, string str, string Context = "")
		{
			Output(StringX.DoesNotBeginWith(value, str, Context));
		}
		
		public void StringEndsWith(string value, string str, string Context = "")
		{
			Output(StringX.EndsWith(value, str, Context));
		}
		
		public void StringDoesNotEndWith(string value, string str, string Context = "")
		{
			Output(StringX.DoesNotEndWith(value, str, Context));
		}
		
		public void WasCalled(object a, object b, string Context = "")
		{
			assertions.Call("was_called", a,  b, Context);
		}
		
		public void WasNotCalled(object a, object b, string Context = "")
		{
			assertions.Call("was_not_called", a,  b, Context);
		}
		
		public void WasCalledWithArguments(object a, object b, object c, string Context = "")
		{
			assertions.Call("was_called_with_arguments", a,  b,  c, Context);
		}
		
		public void FileExists(string path, string Context = "")
		{
			Output(File.Exists(path, Context));
		}
		
		public void FileDoesNotExist(string path, string context = "")
		{
			Output(File.DoesNotExist(path, context));
		}
		
		public void That(object a, object b, object c, object d, object e, string Context = "")
		{
			assertions.Call("that", a,  b,  c,  d,  e, Context);
		}
		
		public void ObjectHasMeta(object a, object b, string Context = "")
		{
			assertions.Call("object_has_meta", a,  b, Context);
		}
		
		public void ObjectDoesNotHaveMeta(object a, object b, string Context = "")
		{
			assertions.Call("object_does_not_have_meta", a,  b, Context);
		}
		
		public void ObjectHasMethod(object a, object b, string Context = "")
		{
			assertions.Call("object_has_method", a,  b, Context);
		}
		
		public void ObjectDoesNotHaveMethod(object a, object b, string Context = "")
		{
			assertions.Call("object_does_not_have_method", a,  b, Context);
		}
		
		public void ObjectIsQueuedForDeletion(object a, string Context = "")
		{
			assertions.Call("object_is_queued_for_deletion", a, Context);
		}
		
		public void ObjectIsNotQueuedForDeletion(object a, string Context = "")
		{
			assertions.Call("object_is_not_queued_for_deletion", a, Context);
		}
		
		public void ObjectIsConnected(object a, object b, object c, object d, string Context = "")
		{
			assertions.Call("object_is_connected", a,  b,  c,  d, Context);
		}
		
		public void ObjectIsNotConnected(object a, object b, object c, object d, string Context = "")
		{
			assertions.Call("object_is_not_connected", a,  b,  c,  d, Context);
		}
		
		public void ObjectIsBlockingSignals(object a, string Context = "")
		{
			assertions.Call("object_is_blocking_signals", a, Context);
		}
		
		public void ObjectIsNotBlockingSignals(object a, string Context = "")
		{
			assertions.Call("object_is_not_blocking_signals", a, Context);
		}
		
		public void ObjectHasUserSignal(object a, object b, string Context = "")
		{
			assertions.Call("object_has_user_signal", a,  b, Context);
		}
		
		public void ObjectDoesNotHaveUserSignal(object a, object b, string Context = "")
		{
			assertions.Call("object_does_not_have_user_signal", a,  b, Context);
		}
		
		public void IsFreed(object a, string Context = "")
		{
			assertions.Call("is_freed", a, Context);
		}
		
		public void IsNotFreed(object a, string Context = "")
		{
			assertions.Call("is_not_freed", a, Context);
		}
		
		public void IsAABB(object a, string Context = "")
		{
			assertions.Call("is_AABB", a, Context);
		}
		
		public void IsNotAABB(object a, string Context = "")
		{
			assertions.Call("is_not_AABB", a, Context);
		}
		
		public void IsBool(object a, string Context = "")
		{
			assertions.Call("is_bool", a, Context);
		}
		
		public void IsNotBool(object a, string Context = "")
		{
			assertions.Call("is_not_bool", a, Context);
		}
		
		public void IsInt(object a, string Context = "")
		{
			assertions.Call("is_int", a, Context);
		}
		
		public void IsNotInt(object a, string Context = "")
		{
			assertions.Call("is_not_int", a, Context);
		}
		
		public void IsFloat(object a, string Context = "")
		{
			assertions.Call("is_float", a, Context);
		}
		
		public void IsNotFloat(object a, string Context = "")
		{
			assertions.Call("is_not_float", a, Context);
		}
		
		public void IsString(object a, string Context = "")
		{
			assertions.Call("is_String", a, Context);
		}
		
		public void IsNotString(object a, string Context = "")
		{
			assertions.Call("is_not_String", a, Context);
		}
		
		public void IsVector2(object a, string Context = "")
		{
			assertions.Call("is_Vector2", a, Context);
		}
		
		public void IsNotVector2(object a, string Context = "")
		{
			assertions.Call("is_not_Vector2", a, Context);
		}
		
		public void IsRect2(object a, string Context = "")
		{
			assertions.Call("is_Rect2", a, Context);
		}
		
		public void IsNotRect2(object a, string Context = "")
		{
			assertions.Call("is_not_Rect2", a, Context);
		}
		
		public void IsVector3(object a, string Context = "")
		{
			assertions.Call("is_Vector3", a, Context);
		}
		
		public void IsNotVector3(object a, string Context = "")
		{
			assertions.Call("is_not_Vector3", a, Context);
		}
		
		public void IsTransform2D(object a, string Context = "")
		{
			assertions.Call("is_Transform2D", a, Context);
		}
		
		public void IsNotTransform2D(object a, string Context = "")
		{
			assertions.Call("is_not_Transform2D", a, Context);
		}
		
		public void IsPlane(object a, string Context = "")
		{
			assertions.Call("is_Plane", a, Context);
		}
		
		public void IsNotPlane(object a, string Context = "")
		{
			assertions.Call("is_not_Plane", a, Context);
		}
		
		public void IsQuat(object a, string Context = "")
		{
			assertions.Call("is_Quat", a, Context);
		}
		
		public void IsNotQuat(object a, string Context = "")
		{
			assertions.Call("is_not_Quat", a, Context);
		}
		
		public void IsAabb(object a, string Context = "")
		{
			assertions.Call("is_AABB", a, Context);
		}
		
		public void IsNotAabb(object a, string Context = "")
		{
			assertions.Call("is_not_AABB", a, Context);
		}
		
		public void IsBasis(object a, string Context = "")
		{
			assertions.Call("is_Basis", a, Context);
		}
		
		public void IsNotBasis(object a, string Context = "")
		{
			assertions.Call("is_not_Basis", a, Context);
		}
		
		public void IsTransform(object a, string Context = "")
		{
			assertions.Call("is_Transform", a, Context);
		}
		
		public void IsNotTransform(object a, string Context = "")
		{
			assertions.Call("is_not_Transform", a, Context);
		}
		
		public void IsColor(object a, string Context = "")
		{
			assertions.Call("is_Color", a, Context);
		}
		
		public void IsNotColor(object a, string Context = "")
		{
			assertions.Call("is_not_Color", a, Context);
		}
		
		public void IsNodePath(object a, string Context = "")
		{
			assertions.Call("is_NodePath", a, Context);
		}
		
		public void IsNotNodePath(object a, string Context = "")
		{
			assertions.Call("is_not_NodePath", a, Context);
		}
		
		public void IsRID(object a, string Context = "")
		{
			assertions.Call("is_RID", a, Context);
		}
		
		public void IsNotRID(object a, string Context = "")
		{
			assertions.Call("is_not_RID", a, Context);
		}
		
		public void IsObject(object a, string Context = "")
		{
			assertions.Call("is_Object", a, Context);
		}
		
		public void IsNotObject(object a, string Context = "")
		{
			assertions.Call("is_not_Object", a, Context);
		}
		
		public void IsDictionary(object a, string Context = "")
		{
			assertions.Call("is_Dictionary", a, Context);
		}
		
		public void IsNotDictionary(object a, string Context = "")
		{
			assertions.Call("is_not_Dictionary", a, Context);
		}
		
		public void IsArray(object a, string Context = "")
		{
			assertions.Call("is_Array", a, Context);
		}
		
		public void IsNotArray(object a, string Context = "")
		{
			assertions.Call("is_not_Array", a, Context);
		}
		
		public void Fail(string Context = "")
		{
			assertions.Call("fail",Context);
		}
	}
}
