using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Au.TS.Messages
{
    [JSWrap]
    public class MonoPointer : MonoBehaviour,
                                IPointerClickHandler,
                                IPointerDownHandler,
                                IPointerUpHandler,
                                IPointerMoveHandler
    {
        public Action<PointerEventData> clickAction;
        public Action<PointerEventData> downAction;
        public Action<PointerEventData> upAction;
        public Action<PointerEventData> moveAction;

        public void OnPointerClick(PointerEventData eventData)
        {
            clickAction?.Invoke(eventData);
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            downAction?.Invoke(eventData);
        }

        public void OnPointerMove(PointerEventData eventData)
        {
            moveAction?.Invoke(eventData);
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            upAction?.Invoke(eventData);
        }
    }
}
