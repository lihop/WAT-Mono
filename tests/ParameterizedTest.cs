using Godot;
using System;

public class ParameterizedTest : WAT.Test
{
	public override String GetTitle()
	{
		return "Given The Addition Operator (Parameter Tests)";
	}
	
	[Test]
	[RunWith(2, 2, 4)]
	[RunWith(5, 3, 8)]
	[RunWith(7, 6, 13)]
	public void Add(int Addend, int Augend, int Result)
	{
		Describe(String.Format("When we add {0} to {1} we get {2}", Addend, Augend, Result));
		
		Assert.IsEqual(Result, Addend + Augend);
	}
}

//
//func test_subtract():
//	parameters([["addend", "augend", "result"], [2, 2, 0], [5, 3, 2], [7, 6, 1]])
//	describe("When we subtract %s from %s we get %s" % [p.addend as String, p.augend as String, p.result as String])
//	var expected = p.result
//	var actual = calculator.sub(p.addend, p.augend)
//	asserts.is_equal(actual, expected)
//
//class calculator:
//	static func add(a, b):
//		return a + b;
//
//	static func sub(a, b):
//		return a - b;
