using System.ComponentModel.DataAnnotations;

namespace floorAndWalls
{
    public class Floor
    {
        public float LengthOfFloor { get; set; }
        public float WidthOfFloor { get; set; }

        public Floor (float lengthOfFloor, float widthOfFloor)
        {
            if (lengthOfFloor <= 0 || widthOfFloor <= 0)
            {
                throw new ArgumentException("Length and width must be positive values");
            }
            LengthOfFloor = lengthOfFloor;
            WidthOfFloor = widthOfFloor;
        }

        public float Area
        {
            get
            {
                return LengthOfFloor * WidthOfFloor;
            }
        }

        public float CalculateFloorArea(float l , float w)
        {
            return l * w;
        }
   

    }
}
