using System;

public static class Globals
{
	internal static void Main()
	{
		int n;
		("%d", n) = Convert.ToInt32(value: Console.ReadLine());
		int dir = 1;
		int a;
		int b;
		for (int i = 0; i < n; i++)
		{
			("%d", a) = Convert.ToInt32(value: Console.ReadLine());
			if (dir != 0)
			{
				if (i != 0 && b > a)
				{
					dir = 0;
				}
			}
			else
			{
				if (b < a)
				{
					b = a;
				}
			}
		}
		return 1;
	}
}

