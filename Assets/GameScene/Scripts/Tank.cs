using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour {

    public GameObject Damage0;
    public GameObject Damage1;
    public GameObject Damage2;

    void Start () {
        Damage0.SetActive(false);
        Damage1.SetActive(false);
        Damage2.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		if(GameState.Instance.MyPlayerState.IsDead == true)
        {
            GameState.Instance.ActualGameState = GameState.State.LosingGame;
        }
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Enemy")
        {
            GameState.Instance.MyPlayerState.loseLive();
        }

        if (GameState.Instance.MyPlayerState.PlayerLives == 2)
        {
            Damage0.SetActive(true);
        } else if (GameState.Instance.MyPlayerState.PlayerLives == 1)
        {
            Damage1.SetActive(true);
        }
        else if (GameState.Instance.MyPlayerState.PlayerLives == 0)
        {
            Damage2.SetActive(true);
        }
    }
}
