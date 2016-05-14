using System;

public class Test
{
	public static void Main(string[] args)
	{
		for(int i=0;i<8;i++)
		{
			if(i%2==0)
			{
				
				for(int j=0;j<4;j++)
					Console.Write("XO");
			}
			else
			{
				for(int j=0;j<4;j++)
					Console.Write("OX");
			}
		Console.WriteLine();
		}
	}
}
