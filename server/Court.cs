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

        public static void Setup (float posts, float center)
            {
            HQMVector leftPostTop     = new HQMVector(25f, posts, 30.5f);
            HQMVector leftPostBottom  = new HQMVector(25f, 0, 30.5f);
            HQMVector rightPostTop    = new HQMVector(5f, posts, 30.5f);
            HQMVector rightPostBottom = new HQMVector(5f, 0, 30.5f);
            HQMVector centerTop       = new HQMVector(15f, center, 30.5f);
            HQMVector centerBottom    = new HQMVector(15f, 0, 30.5f);

            const int BLUE_NET_ADDRESS = 0x00CFA974;

            MemoryEditor.WriteHQMVector(leftPostTop, BLUE_NET_ADDRESS);
            MemoryEditor.WriteHQMVector(leftPostBottom, BLUE_NET_ADDRESS + 0xC);
            MemoryEditor.WriteHQMVector(rightPostTop, BLUE_NET_ADDRESS + 0x18);
            MemoryEditor.WriteHQMVector(rightPostBottom, BLUE_NET_ADDRESS + 0x24);
            MemoryEditor.WriteHQMVector(centerTop, BLUE_NET_ADDRESS + 0x3C);
            MemoryEditor.WriteHQMVector(centerBottom, BLUE_NET_ADDRESS + 0x48);
            }
        public static string GetZone(HQMVector target)
        {
            if (target.Z >= 30.5f && Math.Abs(target.X - 15)< DOUBLES_WIDTH)
            {
                if (target.Z<RED_SERVICE_LINE)
                {
                    return "RED SERVICE BOX";
                }
                else if ((target.Z > RED_SERVICE_LINE)&&(target.Z < RED_BASE_LINE))
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
