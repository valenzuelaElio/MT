using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState {

    private int playerLives;
    private int playerScore;
    private bool isDead;

    public int PlayerLives { get { return playerLives; } set { playerLives = value; } }
    public int PlayerScore { get { return playerScore; } set { playerScore = value; } }
    public bool IsDead { get { return isDead; } set { isDead = value; } }

    public PlayerState(ConfigurationGlobal configurationGlobal)
    {
        this.playerLives = configurationGlobal.InitialLives;
    }

    public void loseLive()
    {
        this.playerLives--;
        GameOver();
    }

    public void GameOver()
    {
        if(this.playerLives >= 0)
        {
            return;
        }

        if(this.playerLives < 0)
        {
            isDead = true;
        }
    }



}
