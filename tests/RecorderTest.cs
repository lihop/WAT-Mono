using Godot;
using System;
using System.Threading.Tasks;

public class Hero : Node 
{
	public int Health = 100;
	
	public Hero()
	{
		
	}
}

public class Poison : Node
{
	public Hero Who;
	
	public Poison(Hero who)
	{
		Who = who;
		Who.AddChild(this);
	}
	
	public override void _Process(float delta)
	{
		if(Who != null && Who.Health > 0) 
		{ 
			Who.Health -= 1;
		}
	}
}

public class RecorderTest : WAT.Test
{
	public override String GetTitle()
	{
		return "Recorder Test";
	}
	
	[Test]
	public async void WhenAHeroIsPoisonedTheirHealthChangesOverTime()
	{
		Hero _Hero = new Hero();
		Godot.Collections.Array Properties = new Godot.Collections.Array();
		Properties.Add("Health");
		Poison poison = new Poison(_Hero);
		Godot.Node Recorder = Record(_Hero, Properties);
		AddChild(_Hero);
		Recorder.Call("start");
		await ToSignal(UntilTimeout(1.0F), YIELD);
		Recorder.Call("stop");
		Godot.Collections.Array Health = (Godot.Collections.Array)Recorder.Call("get_property_timeline", "Health");
		GD.Print(Health[0]);
		GD.Print(Health[Health.Count - 1]);
		Assert.IsLessThan(Health[Health.Count-1], Health[0]);
	
	}
}
