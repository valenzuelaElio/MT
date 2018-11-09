using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameState {

    private static GameState gameState;
    private PlayerState playerState;
    private ConfigurationGlobal configurationGlobal;
    private string myLastScene;

    public static GameState Instance { get { return gameState; } } //Con esto yo trabajo.
    public PlayerState MyPlayerState { get { return playerState; } set { playerState = value; } }
    public ConfigurationGlobal ConfigurationGlobal { get { return configurationGlobal; } }
    public string LastScene { get { return myLastScene; } }

    public enum State
    {
        StartingScene,
        Tutorial,
        Playing,
        Paused,
        LoadingGame,
        LosingGame,
        GameOver,
        Menu

    }
    private State myState;
    public State ActualGameState { get { return myState; } set { myState = value; } }

    private GameState(ConfigurationGlobal configGlobal)
    {
        configurationGlobal = configGlobal;
    }

    public static void CreateGame(ConfigurationGlobal configurationGlobal)
    {
        gameState = new GameState(configurationGlobal);
        gameState.ActualGameState = State.Menu;
        //gameState.Starting();
    }

    public void Starting()
    {
        if (configurationGlobal.TutorialIsEnabled == true)
        {
            ActualGameState = State.Tutorial;
            LoadScene(configurationGlobal.Scenes[3]);
        }
        else
        {
            ActualGameState = State.StartingScene;
            LoadScene(ConfigurationGlobal.Scenes[0]);
        }

    }

    public void LoadScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
        myLastScene = SceneName;
    }

    public void LoadScene(string SceneName, float timeToGo)
    {

        SceneManager.LoadScene(SceneName);
        myLastScene = SceneName;
    }

    public void ReloadScene()
    {
        LoadScene(myLastScene);
    }




	
}
