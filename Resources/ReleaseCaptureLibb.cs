using System.Runtime.InteropServices;

namespace CuatroCuadras
{
    public class ReleaseCaptureLibb
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        public static extern void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        public static extern void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
    }
}
