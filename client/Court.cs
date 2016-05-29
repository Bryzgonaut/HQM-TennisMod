using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HockeyEditor;

namespace HQM_Tennis
{
    class Court
    {
        public static void Setup()
        {
            Net.BlueNet.LeftBackBottom = new HQMVector(13.75f, 0.9f, 30.5f);
            Net.BlueNet.LeftFrontBottom = new HQMVector(8.515f, 1.1f, 30.5f);
            Net.BlueNet.RightBackBottom = new HQMVector(16.25f, 0.9f, 30.5f);
            Net.BlueNet.RightFrontBottom = new HQMVector(21.485f, 1.1f, 30.5f);
            Net.BlueNet.LeftBackTop = new HQMVector(13.75f, 0f, 30.5f);
            Net.BlueNet.LeftFrontTop = new HQMVector(8.515f, 0f, 30.5f);
            Net.BlueNet.RightBackTop = new HQMVector(16.25f, 0f, 30.5f);
            Net.BlueNet.RightFrontTop = new HQMVector(21.485f, 0f, 30.5f);
        }
    }
}
