﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Or : Component
    {
        bool? holder;
        public override void execute(bool input)
        {
            if (holder == null)
            {
                holder = input;
            }
            else
            {
                bool value = ((bool)holder || input);
                sendToNext(value);
            }
        }

        public override string getKey()
        {
            return "OR";
        }

        public override object Clone()
        {
            return new Or();
        }
    }
}
