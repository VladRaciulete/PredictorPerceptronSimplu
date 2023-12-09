using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredictorPerceptronSimplu
{
    internal class Cell
    {
        public int Taken;
        public int NotTaken;

        public Cell(int taken, int notTaken)
        {
            Taken = taken;
            NotTaken = notTaken;
        }
    }

}
