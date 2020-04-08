using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


[CustomEditor(typeof(Enemy))]
public class EnemyEditor : Editor
{
    private void OnSceneViewGUI(SceneView sv)
    {
        Enemy ac = target as Enemy;

        //foreach(ActorAction a in ac.m_Actions)
        //{
        //    a.path.startPoint = Handles.PositionHandle(a.path.startPoint, Quaternion.identity);
        //}
        for (int x = 0; x < ac.m_Actions.Length; x++)
        {
            ac.m_Actions[x].path.startPoint = Handles.PositionHandle(ac.m_Actions[x].path.startPoint, Quaternion.identity);
            ac.m_Actions[x].path.endPoint = Handles.PositionHandle(ac.m_Actions[x].path.endPoint, Quaternion.identity);
            ac.m_Actions[x].path.startControl = Handles.PositionHandle(ac.m_Actions[x].path.startControl, Quaternion.identity);
            ac.m_Actions[x].path.endControl = Handles.PositionHandle(ac.m_Actions[x].path.endControl, Quaternion.identity);

            Handles.DrawBezier(ac.m_Actions[x].path.startPoint,
                ac.m_Actions[x].path.endPoint,
                ac.m_Actions[x].path.startControl,
                ac.m_Actions[x].path.endControl, Color.red, null, 2f);
        }

    }

    void OnEnable()
    {
        Debug.Log("OnEnable");
        SceneView.onSceneGUIDelegate += OnSceneViewGUI;
    }
    void OnDisable()
    {
        Debug.Log("OnDisable");
        SceneView.onSceneGUIDelegate -= OnSceneViewGUI;
    }
}
