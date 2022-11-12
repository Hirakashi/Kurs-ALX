using ALXCourse.Lessons.L2.Enums;

namespace ALXCourse.Lessons.L2.Classes
{
    public class ChessFigure
    {
        public ChessFigureTypes FigureType;
        public ChessFigureColors FigureColor;
        
        public ChessFigure(){}
        
        public ChessFigure(ChessFigureTypes chessFigureType, ChessFigureColors chessColor)
        {
            FigureType = chessFigureType;
            FigureColor = chessColor;
        }
    }
}
