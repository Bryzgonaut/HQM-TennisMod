using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HQMEditorDedicated;

namespace HQM_Dedicated_Tennis
{
    class Game
    {
        public static void Start()
        {
            HQMVector redServicePoint = new HQMVector(19f, 1f, 40.5f);
            Puck.Position = redServicePoint;
            Puck.Velocity = new HQMVector(0f, 0f, 0f);
            
        }
    



    }
}
