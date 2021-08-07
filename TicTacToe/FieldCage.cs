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
            MinCombinationLenght = 3, 
            FirstInd = 0, 
            SecondInd = 1, 
            ThirdInd = 2;

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

            if (valuePosList.Count < MinCombinationLenght)
            {
                return false;
            }

            for (int i = 0; i < CountOfVariants; i++)
            {
                if (valuePosList.Contains(winCombinations[i, FirstInd]) &&
                    valuePosList.Contains(winCombinations[i, SecondInd]) &&
                    valuePosList.Contains(winCombinations[i, ThirdInd]))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
