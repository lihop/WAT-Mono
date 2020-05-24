using Godot;
using System;
using System.Collections.Generic;
using System.Reflection;
using Array = Godot.Collections.Array;
using Dictionary = Godot.Collections.Dictionary;

//public class Node : Godot.Node
//{
//
//	[AttributeUsage(AttributeTargets.Method, AllowMultiple=true)]
//	public class RunWith : Attribute 
//	{
//		public System.Object[] arguments;
//		public RunWith(params System.Object[] args) { arguments = args; }
//	}
//
//	[RunWith(2, 2)]
//	[RunWith(4, 10)]
//	public void Add(int x, int y)
//	{
//		GD.Print(x + y);
//	}
//
//    public override void _Ready()
//    {
//		GetM();
//
//    }
//
//	public List<MethodInfo> GetM()
//	{
//		Dictionary RunMethods = new Dictionary();
//		List<MethodInfo> Methods = new List<MethodInfo>();
//		foreach(MethodInfo m in GetType().GetMethods())
//		{
//			if(m.IsDefined(typeof(RunWith)))
//			{
//
//				System.Attribute[] attrs = System.Attribute.GetCustomAttributes(m);
//
//				foreach (System.Attribute attr in attrs)
//				{
//					if(attr is RunWith)
//					{
//						// Collect Methods
//						// Return a Godot Dictionary Of Method + Arguments Array
//						// Loop through and callv them methodname
//						RunWith a = (RunWith)attr;
//						foreach(var arg in a.arguments){
//							GD.Print(arg);
//						}
//
//					}  
//				}
//			}
//		}
//
//		return Methods;
//	}

//}
