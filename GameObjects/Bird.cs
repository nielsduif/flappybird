using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlappyBird.GameObjects
{
    class Bird : SpriteGameObject
    {
        int fallAmount = 20;
        int jumpAmount = 450;

        public Bird() : base("spr_bird")
        {

        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            velocity.Y = fallAmount;

            position += velocity;
        }

        public override void HandleInput(InputHelper inputHelper)
        {
            base.HandleInput(inputHelper);
            if (inputHelper.KeyPressed(Keys.Space))
            {
                velocity.Y -= jumpAmount;
            }
        }
    }
}
