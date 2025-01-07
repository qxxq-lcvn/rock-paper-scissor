using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonHoverAnimator : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        animator.SetBool("IsHovering", true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        animator.SetBool("IsHovering", false);
    }

    //public void OnPointerClick(PointerEventData eventData)
    //{
    // animator.SetBool("IsHovering", false); // Stop pulsing on click
    // Add any other click functionality here (like loading a new scene)
    //}
    public void OnPointerClick(PointerEventData eventData)
    {
        animator.enabled = false; // Completely stops the Animator
                                  // Add any other click functionality here (like loading a new scene)
    }
}

