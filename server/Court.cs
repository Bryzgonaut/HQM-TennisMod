using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HQMEditorDedicated;

namespace HQM_Dedicated_Tennis
{
    class Court
    {
        const float RED_SERVICE_LINE = 30.5f + 6.40f;
        const float BLUE_SERVICE_LINE = 30.5f - 6.40f;
        const float RED_BASE_LINE = 30.5f + 11.89f;
        const float BLUE_BASE_LINE = 30.5f - 11.89f;
        const float SINGLES_WIDTH = 8.3f / 2;
        const float DOUBLES_WIDTH = 10.97f / 2;

        public static void Setup(float posts, float center)
        {
            HQMVector RIGHT_FRONT_BOTTOM = new HQMVector(21.485f, 1.1f, 30.5f);
            HQMVector LEFT_FRONT_BOTTOM  = new HQMVector(8.515f, 0.9f, 30.5f);
            HQMVector LEFT_BACK_BOTTOM   = new HQMVector(13.75f, 1.1f, 30.5f);
            HQMVector RIGHT_BACK_BOTTOM  = new HQMVector(16.25f, 0.9f, 30.5f);
            HQMVector RIGHT_FRONT_TOP    = new HQMVector(21.485f, 0, 30.5f);
            HQMVector LEFT_FRONT_TOP     = new HQMVector(8.515f, 0, 30.5f);
            HQMVector LEFT_BACK_TOP      = new HQMVector(13.75f, 0, 30.5f);
            HQMVector RIGHT_BACK_TOP     = new HQMVector(16.25f, 0, 30.5f);

        const int BLUE_NET_ADDRESS = 0x00CFA974;

            MemoryEditor.WriteHQMVector(RIGHT_FRONT_BOTTOM, BLUE_NET_ADDRESS);
            MemoryEditor.WriteHQMVector(LEFT_FRONT_BOTTOM, BLUE_NET_ADDRESS + 0xC);
            MemoryEditor.WriteHQMVector(LEFT_BACK_BOTTOM, BLUE_NET_ADDRESS + 0x18);
            MemoryEditor.WriteHQMVector(RIGHT_BACK_BOTTOM, BLUE_NET_ADDRESS + 0x24);
            MemoryEditor.WriteHQMVector(RIGHT_FRONT_TOP, BLUE_NET_ADDRESS + 0x30);
            MemoryEditor.WriteHQMVector(LEFT_FRONT_TOP, BLUE_NET_ADDRESS + 0x3C);
            MemoryEditor.WriteHQMVector(LEFT_BACK_TOP, BLUE_NET_ADDRESS + 0x48);
            MemoryEditor.WriteHQMVector(RIGHT_BACK_TOP, BLUE_NET_ADDRESS + 0x54);
        }
        public static string GetZone(HQMVector target)
        {
            if (target.Z >= 30.5f && Math.Abs(target.X - 15) < DOUBLES_WIDTH)
            {
                if (target.Z < RED_SERVICE_LINE)
                {
                    return "RED SERVICE BOX";
                }
                else if ((target.Z > RED_SERVICE_LINE) && (target.Z < RED_BASE_LINE))
                {
                    return "RED BACK COURT";
                }
                else
                {
                    return "OUT!";
                }
            }
            else if (target.Z < 30.5f && Math.Abs(target.X - 15) < DOUBLES_WIDTH)
            {
                if (target.Z > BLUE_SERVICE_LINE)
                {
                    return "BLUE SERVICE BOX";
                }
                else if ((target.Z < BLUE_SERVICE_LINE) && (target.Z > BLUE_BASE_LINE))
                {
                    return "BLUE BACK COURT";
                }
                else
                {
                    return "OUT!";
                }
            }
            else
            {
                return "OUT!";

            }
        }
    }
}
