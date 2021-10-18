using System;
using Raylib_cs;

namespace TheKeyAndTheGate
{
    class Program
    {
        static void Main(string[] args)
        {
            Raylib.InitWindow(800, 600, "The Key And The Gate");
            Raylib.SetTargetFPS(60);
            Player player = new Player();
            bool end = false;

            while (!Raylib.WindowShouldClose())
            {
                player.Update();
                if (!end)
                {
                    end = player.door.End(player);
                }

                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.WHITE);
                if (!end)
                {
                    player.Draw();
                }
                else
                {
                    Raylib.DrawText("You Win", 50, 50, 50, Color.BLACK);
                }
                Raylib.EndDrawing();

            }

        }
    }
}
