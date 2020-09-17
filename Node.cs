using Godot;
using System;
using WAT;

public class Node : Godot.Node
{
	public override void _Ready()
	{
		int ten = 10;
		Number newNumber = ten;
		GD.Print(newNumber.Value);
		GD.Print(newNumber.Type);
		var someNum = (Number) ten;
	}
}

public class Number
{
	public readonly string Value;
	public readonly string Type;

	private Number(string value, string type)
	{
		Value = value;
		Type = type;
	}
	public static implicit operator Number(int value)
	{
		return new Number(value.ToString(), "int");
	}
}


/*
using System;

public readonly struct Digit
{
	private readonly byte digit;

	public Digit(byte digit)
	{
		if (digit > 9)
		{
			throw new ArgumentOutOfRangeException(nameof(digit), "Digit cannot be greater than nine.");
		}
		this.digit = digit;
	}

	public static implicit operator byte(Digit d) => d.digit;
	public static explicit operator Digit(byte b) => new Digit(b);

	public override string ToString() => $"{digit}";
}

public static class UserDefinedConversions
{
	public static void Main()
	{
		var d = new Digit(7);

		byte number = d;
		Console.WriteLine(number);  // output: 7

		Digit digit = (Digit)number;
		Console.WriteLine(digit);  // output: 7
	}
}*/
