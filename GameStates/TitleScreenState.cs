using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlappyBird.GameStates
{
    class TitleScreenState : GameObjectList
    {
        public TitleScreenState() {
            this.Add(new SpriteGameObject("spr_titlescreen"));
        }
        public override void HandleInput(InputHelper inputHelper)
        {
            if (inputHelper.KeyPressed(Keys.Space))
            {
                GameEnvironment.SwitchTo(1);
            }
            base.HandleInput(inputHelper);
        }
    }
}
