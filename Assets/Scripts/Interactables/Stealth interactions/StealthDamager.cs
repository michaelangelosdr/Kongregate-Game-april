using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class StealthDamager : MonoBehaviour
{
    [SerializeField] private int m_Damage;
    [SerializeField] private Collider2D m_Collider;
    [SerializeField] private InteractionAnimation interactionAnimation;

    public int GetDamageValue()
    {
        m_Collider.enabled = false;
        interactionAnimation.PlayInteractionAnimation();
        return m_Damage;
    }
    public string GetDamageInfo()
    {
       return interactionAnimation.InteractionInfo;
    }
}
