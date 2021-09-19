using Catalogo_series.Application.View;
using System;

namespace Catalogo_series.Application.Controller
{
    public class InputController
    {
        public static void SelectedOption()
        {
            SerieController serieController = new();

            string userOptionInput = Console.ReadLine().ToUpper();
            Console.WriteLine();

            Boolean applicationRunning = true;

            while (applicationRunning == true)
            {
                switch (userOptionInput)
                {
                    case "1":
                        serieController.ListSerie();
                        break;

                    case "2":
                        serieController.InsertSerie();
                        break;

                    case "3":
                        serieController.UpdateSerie();
                        break;

                    case "4":
                        serieController.DeleteSerie();
                        break;

                    case "5":
                        serieController.ViewSerie();
                        break;

                    case "C":
                        serieController.CleanScreen();
                        break;

                    case "X":
                        applicationRunning = false;
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }
                if (applicationRunning == true)
                {
                    InputView.InputOptions();
                }
                else
                {
                    Console.WriteLine("Obrigado por utilizar nossos serviços.");
                    Console.ReadLine();
                }
            }
        }
    }
}