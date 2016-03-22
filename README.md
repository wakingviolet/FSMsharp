# FSMsharp
Incredibly small finite state machine for .NET languages, written in C#. Useful for UIs and games. Runs in .NET, mono, Xamarin and Unity. 
Specially useful with Unity3D and MonoGame.
 

# Usage example

This simple example uses an enum of seasons to cycle between 4 different seasons. In this case the FSM is not particularly exciting, but shows most of the features.

Specifically:

* Each state is created (fsm.Add ... )
* Each state is configured to auto-expire in 3 seconds ( .Expires )
* Each state is configured to go to the next one automagically ( .GoesTo )
* Each state changes the console color upon entering ( .OnEnter )
* Each state prints when it is ending ( .OnLeave )
* Each state prints its progress ( .Calls )

Now, while this might seem trivial, consider how little state management is in the code, how all configuration of the states is in the Init method and think
about what could happen if, for example, the FSM was to be used for a game UI controls, animating them in transition states, enabling and disabling the game logic in OnEnter/OnLeave,
etc.


```csharp
class Seasons
{
	// Define an enum to define the states. Anything could work, a string, int.. but enums are likely the easiest to manage
	enum Season
	{
		Winter,
		Spring,
		Summer,
		Fall
	}

	// Create the FSM
	FSM<Season> fsm = new FSM<Season>("seasons-fsm");

	public void Init()
	{
		// Initialize the states, adding them to the FSM and configuring their behaviour

		fsm.Add(Season.Winter)
			.Expires(3f)
			.GoesTo(Season.Spring)
			.OnEnter(() => Console.ForegroundColor = ConsoleColor.White)
			.OnLeave(() => Console.WriteLine("Winter is ending..."))
			.Calls(d => Console.WriteLine("Winter is going on.. {0}%", d.StateProgress * 100f));

		fsm.Add(Season.Spring)
			.Expires(3f)
			.GoesTo(Season.Summer)
			.OnEnter(() => Console.ForegroundColor = ConsoleColor.Green)
			.OnLeave(() => Console.WriteLine("Spring is ending..."))
			.Calls(d => Console.WriteLine("Spring is going on.. {0}%", d.StateProgress * 100f));

		fsm.Add(Season.Summer)
			.Expires(3f)
			.GoesTo(Season.Fall)
			.OnEnter(() => Console.ForegroundColor = ConsoleColor.Red)
			.OnLeave(() => Console.WriteLine("Summer is ending..."))
			.Calls(d => Console.WriteLine("Summer is going on.. {0}%", d.StateProgress * 100f));

		fsm.Add(Season.Fall)
			.Expires(3f)
			.GoesTo(Season.Winter)
			.OnEnter(() => Console.ForegroundColor = ConsoleColor.DarkYellow)
			.OnLeave(() => Console.WriteLine("Fall is ending..."))
			.Calls(d => Console.WriteLine("Fall is going on.. {0}%", d.StateProgress * 100f));

		// Very important! set the starting state
		fsm.CurrentState = Season.Winter;
	}

	public void Run()
	{
		// Define a base time. This seems pedantic in a pure .NET world, but allows to use custom time providers,
		// Unity3D Time class (scaled or unscaled), MonoGame timing, etc.
		DateTime baseTime = DateTime.Now;

		// Initialize the FSM
		Init();

		// Call the FSM periodically... in a real world scenario this will likely be in a timer callback, or frame handling (e.g.
		// Unity's Update() method).
		while (true)
		{
			// 
			fsm.Process((float)(DateTime.Now - baseTime).TotalSeconds);
			Thread.Sleep(100);
		}
	}
}

```
