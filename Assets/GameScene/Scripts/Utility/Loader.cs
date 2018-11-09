using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Loader : MonoBehaviour {

    public GameObject gameManager;
    public GameObject scenesManager;
    public GameObject soundManager;

	void Awake()
    {
        if(GameManager.Instance == null)
        {
            Instantiate(gameManager);
            
        }

        if (ScenesManager.Instance == null)
        {
            Instantiate(scenesManager);
        }

        if(SoundManager.Instance == null)
        {
            Instantiate(soundManager);
        }
    }
}
