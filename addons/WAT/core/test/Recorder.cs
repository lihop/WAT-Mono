using Godot;
using System;

namespace WAT 
{
	
	public class Recorder : Node
	{
		Godot.Object What;
		Godot.Collections.Dictionary Properties;
		bool isRecording = false;
	
		public void Start() { isRecording = true; }
		public void Stop() { isRecording = false; }
		
		public void Record(Godot.Object what, Godot.Collections.Array properties)
		{
			What = what;
			foreach(string Property in properties){
				Properties[Property] = new Godot.Collections.Array();
			}
		}
		
		public override void _Process(float delta)
		{
			if(isRecording) { Capture(); }
		}
		
		private void Capture()
		{
			if(IsInstanceValid(What)){
				foreach(string Property in Properties){
					Properties[Property] = What.Get(Property);
				}
			}
		}
		
		public Godot.Collections.Array GetPropertyTimeline(string Property){
			return (Godot.Collections.Array)Properties[Property];
		}
		
		public Godot.Collections.Dictionary GetPropertyMap()
		{
			return Properties;
		}
	}
}

