using Godot;
using System;
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
		
		public void IsTrue(bool a, string Context = "")
		{
			EmitSignal(nameof(Asserted), Boolean.IsTrue(a, Context));
		}
		
		public void IsFalse(bool a, string Context = "")
		{
			EmitSignal(nameof(Asserted), Boolean.IsFalse(a, Context));
		}
		
		public void IsEqual(object a, object b, string Context = "")
		{
			assertions.Call("is_equal", a, b, Context);
		}
		
		public void IsNotEqual(object a, object b, string Context = "")
		{
			assertions.Call("is_not_equal", a, b, Context);
		}
		
		public void IsGreaterThan(object a, object b, string Context = "")
		{
			assertions.Call("is_greater_than", a, b, Context);
		}
		
		public void IsLessThan(object a, object b, string Context = "")
		{
			assertions.Call("is_less_than", a, b, Context);
		}
		
		public void IsEqualOrGreaterThan(object a, object b, string Context = "")
		{
			assertions.Call("is_equal_or_greater_than", a, b, Context);
		}
		
		public void IsEqualOrLessThan(object a, object b, string Context = "")
		{
			assertions.Call("is_equal_or_less_than", a, b, Context);
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
		
		public void IsInRange(object a, object b, object c, string Context = "")
		{
			assertions.Call("is_in_range", a,  b,  c, Context);
		}
		
		public void IsNotInRange(object a, object b, object c, string Context = "")
		{
			assertions.Call("is_not_in_range", a,  b,  c, Context);
		}
		
		public void Has(object a, object b, string Context = "")
		{
			assertions.Call("has", a,  b, Context);
		}
		
		public void DoesNotHave(object a, object b, string Context = "")
		{
			assertions.Call("does_not_have", a,  b, Context);
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
		
		public void StringContains(object a, object b, string Context = "")
		{
			assertions.Call("string_contains", a,  b, Context);
		}
		
		public void StringDoesNotContain(object a, object b, string Context = "")
		{
			assertions.Call("string_does_not_contain", a,  b, Context);
		}
		
		public void StringBeginsWith(object a, object b, string Context = "")
		{
			assertions.Call("string_begins_with", a,  b, Context);
		}
		
		public void StringDoesNotBeginWith(object a, object b, string Context = "")
		{
			assertions.Call("string_does_not_begin_with", a,  b, Context);
		}
		
		public void StringEndsWith(object a, object b, string Context = "")
		{
			assertions.Call("string_ends_with", a,  b, Context);
		}
		
		public void StringDoesNotEndWith(object a, object b, string Context = "")
		{
			assertions.Call("string_does_not_end_with", a,  b, Context);
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
		
		public void FileExists(string Context = "")
		{
			assertions.Call("file_exists",Context);
		}
		
		public void FileDoesNotExist(string Context = "")
		{
			assertions.Call("file_does_not_exist",Context);
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
