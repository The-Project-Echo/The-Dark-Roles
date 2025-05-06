using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using ImGuiNET;
using UnityEngine;

namespace TheDarkRoles.Modules
{
    public static class ImGuiRenderHelper
    {
        // Safe DLL import for IL2CPP
        [DllImport("UnityPlayer", EntryPoint = "GLIssuePluginEvent")]
        private static extern void SafeGLIssueEvent(IntPtr eventPtr, int eventId);

        public static void RenderImGui()
        {
            try
            {
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf<ImDrawData>());
                Marshal.StructureToPtr(ImGui.GetDrawData(), ptr, false);
                SafeGLIssueEvent(ptr, 0);
                Marshal.FreeHGlobal(ptr);
            }
            catch (Exception e)
            {
                Logger.Error($"Safe render failed: {e}", "HostFunctions");
            }
        }
    }
}