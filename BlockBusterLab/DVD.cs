using System;
using System.Collections.Generic;


namespace BlockBusterLab
{
    class DVD : Movie
    {

        public DVD(string Title, enum Category,  int runtime, List<string> Scenes) : base (title, Genre, runtime, scenes)
        {

        }

        public override void Play()
        {
            bool runBehaviour = true;
            PrintScenes();
            Console.WriteLine("\nWhat scene do you want to watch?\n Select a number from 1-5.\n");
            int input;


            while (runBehaviour) {
                try
                {
                    input = int.Parse(Console.ReadLine());
                    if(input > 0 || input < 6)
                    {
                        Console.WriteLine("Input 0 to exit");
                        switch(input)
                        {
                            case 1:
                                Movie.PrintScene();
                                break;
                            case 2:
                                PrintInfo();
                                break;
                            case 3:
                                PrintInfo();
                                break;
                            case 4:
                                PrintInfo();
                                break;
                            case 5:
                                PrintInfo();
                                break;
                            case 0:
                                runBehaviour = false;
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("The scene number you entered does not exist please try again.");
                    }
                }
                catch(FormatException isNumber)
                {

                }
                catch(OverflowException tooBig)
                {

                }
            }

        }

        private static bool ValidateNumInput(string toBeValidated)
        {
            bool isANum = false;
            int confirmedInt;
            if (int.TryParse(toBeValidated, out confirmedInt))
            {
                isANum = true;
                return isANum;
            }
            return isANum;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
        }

        private static void SelectAndPrintScene(int sceneNumber, List<string> scenes)
        {
            int sceneIndex = 0;
            foreach (string scene in scenes)
            {
                sceneIndex++;
                Console.WriteLine(scene);
                Console.WriteLine(sceneIndex);
            }
        }
    }
}
