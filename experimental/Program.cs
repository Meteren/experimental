

using System;

public class Program
{
    public static IEnumerable<int> HeuristicFunction(int[,] currentState, int[,] goalState,int G)
    {
        int distance;
        int g = G;
        int F;

        for(int i = 0; i < 3; i++)
        {
            for(int j = 0; j < 3; j++)
            {  
                if(currentState[i, j] != 0)
                {
                    for(int k = 0; k < 3; k++)
                    {
                        for(int l = 0; l < 3; l++)
                        {
                            if(currentState[i, j] == goalState[k, l])
                            {
                                distance = Math.Abs(i - k) + Math.Abs(j - l);
                                F = distance + g;
                                yield return F;
                            }
                        }
                    }
                }
            }
        }

    }
    public static void Main(string[] args)
    {
        int[,] initialState = { { 2, 6, 1 }, { 0, 7, 8 }, { 3, 5, 4 } };
        int[,] goalState = { { 1,2,3 }, { 4, 5, 6 }, { 7, 8, 0 } };
        List<int> functionValues = new List<int>();
        functionValues = HeuristicFunction(initialState, goalState, 0).ToList();

        foreach(int e in functionValues)
        {
            Console.Write(e + " ");
        }

    }
}