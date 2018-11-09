using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour {
    [SerializeField] ConfigurationGlobal configurationGlobal;

    public void StartGame()
    {
        /*StartCoroutine(Fade.GetComponent<FadeEffect>().Fading());
        if (GameState.Instance != null)
        {
            Debug.Log("Ya existe un instancia de GameState");
        }
        else
        {
            GameState.CreateGame(configurationGlobal);

        }
        */
        //SoundManager.Instance.PlayMusic(0);
        GameState.Instance.ActualGameState = GameState.State.Tutorial;

    }

    public Text saveScoretext;

    private void Start()
    {
        saveScoretext.text = "" + configurationGlobal.SavedScore;
    }
}
