using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class FieldCage
    {
        public enum Values
        {
            X,
            O
        }
        public Values Value { get; }
        public int Position { get; }
        public static List<int> PosX_List = new List<int>();
        public static List<int> PosO_List = new List<int>();

        private const int CountOfVariants = 8, 
            CombinationLenght = 3, 
            FirstInd = 0, 
            SecondInd = 1, 
            ThirdInd = 2;

        private static int indexOfWonCombination; 
        private readonly static int[,] winCombinations = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 },
                                                           { 1, 4, 7 }, { 2, 5, 8 }, { 3, 6, 9 },
                                                           { 1, 5, 9 }, { 3, 5, 7 } };
        public FieldCage(int position, bool isPlayer1)
        {
            Position = position;
            if (isPlayer1)
            {
                Value = Values.X;
                PosX_List.Add(position);
            }
            else
            {
                Value = Values.O;
                PosO_List.Add(position);
            }
        }
        public static bool IsPlayerWin(Values value)
        {
            List<int> valuePosList;
            if (value == Values.X)
            {
                valuePosList = PosX_List;
            }
            else
            {
                valuePosList = PosO_List;
            }

            if (valuePosList.Count < CombinationLenght)
            {
                return false;
            }

            for (int i = 0; i < CountOfVariants; i++)
            {
                if (valuePosList.Contains(winCombinations[i, FirstInd]) &&
                    valuePosList.Contains(winCombinations[i, SecondInd]) &&
                    valuePosList.Contains(winCombinations[i, ThirdInd]))
                {
                    indexOfWonCombination = i;
                    return true;
                }
            }
            return false;
        }
        public static int[] GetWonCombination()
        {
            int[] arr = new int[CombinationLenght];
            for (int i = 0; i < CombinationLenght; i++)
            {
                arr[i] = winCombinations[indexOfWonCombination, i];
            }
            return arr;
        }
    }
}
