using System;

public class Program {
	public static int[] TwoNumberSum(int[] array, int targetSum) {
		int x = array.Length-1;
		for(int i =0 ;i<x;i++)
		{
			for(int j= i+1;j<x+1;j++)
			{
				if(array[i]+array[j]==targetSum)
				{
					return new int[] {array[i],array[j]};
				}
			}
		}
		return new int[0];
	}
}