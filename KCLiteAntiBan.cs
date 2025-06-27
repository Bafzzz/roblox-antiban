using System;
using System.Diagnostics;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

public static class __K1C_L1T3_AB
{
// =====================================================
// WARNING: This code is obfuscated for safety reasons.
// Obfuscation helps protect the anti-ban from detection 
// and unauthorized modifications in games.
// Thank you for respecting the effort!
// =====================================================
    private static Mutex __mtx;
    private static readonly HttpClient __h = new HttpClient();

    [DllImport("user32.dll")]
    private static extern int ShowWindow(IntPtr hWnd, int nCmdShow);
    private const int __hide = 0;

    public static void __INIT(Form __frm)
    {
        try
        {
            __A();
            __B(__frm);
            __C(__frm);
            __D();
            __E();
        }
        catch (Exception __ex)
        {
            MessageBox.Show("KC Anti-Ban Error: " + __ex.Message);
        }
    }

    private static void __A()
    {
        string __id = "kc__" + Guid.NewGuid().ToString();
        __mtx = new Mutex(false, __id);
    }

    private static void __B(Form __f)
    {
        Random __r = new Random();
        __f.Text = "KC_" + __r.Next(1000, 9999);
    }

    private static void __C(Form __f)
    {
        __f.ShowInTaskbar = false;
        ShowWindow(Process.GetCurrentProcess().MainWindowHandle, __hide);
    }

    private static async void __D()
    {
        try
        {
            await __h.GetAsync("http://localhost:3000/?event=kc_lite_used");
        }
        catch { }
    }

    private static void __E()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("==== KC::L1T3::ANT1B4N ====");
        Console.WriteLine("[✓] T1TL3_CH4NG3D");
        Console.WriteLine("[✓] MVT3X_OK");
        Console.WriteLine("[✓] T4SKBAR_H1DD3N");
        Console.WriteLine("[✓] ST4TUS: L2 ✅");
        Console.WriteLine("===========================");
        Console.ResetColor();
    }
}