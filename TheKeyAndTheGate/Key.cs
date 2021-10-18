using Raylib_cs;

namespace TheKeyAndTheGate
{
    public class Key
    {
        public Rectangle rec = new Rectangle(500, 400, 40, 40);

        public void Draw()
        {
            Raylib.DrawRectangleRec(rec, Color.ORANGE);
        }
    }
}