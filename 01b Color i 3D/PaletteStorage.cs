using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01b_Color_i_3D;
public static class PaletteStorage
{
    public static Palette Load(string path)
    {
        Palette palette = new Palette();
        string content = File.ReadAllText(path);
        string[] colors = content.Split("\r\n", StringSplitOptions.RemoveEmptyEntries);

        foreach (var color in colors)
        {
            byte[] c = color.Split(new char[] { ',' }, 
                StringSplitOptions.RemoveEmptyEntries).Select(byte.Parse).ToArray();
            palette.Add(new Color3D(c[0], c[1], c[2]));
        }

        return palette;

    }
    public static void Save(Palette palette, string filePath)
    {
        File.WriteAllText(filePath, palette.ToString());
    }

}
