using Dalamud.Hooking;
using Dalamud.Logging;
using FFXIVClientStructs.FFXIV.Client.Game.Character;
using FFXIVClientStructs.FFXIV.Client.Game.Object;
using H.Pipes;
using Lumina.Excel.GeneratedSheets;
using PixelPerfectEx;
using PixelPerfectEx.IPC;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PiPiPlugin.PluginModule
{
    public class TestHack : IPluginModule
    {


        public static bool Enabled { get; private set; }

        private static IntPtr TestHackHookIntptr = IntPtr.Zero;
        private static Hook<TestHackHookDelegate> TestHackHook;
        private unsafe delegate long TestHackHookDelegate(IntPtr a1);


        private unsafe static long TestHackHookDetour(IntPtr a1)
        {
            try
            {

            }
            catch (Exception ex)
            {
                PluginLog.Error(ex.Message);
                PluginLog.Error(ex.StackTrace);
            }
            return TestHackHook.Original(a1);

        }


        public static void DrawSetting()
        {
        }

        public static void Init()
        {
            try
            {
                //TestHackHookIntptr = Service.Address.BaseAddress + 0x12f6210;//停止移动


                //TestHackHook ??= Hook<TestHackHookDelegate>.FromAddress(TestHackHookIntptr, TestHackHookDetour);
                //TestHackHook.Enable();


                //Enabled = true;
            }
            catch (Exception ex)
            {

                PluginLog.Error(ex.Message);
                PluginLog.Error(ex.StackTrace);
            }

        }
        public static void Dispose()
        {
            TestHackHook.Disable();
            TestHackHook.Dispose();
            Enabled = false;
        }


        
    }

    
    
}
