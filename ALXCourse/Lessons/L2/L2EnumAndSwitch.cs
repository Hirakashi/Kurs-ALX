
using ALXCourse.Lessons.L2.Classes;
using ALXCourse.Lessons.L2.Enums;

namespace ALXCourse.Lessons.L2
{
    public class L2EnumAndSwitch
    {
        public static void Run()
        {
            var whiteQueen = new ChessFigure(ChessFigureTypes.QUEEN, ChessFigureColors.WHITE);

            var blackQueen = new ChessFigure()
            {
                FigureType = ChessFigureTypes.QUEEN,
                FigureColor = ChessFigureColors.BLACK
            };
            var blackBishop = new ChessFigure(ChessFigureTypes.BISHOP, ChessFigureColors.BLACK);
            GetFigureType(whiteQueen);
            GetFigureType(blackBishop);
            GetFigureType(blackQueen);
        }
        private static void GetFigureType(ChessFigure chessFigure)
        {
            switch(chessFigure.FigureType)
            {
                case ChessFigureTypes.QUEEN:
                    Console.WriteLine("This figure is a queen.");
                    break;
                case ChessFigureTypes.BISHOP:
                    Console.WriteLine("This figure is a bishop.");
                    break;
                case ChessFigureTypes.ROOK:
                    Console.WriteLine("This figure is a rook.");
                    break;
                case ChessFigureTypes.KING:
                    Console.WriteLine("This figure is a king.");
                    break;
                case ChessFigureTypes.KNIGHT:
                    Console.WriteLine("This figure is a knight.");
                    break;
                case ChessFigureTypes.PAWN:
                    Console.WriteLine("This figure is a queen.");
                    break;
            }
        }
    }
}
