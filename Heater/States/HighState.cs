using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heater.States
{
    public sealed class HighState : IState
    {
        private HighState()
        {
        }

        public static HighState Instance { get; } = new HighState();

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
            context.ChangeState(LowState.Instance);

        }
        public void DownState(Context context)
        {
            context.ChangeState(MiddleState.Instance);
        }

        public void OnOffState(Context context)
        {
            context.ChangeState(OffState.Instance);

        }
    }
}
