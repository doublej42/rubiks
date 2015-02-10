using System;

namespace Rubiks.Models
{
    public class Side
    {
        private Colors[] _squares = new Colors[9];

        //protected Side TopSide { get; set; }
        //protected Side LeftSide { get; set; }
        //protected Side BottomSide { get; set; }
        //protected Side RightSide { get; set; }

        protected Side[] Sides = new Side[Enum.GetNames(typeof (SideTypes)).Length];

        public Side(string colors)
        {
            var colorArray = colors.ToCharArray();
            //I rarely ever user for loops



            foreach (var color in colorArray)
            {
                
            }
        }

        void Rotate(Rotations rotation)
        {
            switch (rotation)
            {
                case Rotations.Top:
                    Sides[(int)SideTypes.Left].Rotate(_squares, new []{ 0, 1, 2}, SideTypes.Left);
                    break;
            }
        }

        void Rotate(Colors[] sourceSquares, int[] locations, SideTypes sideType, int depth = 4)
        {
            var oldSquares = (Colors[])_squares.Clone();
            foreach (var location in locations)
            {
                _squares[location] = sourceSquares[location];
            }
            Sides[(int)sideType].Rotate(oldSquares, locations, sideType,depth - 1);
        }

    }

}