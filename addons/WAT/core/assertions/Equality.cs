using System.Reflection;

namespace WAT
{
    public class Equality: Assertion
    {
        public static object IsEqual(object a, object b, string context)
        {
            var passed = $"|{a.GetType()}| {a} is equal to |{b.GetType()}|{b}";
            var failed = $"|{a.GetType()}| {a} is not equal to |{b.GetType()}|{b}";
            var success = (a.Equals(b));
            var result = success ? passed : failed;
            return Create(success, passed, result, context);
        }

        public static object IsNotEqual(object a, object b, string context)
        {
            var passed = $"|{a.GetType()}| {a} is not equal to |{b.GetType()}|{b}";
            var failed = $"|{a.GetType()}| {a} is equal to |{b.GetType()}|{b}";
            var success = !(a.Equals(b));
            var result = success ? passed : failed;
            return Create(success, passed, result, context);
        }

        public static object IsEqualOrGreaterThan()
        {
            return new object();
        }

        public static object IsEqualOrLessThan()
        {
            return new object();
        }

        public static object IsGreaterThan()
        {
            return new object();
        }

        public static object IsLessThan()
        {
            return new object();
        }
    }
}