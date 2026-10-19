using System.Security.Authentication.ExtendedProtection;
using Microsoft.Xna.Framework;

namespace MP2D_Physics
{
    public class RigidBody
    {
        public Vector2 Position;
        public Vector2 Accerlation;
        public Vector2 Velocity;
        public Vector2 Force;

        public float Mass = 1.0f;

        public RigidBody(Vector2 position, Vector2 accerlation, Vector2 velocity, Vector2 force)
        {
            Position = position;
            Accerlation = accerlation;
            Velocity = velocity;
            Force = force;
        }

        public void addForce(Vector2 force) 
        {
            Force += force;
        
        }
        public void update(float dt) 
        { 
            Accerlation = Force/Mass;
            Position += Velocity *dt;
            Accerlation += Velocity *dt;
            Force = Vector2.Zero;
        }
    }
}
