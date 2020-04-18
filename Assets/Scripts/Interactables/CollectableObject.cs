using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


[RequireComponent(typeof(SpriteRenderer))]
public class CollectableObject : MonoBehaviour, IInteractable
{

    [SerializeField]
    public CollectableTypes m_objectType;
    [SerializeField]
    private SpriteRenderer m_renderer;
    [SerializeField]
    private Sprite DefaultSprite;
    [SerializeField]
    public Sprite CollectedSprite;

    [HideInInspector]
    public bool isCollected;

    private event UnityAction<CollectableTypes> onCollectAction;


    public void Initialize(CollectableSystem p_system)
    {
        onCollectAction += p_system.Collected;
        isCollected = false; 
    }

    public void Interact()
    {
        if (isCollected) return;


        Debug.Log("TEST");
        isCollected = true;
        Animatecollect();
        onCollectAction(m_objectType);
        
    }

    public IEnumerator _Interact()
    {
        yield break;
    }

    private void Animatecollect()
    {
        LeanTween.scale(gameObject, new Vector3(0, 0, 0), 0.25f).setEaseInBack().setOnComplete(() => { gameObject.SetActive(false); });
    }


}


/// <summary>
/// Yes I am aware that this is a bad way but for now we have 2 collectable types 
/// 
/// </summary>
public enum CollectableTypes
{
    EGGS,
    ARTIFACT

}