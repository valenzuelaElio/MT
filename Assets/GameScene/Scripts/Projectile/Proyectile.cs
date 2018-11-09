using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectile : MonoBehaviour {

    private OperationType bulletType;
    public OperationType BulletType { get { return bulletType; } set { bulletType = value; } }

    private SpriteRenderer mySpriteRenderer;
    private Animator myAnimator;

	void Start () {
        this.mySpriteRenderer = GetComponent<SpriteRenderer>();
        this.myAnimator = GetComponent<Animator>();
	}
	
	void Update () {
        ChangeType();
        GoRight();
	}

    private void GoRight()
    {
        transform.Translate(Vector2.right * 10 * Time.deltaTime);
    }

    private void ChangeType()
    {
        switch (this.bulletType)
        {
            case OperationType.SUM:
                this.myAnimator.Play("Plus");
                break;

            case OperationType.SUBSTRACTION:
                this.myAnimator.Play("Substraction");
                break;

            case OperationType.MULTIPLICATION:
                this.myAnimator.Play("Multiplication");
                break;

            case OperationType.DIVISION:
                this.myAnimator.Play("Division");
                break;

            case OperationType.NO_TYPE:
                this.mySpriteRenderer.color = Color.white;
                break;

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
}
