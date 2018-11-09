using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour {

    public GameObject Sum;
    public GameObject Res;
    public GameObject Mul;
    public GameObject Div;

    private static SimpleButton currentPressed;

    void Start () {
        Sum.GetComponent<SimpleButton>().Pressed = false;
        Res.GetComponent<SimpleButton>().Pressed = false;
        Mul.GetComponent<SimpleButton>().Pressed = false;
        Div.GetComponent<SimpleButton>().Pressed = false;

    }
	
    public void UpdateCurrentPessed(OperationType operationType)
    {
        switch (operationType)
        {
            case OperationType.SUM:
                Sum.GetComponent<SimpleButton>().Pressed = true;
                Res.GetComponent<SimpleButton>().Pressed = false;
                Mul.GetComponent<SimpleButton>().Pressed = false;
                Div.GetComponent<SimpleButton>().Pressed = false;
                break;

            case OperationType.SUBSTRACTION:
                Sum.GetComponent<SimpleButton>().Pressed = false;
                Res.GetComponent<SimpleButton>().Pressed = true;
                Mul.GetComponent<SimpleButton>().Pressed = false;
                Div.GetComponent<SimpleButton>().Pressed = false;
                break;

            case OperationType.MULTIPLICATION:
                Sum.GetComponent<SimpleButton>().Pressed = false;
                Res.GetComponent<SimpleButton>().Pressed = false;
                Mul.GetComponent<SimpleButton>().Pressed = true;
                Div.GetComponent<SimpleButton>().Pressed = false;
                break;

            case OperationType.DIVISION:
                Sum.GetComponent<SimpleButton>().Pressed = false;
                Res.GetComponent<SimpleButton>().Pressed = false;
                Mul.GetComponent<SimpleButton>().Pressed = false;
                Div.GetComponent<SimpleButton>().Pressed = true;
                break;
        }

    }


}
