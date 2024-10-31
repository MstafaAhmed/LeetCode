public class Solution {
    public string Interpret(string command) {
    
		string answer = ""; // intialaize the string answer

		int right = 1;

		for (int i = 0; i < command.Length; i++,right++)
		{
            // The Goal Parser will interpret "G" as the string "G"
			if (command[i] == 'G')  

			{
				answer += 'G';    //  G -> G
			}

            // replace "()"  as the string "o"  
			if (command[i] == '(' && command[right] == ')')

			{
				answer += 'o';      // () -> o
			}

			if (command[i] == 'a' && command[right] == 'l')

			{
                //(al) -> al
				answer += 'a';
				answer += 'l';
			}


		}
		return answer;
	}
}