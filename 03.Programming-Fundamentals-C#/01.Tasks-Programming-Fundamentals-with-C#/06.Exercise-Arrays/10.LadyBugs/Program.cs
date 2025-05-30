using System;
using System.Linq;

namespace LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfTheField = int.Parse(Console.ReadLine());
            int[] initialIndexes = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] playground = new int[sizeOfTheField]; //игрално поле с калинки
            foreach (var newIndex in initialIndexes)
            {
                if (newIndex >= 0 && newIndex < playground.Length)
                {
                    playground[newIndex] = 1;
                }
            }

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "end")
            {
                int start = int.Parse(command.Split()[0]); // позиция от която взимаме калинка
                int end = int.Parse(command.Split()[2]); // брой позиции за изместване
                string direction = command.Split()[1]; // посока на движение

                if (ChekPosition(start, end, playground))
                {
                    if (playground[start] == 1)
                    {
                        if (direction == "left")
                        {
                            playground = LadybugFlightLeft(start, end, playground);
                        }
                        else if (direction == "right")
                        {
                            playground = LadybugFlightRight(start, end, playground);
                        }
                    }
                }

            }

            Console.WriteLine(string.Join(" ", playground));
        }

        static bool ChekPosition(int startPosition, int endPosition, int[] playground)
        {
            bool result = false;
            // 1) ако калинката е извън полето = false
            if ((startPosition <= playground.Length - 1 && startPosition >= 0))
                result = true;
            else
                result = false;

            return result;
        }

        static int[] LadybugFlightLeft(int startPosition, int endPosition, int[] playground)
        {
            int ladybugFlightLeft = startPosition - endPosition; // стъпка наляво
            int flightToNewIndex = 0;

            // проверявам с колко позиции калинката ще лети
            // 1) ако позициите са = 0, връщам като резултат същия масив
            if (endPosition == 0)
            {
                return playground;
            }
            // 2) ако позициите са < 0, връщам като резултат масива за летене надясно
            if (endPosition < 0)
            {
                playground = LadybugFlightRight(startPosition, Math.Abs(endPosition), playground);
                return playground;
            }
            // ако калинката лети в границите на масива
            if (ladybugFlightLeft >= 0 && ladybugFlightLeft < playground.Length)
            {
                // 1) ако новата позиция в масива е свободна
                if (playground[ladybugFlightLeft] == 0)
                {
                    flightToNewIndex = ladybugFlightLeft; // присвоявам стойността като нов индекс
                    playground[startPosition] = 0; // освобождавам индекса от който калинката тръгва
                    playground[flightToNewIndex] = 1; // поставям калинката на новата бозиция
                }
                // 2) ако новата позиция в масива е заета от друга калинка 
                else
                {
                    flightToNewIndex = -1; // изваждам променливата за нова позиция извън границите на масива

                    // обхождам масива със посочената стъпка от позицията на калинката до началото на масива
                    // и проверявам за свободен индекс - т.е. == 0
                    for (int i = ladybugFlightLeft; i >= 0; i -= endPosition)
                    {
                        // ако намеря свободен индекс
                        if (playground[i] != 1)
                        {
                            flightToNewIndex = i; // присвоявам стойността като нов индекс
                            playground[startPosition] = 0; // освобождавам индекса от който калинката тръгва
                            playground[flightToNewIndex] = 1; // поставям калинката на новата бозиция
                            break; // излизам от цикъла
                        }
                    }
                    // ако стойността на новия индек остане извън границите на масива
                    // калинката е отлетяла и нейната позиция остава празна
                    if (flightToNewIndex < 0)
                    {
                        playground[startPosition] = 0; // освобождавам индекса от който калинката тръгва
                    }
                }
            }
            // ако калинката лети извън границите на масива
            // калинката е отлетяла и нейната позиция остава празна
            else
                playground[startPosition] = 0; // освобождавам индекса от който калинката тръгва

            return playground;
        }

        static int[] LadybugFlightRight(int startPosition, int endPosition, int[] playground)
        {
            int ladybugFlightLeft = startPosition + endPosition; // стъпка надясно
            int flightToNewIndex = 0;

            // проверявам с колко позиции калинката ще лети
            // 1) ако позициите са = 0, връщам като резултат същия масив
            if (endPosition == 0)
            {
                return playground;
            }
            // 2) ако позициите са < 0, връщам като резултат масива за летене наляво
            if (endPosition < 0)
            {
                playground = LadybugFlightLeft(startPosition, Math.Abs(endPosition), playground);
                return playground;
            }
            // ако калинката лети в границите на масива
            if (ladybugFlightLeft >= 0 && ladybugFlightLeft < playground.Length)
            {
                // 1) ако новата позиция в масива е свободна
                if (playground[ladybugFlightLeft] == 0)
                {
                    flightToNewIndex = ladybugFlightLeft; // присвоявам стойността като нов индекс
                    playground[startPosition] = 0; // освобождавам индекса от който калинката тръгва
                    playground[flightToNewIndex] = 1; // поставям калинката на новата бозиция
                }
                // 2) ако новата позиция в масива е заета от друга калинка 
                else
                {
                    flightToNewIndex = -1; // изваждам променливата за нова позиция извън границите на масива

                    // обхождам масива със посочената стъпка от позицията на калинката до края на масива
                    // и проверявам за свободен индекс - т.е. == 0
                    for (int i = ladybugFlightLeft; i < playground.Length; i += endPosition)
                    {
                        // ако намеря свободен индекс
                        if (playground[i] != 1)
                        {
                            flightToNewIndex = i; // присвоявам стойността като нов индекс
                            playground[startPosition] = 0; // освобождавам индекса от който калинката тръгва
                            playground[flightToNewIndex] = 1; // поставям калинката на новата бозиция
                            break; // излизам от цикъла
                        }
                    }
                    // ако стойността на новия индек остане извън границите на масива
                    // калинката е отлетяла и нейната позиция остава празна
                    if (flightToNewIndex < 0)
                    {
                        playground[startPosition] = 0; // освобождавам индекса от който калинката тръгва
                    }
                }
            }
            // ако калинката лети извън границите на масива
            // калинката е отлетяла и нейната позиция остава празна
            else
                playground[startPosition] = 0; // освобождавам индекса от който калинката тръгва

            return playground;
        }
    }
}