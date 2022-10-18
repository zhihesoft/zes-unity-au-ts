using System;
using UnityEngine;

namespace Au.TS.Messages
{
    [JSWrap]
    public class MonoStart : MonoBehaviour
    {
        public Action action;

        void Start()
        {
            action?.Invoke();
        }
    }
}
