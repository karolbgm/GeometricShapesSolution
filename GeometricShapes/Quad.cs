using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes;
internal class Quad
{
    public int Side1 { get; set; } = 0;
    public int Side2 { get; set; } = 0;
    public int Side3 { get; set; } = 0;
    public int Side4 { get; set; } = 0;


    public int Perimeter()
    {
        int perim = Side1 + Side2 + Side3 + Side4;
        return perim;
    }

    public void Area()
    {
        Console.WriteLine("Not implemented");
    }

    public Quad(int Side1, int Side2, int Side3, int Side4)
    {
        this.Side1 = Side1;
        this.Side2 = Side2;
        this.Side3 = Side3;
        this.Side4 = Side4;
    }
}
