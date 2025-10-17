using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01b_Color_i_3D;
public struct Color3D
{
    // Konstant fält
    private static readonly Color3D _red = new Color3D(255, 0, 0);
    private static readonly Color3D _green = new Color3D(0, 255, 0);
    private static readonly Color3D _blue = new Color3D(0, 0, 255);
    private static readonly Color3D _black = new Color3D(0, 0, 0);
    private static readonly Color3D _white = new Color3D(255, 255, 255);

    // Konstruktor
    public Color3D(byte r, byte g, byte b)
    {
        R = r;
        G = g;
        B = b;
    }

    // Egenskaper
    public byte R { get; set; }     // Red
    public byte G { get; set; }     // Grren
    public byte B { get; set; }     // Blue
    public static Color3D Red { get { return _red; } }
    public static Color3D Green { get { return _green; } }
    public static Color3D Blue { get { return _blue; } }

    // Egenskap för svart:
    public static Color3D Default
    {
        get { return _black; }
    }


    // Metoder
    public static Color3D GetDefault()
    {
        return Default;
    }

    // Override metod
    public override string ToString()
    {
        return string.Format("R = {0}, G = {1}, B = {2}", R, G, B);
    }
}
