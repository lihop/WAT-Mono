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
		
		public void IsTrue(bool a, String Context = "")
		{
			assertions.Call("is_true", a, Context);
		}
		
		public void IsFalse(bool a, String Context = "")
		{
			assertions.Call("is_false", a, Context);
		}
		
		public void IsEqual(System.Object a, System.Object b, String Context = "")
		{
			assertions.Call("is_equal", a, b, Context);
		}
		
		public void IsNotEqual(System.Object a, System.Object b, String Context = "")
		{
			assertions.Call("is_not_equal", a, b, Context);
		}
		
		public void IsGreaterThan(System.Object a, System.Object b, String Context = "")
		{
			assertions.Call("is_greater_than", a, b, Context);
		}
		
		public void IsLessThan(System.Object a, System.Object b, String Context = "")
		{
			assertions.Call("is_less_than", a, b, Context);
		}
		
		public void IsEqualOrGreaterThan(System.Object a, System.Object b, String Context = "")
		{
			assertions.Call("is_equal_or_greater_than", a, b, Context);
		}
		
		public void IsEqualOrLessThan(System.Object a, System.Object b, String Context = "")
		{
			assertions.Call("is_equal_or_less_than", a, b, Context);
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
		
		public void IsInRange(System.Object a, System.Object b, System.Object c, String Context)
		{
			assertions.Call("IsInRange", a,  b,  c, Context);
		}
		
		public void IsNotInRange(System.Object a, System.Object b, System.Object c, String Context)
		{
			assertions.Call("IsNotInRange", a,  b,  c, Context);
		}
		
		public void Has(System.Object a, System.Object b, String Context)
		{
			assertions.Call("Has", a,  b, Context);
		}
		
		public void DoesNotHave(System.Object a, System.Object b, String Context)
		{
			assertions.Call("DoesNotHave", a,  b, Context);
		}
		
		public void IsClassInstance(System.Object a, System.Object b, String Context)
		{
			assertions.Call("IsClassInstance", a,  b, Context);
		}
		
		public void IsNotClassInstance(System.Object a, System.Object b, String Context)
		{
			assertions.Call("IsNotClassInstance", a,  b, Context);
		}
		
		public void IsBuiltInType(System.Object a, System.Object b, String Context)
		{
			assertions.Call("IsBuiltInType", a,  b, Context);
		}
		
		public void IsNotBuiltInType(System.Object a, System.Object b, String Context)
		{
			assertions.Call("IsNotBuiltInType", a,  b, Context);
		}
		
		public void IsNull(System.Object a, String Context)
		{
			assertions.Call("is_null", a, Context);
		}
		
		public void IsNotNull(System.Object a, String Context)
		{
			assertions.Call("is_not_null", a, Context);
		}
		
		public void StringContains(System.Object a, System.Object b, String Context)
		{
			assertions.Call("StringContains", a,  b, Context);
		}
		
		public void StringDoesNotContain(System.Object a, System.Object b, String Context)
		{
			assertions.Call("StringDoesNotContain", a,  b, Context);
		}
		
		public void StringBeginsWith(System.Object a, System.Object b, String Context)
		{
			assertions.Call("StringBeginsWith", a,  b, Context);
		}
		
		public void StringDoesNotBeginWith(System.Object a, System.Object b, String Context)
		{
			assertions.Call("StringDoesNotBeginWith", a,  b, Context);
		}
		
		public void StringEndsWith(System.Object a, System.Object b, String Context)
		{
			assertions.Call("StringEndsWith", a,  b, Context);
		}
		
		public void StringDoesNotEndWith(System.Object a, System.Object b, String Context)
		{
			assertions.Call("StringDoesNotEndWith", a,  b, Context);
		}
		
		public void WasCalled(System.Object a, System.Object b, String Context)
		{
			assertions.Call("WasCalled", a,  b, Context);
		}
		
		public void WasNotCalled(System.Object a, System.Object b, String Context)
		{
			assertions.Call("WasNotCalled", a,  b, Context);
		}
		
		public void WasCalledWithArguments(System.Object a, System.Object b, System.Object c, String Context)
		{
			assertions.Call("WasCalledWithArguments", a,  b,  c, Context);
		}
		
		public void FileExists(String Context)
		{
			assertions.Call("FileExists", Context);
		}
		
		public void FileDoesNotExist(String Context)
		{
			assertions.Call("FileDoesNotExist", Context);
		}
		
		public void That(System.Object a, System.Object b, System.Object c, System.Object d, System.Object e, String Context)
		{
			assertions.Call("That", a,  b,  c,  d,  e, Context);
		}
		
		public void ObjectHasMeta(System.Object a, System.Object b, String Context)
		{
			assertions.Call("ObjectHasMeta", a,  b, Context);
		}
		
		public void ObjectDoesNotHaveMeta(System.Object a, System.Object b, String Context)
		{
			assertions.Call("ObjectDoesNotHaveMeta", a,  b, Context);
		}
		
		public void ObjectHasMethod(System.Object a, System.Object b, String Context)
		{
			assertions.Call("ObjectHasMethod", a,  b, Context);
		}
		
		public void ObjectDoesNotHaveMethod(System.Object a, System.Object b, String Context)
		{
			assertions.Call("ObjectDoesNotHaveMethod", a,  b, Context);
		}
		
		public void ObjectIsQueuedForDeletion(System.Object a, String Context)
		{
			assertions.Call("ObjectIsQueuedForDeletion", a, Context);
		}
		
		public void ObjectIsNotQueuedForDeletion(System.Object a, String Context)
		{
			assertions.Call("ObjectIsNotQueuedForDeletion", a, Context);
		}
		
		public void ObjectIsConnected(System.Object a, System.Object b, System.Object c, System.Object d, String Context)
		{
			assertions.Call("ObjectIsConnected", a,  b,  c,  d, Context);
		}
		
		public void ObjectIsNotConnected(System.Object a, System.Object b, System.Object c, System.Object d, String Context)
		{
			assertions.Call("ObjectIsNotConnected", a,  b,  c,  d, Context);
		}
		
		public void ObjectIsBlockingSignals(System.Object a, String Context)
		{
			assertions.Call("ObjectIsBlockingSignals", a, Context);
		}
		
		public void ObjectIsNotBlockingSignals(System.Object a, String Context)
		{
			assertions.Call("ObjectIsNotBlockingSignals", a, Context);
		}
		
		public void ObjectHasUserSignal(System.Object a, System.Object b, String Context)
		{
			assertions.Call("ObjectHasUserSignal", a,  b, Context);
		}
		
		public void ObjectDoesNotHaveUserSignal(System.Object a, System.Object b, String Context)
		{
			assertions.Call("ObjectDoesNotHaveUserSignal", a,  b, Context);
		}
		
		public void IsFreed(System.Object a, String Context)
		{
			assertions.Call("IsFreed", a, Context);
		}
		
		public void IsNotFreed(System.Object a, String Context)
		{
			assertions.Call("IsNotFreed", a, Context);
		}
		
		public void IsBool(System.Object a, String Context)
		{
			assertions.Call("IsBool", a, Context);
		}
		
		public void IsNotBool(System.Object a, String Context)
		{
			assertions.Call("IsNotBool", a, Context);
		}
		
		public void IsInt(System.Object a, String Context)
		{
			assertions.Call("IsInt", a, Context);
		}
		
		public void IsNotInt(System.Object a, String Context)
		{
			assertions.Call("IsNotInt", a, Context);
		}
		
		public void IsFloat(System.Object a, String Context)
		{
			assertions.Call("IsFloat", a, Context);
		}
		
		public void IsNotFloat(System.Object a, String Context)
		{
			assertions.Call("IsNotFloat", a, Context);
		}
		
		public void IsString(System.Object a, String Context)
		{
			assertions.Call("IsString", a, Context);
		}
		
		public void IsNotString(System.Object a, String Context)
		{
			assertions.Call("IsNotString", a, Context);
		}
		
		public void IsVector2(System.Object a, String Context)
		{
			assertions.Call("IsVector2", a, Context);
		}
		
		public void IsNotVector2(System.Object a, String Context)
		{
			assertions.Call("IsNotVector2", a, Context);
		}
		
		public void IsRect2(System.Object a, String Context)
		{
			assertions.Call("IsRect2", a, Context);
		}
		
		public void IsNotRect2(System.Object a, String Context)
		{
			assertions.Call("IsNotRect2", a, Context);
		}
		
		public void IsVector3(System.Object a, String Context)
		{
			assertions.Call("IsVector3", a, Context);
		}
		
		public void IsNotVector3(System.Object a, String Context)
		{
			assertions.Call("IsNotVector3", a, Context);
		}
		
		public void IsTransform2d(System.Object a, String Context)
		{
			assertions.Call("IsTransform2d", a, Context);
		}
		
		public void IsNotTransform2d(System.Object a, String Context)
		{
			assertions.Call("IsNotTransform2d", a, Context);
		}
		
		public void IsPlane(System.Object a, String Context)
		{
			assertions.Call("IsPlane", a, Context);
		}
		
		public void IsNotPlane(System.Object a, String Context)
		{
			assertions.Call("IsNotPlane", a, Context);
		}
		
		public void IsQuat(System.Object a, String Context)
		{
			assertions.Call("IsQuat", a, Context);
		}
		
		public void IsNotQuat(System.Object a, String Context)
		{
			assertions.Call("IsNotQuat", a, Context);
		}
		
		public void IsAabb(System.Object a, String Context)
		{
			assertions.Call("IsAabb", a, Context);
		}
		
		public void IsNotAabb(System.Object a, String Context)
		{
			assertions.Call("IsNotAabb", a, Context);
		}
		
		public void IsBasis(System.Object a, String Context)
		{
			assertions.Call("IsBasis", a, Context);
		}
		
		public void IsNotBasis(System.Object a, String Context)
		{
			assertions.Call("IsNotBasis", a, Context);
		}
		
		public void IsTransform(System.Object a, String Context)
		{
			assertions.Call("IsTransform", a, Context);
		}
		
		public void IsNotTransform(System.Object a, String Context)
		{
			assertions.Call("IsNotTransform", a, Context);
		}
		
		public void IsColor(System.Object a, String Context)
		{
			assertions.Call("IsColor", a, Context);
		}
		
		public void IsNotColor(System.Object a, String Context)
		{
			assertions.Call("IsNotColor", a, Context);
		}
		
		public void IsNodePath(System.Object a, String Context)
		{
			assertions.Call("IsNodePath", a, Context);
		}
		
		public void IsNotNodePath(System.Object a, String Context)
		{
			assertions.Call("IsNotNodePath", a, Context);
		}
		
		public void IsRid(System.Object a, String Context)
		{
			assertions.Call("IsRid", a, Context);
		}
		
		public void IsNotRid(System.Object a, String Context)
		{
			assertions.Call("IsNotRid", a, Context);
		}
		
		public void IsObject(System.Object a, String Context)
		{
			assertions.Call("IsObject", a, Context);
		}
		
		public void IsNotObject(System.Object a, String Context)
		{
			assertions.Call("IsNotObject", a, Context);
		}
		
		public void IsDictionary(System.Object a, String Context)
		{
			assertions.Call("IsDictionary", a, Context);
		}
		
		public void IsNotDictionary(System.Object a, String Context)
		{
			assertions.Call("IsNotDictionary", a, Context);
		}
		
		public void IsArray(System.Object a, String Context)
		{
			assertions.Call("IsArray", a, Context);
		}
		
		public void IsNotArray(System.Object a, String Context)
		{
			assertions.Call("IsNotArray", a, Context);
		}
		
		public void IsPoolByteArray(System.Object a, String Context)
		{
			assertions.Call("IsPoolByteArray", a, Context);
		}
		
		public void IsNotPoolByteArray(System.Object a, String Context)
		{
			assertions.Call("IsNotPoolByteArray", a, Context);
		}
		
		public void IsPoolIntArray(System.Object a, String Context)
		{
			assertions.Call("IsPoolIntArray", a, Context);
		}
		
		public void IsNotPoolIntArray(System.Object a, String Context)
		{
			assertions.Call("IsNotPoolIntArray", a, Context);
		}
		
		public void IsPoolRealArray(System.Object a, String Context)
		{
			assertions.Call("IsPoolRealArray", a, Context);
		}
		
		public void IsNotPoolRealArray(System.Object a, String Context)
		{
			assertions.Call("IsNotPoolRealArray", a, Context);
		}
		
		public void IsPoolStringArray(System.Object a, String Context)
		{
			assertions.Call("IsPoolStringArray", a, Context);
		}
		
		public void IsNotPoolStringArray(System.Object a, String Context)
		{
			assertions.Call("IsNotPoolStringArray", a, Context);
		}
		
		public void IsPoolVector2Array(System.Object a, String Context)
		{
			assertions.Call("IsPoolVector2Array", a, Context);
		}
		
		public void IsNotPoolVector2Array(System.Object a, String Context)
		{
			assertions.Call("IsNotPoolVector2Array", a, Context);
		}
		
		public void IsPoolVector3Array(System.Object a, String Context)
		{
			assertions.Call("IsPoolVector3Array", a, Context);
		}
		
		public void IsNotPoolVector3Array(System.Object a, String Context)
		{
			assertions.Call("IsNotPoolVector3Array", a, Context);
		}
		
		public void IsPoolColorArray(System.Object a, String Context)
		{
			assertions.Call("IsPoolColorArray", a, Context);
		}
		
		public void IsNotPoolColorArray(System.Object a, String Context)
		{
			assertions.Call("IsNotPoolColorArray", a, Context);
		}
		
		public void Fail(String Context)
		{
			assertions.Call("Fail", Context);
		}
	}
}
