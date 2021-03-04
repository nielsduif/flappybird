using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

class TextGameObject : GameObject
{
    Color color;
    SpriteFont spriteFont;
    public string text;
    public TextGameObject(Vector2 _position, Color _color)
    {
        position = _position;
        spriteFont = GameEnvironment.ContentManager.Load<SpriteFont>("GameFont");
        color = _color;
    }
    public override void Draw(SpriteBatch spriteBatch)
    {
        spriteBatch.DrawString(spriteFont, text, position, color);
    }
    public void _TextGameObject()
    {

    }
}

