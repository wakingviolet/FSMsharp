# FSMsharp
Incredibly small finite state machine for .NET languages, written in C#. Useful for UIs and games. Runs in .NET, mono, Xamarin and Unity. 
Specially useful with Unity3D and MonoGame.
 

# Usage example

This simple example uses an enum of seasons to cycle between 4 different seasons. In this case the FSM is not particularly exciting, but shows most of the features.

<svg xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" width="343px" height="253px" version="1.1" content="%3CmxGraphModel%20dx%3D%22794%22%20dy%3D%22752%22%20grid%3D%221%22%20gridSize%3D%2210%22%20guides%3D%221%22%20tooltips%3D%221%22%20connect%3D%221%22%20arrows%3D%221%22%20fold%3D%221%22%20page%3D%221%22%20pageScale%3D%221%22%20pageWidth%3D%22826%22%20pageHeight%3D%221169%22%20background%3D%22%23ffffff%22%20math%3D%220%22%3E%3Croot%3E%3CmxCell%20id%3D%220%22%2F%3E%3CmxCell%20id%3D%221%22%20parent%3D%220%22%2F%3E%3CmxCell%20id%3D%222%22%20value%3D%22%22%20style%3D%22edgeStyle%3DorthogonalEdgeStyle%3Brounded%3D0%3Bhtml%3D1%3BjettySize%3Dauto%3BorthogonalLoop%3D1%3B%22%20edge%3D%221%22%20source%3D%223%22%20target%3D%225%22%20parent%3D%221%22%3E%3CmxGeometry%20x%3D%22430%22%20y%3D%22240%22%20as%3D%22geometry%22%2F%3E%3C%2FmxCell%3E%3CmxCell%20id%3D%223%22%20value%3D%22Winter%22%20style%3D%22ellipse%3BwhiteSpace%3Dwrap%3Bhtml%3D1%3B%22%20vertex%3D%221%22%20parent%3D%221%22%3E%3CmxGeometry%20x%3D%22310%22%20y%3D%22200%22%20width%3D%22120%22%20height%3D%2280%22%20as%3D%22geometry%22%2F%3E%3C%2FmxCell%3E%3CmxCell%20id%3D%224%22%20value%3D%22%22%20style%3D%22edgeStyle%3DorthogonalEdgeStyle%3Brounded%3D0%3Bhtml%3D1%3BjettySize%3Dauto%3BorthogonalLoop%3D1%3B%22%20edge%3D%221%22%20source%3D%225%22%20target%3D%229%22%20parent%3D%221%22%3E%3CmxGeometry%20x%3D%22590%22%20y%3D%22280%22%20as%3D%22geometry%22%2F%3E%3C%2FmxCell%3E%3CmxCell%20id%3D%225%22%20value%3D%22Spring%22%20style%3D%22ellipse%3BwhiteSpace%3Dwrap%3Bhtml%3D1%3B%22%20vertex%3D%221%22%20parent%3D%221%22%3E%3CmxGeometry%20x%3D%22530%22%20y%3D%22200%22%20width%3D%22120%22%20height%3D%2280%22%20as%3D%22geometry%22%2F%3E%3C%2FmxCell%3E%3CmxCell%20id%3D%226%22%20value%3D%22%22%20style%3D%22edgeStyle%3DorthogonalEdgeStyle%3Brounded%3D0%3Bhtml%3D1%3BjettySize%3Dauto%3BorthogonalLoop%3D1%3B%22%20edge%3D%221%22%20source%3D%227%22%20target%3D%223%22%20parent%3D%221%22%3E%3CmxGeometry%20x%3D%22370%22%20y%3D%22280%22%20as%3D%22geometry%22%2F%3E%3C%2FmxCell%3E%3CmxCell%20id%3D%227%22%20value%3D%22Fall%22%20style%3D%22ellipse%3BwhiteSpace%3Dwrap%3Bhtml%3D1%3B%22%20vertex%3D%221%22%20parent%3D%221%22%3E%3CmxGeometry%20x%3D%22310%22%20y%3D%22370%22%20width%3D%22120%22%20height%3D%2280%22%20as%3D%22geometry%22%2F%3E%3C%2FmxCell%3E%3CmxCell%20id%3D%228%22%20value%3D%22%22%20style%3D%22edgeStyle%3DorthogonalEdgeStyle%3Brounded%3D0%3Bhtml%3D1%3BjettySize%3Dauto%3BorthogonalLoop%3D1%3B%22%20edge%3D%221%22%20source%3D%229%22%20target%3D%227%22%20parent%3D%221%22%3E%3CmxGeometry%20x%3D%22430%22%20y%3D%22410%22%20as%3D%22geometry%22%2F%3E%3C%2FmxCell%3E%3CmxCell%20id%3D%229%22%20value%3D%22Summer%22%20style%3D%22ellipse%3BwhiteSpace%3Dwrap%3Bhtml%3D1%3B%22%20vertex%3D%221%22%20parent%3D%221%22%3E%3CmxGeometry%20x%3D%22530%22%20y%3D%22370%22%20width%3D%22120%22%20height%3D%2280%22%20as%3D%22geometry%22%2F%3E%3C%2FmxCell%3E%3C%2Froot%3E%3C%2FmxGraphModel%3E" style="background-color: rgb(255, 255, 255);"><defs/><g transform="translate(0.5,0.5)"><path d="M 121 41 L 214.63 41" fill="none" stroke="#000000" stroke-miterlimit="10" pointer-events="none"/><path d="M 219.88 41 L 212.88 44.5 L 214.63 41 L 212.88 37.5 Z" fill="#000000" stroke="#000000" stroke-miterlimit="10" pointer-events="none"/><ellipse cx="61" cy="41" rx="60" ry="40" fill="#ffffff" stroke="#000000" pointer-events="none"/><g transform="translate(43.5,34.5)"><switch><foreignObject style="overflow:visible;" pointer-events="all" width="34" height="12" requiredFeatures="http://www.w3.org/TR/SVG11/feature#Extensibility"><div xmlns="http://www.w3.org/1999/xhtml" style="display: inline-block; font-size: 12px; font-family: Helvetica; color: rgb(0, 0, 0); line-height: 1.2; vertical-align: top; width: 36px; white-space: nowrap; text-align: center;"><div xmlns="http://www.w3.org/1999/xhtml" style="display:inline-block;text-align:inherit;text-decoration:inherit;">Winter</div></div></foreignObject><text x="17" y="12" fill="#000000" text-anchor="middle" font-size="12px" font-family="Helvetica">Winter</text></switch></g><path d="M 281 81 L 281 164.63" fill="none" stroke="#000000" stroke-miterlimit="10" pointer-events="none"/><path d="M 281 169.88 L 277.5 162.88 L 281 164.63 L 284.5 162.88 Z" fill="#000000" stroke="#000000" stroke-miterlimit="10" pointer-events="none"/><ellipse cx="281" cy="41" rx="60" ry="40" fill="#ffffff" stroke="#000000" pointer-events="none"/><g transform="translate(263.5,34.5)"><switch><foreignObject style="overflow:visible;" pointer-events="all" width="34" height="12" requiredFeatures="http://www.w3.org/TR/SVG11/feature#Extensibility"><div xmlns="http://www.w3.org/1999/xhtml" style="display: inline-block; font-size: 12px; font-family: Helvetica; color: rgb(0, 0, 0); line-height: 1.2; vertical-align: top; width: 36px; white-space: nowrap; text-align: center;"><div xmlns="http://www.w3.org/1999/xhtml" style="display:inline-block;text-align:inherit;text-decoration:inherit;">Spring</div></div></foreignObject><text x="17" y="12" fill="#000000" text-anchor="middle" font-size="12px" font-family="Helvetica">Spring</text></switch></g><path d="M 61 171 L 61 87.37" fill="none" stroke="#000000" stroke-miterlimit="10" pointer-events="none"/><path d="M 61 82.12 L 64.5 89.12 L 61 87.37 L 57.5 89.12 Z" fill="#000000" stroke="#000000" stroke-miterlimit="10" pointer-events="none"/><ellipse cx="61" cy="211" rx="60" ry="40" fill="#ffffff" stroke="#000000" pointer-events="none"/><g transform="translate(50.5,204.5)"><switch><foreignObject style="overflow:visible;" pointer-events="all" width="20" height="12" requiredFeatures="http://www.w3.org/TR/SVG11/feature#Extensibility"><div xmlns="http://www.w3.org/1999/xhtml" style="display: inline-block; font-size: 12px; font-family: Helvetica; color: rgb(0, 0, 0); line-height: 1.2; vertical-align: top; width: 20px; white-space: nowrap; text-align: center;"><div xmlns="http://www.w3.org/1999/xhtml" style="display:inline-block;text-align:inherit;text-decoration:inherit;">Fall</div></div></foreignObject><text x="10" y="12" fill="#000000" text-anchor="middle" font-size="12px" font-family="Helvetica">Fall</text></switch></g><path d="M 221 211 L 127.37 211" fill="none" stroke="#000000" stroke-miterlimit="10" pointer-events="none"/><path d="M 122.12 211 L 129.12 207.5 L 127.37 211 L 129.12 214.5 Z" fill="#000000" stroke="#000000" stroke-miterlimit="10" pointer-events="none"/><ellipse cx="281" cy="211" rx="60" ry="40" fill="#ffffff" stroke="#000000" pointer-events="none"/><g transform="translate(257.5,204.5)"><switch><foreignObject style="overflow:visible;" pointer-events="all" width="46" height="12" requiredFeatures="http://www.w3.org/TR/SVG11/feature#Extensibility"><div xmlns="http://www.w3.org/1999/xhtml" style="display: inline-block; font-size: 12px; font-family: Helvetica; color: rgb(0, 0, 0); line-height: 1.2; vertical-align: top; width: 46px; white-space: nowrap; text-align: center;"><div xmlns="http://www.w3.org/1999/xhtml" style="display:inline-block;text-align:inherit;text-decoration:inherit;">Summer</div></div></foreignObject><text x="23" y="12" fill="#000000" text-anchor="middle" font-size="12px" font-family="Helvetica">Summer</text></switch></g></g></svg>

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
