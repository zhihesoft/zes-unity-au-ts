using System;
using UnityEngine;

namespace Au.TS.Messages
{
    [JSWrap]
    public class MonoDestroy : MonoBehaviour
    {
        public Action action;

        private void OnDestroy()
        {
            action?.Invoke();
        }
    }
}
