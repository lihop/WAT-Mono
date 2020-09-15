using System.Collections;
using Godot;

namespace WAT
{
    public class Signal: Assertion
    {
        public static object WasEmitted(Object emitter, string signal, string context)
        {
            var passed = $"Signal {signal} was emitted from {emitter}";
            var failed = $"Signal {signal} was not emitted from {emitter}";
            
            var watcher = (Object) emitter.GetMeta("watcher");
            var success = (int) watcher.Call("get_emit_count", signal) > 0;
            var result = success ? passed : failed;

            return Result(success, passed, result, context);
        }

        public static object WasNotEmitted(Object emitter, string signal, string context)
        {
            var passed = $"Signal {signal} was not emitted from {emitter}";
            var failed = $"Signal {signal} was emitted from {emitter}";
            
            var watcher = (Object) emitter.GetMeta("watcher");
            var success = (int) watcher.Call("get_emit_count", signal) <= 0;
            var result = success ? passed : failed;

            return Result(success, passed, result, context);
        }

        public static object WasEmittedXTimes(Object emitter, string signal, int times, string context)
        {
            var passed = $"Signal {signal} was emitted {times} times from {emitter}";
            var failed = $"Signal {signal} was not emitted {times} times from {emitter}";
            
            var watcher = (Object) emitter.GetMeta("watcher");
            var success = (int) watcher.Call("get_emit_count", signal) == times;
            var result = success ? passed : failed;

            return Result(success, passed, result, context);
        }
    }
}