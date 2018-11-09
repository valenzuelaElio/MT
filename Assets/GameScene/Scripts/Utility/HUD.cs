using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour {
    public Text scoretext;

	void Start () {
        //scoretext.text = "" + GameState.Instance.MyPlayerState.PlayerScore;
	}
	
	void Update () {
        UpdateScore();
	}

    void UpdateScore()
    {
        scoretext.text = "" + GameState.Instance.MyPlayerState.PlayerScore;
    }
}
