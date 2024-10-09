using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class INPGUI : MonoBehaviour
{
    public Animator animator;


    public void UIAnimation()
    {
        animator.SetTrigger("StarAnim");
    }
}
