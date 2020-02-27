using System.Collections.Generic;

namespace Host
{
    public class Service : IService
    {
        static List<int> lst = new List<int>();
        static List<GameGrid> moves = new List<GameGrid> { new GameGrid { MoveType = GridType.StartEnd, Num = 0, CrdCol = 1, CrdRow = 1 },
            new GameGrid { MoveType = GridType.Normal, Num = 1, CrdCol = 2, CrdRow = 2 },
            new GameGrid { MoveType = GridType.Normal, Num = 2, CrdCol = 2, CrdRow = 3 },
            new GameGrid { MoveType = GridType.Normal, Num = 3, CrdCol = 3, CrdRow = 3 },
            new GameGrid { MoveType = GridType.Normal, Num = 4, CrdCol = 4, CrdRow = 2 },
            new GameGrid { MoveType = GridType.Normal, Num = 5, CrdCol = 5, CrdRow = 1 },
            new GameGrid { MoveType = GridType.Normal, Num = 6, CrdCol = 6, CrdRow = 0 },
            new GameGrid { MoveType = GridType.Normal, Num = 7, CrdCol = 7, CrdRow = 0 },
            new GameGrid { MoveType = GridType.NavyStart, Num = 8, CrdCol = 8, CrdRow = 1 },
            new GameGrid { MoveType = GridType.Normal, Num = 9, CrdCol = 7, CrdRow = 2 },
            new GameGrid { MoveType = GridType.NavyEnd, Num = 10, CrdCol = 7, CrdRow = 3 },
            new GameGrid { MoveType = GridType.Red, Num = 11, CrdCol = 6, CrdRow = 4 },
            new GameGrid { MoveType = GridType.Normal, Num = 12, CrdCol = 5, CrdRow = 5 },
            new GameGrid { MoveType = GridType.Normal, Num = 13, CrdCol = 4, CrdRow = 5 },
            new GameGrid { MoveType = GridType.BrownEnd, Num = 14, CrdCol = 3, CrdRow = 5 },
            new GameGrid { MoveType = GridType.Normal, Num = 15, CrdCol = 2, CrdRow = 5 },
            new GameGrid { MoveType = GridType.Normal, Num = 16, CrdCol = 1, CrdRow = 6 },
            new GameGrid { MoveType = GridType.BrownStart, Num = 17, CrdCol = 2, CrdRow = 7 },
            new GameGrid { MoveType = GridType.Normal, Num = 18, CrdCol = 2, CrdRow = 8 },
            new GameGrid { MoveType = GridType.Normal, Num = 19, CrdCol = 2, CrdRow = 9 },
            new GameGrid { MoveType = GridType.NavyStart, Num = 20, CrdCol = 1, CrdRow = 9 },
            new GameGrid { MoveType = GridType.Normal, Num = 21, CrdCol = 1, CrdRow = 10 },
            new GameGrid { MoveType = GridType.Normal, Num = 22, CrdCol = 2, CrdRow = 11 },
            new GameGrid { MoveType = GridType.NavyEnd, Num = 23, CrdCol = 3, CrdRow = 11 },
            new GameGrid { MoveType = GridType.Red, Num = 24, CrdCol = 4, CrdRow = 10 },
            new GameGrid { MoveType = GridType.Normal, Num = 25, CrdCol = 5, CrdRow = 9 },
            new GameGrid { MoveType = GridType.Normal, Num = 26, CrdCol = 5, CrdRow = 8 },
            new GameGrid { MoveType = GridType.BrownEnd, Num = 27, CrdCol = 6, CrdRow = 7 },
            new GameGrid { MoveType = GridType.Normal, Num = 28, CrdCol = 7, CrdRow = 6 },
            new GameGrid { MoveType = GridType.Normal, Num = 29, CrdCol = 8, CrdRow = 7 },
            new GameGrid { MoveType = GridType.Red, Num = 30, CrdCol = 8, CrdRow = 8 },
            new GameGrid { MoveType = GridType.Normal, Num = 31, CrdCol = 8, CrdRow = 9 },
            new GameGrid { MoveType = GridType.BrownStart, Num = 32, CrdCol = 7, CrdRow = 10 },
            new GameGrid { MoveType = GridType.Normal, Num = 33, CrdCol = 7, CrdRow = 11 },
            new GameGrid { MoveType = GridType.Red, Num = 34, CrdCol = 8, CrdRow = 11 },
            new GameGrid { MoveType = GridType.Normal, Num = 35, CrdCol = 9, CrdRow = 11 },
            new GameGrid { MoveType = GridType.Normal, Num = 36, CrdCol = 10, CrdRow = 11 },
            new GameGrid { MoveType = GridType.Normal, Num = 37, CrdCol = 11, CrdRow = 11 },
            new GameGrid { MoveType = GridType.Normal, Num = 38, CrdCol = 12, CrdRow = 11 },
            new GameGrid { MoveType = GridType.Normal, Num = 39, CrdCol = 13, CrdRow = 11 },
            new GameGrid { MoveType = GridType.NavyStart, Num = 40, CrdCol = 14, CrdRow = 10 },
            new GameGrid { MoveType = GridType.Red, Num = 41, CrdCol = 15, CrdRow = 9 },
            new GameGrid { MoveType = GridType.Normal, Num = 42, CrdCol = 14, CrdRow = 8 },
            new GameGrid { MoveType = GridType.Normal, Num = 43, CrdCol = 13, CrdRow = 8 },
            new GameGrid { MoveType = GridType.NavyEnd, Num = 44, CrdCol = 12, CrdRow = 8 },
            new GameGrid { MoveType = GridType.Normal, Num = 45, CrdCol = 11, CrdRow = 7 },
            new GameGrid { MoveType = GridType.Normal, Num = 46, CrdCol = 12, CrdRow = 6 },
            new GameGrid { MoveType = GridType.Normal, Num = 47, CrdCol = 13, CrdRow = 6 },
            new GameGrid { MoveType = GridType.Normal, Num = 48, CrdCol = 14, CrdRow = 6 },
            new GameGrid { MoveType = GridType.Normal, Num = 49, CrdCol = 15, CrdRow = 6 },
            new GameGrid { MoveType = GridType.Normal, Num = 50, CrdCol = 16, CrdRow = 5 },
            new GameGrid { MoveType = GridType.NavyStart, Num = 51, CrdCol = 16, CrdRow = 4 },
            new GameGrid { MoveType = GridType.Normal, Num = 52, CrdCol = 16, CrdRow = 3 },
            new GameGrid { MoveType = GridType.Red, Num = 53, CrdCol = 15, CrdRow = 2 },
            new GameGrid { MoveType = GridType.Normal, Num = 54, CrdCol = 14, CrdRow = 2 },
            new GameGrid { MoveType = GridType.NavyEnd, Num = 55, CrdCol = 13, CrdRow = 3 },
            new GameGrid { MoveType = GridType.Normal, Num = 56, CrdCol = 12, CrdRow = 4 },
            new GameGrid { MoveType = GridType.Normal, Num = 57, CrdCol = 11, CrdRow = 4 },
            new GameGrid { MoveType = GridType.Normal, Num = 58, CrdCol = 10, CrdRow = 3 },
            new GameGrid { MoveType = GridType.Normal, Num = 59, CrdCol = 10, CrdRow = 2 },
            new GameGrid { MoveType = GridType.Normal, Num = 60, CrdCol = 10, CrdRow = 1 },
            new GameGrid { MoveType = GridType.Normal, Num = 61, CrdCol = 11, CrdRow = 0 },
            new GameGrid { MoveType = GridType.Normal, Num = 62, CrdCol = 12, CrdRow = 0 },
            new GameGrid { MoveType = GridType.Normal, Num = 63, CrdCol = 13, CrdRow = 0 },
            new GameGrid { MoveType = GridType.Normal, Num = 64, CrdCol = 14, CrdRow = 0 },
            new GameGrid { MoveType = GridType.Normal, Num = 65, CrdCol = 15, CrdRow = 0 },
            new GameGrid { MoveType = GridType.Normal, Num = 66, CrdCol = 16, CrdRow = 1 },
            new GameGrid { MoveType = GridType.StartEnd, Num = 67, CrdCol = 17, CrdRow = 1 },
        };
        static int pl1 = 0;
        static int pl2 = 0;
        static int clients = 0;
        static bool first = true;

        public void AddClient(int num)
        {
            lst.Add(num);
            clients++;
        }

        public List<GameGrid> GetBoard()
        {
            return moves;
        }
        public GameGrid Move(int id, int num)
        {
            int start = (id == lst[0]) ? pl1 : pl2;            

            try
            {
                if (moves[num + start].MoveType != GridType.Red)
                    first = !first;

                if (moves[num + start].MoveType == GridType.NavyStart)
                {
                    for (int i = num + start; i < moves.Count; i++)
                    {
                        if (moves[i].MoveType == GridType.NavyEnd)
                            break;
                        
                        num++;
                    }
                }

                if (moves[num + start].MoveType == GridType.BrownStart)
                {
                    for (int i = num + start; i > 0; i--)
                    {
                        if (moves[i].MoveType == GridType.BrownEnd)
                            break;
                        
                        num--;
                    }
                }
            }
            catch
            {
                if (id == lst[0])
                    pl1 = moves.Count - 1;
                else
                    pl1 = moves.Count - 1;

                first = !first;
                return moves[moves.Count - 1];
            }

            if (id == lst[0])
                pl1 += num;
            else
                pl2 += num;
            return moves[num + start];
        }
        public GameGrid OponentPos(int id)
        {
            return moves[(id == lst[0]) ? pl2 : pl1];
        }

        public bool CheckCl()
        {
            return clients == 2;
        }
        public bool CheckMove(int num)
        {
            return first? lst[0] == num : lst[1] == num;
        }
        public bool CheckIfWon(int num)
        {
            return first ? lst[0] == num : lst[1] == num;
        }

        public void DelClient(int num)
        {
            if (lst.Contains(num))
                lst.Remove(num);
            clients--;
        }
    }
}