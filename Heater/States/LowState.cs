using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heater.States
{
    public sealed class LowState : IState
    {
        public IEnumerable<string> GetCommand()
        {
            return new List<string> { "Lo", "500W" };
        }

        public string GetText()
        {
            return "Lo";
        }

        public void UpState(Context context)
        {
            // Hiにしたい
            context.ChangeState(new HighState());
        }
    }
}
