namespace TicTacToeWebApi.Domain.Entity
{
    public class GameSession
    {
        public bool isEnd { get; set; }=false;
        public bool isMove { get; set; }

        public int[,] Board { get; private set; } = { { 0, 0, 0 },
                                                      { 0, 0, 0 },
                                                      { 0, 0, 0 } };

        //public in[,] Board { get; private set; } = { { null, null, null }, 
        //                                                 { null, null, null }, 
        //                                                 { null, null, null } };

        //public int[][] WinCombination { get; set; } = {
        //    new int[] {0,1,2},
        //    new int[] {3,4,5},
        //    new int[] {6,7,8},
        //    new int[] {0,3,6},
        //    new int[] {1,4,7},
        //    new int[] {2,5,8},
        //    new int[] {0,4,8},
        //    new int[] {2,4,6},
        //};
    }
}
