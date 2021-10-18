using System;
using Raylib_cs;

namespace TheKeyAndTheGate
{
    public class Player
    {
        public Rectangle rec = new Rectangle(0, 0, 40, 40);
        public Key key = new Key();
        public bool hasKey = false;
        public Door door = new Door();
        int speed = 5;

        public void Update()
        {
            if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
            {
                rec.x -= speed;
            }
            else if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
            {
                rec.x += speed;
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
            {
                rec.y += speed;
            }
            else if (Raylib.IsKeyDown(KeyboardKey.KEY_UP))
            {
                rec.y -= speed;
            }
            if (Raylib.CheckCollisionRecs(rec, key.rec) || hasKey)
            {
                hasKey = true;
                key.rec.x = rec.x - 20;
                key.rec.y = rec.y - 20;
            }
            door.Update(key.rec, hasKey);
        }
        public void Draw()
        {
            Raylib.DrawRectangleRec(rec, Color.BLUE);
            if (!door.isOpen)
            {
                key.Draw();
            }
            door.Draw();
        }
    }
}