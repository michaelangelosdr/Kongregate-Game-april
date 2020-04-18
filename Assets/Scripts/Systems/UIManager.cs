using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIManager : MonoBehaviour
{

    [SerializeField]
    Color m_fullBlack;
    [SerializeField]
    Color m_zeroBlack;

    [SerializeField]
    Image BlackOverlay;

    [SerializeField]
    Text ScreenText;
    



    public IEnumerator FadeIn(float fadeTime)
    {

        LeanTween.color(BlackOverlay.rectTransform,m_fullBlack,fadeTime);
        yield return new WaitForSeconds(fadeTime);

        yield return null;
    }

    public IEnumerator SetText(string Text,bool isActive)
    {
        ScreenText.text = Text;
        ScreenText.gameObject.SetActive(isActive);

        yield return null;
    }

    public IEnumerator FadeOut(float fadeTime)
    {
        LeanTween.color(BlackOverlay.rectTransform, m_zeroBlack, fadeTime);
        yield return new WaitForSeconds(fadeTime);


        yield break;
    }

}
