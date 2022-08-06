using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZBase.Utilities;
using ZBase.Classes;
using System.Threading;

namespace ZBase.Cheats
{
    public class Misc
    {
        public static void SetFov(int fov)
        {
            Memory.WriteMemory<int>(G.Engine.LocalPlayer.EntityBase + 0x333C, fov);
        }
    }
}
