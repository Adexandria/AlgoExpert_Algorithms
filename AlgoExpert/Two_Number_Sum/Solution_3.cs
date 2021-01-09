using System;

public class Program {
	public static int[] TwoNumberSum(int[] array, int targetSum) {
		Array.Sort(array);
		int left =0;
		int right = array.Length-1;
	 return Sum(array,left,right,targetSum);
	}
	public static int[] Sum(int[] array,int left,int right, int target)
	{
			if(left < right)
		{
			int current = array[left] + array[right];
			if(current == target)
			{
				return new int[] {array[left] , array[right]};
			}else if(current < target)
			{
				return Sum(array,left + 1,right,target);
			}
			else if(current > target)
			{
			 return Sum(array,left,right - 1 ,target);
			}
		}
		return  new int[0];
	}
	}