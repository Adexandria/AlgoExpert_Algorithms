  int count =0;
		foreach(var item in array)
		{
			if(count == sequence.Count)
			{
				 break;
			}
			if(sequence[count]==item)
			{
				count++;
			}
			
		}
		return sequence.Count == count;
}