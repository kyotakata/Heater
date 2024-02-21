﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heater.States
{
    public sealed class LowState : IState
    {
        public void UpState(Context context)
        {
            // Hiにしたい
            context.ChangeState(new HighState());
        }
    }
}
