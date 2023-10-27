using System.Collections.Generic;

namespace Shape.Lib.Types
{
    public static class Builder
    {
        public static dynamic[] Build(params (double x, double y)[] coords) =>
            Utils.ConvertCoordinates(coords);

        public static dynamic Build(double x, double y)
        {
            return Utils.CreatePoint(x,y);
        }
    }
}