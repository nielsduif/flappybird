using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace FlappyBird
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    class FlappyBird : GameEnvironment
    {      
        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            base.LoadContent();
            screen.X = 640;
            screen.Y = 480;
            ApplyResolutionSettings();
            gameStateList.Add(new PlayingState());
            GameEnvironment.SwitchTo(0);

        }
    }
}
