# WATSharp

WAT with a C# Wrapper around the Test Class;

[Documentation](https://wat.readthedocs.io/en/latest/index.html)

[C# API Differences](https://wat.readthedocs.io/en/latest/pages/csharp_differences.html)

[Twitter](https://twitter.com/AlexAndDraw)

[Email](code@darigan.ie)

[![ko-fi](https://www.ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/Q5Q51D9K5)

WAT Sharp Github
WAT-Sharp Install Instructions & API Differences
Support WAT/WAT-Sharp/Me On Kofi
GDScript has not been enough for the size of my project. I swear to god if I get another "cyclic reference" error I'm going do something drastic! So I decided to eventually switch to C#.
However I ran into issues when trying to use established C# Unit Testing Frameworks like x or n Unit. I don't understand the absolute specifics but the gist is that these established systems don't work well (if at all sometimes) with Godot's Managed API.
So being the dev that works far too much on their own tools instead of their game, I ended up adding a C# Wrapper around WAT (My GDScript Unit Testing Plugin).

Installing WAT-Sharp

- Add "addons/WAT" from the Github to your addons folder
- Include the following files in your csproj file
 - addons\WAT\core\assertions\Assertions.cs
 - addons\WAT\core\test\Recorder.cs
 - addons\WAT\core\test\Test.cs
C# API Differences

- You still extend/inherit from WAT.Test (note WAT is a namespace)
- Use the [Test] Attribute instead of prefixing your method names with test
- Use public override String Title() instead of func title()
- Use public override Start() instead of func start()
- Use public override Pre() instead of func pre()
- Use public override Post() instead of func post()
- Use public override End() instead of func end()
- Use Describe() instead of describe()
- Assertions are PascalCase (Check addons/WAT/core/assertions/Assertions.cs if you're stuck)
- Use await ToSignal(until_timeout/signal) to use Yield Methods
- Use the [RunWith(args)] Attribute for parameterized tests (and pass them via the call)
- PoolArray Assertions were removed
- TestSuiteOfSuites doesn't exist (yet)
- Test Doubles don't exist in C# (I'm not as familler with C# enough to do this properly)
Examples
You can find examples of tests in WAT-Sharp's own test suite at https://github.com/CodeDarigan/WATSharp/tree/master/tests which should hopefully help clear up any confusion.
