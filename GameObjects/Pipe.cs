using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace FlappyBird.GameObjects
{
    class Pipe : GameObjectList
    {
        int upperPipeY = -525, lowerPipeY = 265;
        int speedX = -5;
        int startX = 700, startYMax = 200;
        SpriteGameObject[] spriteGOs;

        public Pipe() : base()
        {
            string[] sprites = { "spr_pipe_upper", "spr_pipe_lower" };
            spriteGOs = new SpriteGameObject[sprites.Length];
            for (int i = 0; i < sprites.Length; i++)
            {
                spriteGOs[i] = new SpriteGameObject(sprites[i]);
            }
            spriteGOs[0].position.Y = upperPipeY;
            spriteGOs[1].position.Y = lowerPipeY;
            for (int i = 0; i < sprites.Length; i++)
            {
                this.Add(spriteGOs[i]);
            }
            velocity.X = speedX;
            Random r = new Random();
            int randomY = r.Next(startYMax);
            position = new Vector2(startX, randomY);
        }

        public override void Update(GameTime gameTime)
        {
            position.X += velocity.X;
        }

        public bool OverlapsWith(SpriteGameObject other)
        {
            return (other.Overlaps(spriteGOs[0]) || other.Overlaps(spriteGOs[1]));
        }

        public bool OverlapsWithFor(SpriteGameObject other)
        {
            for (int i = 0; i < spriteGOs.Length; i++)
            {
                return (other.Overlaps(spriteGOs[i]));
            }
            return false;
        }
    }
}
