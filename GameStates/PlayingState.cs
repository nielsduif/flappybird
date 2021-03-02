using System;
using System.Collections.Generic;
using System.Text;

namespace FlappyBird
{
    
    class PlayingState : GameObjectList
    {
        public PlayingState()
        {
            this.Add(new SpriteGameObject("FlappyBirdContent/spr_background"));
        }
    }
}
