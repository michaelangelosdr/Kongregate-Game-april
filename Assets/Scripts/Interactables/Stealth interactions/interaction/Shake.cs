using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shake : InteractionAnimation
{
    

    public override void PlayInteractionAnimation()
    {
        StartCoroutine(ShakeAnimation());
    }

    private IEnumerator ShakeAnimation()
    {
        LeanTween.rotate(gameObject, new Vector3(0, 0, 0), 0);
        //Play sound


        LeanTween.rotate(gameObject, new Vector3(0, 0, 5), 0.10f);
        yield return new WaitForSeconds(0.10f);
        LeanTween.rotate(gameObject, new Vector3(0, 0, -5), 0.10f);
        yield return new WaitForSeconds(0.10f);
        LeanTween.rotate(gameObject, new Vector3(0, 0, 5), 0.10f);
        yield return new WaitForSeconds(0.10f);
        LeanTween.rotate(gameObject, new Vector3(0, 0, -5), 0.10f);
        yield return new WaitForSeconds(0.10f);
        LeanTween.rotate(gameObject, new Vector3(0, 0, 0), 0.10f);


        yield break;
    }
}
