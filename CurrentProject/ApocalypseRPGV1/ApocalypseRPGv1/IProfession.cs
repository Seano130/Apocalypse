using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace ApocalypseRPGv1
{
    public interface IProfession
    {
        int MaxSpeed { get; set; }
       Vector Vel { get; set; }
      //  void Move(double time);


    }
}
