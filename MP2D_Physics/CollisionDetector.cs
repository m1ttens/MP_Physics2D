using Microsoft.Xna.Framework;

namespace MP2D_Physics
{
    public class CollisionDetector
    {
        public RigidBody Body;
        public Vector2 Size;

        public CollisionDetector(RigidBody body, Vector2 size)
        {
            Body = body;
            Size = size;
        }

        public Rectangle Bounds 
        {
            get 
            { 
            
                return new Rectangle((int)Body.Position.X, (int)Body.Position.X, (int)Size.X, (int)Size.Y);
            
            }

        }
        public bool Intersects(CollisionDetector other) 
        { 
            return Bounds.Intersects(other.Bounds);
        
        
        }
    }
}
