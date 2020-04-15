using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionAnimation : MonoBehaviour
{
    [SerializeField] private Animation m_Animation;
    [SerializeField] public string InteractionInfo;


    public virtual void PlayInteractionAnimation()
    {
        m_Animation.Play();
    }



}
