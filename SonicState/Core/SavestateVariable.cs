using System;
using System.Collections.Generic;
using System.Text;

namespace SonicState
{
    public class SavestateVariable : Attribute
    {
        public SavestateVariable(int address)
        {
            this.Address = address;
        }

        public int Address { get; private set; }
    }
}
