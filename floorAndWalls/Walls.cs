using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace floorAndWalls
{
    public class Wall
    {
       float Height { get; set; }
       float Width { get; set; }    

    public static float CalculateAreaOfWall(float height , float width)
        {
            return height * width;
        }

    public Wall(float height , float width)
        {
            if (height <= 0 || width <= 0)
            {
                throw new ArgumentException(message: "Height and width must be positive values");
            }
            Height = height;
            Width = width;
        }

    public float Area
        {
            get
            {
                return Height * Width;
            }

        }

    
    }
}
