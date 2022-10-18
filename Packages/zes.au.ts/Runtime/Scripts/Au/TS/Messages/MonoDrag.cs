using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Au.TS.Messages
{
    [JSWrap]
    public class MonoDrag : MonoBehaviour,
                            IBeginDragHandler,
                            IDragHandler,
                            IEndDragHandler
    {
        public Action<PointerEventData> beginAction;
        public Action<PointerEventData> endAction;
        public Action<PointerEventData> dragAction;

        public void OnBeginDrag(PointerEventData eventData)
        {
            beginAction?.Invoke(eventData);
        }

        public void OnDrag(PointerEventData eventData)
        {
            dragAction?.Invoke(eventData);
        }

        public void OnEndDrag(PointerEventData eventData)
        {
            endAction?.Invoke(eventData);
        }
    }
}
