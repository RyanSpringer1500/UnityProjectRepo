/** (Ryan Springer) * 
 * (Assignment6) * 
 * (loads levels) */


using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager  : Sinlgeton<GameManager>
{
    public int score;
    public GameObject pauseMenu;

    protected string CurrentLevelName = string.Empty;

    /*#region this code makes this class a singleton
    public  static GameManager instance;
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;

            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            Debug.LogError("Trying to instantiat a second" + "instance of singleton Game Manager");
        }
    }
    #endregion */
    public void LoadLevel(string levelName)
    {
        AsyncOperation ao = SceneManager.LoadSceneAsync(levelName, LoadSceneMode.Additive);
        if(ao == null)
        {
            Debug.LogError("[GameManager]  Unable to load level" + levelName);
            return;
        }
        CurrentLevelName = levelName;
    }
    public void unloadLevel(string levelName)
    {
        AsyncOperation ao = SceneManager.UnloadSceneAsync(levelName);
        if (ao == null)
        {
            Debug.LogError("[GameManager]  Unable to unload level" + levelName);
            return;
        }
       
    }

    public void unloadCurrentLevel()
    {
        AsyncOperation ao = SceneManager.UnloadSceneAsync(CurrentLevelName);
        if (ao == null)
        {
            Debug.LogError("[GameManager]  Unable to unload level" + CurrentLevelName);
            return;
        }
    }


    public void Pause()
    {
        Time.timeScale = 0f;
        pauseMenu.SetActive(true);
    }
    public void Unpause()
    {
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            Pause();
        }
    }

}


