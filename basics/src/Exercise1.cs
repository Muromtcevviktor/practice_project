namespace Basics;


/// <summary>
/// Class should provide data object that includes information how many times given element occurs in the array
/// example parameter object : List<int> numbers = new List<int>(){9,9,9,2,1,1,3,3,4,4}
/// </summary>
public class Exercise1
{
    public Dictionary<int,int> GetStatistics(List<int> numbers)
    {
        Dictionary<int, int> toReturn = new Dictionary<int, int>();

        //logic

        //A loop iterates through each element of a List
        foreach (int number in numbers)
        {
            //Condtition to check if the dictionary already contains the current number (KEY value)
            if(toReturn.ContainsKey(number))
            {
                // if true -> Add +1 to the count
                toReturn[number]++;
            }
            else 
            {   // else -> Add number with count of 1
                toReturn.Add(number, 1);
            }
        }

        return toReturn;
    }
}
