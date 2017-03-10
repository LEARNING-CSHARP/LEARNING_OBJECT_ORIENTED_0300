namespace LEARNING_CSHARP
{
	public class Stack
	{
		private int Index = -1;
		private System.Collections.ArrayList Array = new System.Collections.ArrayList();

		public void Push(int data)
		{
			Index++;

			Array.Add(data);
		}

		public int Pop()
		{
			if (Index >= 0)
			{
				int intData = (int)Array[Index];

				Array.RemoveAt(Index);

				Index--;

				return (intData);
			}
			else
			{
				return (-1);
			}
		}
	}
}
