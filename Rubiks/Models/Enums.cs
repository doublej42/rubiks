using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rubiks.Models
{
    public enum SideTypes { Top = 0, Left = 1, Right = 2, Bottom = 3 }
    public enum Colors { Yellow, Green, Orange, Blue, Red, White, Error }
    public enum Rotations { Top, Middle, Bottom, Left, Center, Right, Front, Inner, Back }
}