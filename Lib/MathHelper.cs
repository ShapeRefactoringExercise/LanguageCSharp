using System;

namespace Shape.Lib
{
    public static class MathHelper
    {
        internal static Func<int?, dynamic> Gs(int s)
        {
            return Utils.ApplyOffset(s);
        }

        public static Func<int?, dynamic> Gz()
        {
            return Utils.DefaultFunction();
        }

        internal static dynamic no = null;
    }
}