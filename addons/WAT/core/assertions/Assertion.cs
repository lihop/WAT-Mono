using System.Dynamic;
using Godot;

namespace WAT
{
    public class Assertion
    {
        private static readonly Script Result = GD.Load<Script>("res://addons/WAT/core/assertions/base.gd");

        protected static object Create(bool success, string expected, string actual, string context, string notes = "")
        {
            return Result.Call("create", success, expected, actual, context, notes);
        }
    }
}
