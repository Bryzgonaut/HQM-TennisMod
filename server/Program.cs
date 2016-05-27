using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HQMEditorDedicated;

namespace HQM_Dedicated_Tennis
{
    class Program
    {
        static void Main(string[] args)
        {
            MemoryEditor.Init();


            Court.Setup(1.5f, 1.2f); //1.5m high net at posts, dips to 1.2 m at center
            string pZoneOld = " ";

            //debug get zone puck is in
            while (true)
            {
                string pZone = Court.GetZone(Puck.Position);

                if (pZoneOld != pZone && Puck.Position.Y < 0.1)
                {
                    Chat.SendMessage(pZone);
                    Console.Beep();
                    pZoneOld = pZone;
                }
                

                if (pZone == "OUT!"&&Puck.Position.Y<0.1)
                {
                    Game.Start();
                    pZoneOld = pZone;
                }

            }

        }
    }
}
