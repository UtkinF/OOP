using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeLibrary
{
    public class Bomb
    {
        protected bool ActiveBomb { get;private set; }
        public Bomb(bool active)
        {
            ActiveBomb = active;
        }
    }
}
