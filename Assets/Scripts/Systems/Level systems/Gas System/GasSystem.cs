using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GasSystem : LevelSystem
{

    [SerializeField]
    List<GasValve> gasValves;
    [SerializeField]
    GasUI m_UI;

    [SerializeField]
    PlayerStats m_stats;

    [SerializeField]
    bool isCollectingGas;

    [SerializeField]
    int GasDepletionValue = 1;

    

    float TickTime =  1;
    private float timer = 0;
    private event UnityAction onGasDepletion;


    public override void Initialize(LevelManager p_manager)
    {
        isCollectingGas = false;
        timer = 0;
        onGasDepletion += p_manager.LevelFailed;

        foreach (GasValve g in gasValves)
        {
            g.Initialize(this);
        }
    }

    public override void onAwake()
    {
        m_stats.GasValue = m_stats.Max_GasValue;
        m_UI.SetGasBar(m_stats.GasValue);


    }

    public override void Refresh()
    {
        if(!isCollectingGas)
        {
            timer += Time.deltaTime;
            if (timer >= TickTime)
            {
                DecreaseGas();
                timer = 0;
            }
        }
        else
        {
            timer += Time.deltaTime;
            if (timer >= 0.10f)
            {
                IncreaseGas();
                timer = 0;
            }
        }

        isCollectingGas = false;
    }
    
    public void collectGas()
    {
        isCollectingGas = true;

    }
    
    public void IncreaseGas()
    {
        if (m_stats.GasValue < 100)
        {
            m_stats.GasValue += 1;
            m_UI.SetGasBar(m_stats.GasValue);
            return;
        }
    }

    public void DecreaseGas()
    {       
        if(m_stats.GasValue >1)
        {
            m_stats.GasValue -= 1;
            m_UI.SetGasBar(m_stats.GasValue);
            return;
        }

        onGasDepletion();
    }



}
