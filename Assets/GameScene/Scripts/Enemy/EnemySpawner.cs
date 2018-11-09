using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {
    public GameObject toInstantiate;
    public bool startToGenerate;
    public float GeneralSpeed;

	void Start () {
        GeneralSpeed = 1f;
	}
	
	void Update () {
        if (startToGenerate == true)
        {
            EnemySpeedUp();
            Generate();
        }
        
	}

    void Generate() {
        int random = Random.Range(0, 10);
        int PoissonRes = Poisson(random);
        int res = PoissonRes * 60;
        if (Time.time >= res)
        {
            GameObject newEnemy = Instantiate(toInstantiate, transform.position, transform.rotation) as GameObject;
            newEnemy.transform.parent = gameObject.transform;
            newEnemy.GetComponent<Enemy>().speed = GeneralSpeed;
        }
    }

    int Poisson(int lambda)
    {
        //Creditos al Profesor Pablo por la ayuda en esta ecuacion;
        //lambda = numero de veces evento en el tiempo
        float random = Random.Range(0, 100);
        int i = 0; //numero de veces el cual hay que multiplicar por unidad de tiempo
        double f = Mathf.Exp(-lambda);
        double p = f;

        while (random >= f)
        {
            p = (lambda / (i + 1)) + p;
            f = f + p;
            i++;
        }

        return i;
    }

    public void EnemySpeedUp()
    {
        int pScore = GameState.Instance.MyPlayerState.PlayerScore;
        if (pScore >= 300 && pScore < 1000)
        {
            GeneralSpeed = 1.2f;
        }
        else if (pScore >= 1000 && pScore < 2500)
        {
            GeneralSpeed = 1.5f;
        }
    }
}
