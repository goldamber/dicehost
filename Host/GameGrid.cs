namespace Host
{
    public enum GridType { Red, BrownStart, BrownEnd, NavyStart, NavyEnd, Normal, StartEnd }

    public class GameGrid
    {
        public int Num { get; set; }
        public int CrdCol { get; set; }
        public int CrdRow { get; set; }
        public GridType MoveType { get; set; }
    }
}