using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviourSingleton<ScenesManager>
{
    public string[] scenes;
    private int index = 0;

    public void nextScene()
    {
        SceneManager.LoadScene(Instance.scenes[Instance.index]);
        Instance.index++;
    }

    public void restart()
    {
        Instance.index = 0;
        nextScene();
    }

}
