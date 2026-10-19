using System.IO.Pipes;
using Microsoft.Xna.Framework;


namespace MP2D_Physics
{
    public class SAT
    {
        public Vector2 A = new Vector2(2,2);
        public Vector2 B = new Vector2(8,2);
        public Vector2 C = new Vector2(8,6);
        public Vector2 D = new Vector2(2,6);

        public Vector2 An;
        public Vector2 Bn;
        public Vector2 Cn;
        public Vector2 Dn;

        public static Vector2 Perpendicular(Vector2 vector) 
        { 
            return new Vector2(-vector.Y, vector.X);
        }
        public void CalculateNormals()
        {
            An = Vector2.Normalize(Perpendicular(B - A));
            Bn = Vector2.Normalize(Perpendicular(C - B));
            Cn = Vector2.Normalize(Perpendicular(D - C));
            Dn = Vector2.Normalize(Perpendicular(A - D));
        }


    }
}
