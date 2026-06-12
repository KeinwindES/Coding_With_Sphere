using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Coding_With_Sphere;

public class ColoredSprite : ScaledSprite {
    public Color color;
    public ColoredSprite(Texture2D texture, Vector2 position, Color color) : base(texture, position) {
        this.color = color;
    }
}