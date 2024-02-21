using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heater.States
{
    /// <summary>
    /// 状態を同一視するためのインタフェース
    /// </summary>
    public interface IState
    {

        void UpState(Context context);
    }
}
