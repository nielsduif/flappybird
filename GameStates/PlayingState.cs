using FlappyBird.GameObjects;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace FlappyBird.GameStates
{
    
    class PlayingState : GameObjectList
    {
        Bird bird;
        List<Pipe> pipes = new List<Pipe>();
        TextGameObject score;
        
        int frameCounter, framesBetweenPipeSpawn = 100;
        Vector2 scorePos = new Vector2(300, 50);
        public PlayingState()
        {
            this.Add(new SpriteGameObject("spr_background"));
            score = new TextGameObject(scorePos, Color.White);
            this.Add(score);
            bird = new Bird();
            this.Add(bird);
        }

        public override void Update(GameTime gameTime)
        {
            bool isGameOver = false;
            frameCounter++;
            if(frameCounter >= framesBetweenPipeSpawn)
            {
                Pipe pipe = new Pipe();
                pipes.Add(pipe);
                this.Add(pipe);
                frameCounter = 0;
            }
            int _score = 0;
            for (int i = 0; i < pipes.Count; i++)
            {
                if (pipes[i].position.X < bird.position.X)
                {
                    _score++;
                }
                isGameOver = pipes[i].OverlapsWith(bird) || !bird.onScreen();
                if (isGameOver)
                {
                    //Debug.Print("pipe: " + pipes[i].OverlapsWith(bird) + " offscreen: " + !bird.onScreen());
                    Reset(); 
                }
                
            }
            score.text = _score.ToString();
            base.Update(gameTime);
        }

        public override void Reset()
        {
            pipes.Clear();
            frameCounter = 0;
            base.Reset();
            GameEnvironment.SwitchTo(2);
        }
    }
}
