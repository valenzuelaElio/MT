using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {
    public Color explosionColor;

	void Start () {
        Explode();
	}

    void Explode()
    {
        var explode = GetComponent<ParticleSystem>();
        explode.startColor = explosionColor;
        explode.Play();
        Destroy(gameObject, explode.main.duration);

    }

    public void changeColor(OperationType opType)
    {
        switch (opType)
        {
            case OperationType.SUM:
                explosionColor = Color.red + Color.yellow;
                break;
            case OperationType.SUBSTRACTION:
                explosionColor = Color.green;
                break;
            case OperationType.MULTIPLICATION:
                explosionColor = Color.magenta;
                break;
            case OperationType.DIVISION:
                explosionColor = Color.blue;
                break;
        }
    }

    public void changeColor()
    {
        explosionColor = Color.red;
    }
}
