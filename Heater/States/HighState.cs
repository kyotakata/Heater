using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heater.States
{
    public sealed class HighState : IState
    {

        public IEnumerable<string> GetCommand()
        {
            return new List<string> { "Hi", "1000W"};
        }

        public string GetText()
        {
            return "Hi";
        }

        public void UpState(Context context)
        {
            // 次はOFFになりたい
            context.ChangeState(new OffState());

        }
        public void DownState(Context context)
        {
            context.ChangeState(new MiddleState());
        }

    }
}
