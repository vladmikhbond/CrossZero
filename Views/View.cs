using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossZero.Views
{
   public class View
   {
      Model model;

      public View(Model model)
      {
         this.model = model;
      }

      public void Show()
      {
         Console.Clear();
         for (int r = 0; r < model.Size; r++)
         {
            for (int c = 0; c < model.Size; c++)
            {
               if (model[r, c] == Cell.Cross)
                  Console.Write(" X");
               else if (model[r, c] == Cell.Zero)
                  Console.Write(" O");
               else
                  Console.Write(" .");
            }
            Console.WriteLine();
         }
      }
   }

}
