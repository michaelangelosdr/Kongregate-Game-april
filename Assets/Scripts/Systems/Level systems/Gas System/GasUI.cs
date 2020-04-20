using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GasUI : MonoBehaviour
{

    [SerializeField] Slider m_GasSlider;
    [SerializeField] Text m_GasValueText;



    public void SetGasBar(int p_val)
    {
        SetSliderValue(p_val);
        SetValueText(p_val);
    }

    public void SetSliderValue(int p_val)
    {
        if(p_val >=0 && p_val<=100)
        {
            m_GasSlider.value = p_val;
        }  
    }

    public void SetValueText(int p_text)
    {
        if (p_text >= 10)
        {
            m_GasValueText.text = p_text.ToString() +"/100";
        }
        else
        {
            m_GasValueText.text = "0" + p_text.ToString() +"/100";
        }
    }
    

}
