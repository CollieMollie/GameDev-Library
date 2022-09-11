using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace CollieMollie.Interactable
{
    public abstract class BaseInteractable : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
    {
        #region Variable Field
        [Header("BaseInteractable")]
        [SerializeField] protected bool _interactable = true;
        public bool IsInteractable
        {
            get => _interactable;
        }

        [SerializeField] protected bool _hovering = false;
        public bool IsHovering
        {
            get => _hovering;
        }

        [SerializeField] protected bool _pressed = false;
        public bool IsPressed
        {
            get => _pressed;
        }

        [SerializeField] protected bool _selected = false;
        public bool IsSelected
        {
            get => _selected;
        }

        [SerializeField] protected bool _dragging = false;
        public bool IsDragging
        {
            get => _dragging;
        }
        #endregion

        #region Pointer Callbacks
        void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData) => InvokeEnterAction(eventData);

        void IPointerExitHandler.OnPointerExit(PointerEventData eventData) => InvokeExitAction(eventData);

        void IPointerDownHandler.OnPointerDown(PointerEventData eventData) => InvokeDownAction(eventData);

        void IPointerUpHandler.OnPointerUp(PointerEventData eventData) => InvokeUpAction(eventData);

        void IPointerClickHandler.OnPointerClick(PointerEventData eventData) => InvokeClickAction(eventData);

        void IBeginDragHandler.OnBeginDrag(PointerEventData eventData) => BeginDragAction(eventData);

        void IDragHandler.OnDrag(PointerEventData eventData) => DragAction(eventData);

        void IEndDragHandler.OnEndDrag(PointerEventData eventData) => EndDragAction(eventData);
        #endregion

        #region Pointer Subscribers
        protected virtual void InvokeEnterAction(PointerEventData eventData = null)
        {
            if (this.GetType() == typeof(BaseInteractable)) return;
        }

        protected virtual void InvokeExitAction(PointerEventData eventData = null)
        {
            if (this.GetType() == typeof(BaseInteractable)) return;
        }

        protected virtual void InvokeDownAction(PointerEventData eventData = null)
        {
            if (this.GetType() == typeof(BaseInteractable)) return;
        }

        protected virtual void InvokeUpAction(PointerEventData eventData = null)
        {
            if (this.GetType() == typeof(BaseInteractable)) return;
        }

        protected virtual void InvokeClickAction(PointerEventData eventData = null)
        {
            if (this.GetType() == typeof(BaseInteractable)) return;
        }

        protected virtual void BeginDragAction(PointerEventData eventData = null)
        {
            if (this.GetType() == typeof(BaseInteractable)) return;
        }

        protected virtual void DragAction(PointerEventData eventData = null)
        {
            if (this.GetType() == typeof(BaseInteractable)) return;
        }

        protected virtual void EndDragAction(PointerEventData eventData = null)
        {
            if (this.GetType() == typeof(BaseInteractable)) return;
        }
        #endregion
    }

    public class InteractableEventArgs
    {
        public BaseInteractable Sender = null;

        public InteractableEventArgs() { }

        public InteractableEventArgs(BaseInteractable sender)
        {
            this.Sender = sender;
        }

        public bool IsValid()
        {
            return Sender != null;
        }
    }
}