using System;
using UnityEngine;

namespace Au.TS.Messages
{
    [JSWrap]
    public class MonoCollision : MonoBehaviour
    {
        public Action<Collision> enterAction;
        public Action<Collision> exitAction;
        public Action<Collision> stayAction;

        private void OnCollisionEnter(Collision collision)
        {
            enterAction?.Invoke(collision);
        }

        private void OnCollisionExit(Collision collision)
        {
            exitAction?.Invoke(collision);
        }

        private void OnCollisionStay(Collision collision)
        {
            stayAction?.Invoke(collision);
        }
    }
}
