using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimpleButton : MonoBehaviour {

    public OperationType myType;
    public bool Pressed;

    ButtonManager buttonManager;

    public Sprite PressedIMG;
    public Sprite UnPressedIMG;
    private Image MyImage;

    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(onClick);

        buttonManager = GameObject.Find("ButtonPanel").GetComponent<ButtonManager>();

        ChargeSimpleButton();
        this.MyImage = GetComponent<Image>();
    }

    void Update()
    {
        if (Pressed == true)
        {
            this.MyImage.sprite = PressedIMG;
        }
        else
        {
            this.MyImage.sprite = UnPressedIMG;

        }
    }

    public void onClick()
    {
        OperationType currentBulletType = ProyectileGenerator.Instance.BulletCurrentType;
        if(currentBulletType != myType)
        {
            buttonManager.UpdateCurrentPessed(myType);
            ProyectileGenerator.Instance.BulletCurrentType = myType;
        }
    }

    void ChargeSimpleButton()
    {
        switch (myType)
        {
            case OperationType.SUM:
                buttonManager.Sum = gameObject;
                break;

            case OperationType.SUBSTRACTION:
                buttonManager.Res = gameObject;
                break;

            case OperationType.MULTIPLICATION:
                buttonManager.Mul = gameObject;
                break;

            case OperationType.DIVISION:
                buttonManager.Div = gameObject;
                break;
        }


    }
}
