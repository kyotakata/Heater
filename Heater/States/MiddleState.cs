using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heater.States
{
    public sealed class MiddleState : IState
    {
        private MiddleState()
        {
        }

        public static MiddleState Instance { get; } = new MiddleState();

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
            context.ChangeState(HighState.Instance);

        }

        public void DownState(Context context)
        {
            context.ChangeState(LowState.Instance);
        }

        public void OnOffState(Context context)
        {
            context.ChangeState(OffState.Instance);

        }

    }
}
