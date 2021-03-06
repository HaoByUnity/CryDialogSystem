﻿/**********************************************************
*Author: wangjiaying
*Date: 2016.7.11
*Func:
**********************************************************/
using UnityEngine;

namespace CryDialog.Runtime
{
    [Help("设置作用域为当前Mission的变量的值")]
    [Category("System/Values")]
    public class SetValue : Action
    {
        [ValueNameSelect]
        public string ValueName;
        [ValueKeyReference("ValueName")]
        public ValueFunctor Functor;
        [ValueKeyReference("ValueName")]
        public string Value;

        protected override EnumResult OnStart()
        {
            GetValueContainer._valueContainer[ValueName].OperationValue(Functor, Value);
            return EnumResult.Success;
        }

        public override string ToDescription()
        {
            return "设置变量 [" + ValueName + "] " + Functor + " [" + Value + "]";
        }
    }
}