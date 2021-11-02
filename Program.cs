using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VidzyTask
{
    class Program
    {
        static void Main(string[] args)
        {
            VidzyEntities entities = new VidzyEntities();
            entities.AddVideo("Lol, video", DateTime.Now, "Horror", 1);
        }
    }
}
