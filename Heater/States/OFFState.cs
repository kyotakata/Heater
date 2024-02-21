using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heater.States
{
    public sealed class OffState : IState
    {
        public string GetText()
        {
            return "OFF";
        }

        public void UpState(Context context)
        {
            // Lowになりたい
            context.ChangeState(new LowState());

        }
    }
}
