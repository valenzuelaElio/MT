using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToMenu : MonoBehaviour {

	public void GoToMenuAction()
    {
        GameState.Instance.LoadScene(GameState.Instance.ConfigurationGlobal.Scenes[0]);
    }
}
