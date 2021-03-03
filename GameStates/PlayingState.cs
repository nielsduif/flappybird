using System;
using System.Collections.Generic;
using System.Text;

namespace FlappyBird
{
    
    class PlayingState : GameObjectList
    {
        Bird bird;
        public PlayingState()
        {
            this.Add(new SpriteGameObject("spr_background"));
            bird = new Bird();
            this.Add(bird);
        }
    }
}
