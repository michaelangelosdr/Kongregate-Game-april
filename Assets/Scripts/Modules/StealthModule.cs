using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StealthModule : GameModule
{
    [SerializeField] private int Max_StealthValue;
    [SerializeField] private float StealthValueMultiplier;
    [SerializeField] public int StealthValue;
    [SerializeField] private StealthBarUI stealthBarUI;




    public override void onAwake()
    {
        if (stealthBarUI == null)
        {
            stealthBarUI = GameObject.Find("Stealth Bar Canvas").GetComponent<StealthBarUI>();
        }

        stealthBarUI.SetStealthBarVal(StealthValue, "Game start");
    }

    public override void onStart()
    {       
       stealthBarUI.SetStealthBarVal(StealthValue,"Game start");
    }

    public override void Refresh()
    {
        //Debug.Log(StealthValue);
        //stealthBarUI.SetStealthBarVal(StealthValue ," ");  
    }

    public void Found()
    {
        StealthValue = StealthValue - (int)(Time.deltaTime * StealthValueMultiplier);
        stealthBarUI.SetStealthBarVal(StealthValue);
    }
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Stealth Damager Object"))
        {
            StealthDamager d = collision.GetComponent<StealthDamager>();

            StealthValue -=d.GetDamageValue();
            stealthBarUI.SetStealthBarVal(StealthValue, d.GetDamageInfo());
        }
    }

}
