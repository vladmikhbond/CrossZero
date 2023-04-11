using CrossZero.Models;

public enum Cell { Empty, Cross, Zero };

public enum GameState { WaitForCross, WaitForZero };

public class Model
{
   public int Size { get; }
   public GameState GameState { private set; get; }

   Cell[] cells;
   int winSize;

   public Model(int size, int winSize)
   {
      Size = size;
      this.winSize = winSize;
      cells = new Cell[Size * Size];
      GameState = GameState.WaitForCross;
   }

   public Cell this[int r, int c]
   {
      private set { cells[r * Size + c] = value; }
      get { return cells[r * Size + c]; }
   }


   public void Turn(int row, int col)
   {
      if (row < 0 || row >= Size || col < 0 || col >= Size)
         throw new CrossZeroException("Turn is out of field.");

      if (this[row, col] != Cell.Empty)
         throw new CrossZeroException("Cell is not empty.");

      switch (GameState)
      {
         case GameState.WaitForCross:
            this[row, col] = Cell.Cross;
            GameState = GameState.WaitForZero;
            break;
         case GameState.WaitForZero:
            this[row, col] = Cell.Zero;
            GameState = GameState.WaitForCross;
            break;
      }
   }
}