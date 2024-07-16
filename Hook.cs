using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Threading;
using SzlDaRecoilMod;
using WindowsInput;
using WindowsInput.Native;




InputSimulator inputSimulator = new InputSimulator();
Vector2 mouseMovement = new Vector2(0, 0);

Renderer renderer = new Renderer();
renderer.Start().Wait();


[DllImport("user32.dll")]
static extern short GetAsyncKeyState(int vKey);

const int VK_RBUTTON = 0x02;
const int VK_LBUTTON = 0x01;


while  (true)
{


    mouseMovement.Y = renderer.slidervauley;
    mouseMovement.X = renderer.slidervaulex;

    if ((GetAsyncKeyState(VK_RBUTTON) & 0x8000) != 0)
    {
        if ((GetAsyncKeyState(VK_LBUTTON) & 0x8000) != 0)
        {
            inputSimulator.Mouse.MoveMouseBy(
            (int)mouseMovement.X,
            (int)mouseMovement.Y
            );
        }
    }

    Thread.Sleep(10);
}