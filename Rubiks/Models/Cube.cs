using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;

namespace Rubiks.Models
{
    public class Cube
    {

        protected Side front;

        public Cube()
        {
            var side = new Side()
        }

        public void Rotate(Rotations direction)
        {
            
        }

        public void Solve()
        {
            Rotate(Rotations.Middle);
        }
    }


}