using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Statemachine
{
    public static GameManager instance = null;

    public static GameManager Instance
    {
        get
        {
            return instance;
        }

    }



    [SerializeField]
    public List<GameSystem> systems;
    [SerializeField]
    public LevelManager currentLevel;
    public UIManager m_UImanager;

    [SerializeField]
    private GameStates startingState;


    private void Awake()
    {
     
        if(instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(this);
        }

        states = new List<GameState>();
        states.Add(new RootState(this));
        states.Add(new LevelOne_State(this));
        states.Add(new LevelOneEnd_State(this));

        SetState(startingState);
    }

    public void InitializeRoot()
    {
  
        if (systems.Count <= 0) return;

        foreach (GameSystem s in systems)
        {
            s.Initialize(this);
            s.onAwake();
            s.onStart();
        }

     
    }

    public void LoadScene(int SceneIndex)
    {
        Debug.Log("LOL");
        SceneManager.LoadScene(SceneIndex);
    }

    public IEnumerator _LoadScene(int SceneIndex)
    {

        AsyncOperation operation = SceneManager.LoadSceneAsync(SceneIndex);
        while(!operation.isDone)
        {
           
            yield return null;
        }

    }       


    public void GetLevelManager()
    {
        currentLevel = GameObject.Find("Level Manager").GetComponent<LevelManager>();
        currentLevel.Initialize(this);
        if(currentLevel !=null)
        {
            currentLevel.onAwake();
        }
    }

}
