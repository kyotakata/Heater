using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heater.States
{
    public sealed class Context
    {
        private IState _state = new OffState();    // 現在の状態を保持


    }
}
