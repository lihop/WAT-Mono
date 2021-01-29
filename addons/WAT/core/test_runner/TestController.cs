using System;
using Godot;
using Godot.Collections;
using Array = Godot.Collections.Array;
using Object = Godot.Object;

namespace WAT
{
    public class TestController: Node
    {
        private GDScript Case = ResourceLoader.Load<GDScript>("res://addons/WAT/core/test/case.gd");
        private GDScript Watcher = ResourceLoader.Load<GDScript>("res://addons/WAT/core/test/watcher.gd");
        private GDScript Yielder = ResourceLoader.Load<GDScript>("res://addons/WAT/core/test/yielder.gd");

        // These exist in the name space
        //const Assertions: Script = preload("res://addons/WAT/core/assertions/assertions.gd")
        //const Parameters: Script = preload("res://addons/WAT/core/test/parameters.gd")
        //const Recorder: Script = preload("res://addons/WAT/core/test/recorder.gd")
        
        // We do not use doubles in CSharp but maybe keep this around for people who like to mix
        //const Any: Script = preload("res://addons/WAT/core/test/any.gd")
        //const Director: Script = preload("res://addons/WAT/core/double/factory.gd")
        //const Registry: Script = preload("res://addons/WAT/core/double/registry.gd")
        //enum { START, PRE, EXECUTE, POST, END }
        //signal finished
            // signal done

        [Signal]
        public delegate void finished();

        [Signal]
        public delegate void done();
        
        enum STATE { START, PRE, EXECUTE, POST, END }

        private Test Test;
        private Node TestCase;
        private STATE State = STATE.START;
        private int Cursor = -1;
        private Array Methods = new Array();
        private string CurrentMethod;
        private Assertions Assertions;
        private Timer _Yielder;
        private Object _Watcher;

        public TestController()
        {
            Console.WriteLine("Mono!");
            Assertions = new Assertions();
            _Watcher = (Object) Watcher.New();
            _Yielder = (Timer) Yielder.New();
            AddChild(_Yielder);
            _Yielder.Connect("finished", this, nameof(Next));
        }

        public void Run(Dictionary test)
        {
            Console.WriteLine("Adding");
            CSharpScript _test = (CSharpScript) test["script"];
            Test = (Test) _test.New();
            Console.WriteLine("Reached");
        }

        public void Next()
        {
            
        }
    }
}