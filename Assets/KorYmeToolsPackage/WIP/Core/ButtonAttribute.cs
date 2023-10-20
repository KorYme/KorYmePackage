using System;
using UnityEngine;

namespace KorYmeLibrary.Attributes
{
    [AttributeUsage(AttributeTargets.Method)]
    public class ButtonAttribute : PropertyAttribute
    {
        protected string _methodName;
        public string MethodName => _methodName;

        public ButtonAttribute(string methodName = "Button")
        {
            _methodName = methodName;
        }
    }
}
