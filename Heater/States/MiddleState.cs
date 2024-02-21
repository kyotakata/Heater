using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heater.States
{
    public sealed class MiddleState : IState
    {
        public IEnumerable<string> GetCommand()
        {
            return new List<string> { "Mid", "700W" };
        }

        public string GetText()
        {
            return "Mid";
        }

        public void UpState(Context context)
        {
            // 次はHighになりたい
            context.ChangeState(new HighState());

        }

    }
}
