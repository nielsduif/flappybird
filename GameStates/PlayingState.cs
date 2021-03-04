using FlappyBird.GameObjects;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlappyBird
{
    
    class PlayingState : GameObjectList
    {
        Bird bird;
        List<Pipe> pipes = new List<Pipe>();
        int frameCounter, framesBetweenPipeSpawn = 10;
        public PlayingState()
        {
            this.Add(new SpriteGameObject("spr_background"));
            bird = new Bird();
            this.Add(bird);
        }

        public override void Update(GameTime gameTime)
        {
            frameCounter++;
            if(frameCounter >= framesBetweenPipeSpawn)
            {
                Pipe pipe = new Pipe();
                pipes.Add(pipe);
                this.Add(pipe);
                frameCounter = 0;
            }
            base.Update(gameTime);
        }
    }
}
