using System;
using UnityEngine;

namespace Au.TS.Messages
{
    [JSWrap]
    public class MonoEnable : MonoBehaviour
    {
        public Action<bool> action;

        private void OnEnable()
        {
            action?.Invoke(true);
        }

        private void OnDisable()
        {
            action?.Invoke(false);
        }
    }
}
