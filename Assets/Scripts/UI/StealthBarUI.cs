﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class StealthBarUI : MonoBehaviour
{

    [SerializeField] Slider m_StealthBarSlider;
    [SerializeField] Image m_StealthBardFillImage;
    [SerializeField] Text m_StealthBarLabel;
    [SerializeField] Text m_StealthBarInfoLabel;

    [SerializeField] private Color Startcolor;
    [SerializeField] private Color Endcolor;

    [SerializeField] private float color;

    public void SetStealthBarVal(int p_Value)
    {
        m_StealthBarSlider.value = p_Value;
        StartCoroutine(ShowInfo());
        m_StealthBardFillImage.color = Color.LerpUnclamped(Endcolor, Startcolor,(100/p_Value));
    }

    public void SetStealthBarVal(int p_Value, string p_InformationString)
    {
        m_StealthBarSlider.value = p_Value;
        StartCoroutine(ShowInfo(p_InformationString));
        m_StealthBardFillImage.color = Color.LerpUnclamped(Endcolor, Startcolor, (100 / p_Value));
    }

    public IEnumerator ShowInfo(string info ="*beep*")
    {
        m_StealthBarInfoLabel.text = info;
        LeanTween.textColor(m_StealthBarInfoLabel.rectTransform, new Color(0, 0, 0, 0), 0);

        LeanTween.textColor(m_StealthBarInfoLabel.rectTransform, Color.black, 0.25f);
        yield return new WaitForSeconds(2);

        LeanTween.textColor(m_StealthBarInfoLabel.rectTransform, new Color(0, 0, 0, 0), 0.25f);


        yield break;
    }

}
