using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Utilities;

namespace ApocalypseRPGv1
{
    public interface ILocateable
    {
        // Properties for any "Locateable"
        string Name { get; set; }
        Image Img { get; set; }
        Vector Position { get; set;} 
        double Angle { get; set; }
        int Width { get;}
        int Height { get; }









    }
}
