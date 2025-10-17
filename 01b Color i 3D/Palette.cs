using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01b_Color_i_3D;
public class Palette
{
    // Konstantfält
    private const string Separator = "\n";
    private readonly List<Color3D> _colors = new List<Color3D>();

    // Konstruktor
    public Palette(params Color3D[] colors)
    {
        this.Add(colors);
    }


    // Egenskaper
    public int Count { get { return _colors.Count; } }

    public Color3D this[int index]
    {
        get { return _colors[index]; }
        set { _colors[index] = value; }
    }

    // Metoder
    public Palette Add(params Color3D[] colors)
    {
        foreach (var color in colors)
        {
            this._colors.Add(color);
        }

        return this;
    }

    public Palette Remove(Color3D color)
    {
        _colors.Remove(color);
        return this;
    }

    public Palette Clear()
    {
        _colors.Clear();
        return this;
    }

    // Override metod
    public override string ToString()
    {
        return string.Join(Separator, _colors);
    }

}
