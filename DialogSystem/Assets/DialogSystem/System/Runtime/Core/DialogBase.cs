﻿/**********************************************************
*Author: wangjiaying
*Date: 2016.6.6
*Func:
**********************************************************/

using System.Collections.Generic;

namespace CryDialog.Runtime
{

    abstract public class DialogBase
    {
        public virtual EnumResult Tick(NodeContent content) { return EnumResult.Success; }

        public virtual void ForceStop() { }

        //For Editor
        public UnityEngine.Vector2 _position;
        public string _name;
    }
}
