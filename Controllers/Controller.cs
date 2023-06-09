﻿using CrossZero.Models;
using CrossZero.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossZero.Controllers
{
   public class Controller
   {
      Model model;
      View view;

      public Controller(Model model, View view)
      {
         this.model = model;
         this.view = view;
      }

      public void Run()
      {
         view.Show();
         for (; ; )
         {
            switch (model.GameState)
            {
               case GameState.WaitForCross:
                  Console.Write("Cross turn > ");
                  DoTurn();
                  break;
               case GameState.WaitForZero:
                  Console.Write("Zero turn > ");
                  DoTurn();
                  break;
            }
            view.Show();
         }

         void DoTurn()
         {
            string str = Console.ReadLine();

            // validate user input
            try
            {
               int n = Convert.ToInt32(str);
               model.Turn(n / 10, n % 10);
            }
            catch (FormatException ex)
            {
               Display(ex.Message);
            }
            catch (CrossZeroException ex)
            {
               Display(ex.Message);
            }
         }

         void Display(string message)
         {
            Console.WriteLine(message);
            Console.WriteLine("Press Enter.");
            Console.ReadLine();
         }
      }

   }
}
