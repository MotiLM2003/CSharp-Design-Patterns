using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public enum Color
    {
        Red, Green, Blue
    }

    public enum Size
    {
        Small, Medium, Large, Huge
    }
    public class Product
    {
        #region proprties
        public string Name { set; get; }
        public Color Color { set; get; }
        public Size Size { set; get; }
        #endregion

        #region Constructor
        public Product(string name, Color color, Size size)
        {
            Name = name;
            Color = Color;
            Size = Size;
        }
        #endregion

    }

}
