// See https://aka.ms/new-console-template for more information
using System.Numerics;
using System.Runtime.InteropServices;
using ImGuiNET;
using ClickableTransparentOverlay;


namespace SzlDaRecoilMod
{
    public class Renderer : Overlay
    {


        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string IpClassName, string IpWindowName);

        [DllImport("user32.dll")]
        public static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(int vkey);


        public bool checkbox1 = false;
        public bool checkbox2 = false;
        public bool checkbox3 = false;
        public bool checkbox4 = false;
        public bool checkbox5 = false;
        public bool checkbox6 = false;
        public bool checkbox7 = false;
        public bool checkbox8 = false;
        public bool checkbox9 = false;
        public bool checkbox10 = false;
        public bool checkbox11 = false;
        public bool checkbox12 = false;
        public bool checkbox13 = false;
        public bool checkbox14 = false;


        bool showwindow = true;

        const int VKk_RBUTTON = 0x02;
        const int VKk_LBUTTON = 0x01;

        public float slidervaule1 = 51;
        public float slidervaule2 = 50;
        public float slidervaule3 = 50;
        public float slidervaule4 = 50;

        public float slidervauley = 0;
        public float slidervaulex = 0;

        public float sizeofcircle = 40;
        public float croshairsize = 20;

        Vector2 windowsize = new Vector2(400, 200);
        Vector4 _crossColor = new Vector4(1.0f, 0.0f, 0.0f, 1.0f); // Initial color (red)

        protected override void Render()
        {

            var style = ImGui.GetStyle();
            var colors = style.Colors;

            colors[(int)ImGuiCol.Text] = new Vector4(1.00f, 1.00f, 1.00f, 1.00f);
            colors[(int)ImGuiCol.TextDisabled] = new Vector4(0.50f, 0.50f, 0.50f, 1.00f);
            colors[(int)ImGuiCol.WindowBg] = new Vector4(0.10f, 0.10f, 0.10f, 1.00f);
            colors[(int)ImGuiCol.ChildBg] = new Vector4(0.00f, 0.00f, 0.00f, 0.00f);
            colors[(int)ImGuiCol.PopupBg] = new Vector4(0.19f, 0.19f, 0.19f, 0.92f);
            colors[(int)ImGuiCol.Border] = new Vector4(0.19f, 0.19f, 0.19f, 0.29f);
            colors[(int)ImGuiCol.BorderShadow] = new Vector4(0.00f, 0.00f, 0.00f, 0.24f);
            colors[(int)ImGuiCol.FrameBg] = new Vector4(0.05f, 0.05f, 0.05f, 0.54f);
            colors[(int)ImGuiCol.FrameBgHovered] = new Vector4(0.19f, 0.19f, 0.19f, 0.54f);
            colors[(int)ImGuiCol.FrameBgActive] = new Vector4(0.20f, 0.22f, 0.23f, 1.00f);
            colors[(int)ImGuiCol.TitleBg] = new Vector4(0.00f, 0.00f, 0.00f, 1.00f);
            colors[(int)ImGuiCol.TitleBgActive] = new Vector4(0.06f, 0.06f, 0.06f, 1.00f);
            colors[(int)ImGuiCol.TitleBgCollapsed] = new Vector4(0.00f, 0.00f, 0.00f, 1.00f);
            colors[(int)ImGuiCol.MenuBarBg] = new Vector4(0.14f, 0.14f, 0.14f, 1.00f);
            colors[(int)ImGuiCol.ScrollbarBg] = new Vector4(0.05f, 0.05f, 0.05f, 0.54f);
            colors[(int)ImGuiCol.ScrollbarGrab] = new Vector4(0.34f, 0.34f, 0.34f, 0.54f);
            colors[(int)ImGuiCol.ScrollbarGrabHovered] = new Vector4(0.40f, 0.40f, 0.40f, 0.54f);
            colors[(int)ImGuiCol.ScrollbarGrabActive] = new Vector4(0.56f, 0.56f, 0.56f, 0.54f);
            colors[(int)ImGuiCol.CheckMark] = new Vector4(0.33f, 0.67f, 0.86f, 1.00f);
            colors[(int)ImGuiCol.SliderGrab] = new Vector4(0.34f, 0.34f, 0.34f, 0.54f);
            colors[(int)ImGuiCol.SliderGrabActive] = new Vector4(0.56f, 0.56f, 0.56f, 0.54f);
            colors[(int)ImGuiCol.Button] = new Vector4(0.05f, 0.05f, 0.05f, 0.54f);
            colors[(int)ImGuiCol.ButtonHovered] = new Vector4(0.19f, 0.19f, 0.19f, 0.54f);
            colors[(int)ImGuiCol.ButtonActive] = new Vector4(0.20f, 0.22f, 0.23f, 1.00f);
            colors[(int)ImGuiCol.Header] = new Vector4(0.00f, 0.00f, 0.00f, 0.52f);
            colors[(int)ImGuiCol.HeaderHovered] = new Vector4(0.00f, 0.00f, 0.00f, 0.36f);
            colors[(int)ImGuiCol.HeaderActive] = new Vector4(0.20f, 0.22f, 0.23f, 0.33f);
            colors[(int)ImGuiCol.Separator] = new Vector4(0.28f, 0.28f, 0.28f, 0.29f);
            colors[(int)ImGuiCol.SeparatorHovered] = new Vector4(0.44f, 0.44f, 0.44f, 0.29f);
            colors[(int)ImGuiCol.SeparatorActive] = new Vector4(0.40f, 0.44f, 0.47f, 1.00f);
            colors[(int)ImGuiCol.ResizeGrip] = new Vector4(0.28f, 0.28f, 0.28f, 0.29f);
            colors[(int)ImGuiCol.ResizeGripHovered] = new Vector4(0.44f, 0.44f, 0.44f, 0.29f);
            colors[(int)ImGuiCol.ResizeGripActive] = new Vector4(0.40f, 0.44f, 0.47f, 1.00f);
            colors[(int)ImGuiCol.Tab] = new Vector4(0.00f, 0.00f, 0.00f, 0.52f);
            colors[(int)ImGuiCol.TabHovered] = new Vector4(0.14f, 0.14f, 0.14f, 1.00f);
            colors[(int)ImGuiCol.DockingPreview] = new Vector4(0.33f, 0.67f, 0.86f, 1.00f);
            colors[(int)ImGuiCol.DockingEmptyBg] = new Vector4(1.00f, 0.00f, 0.00f, 1.00f);
            colors[(int)ImGuiCol.PlotLines] = new Vector4(1.00f, 0.00f, 0.00f, 1.00f);
            colors[(int)ImGuiCol.PlotLinesHovered] = new Vector4(1.00f, 0.00f, 0.00f, 1.00f);
            colors[(int)ImGuiCol.PlotHistogram] = new Vector4(1.00f, 0.00f, 0.00f, 1.00f);
            colors[(int)ImGuiCol.PlotHistogramHovered] = new Vector4(1.00f, 0.00f, 0.00f, 1.00f);
            colors[(int)ImGuiCol.TableHeaderBg] = new Vector4(0.00f, 0.00f, 0.00f, 0.52f);
            colors[(int)ImGuiCol.TableBorderStrong] = new Vector4(0.00f, 0.00f, 0.00f, 0.52f);
            colors[(int)ImGuiCol.TableBorderLight] = new Vector4(0.28f, 0.28f, 0.28f, 0.29f);
            colors[(int)ImGuiCol.TableRowBg] = new Vector4(0.00f, 0.00f, 0.00f, 0.00f);
            colors[(int)ImGuiCol.TableRowBgAlt] = new Vector4(1.00f, 1.00f, 1.00f, 0.06f);
            colors[(int)ImGuiCol.TextSelectedBg] = new Vector4(0.20f, 0.22f, 0.23f, 1.00f);
            colors[(int)ImGuiCol.DragDropTarget] = new Vector4(0.33f, 0.67f, 0.86f, 1.00f);
            colors[(int)ImGuiCol.NavHighlight] = new Vector4(1.00f, 0.00f, 0.00f, 1.00f);
            colors[(int)ImGuiCol.NavWindowingHighlight] = new Vector4(1.00f, 0.00f, 0.00f, 0.70f);
            colors[(int)ImGuiCol.NavWindowingDimBg] = new Vector4(1.00f, 0.00f, 0.00f, 0.20f);
            colors[(int)ImGuiCol.ModalWindowDimBg] = new Vector4(1.00f, 0.00f, 0.00f, 0.35f);

            style.WindowPadding = new Vector2(8.00f, 8.00f);
            style.FramePadding = new Vector2(5.00f, 2.00f);
            style.CellPadding = new Vector2(6.00f, 6.00f);
            style.ItemSpacing = new Vector2(6.00f, 6.00f);
            style.ItemInnerSpacing = new Vector2(6.00f, 6.00f);
            style.TouchExtraPadding = new Vector2(0.00f, 0.00f);
            style.IndentSpacing = 25;
            style.ScrollbarSize = 15;
            style.GrabMinSize = 10;
            style.WindowBorderSize = 1;
            style.ChildBorderSize = 1;
            style.PopupBorderSize = 1;
            style.FrameBorderSize = 1;
            style.TabBorderSize = 1;
            style.WindowRounding = 7;
            style.ChildRounding = 4;
            style.FrameRounding = 3;
            style.PopupRounding = 4;
            style.ScrollbarRounding = 9;
            style.GrabRounding = 3;
            style.LogSliderDeadzone = 4;
            style.TabRounding = 4;

            if (GetAsyncKeyState(0x2D) < 0)
            {
                showwindow = !showwindow;
                Thread.Sleep(100);
            }

            if (showwindow)
            {

                ImGui.Begin("                      Recoil Mod", ImGuiWindowFlags.NoCollapse | ImGuiWindowFlags.NoResize);

                ImGui.SetWindowSize(windowsize);

                if (ImGui.Button("set x to 0"))
                {
                    slidervaulex = 0;
                }
                ImGui.Separator();
                if (ImGui.Button("set y to 0"))
                {
                    slidervauley = 0;
                }

                ImGui.Separator();

                ImGui.SliderFloat("X Recoil", ref slidervaulex, -100, 100);
                ImGui.SliderFloat("Y Recoil", ref slidervauley, -100, 100);

                ImGui.Separator();

                ImGui.Checkbox("Show Custom Croshair", ref checkbox10);
                ImGui.Checkbox("Show Fov Circle", ref checkbox11);

                ImGui.Separator();

                ImGui.SliderFloat("Circle Size", ref sizeofcircle, 40, 150);
                ImGui.SliderFloat("Croshair Size", ref croshairsize, 20, 150);

                ImGui.Separator();

                if (ImGui.ColorPicker4("Cross Color", ref _crossColor))
                {

                }



                ImGui.End();


            }


            // Set window flags for transparency and no decorations
            ImGuiWindowFlags windowFlags = ImGuiWindowFlags.NoTitleBar |
                                           ImGuiWindowFlags.NoResize |
                                           ImGuiWindowFlags.NoMove |
                                           ImGuiWindowFlags.NoScrollbar |
                                           ImGuiWindowFlags.NoSavedSettings |
                                           ImGuiWindowFlags.NoInputs |
                                           ImGuiWindowFlags.NoFocusOnAppearing |

                                           ImGuiWindowFlags.NoBringToFrontOnFocus;

            Vector2 screenSize = ImGui.GetIO().DisplaySize;

            // Calculate the window size (adjust as needed)
            Vector2 windowSize = new Vector2(300, 300);

            // Calculate the window position to center it on the screen
            Vector2 windowPos = (screenSize - windowSize) / 2;

            // Begin the transparent window
            ImGui.SetNextWindowBgAlpha(0.0f); // Fully transparent background
            ImGui.SetNextWindowPos(windowPos);
            ImGui.SetNextWindowSize(windowSize);
            ImGui.Begin("Transparent Circle Window", windowFlags);

            if ((GetAsyncKeyState(VKk_RBUTTON) & 0x8000) != 0)
            {
                sizeofcircle = 60;
            }
            else
            {
                sizeofcircle = 149;
            }

            // Get the draw list for the window
            ImDrawListPtr drawList = ImGui.GetWindowDrawList();

            // Calculate cross parameters
            Vector2 center = screenSize / 2;
            float size = croshairsize; // Size of the cross (adjust as needed)
            float circlesize = sizeofcircle; // Size of the cross (adjust as needed)

            float thickness = 2; // Thickness of the lines (adjust as needed)
            uint color = ImGui.ColorConvertFloat4ToU32(_crossColor);

            // Calculate the points for the cross
            Vector2 topPoint = new Vector2(center.X, center.Y - size);
            Vector2 bottomPoint = new Vector2(center.X, center.Y + size);
            Vector2 leftPoint = new Vector2(center.X - size, center.Y);
            Vector2 rightPoint = new Vector2(center.X + size, center.Y);

            // Draw the vertical line of the cross

            if (checkbox10)
            {
                drawList.AddLine(topPoint, bottomPoint, color, thickness);

                // Draw the horizontal line of the cross
                drawList.AddLine(leftPoint, rightPoint, color, thickness);
            }

            if (checkbox11)
            {
                drawList.AddCircle(center, circlesize, color);

            }




            ImGui.End();
        }

    }
}