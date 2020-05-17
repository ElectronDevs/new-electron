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

            // Velocity -idk if this shit works, it its glide, uh no
            public static string VelocityY = "Minecraft.Windows.exe+03055638,0x0,0xC8,0x18,0xA8";

            // Onground -dont work anymore
            public static string Onground = "Minecraft.Windows.exe+0x3022668,0x30,0x28,0x8,0x1F8,0x1F0,0x0,0xF0,0x178";

            // Speed -works
            public static string Speed = "Minecraft.Windows.exe+03055638,0xa8,0x18,0xc8,0x438,0x18,0xe0,0x8,0x9c";

            // Rapidhit -dont work
            public static string Rapidhit = "Minecraft.Windows.exe+03055638,0x199,0x131,0x148,0x1,0x0,0x0,0x0,0x0,0x0,0x0,0x144,0x144";

            // highjump -dont work
            public static string highjump = "Minecraft.Windows.exe+0307CF18,0xF0,0x138,0xB0,0x8B0,0xC0";

            // bhop -dont work
            public static string bhop = "Minecraft.Windows.exe+0307CF18,0xF0,0x138,0xB0,0x8B0,0xC0";

            // instabreak -dont work
            public static string instabreak = "Minecraft.Windows.exe+0x14A6125,0x20,0x57,0x11,0x0F,0xF3";

            // step -dont work
            public static string step = "Minecraft.Windows.exe+0307CF18,0xF0,0x138,0xB0,0x8B0,0xC0";

            // reach -dont work
            public static string reach = "Minecraft.Windows.exe+0307CF18,0xF0,0x138,0xB0,0x8B0,0xC0";

            // Nofall -dont work
            public static string Nofall = "Minecraft.Windows.exe+03055638,0x199,0x131,0x148,0x1,0x0,0x0,0x0,0x0,0x0,0x0,0x144,0x144";

            // Noknockback -dont work
            public static string noknockback = "Minecraft.Windows.exe+03055638,0x199,0x131,0x148,0x1,0x0,0x0,0x0,0x0,0x0,0x0,0x144,0x144";

            // IngameCoordinates -dont work
            public static string ShowCoordinates = "Minecraft.Windows.exe+0x297FF18,0x58,0x10,0x150,0x9a4";

            // killaura -dont work
            public static string killaura = "Minecraft.Windows.exe+0x297FF18,0x58,0x10,0x150,0x9a4";

            // fullbright -dont work
            public static string fullbright = "Minecraft.Windows.exe+0x2FFECD8,0xC0,0x20,0xB0,0x138,0xF0";

            // FakeCreative (1/2) -dont work
            public static string FakeGamemode = "Minecraft.Windows.exe+0x0297FFB0,0x1E74";

            // FakeCrative Help (2/2) -cube wtf is this
            public static string FakeGamemodeHelp = "Minecraft.Windows.exe+0x0299A838,0x80,0x18,0x10,0x40,0x0,0xf98,0x0,0xc1c";

        }

        public static class Module
        {
            public static class Status
            {
                public static bool ChangeOnNextCheck = false;
                public static bool Airjump = false;
                public static bool reach = false;
                public static bool fullbright = false;
                public static bool highjump = false;
                public static bool bhop = false;
                public static bool killaura = false;
                public static bool step = false;
                public static bool instabreak = false;
                public static bool noknockback = false;
                public static bool phase = false;
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
                public static float fullbright = 10f;
                public static float reach = 7f;
                public static int FakeGamemode = 1;
                public static int AirJump = 16777473;
                public static int Rapidhit = 0x1;
            }
        }

        public static class DefaultHotKeyProfiles
        {
            public static Key AirJump = Key.L;
            public static Key highjump = Key.NumPad4;
            public static Key reach = Key.NumPad2;
            public static Key Speed = Key.NumPad8;
            public static Key fullbright = Key.N;
            public static Key Rapidhit = Key.NumPad0;
            public static Key Nofall = Key.NumPad1;
            public static Key noknockback = Key.NumPad3;
            public static Key ShowCoordinates = Key.NumPad7;
            public static Key FakeCreative = Key.NumPad4;
            public static Key Glide = Key.F;
            public static Key bhop = Key.R;
            public static Key step = Key.M;
            public static Key killaura = Key.O;
            public static Key instabreak = Key.J;
            public static Key phase = Key.P;
        }

        public static class ClientSettings
        {
            public static bool EnableDevSettings = false;
        }

        public static class DefaultColors
        {
            public static class gbutton
            {
                public static string on = "#3e9fb3";
                public static string off = "#393f4d";//12343b
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
                public static bool gbutton_module_airjump = true;
                public static bool gbutton_module_killaura = true;
                public static bool gbutton_module_highjump = true;
                public static bool gbutton_module_noknockback = true;
                public static bool gbutton_module_phase = true;
                public static bool gbutton_module_reach = true;
                public static bool gbutton_module_fullbright = true;
                public static bool gbutton_module_instabreak = true;
                public static bool gbutton_module_step= true;
                public static bool gbutton_module_bhop = true;
                public static bool gbutton_module_speed = false;
                public static bool gbutton_module_glide = true;
                public static bool gbutton_module_rapidhit = true;
                public static bool gbutton_module_nofall = true;
                public static bool gbutton_module_fallfromhightplace = true;
                public static bool gbutton_module_showcoordinates = true;
                public static bool gbutton_module_fakegamemode = true;
                public static bool gbutton_module_teleport = false;
            }
        }
    }
}
