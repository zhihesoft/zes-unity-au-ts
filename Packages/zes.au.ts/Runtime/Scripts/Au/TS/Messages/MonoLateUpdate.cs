using System;
using UnityEngine;

namespace Au.TS.Messages
{
    [JSWrap]
    public class MonoLateUpdate : MonoBehaviour
    {
        public Action action;

        private void LateUpdate()
        {
            action?.Invoke();
        }
    }
}
