using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heater.States
{
    public sealed class OffState : IState
    {
        public IEnumerable<string> GetCommand()
        {
            return new List<string> { "OFF", "0W" };
        }

        public string GetText()
        {
            return "OFF";
        }

        public void UpState(Context context)
        {
            throw new OffException();
        }
        public void DownState(Context context)
        {
            throw new OffException();
        }

        public void OnOffState(Context context)
        {
            context.ChangeState(new LowState());

        }

    }
}
