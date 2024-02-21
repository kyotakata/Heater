﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heater.States
{
    public sealed class Context
    {
        private IState _state = new OffState();    // 現在の状態を保持

        // Clientに公開する窓口を作る
        public void Up()
        {
            _state.UpState(this);

            string path = "heater.txt";
            File.WriteAllLines(path, _state.GetCommand());

        }

        public string GetText()
        {
            return _state.GetText();
        }

        internal void ChangeState(IState state)
        {
            _state = state;
        }
    }
}
