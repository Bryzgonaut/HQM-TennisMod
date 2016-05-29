using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HockeyEditor;

namespace HQM_Tennis
{
    class Program
    {
        static void Main(string[] args)
        {
            MemoryEditor.Init();
            Court.Setup();
        }
    }
}
