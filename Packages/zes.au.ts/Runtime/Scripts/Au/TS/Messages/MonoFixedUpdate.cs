using System;
using UnityEngine;

namespace Au.TS.Messages
{
    [JSWrap]
    public class MonoFixedUpdate : MonoBehaviour
    {
        public Action action;

        private void FixedUpdate()
        {
            action?.Invoke();
        }
    }
}
