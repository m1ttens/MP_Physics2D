using System;
using Microsoft.Xna.Framework;


namespace MP2D_Physics
{
    public class Shape
    {
        Vector2[] Vertices;
        Vector2[] RotationArray;
        Vector2[] TranslatePosition;
        Vector2[] Edges;
        Vector2[] Normals;

        public Shape(Vector2[] vertices)
        {
            Vertices = vertices;

        }
        public void RotationTranslation(float theta, RigidBody body)
        {
            RotationArray = new Vector2[]
            {new Vector2((float)Math.Cos(theta),-(float)Math.Sin(theta))
            ,new Vector2((float)Math.Sin(theta),(float)Math.Cos(theta))};

            for (int i = 0; i < Vertices.Length; i++)
            {
                float x = Vertices[i].X;
                float y = Vertices[i].Y;

                float newX = x * RotationArray[0].X
                           + y * RotationArray[0].Y;

                float newY = x * RotationArray[1].X
                           + y * RotationArray[1].Y;

                Vertices[i] = new Vector2(newX, newY);

            }

            for (int i = 0; i < Vertices.Length; i++)
            {
                float x = Vertices[i].X + body.Position.X;
                float y = Vertices[i].Y + body.Position.Y;

                TranslatePosition[i] = new Vector2(x, y);
            }
        }
        public void NormalVector() 
        {
            Edges = new Vector2[Vertices.Length];
            for (int i = 0; i < Vertices.Length; i++) 
            {
                Vector2 EdgeVector = Vertices[(i+1) %  Vertices.Length] - Vertices[i] ;

                Edges[i] = EdgeVector;

            
            }
            Normals = new Vector2[Edges.Length];
            for (int i = 0; i < Edges.Length; i++) 
            { 
                Vector2 Edge = Edges[i];
                Normals[i] = Vector2.Normalize(
                    new Vector2(-Edge.Y, Edge.X)
                );

            }
        
        }


    }
}
