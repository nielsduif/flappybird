using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlappyBird.GameObjects
{
    class Bird : SpriteGameObject
    {
        Vector2 StartPosition;
        int fallAmount = 20;
        int jumpAmount = 450;

        public Bird() : base("spr_bird")
        {
            StartPosition = new Vector2(GameEnvironment.Screen.X / 2 - texture.Width / 2, GameEnvironment.Screen.Y / 2 - texture.Height / 2);
            Reset();
        }

        public override void Reset()
        {
            position = StartPosition;
            velocity = Vector2.Zero;
        }

        public override void Update(GameTime gameTime)
        {
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
    }
}
