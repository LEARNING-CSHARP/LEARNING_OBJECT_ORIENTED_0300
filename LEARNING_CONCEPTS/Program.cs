using System;

namespace LEARNING_CSHARP
{
	class Program
	{
		static void Main(string[] args)
		{
			Stack oStack = new Stack();

			oStack.Push(7);
			oStack.Push(2);
			oStack.Push(11);

			int intData;

			intData = oStack.Pop();
			System.Console.WriteLine("> " + intData);

			intData = oStack.Pop();
			System.Console.WriteLine("> " + intData);

			intData = oStack.Pop();
			System.Console.WriteLine("> " + intData);

			intData = oStack.Pop();
			System.Console.WriteLine("> " + intData);

			intData = oStack.Pop();
			System.Console.WriteLine("> " + intData);

			System.Console.Write("Press [ENTER] To Exit...");
			System.Console.ReadLine();
		}
	}
}
