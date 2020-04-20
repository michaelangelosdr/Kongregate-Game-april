using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


[RequireComponent(typeof(BoxCollider2D))]
public class GasValve : MonoBehaviour, IInteractable
{
    [SerializeField]
    BoxCollider2D m_Collider;

    [SerializeField]
    int GasValveValue;

    private float timer;

    private event UnityAction CollectGas;

    public void Initialize(GasSystem p_system)
    {
        CollectGas += p_system.collectGas;
    }

    public void Interact()
    {
        if (GasValveValue < 1) return;

        timer += Time.deltaTime;
        if(timer>=1)
        {
            GasValveValue--;
            timer = 0;
        }
        CollectGas();
        if(GasValveValue<=0)
        {
            Debug.Log("NO MORE");
        }
    }

    public IEnumerator _Interact()
    {
        throw new System.NotImplementedException();
    }
}
