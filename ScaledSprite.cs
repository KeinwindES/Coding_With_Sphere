using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Coding_With_Sphere;

public class ScaledSprite : Sprite {

    public Rectangle Rect {
        get {
            return new Rectangle((int)position.X, (int)position.Y, 32, 32);
        }
    }
    
    public ScaledSprite(Texture2D texture, Vector2 position) : base(texture, position) {
        
    }
}