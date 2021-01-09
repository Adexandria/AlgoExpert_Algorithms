using System;

public class Program {
	
	public static int[] TwoNumberSum(int[] array, int targetSum) {
		Array.Sort(array);
		int left =0;
		int right = array.Length-1;
		while(left < right)
		{
			int current = array[left] + array[right];
			if(current == targetSum)
			{
				return new int[] {array[left] , array[right]};
			}else if(current < targetSum)
			{
				left++;
			}
			else if(current > targetSum)
			{
			 right--;
			}
		}
		return  new int[0];
	}
	
}
