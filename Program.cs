using static Raylib_cs.Raylib;
using static Raylib_cs.Color;
using ImGuiNET;

namespace raylib_imgui_dotnet_template;

class Program
{
    static void Main(string[] args)
    {
        // Initialization
        //--------------------------------------------------------------------------------------
        const int screenWidth = 1280;
        const int screenHeight = 720;

        InitWindow(screenWidth, screenHeight, "raylib [core] example - basic window");

        ImGuiController igc = new ImGuiController();
        igc.Load(screenWidth, screenHeight);

        SetTargetFPS(60);
        //--------------------------------------------------------------------------------------

        // Main game loop
        while (!WindowShouldClose())    // Detect window close button or ESC key
        {
            // Update
            //----------------------------------------------------------------------------------
            // TODO: Update your variables here
            //----------------------------------------------------------------------------------
            igc.Update(GetFrameTime());

            ImGui.ShowDemoWindow();

            // Draw
            //----------------------------------------------------------------------------------
            BeginDrawing();
            ClearBackground(RAYWHITE);

            DrawText("Congrats! You created your first window!", 350, 320, 20, MAROON);

            igc.Draw();

            EndDrawing();
            //----------------------------------------------------------------------------------
        }

        // De-Initialization
        //--------------------------------------------------------------------------------------
        CloseWindow();        // Close window and OpenGL context
                              //--------------------------------------------------------------------------------------
    }
}