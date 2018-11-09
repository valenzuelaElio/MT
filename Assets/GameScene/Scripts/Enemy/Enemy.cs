using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    EnemyState enemyState;
    GameObject limitToSpawn;
    Vector2 limitToSpawnPosition;
    public float speed;
    public GameObject explosionPref;

	void Start () {
        this.enemyState = GetComponent<EnemyState>();
        this.limitToSpawnPosition = GameObject.Find("limitToSpawn").GetComponent<Transform>().position;

	}
	
	void Update () {
        //Movimiento sin fisica
        GoToLeft();
        VerifyPosition();
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            GameObject expl = Instantiate(explosionPref, transform.position, Quaternion.identity) as GameObject;
            expl.GetComponent<Explosion>().changeColor();
            Destroy(gameObject);
        }

        if(collision.collider.tag == "Projectile")
        {
            OperationType ot = collision.collider.GetComponent<Proyectile>().BulletType;
            this.enemyState.Damaged(ot);
            this.enemyState.VerifyState(explosionPref, ot);
        }
    }

    void GoToLeft()
    {
        gameObject.transform.Translate(Vector3.left * Time.deltaTime * speed);
    }

    void VerifyPosition()
    {
        if (this.transform.position.x >= limitToSpawnPosition.x)
        {
            GameObject.Find("EnemySpawner").GetComponent<EnemySpawner>().startToGenerate = false;
        }
        else
        {
            GameObject.Find("EnemySpawner").GetComponent<EnemySpawner>().startToGenerate = true;
        }
    }

}
