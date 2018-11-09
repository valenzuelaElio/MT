using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProyectileGenerator : MonoBehaviour {

    public GameObject toInstantiate;
    private GameObject instantiatedObject;

    private OperationType opType = OperationType.NO_TYPE;
    public OperationType BulletCurrentType { get { return opType; } set { opType = value; } }

    private static ProyectileGenerator cannon = null;
    public static ProyectileGenerator Instance { get { return cannon; } }

    private void Awake()
    {
        if (cannon != null && cannon != this)
        {
            Destroy(this.gameObject);
            return;
        }

        cannon = this;
    }


    void Update()
    {
        ChangeBulletType();

    }

    public void ChangeBulletType()
    {
        if (Input.GetKeyDown(KeyCode.A) )
        {
            opType = OperationType.SUM;
            Debug.Log("Cambio: " + opType);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            opType = OperationType.SUBSTRACTION;
            Debug.Log("Cambio: " + opType);
        }   

        if(Input.GetKeyDown(KeyCode.D))
        {
            opType = OperationType.MULTIPLICATION;
        }

        if(Input.GetKeyDown(KeyCode.F))
        {
            opType = OperationType.DIVISION;
        }

    }

    public void Shoot()
    {
        instantiatedObject = Instantiate(toInstantiate, transform.position, transform.rotation);
        instantiatedObject.GetComponent<Proyectile>().BulletType = opType;
    }


}
