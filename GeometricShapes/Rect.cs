using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes;
internal class Rect : Quad
{
    public new int Area() //overwriting the Area method - ALWAYS use the new keyword
    {
        return Side1 * Side2;
    }

    public Rect(int Side1, int Side2) : base(Side1, Side2, Side1, Side2) //base represents Quad
    {
        
    }
}
