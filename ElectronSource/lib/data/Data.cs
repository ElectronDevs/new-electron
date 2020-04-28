using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Electron
{
    public static class Data
    {
        public static class NAME
        {
            public static readonly string client = "Electron";
            public static readonly string creator = "Okuchi";
        }

        public static string procName = "Minecraft.Windows";

        public static class Pointer
        {
            // POS 
            public static string PosX = "Minecraft.Windows.exe+0x3055618,0xA8,0x18,0xC8,0x458";
            public static string PosY = "Minecraft.Windows.exe+0x3055618,0xA8,0x18,0xC8,0x45C";
            public static string PosZ = "Minecraft.Windows.exe+0x3055618,0xA8,0x18,0xC8,0x460";
            public static string Pos2X = "Minecraft.Windows.exe+0x3055618,0xA8,0x18,0xC8,0x464";
            public static string Pos2Y = "Minecraft.Windows.exe+0x3055618,0xA8,0x18,0xC8,0x468";
            public static string Pos2Z = "Minecraft.Windows.exe+0x3055618,0xA8,0x18,0xC8,0x46C";

            // Velocity
            public static string VelocityY = "Minecraft.Windows.exe+03055638,0x0,0xC8,0x18,0xA8";

            // Onground
            public static string Onground = "Minecraft.Windows.exe+03090F38,0x18,0x20,0x60,0x568,0x1108,0x70,0x78,0x178";

            // Speed
            public static string Speed = "Minecraft.Windows.exe+03055638,0xa8,0x18,0xc8,0x438,0x18,0xe0,0x8,0x9c";

            // Rapidhit
            public static string Rapidhit = "Minecraft.Windows.exe+03055638,0x210,0x58,0x1E8,0x1E0,0x8,0x100,0x10,0x438";

            // Nofall
            public static string Nofall = "Minecraft.Windows.exe+030506A8,0xC8,0x30,0x0,0x0,0x438,0x18,0x20,0x9C";

            // IngameCoordinates
            public static string ShowCoordinates = "Minecraft.Windows.exe+0x297FF18,0x58,0x10,0x150,0x9a4";

            // FakeCreative (1/2)
            public static string FakeGamemode = "Minecraft.Windows.exe+0x0297FFB0,0x58,0x18,0xf8,0x8,0xf98,0x0,0xc1c";

            // FakeCrative Help (2/2)
            public static string FakeGamemodeHelp = "Minecraft.Windows.exe+0x0299A838,0x80,0x18,0x10,0x40,0x0,0xf98,0x0,0xc1c";

        }

        public static class Module
        {
            public static class Status
            {
                public static bool ChangeOnNextCheck = false;
                public static bool Airjump = false;
                public static bool Speed = false;
                public static bool Rapidhit = false;
                public static bool Nofall = false;
                public static bool ShowCoordinates = false;
                public static bool FakeGamemode = false;
                public static bool Glide = false;
            }

            public static class Value
            {
                public static float Speed = 0.1000000015f;
                public static float GlideVelocityY = 0.02f;
                public static int FakeGamemode = 1;
                public static int AirJump = 16777473;
                public static int Rapidhit = 1;
            }
        }

        public static class DefaultHotKeyProfiles
        {
            public static Key AirJump = Key.NumPad9;
            public static Key Speed = Key.P;
            public static Key Rapidhit = Key.NumPad0;
            public static Key Nofall = Key.NumPad1;
            public static Key ShowCoordinates = Key.NumPad7;
            public static Key FakeCreative = Key.NumPad4;
            public static Key Glide = Key.F;
        }

        public static class ClientSettings
        {
            public static bool EnableDevSettings = false;
        }

        public static class DefaultColors
        {
            public static class gbutton
            {
                public static string on = "#9400D3";
                public static string off = "#7F6400FF";
                public static string locked = "#7F646464";
                public static string trigger = "#7F6400FF";
            }

            public static class gbutton_radio
            {
                public static string active = "#FF8C00";
                public static string inactive = "#FFA500";
            }
        }

        public static class GButtonStatus
        {
            public static class Locked
            {
                public static bool gbutton_module_airjump = false;
                public static bool gbutton_module_speed = false;
                public static bool gbutton_module_glide = true;
                public static bool gbutton_module_rapidhit = false;
                public static bool gbutton_module_nofall = false;
                public static bool gbutton_module_fallfromhightplace = false;
                public static bool gbutton_module_showcoordinates = true;
                public static bool gbutton_module_fakegamemode = true;
                public static bool gbutton_module_teleport = false;
            }
        }
    }
}
