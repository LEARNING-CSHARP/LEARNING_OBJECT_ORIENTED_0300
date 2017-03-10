namespace LEARNING_CSHARP
{
	class SecondStack
	{
		private int Index = -1;
		private int[] Array = new int[100];

		public void Push(int data)
		{
			if (Index < Array.Length - 1)
			{
				Index++;

				Array[Index] = data;
			}
		}

		public int Pop()
		{
			if (Index >= 0)
			{

				int intResult = Array[Index];

				Index--;

				return (intResult);
			}
			else
			{
				return (-1);
			}
		}
	}
}
