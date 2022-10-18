using System;
using UnityEngine;

namespace Au.TS.Messages
{
    [JSWrap]
    public class MonoUpdate : MonoBehaviour
    {
        public Action action;

        private void Update()
        {
            action?.Invoke();
        }
    }
}
