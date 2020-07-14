using Godot;

namespace WAT
{
    public class Boolean
    {
        
        private static readonly Script Result = GD.Load<Script>("res://addons/WAT/core/assertions/base.gd");
        
        public static object IsTrue(bool value, string context)
        {
            var passed = $"|boolean| {value.ToString()} == true";
            var failed = $"|boolean| {value.ToString()} == false";
            var success = value;
            var result = success ? passed : failed;
            return Result.Call("Create", success, passed, result, context);
        }
    }
}

 //static func Create(success: bool, expected: String, actual: String, context: String, notes: String = "") -> Reference:
