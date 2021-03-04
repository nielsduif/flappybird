using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlappyBird.GameObjects
{
    class Bird : RotatingSpriteGameObject
    {
        Vector2 StartPosition;
        float fallAmount = .33f;
        float jumpAmount = 7.5f;

        public Bird() : base("spr_bird")
        {
            StartPosition = new Vector2(GameEnvironment.Screen.X / 2 - texture.Width / 2, GameEnvironment.Screen.Y / 2 - texture.Height / 2);
            Origin = new Vector2(texture.Width / 2, texture.Height / 2);
            Reset();
        }

        public override void Reset()
        {
            position = StartPosition;
            velocity = Vector2.Zero;
        }

        public override void Update(GameTime gameTime)
        {
            AngularDirection = new Vector2(100, velocity.Y);
            position += velocity;
        }

        public override void HandleInput(InputHelper inputHelper)
        {
            if (inputHelper.KeyPressed(Keys.Space))
            {
                velocity.Y = -jumpAmount;
            }
            else
            {
                velocity.Y = fallAmount;
            }
        }

        public bool onScreen()
        {
            return (position.X > 0 && position.X - texture.Width < GameEnvironment.Screen.X && position.Y > 0 && position.Y - texture.Height < GameEnvironment.Screen.Y);
        }
    }
}
