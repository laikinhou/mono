// Compiler options: /r:gtest-235-lib.dll
// Dependencies: gtest-235-lib.cs
using System;

class GettingStarted
{
	public static void Main ()
	{
		MyList<string> names = new MyList<string> ();
		names.AddAll<string> ();
	}
}
