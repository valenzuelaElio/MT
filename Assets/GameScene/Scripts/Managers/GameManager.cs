using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviourSingleton<GameManager> {

    private bool enabled;
    public ConfigurationGlobal CG;

    void Start () {
        if(GameState.Instance == null)
        {
            GameState.CreateGame(CG);
            enabled = true;
        }
    }

    void Update () {
        switch (GameState.Instance.ActualGameState)
        {
            case GameState.State.Menu:
                SoundManager20.Instance.PlayBgMusic(0);
                GameState.Instance.ActualGameState = GameState.State.Playing;
                break;

            case GameState.State.StartingScene:
                SoundManager20.Instance.PlayBgMusic(1);
                GameState.Instance.MyPlayerState = new PlayerState(CG);
                Initiallize();
                GameState.Instance.ActualGameState = GameState.State.Playing;
                break;

            case GameState.State.LoadingGame:
                GameState.Instance.ActualGameState = GameState.State.StartingScene;
                GameState.Instance.LoadScene(GameState.Instance.ConfigurationGlobal.Scenes[1]);
                break;

            case GameState.State.Playing: //Default; more than playing is waiting for a player input;
                break;

            case GameState.State.Tutorial:
                GameState.Instance.ActualGameState = GameState.State.Playing;
                GameState.Instance.LoadScene(GameState.Instance.ConfigurationGlobal.Scenes[3],1f);
                break;

            case GameState.State.LosingGame:
                SoundManager20.Instance.PlaySingle(3);
                GameState.Instance.ActualGameState = GameState.State.GameOver;
                GameState.Instance.LoadScene(GameState.Instance.ConfigurationGlobal.Scenes[2]);
                break;

            case GameState.State.GameOver:
                break;
        }
	}

    public void Save()
    {
        if (GameState.Instance.ConfigurationGlobal.SavedScore < GameState.Instance.MyPlayerState.PlayerScore)
        {
            GameState.Instance.ConfigurationGlobal.SavedScore = GameState.Instance.MyPlayerState.PlayerScore;
        }
    }

    void Initiallize()
    {
        GameObject.Find("Parallax0").GetComponent<OffSetSroller>().startMoving = enabled;
        GameObject.Find("Parallax1").GetComponent<OffSetSroller>().startMoving = enabled;
        GameObject.Find("Parallax2").GetComponent<OffSetSroller>().startMoving = enabled;
        GameObject.Find("Parallax3").GetComponent<OffSetSroller>().startMoving = enabled;
        GameObject.Find("ScrollingFloor").GetComponent<OffSetSroller>().startMoving = enabled;
        GameObject.Find("EnemySpawner").GetComponent<EnemySpawner>().startToGenerate = enabled;
        //enabled = !enabled;
    }

    public void Play()
    {
        GameState.Instance.ActualGameState = GameState.State.LoadingGame;
    }

    public void SubmitScore()
    {


        GameState.Instance.LoadScene( GameState.Instance.ConfigurationGlobal.Scenes[0] );
    }

    

}
