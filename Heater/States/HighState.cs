using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heater.States
{
    public sealed class HighState : IState
    {
        public string GetText()
        {
            return "Hi";
        }

        public void UpState(Context context)
        {
            // 次はOFFになりたい
            context.ChangeState(new OffState());

        }
    }
}
