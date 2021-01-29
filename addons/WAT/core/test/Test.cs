using System;
using System.Reflection;
using Godot;
using Array = Godot.Collections.Array;
using Timer = Godot.Timer;

namespace WAT
{

    public class Test : Node
    {
        [AttributeUsage(AttributeTargets.Method)]
        protected class TestAttribute : Attribute
        {
        }

        [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
        protected class RunWith : Attribute
        {
            private object[] arguments;

            public RunWith(params object[] args)
            {
                arguments = args;
            }
        }

        protected const String YIELD = "finished";
        public const bool TEST = true;
        protected Assertions Assert;
        protected Timer Yielder;
        public Reference Watcher;

        [Signal]
        delegate void Described(string MethodDescription);

        public virtual string Title()
        {
            return GetType().Name;
        }

        protected void Describe(string message)
        {
            EmitSignal(nameof(Described), message);
        }

        public virtual void Start()
        {
        }

        public virtual void Pre()
        {
        }

        public virtual void Post()
        {
        }

        public virtual void End()
        {
        }

        protected Timer UntilTimeout(double time)
        {
            return Yielder;
        }

        protected Timer UntilSignal(Godot.Object obj, string signal, double time)
        {
            return Yielder;
        }

        protected void Watch(Godot.Object obj, string signal)
        {

        }

        protected void UnWatch(Godot.Object obj, string signal)
        {

        }

        protected Recorder Record(Godot.Object who, Array properties) 
        {
            Recorder recorder = new Recorder();
            recorder.Record(who, properties);
            AddChild(recorder);
            return recorder;

        }
        
        public void Simulate(Node obj, int times, float delta)
        {
            for (int i = 0; i < times; i ++)
            {
                if(obj.HasMethod("_Process")) {
                    obj._Process(delta);
                }
				
                if(obj.HasMethod("_PhysicsProcess")) {
                    obj._PhysicsProcess(delta);
                }
				
                foreach(Node kid in obj.GetChildren()) {
                    Simulate(kid, 1, delta);
                }
            }
        }
        
        public static string get_instance_base_type()
        {
            return "WAT.Test";
        }
    }
}