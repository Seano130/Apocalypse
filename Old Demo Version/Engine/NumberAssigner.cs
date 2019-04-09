using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    // You could create a static NumberAssigner class, with a static GetNextNumber method, 
    //that keeps track of a static _nextNumber variable.

    // When a user calls the GetNextNumber method, the code adds 1 to _nextNumber and 
    //returns the value (in this case, 1) to the program. The next time the GetNextNumber method is called,
    //it adds 1 to _nextNumber (resulting in 2 this time) and returns 2 to the program.
    public static class NumberAssigner
    {
        static int _nextNumber = 0;

        public static int GetNextNumber()
        {
            _nextNumber = (_nextNumber + 1);

            return _nextNumber;
        }
    }
}
