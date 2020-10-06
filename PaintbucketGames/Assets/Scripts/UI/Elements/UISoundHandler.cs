using System;
using FMODUnity;
using UnityEngine;
using UnityEngine.EventSystems;

namespace PaintbucketGames.UI
{
    public class UISoundHandler : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
    {
        [EventRef] [SerializeField]
        public string MouseClickEvent = "";
        [EventRef] [SerializeField]
        public string MouseEnterEvent = "";
        [EventRef] [SerializeField]
        public string MouseExitEvent = "";

        public void OnPointerClick(PointerEventData eventData)
        {
            if (String.IsNullOrEmpty(MouseClickEvent))
                return;
            
            FMODUnity.RuntimeManager.PlayOneShot(MouseClickEvent);
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            if (String.IsNullOrEmpty(MouseEnterEvent))
                return;
            
            FMODUnity.RuntimeManager.PlayOneShot(MouseEnterEvent);
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            if (String.IsNullOrEmpty(MouseExitEvent))
                return;
            
            FMODUnity.RuntimeManager.PlayOneShot(MouseExitEvent);
        }
    }
}