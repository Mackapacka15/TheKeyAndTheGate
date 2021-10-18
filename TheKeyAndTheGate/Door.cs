using System;
using Raylib_cs;

namespace TheKeyAndTheGate
{
    public class Door
    {
        public Rectangle rec = new Rectangle(300, 200, 40, 40);
        public bool isOpen = false;


        public void Update(Rectangle key, bool hasKey)
        {
            if (hasKey && Raylib.CheckCollisionRecs(rec, key))
            {
                isOpen = true;
            }
        }
        public bool End(Player player)
        {
            if (isOpen && Raylib.CheckCollisionRecs(rec, player.rec) && player.hasKey)
            {
                return true;
            }
            return false;
        }
        public void Draw()
        {
            if (!isOpen)
            {
                Raylib.DrawRectangleRec(rec, Color.RED);
            }
            else
            {
                Raylib.DrawRectangleRec(rec, Color.GREEN);
            }
        }
    }
}