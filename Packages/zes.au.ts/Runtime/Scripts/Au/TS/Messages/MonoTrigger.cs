using System;
using UnityEngine;

namespace Au.TS.Messages
{
    [JSWrap]
    public class MonoTrigger : MonoBehaviour
    {
        public Action<Collider> enterAction;
        public Action<Collider> exitAction;
        public Action<Collider> stayAction;

        private void OnTriggerEnter(Collider other)
        {
            enterAction?.Invoke(other);
        }

        private void OnTriggerExit(Collider other)
        {
            exitAction?.Invoke(other);
        }

        private void OnTriggerStay(Collider other)
        {
            stayAction?.Invoke(other);
        }
    }
}
