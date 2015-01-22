using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;

namespace Rubiks.Models
{
    public class Cube
    {
        private DataTable _sides;

        public DataTable sides
        {
            get { return _sides; }
            set { _sides = value; }
        }

        public void RotateFlipType(Rotations direction)
        {
            
        }

        public void Solve()
        {
            RotateFlipType(Rotations.Middle);
        }
    }

    //Rotations are to the right or down
    public enum Rotations {Top, Middle, Bottom, Left, Center, Right, Front, Inner, Back }

}