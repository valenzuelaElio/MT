using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemyState : MonoBehaviour {

    Dictionary<string, bool > answerOptions;

    private int questionConstant;

    private int questionLimit;
    private int randomQuestion;
    private string question;
    public TextMesh questionBox;

    QuestionClass questionClass;
    public QuestionClass QuestionClass { get { return questionClass; } }

	void Start () {
        this.questionClass = new QuestionClass();

        this.questionBox.text = "" + questionClass.Question;

        //Escojo la contante del puntaje en base a la cantidad de preguntas (dificultad)
        switch (this.questionClass.Dificutly)
        {
            case 1:
                this.questionConstant = GameState.Instance.ConfigurationGlobal.EasyQuestionConstant;
                break;
            case 2:
                this.questionConstant = GameState.Instance.ConfigurationGlobal.EasyQuestionConstant;
                break;
            case 3:
                this.questionConstant = GameState.Instance.ConfigurationGlobal.MidQuestionConstant;
                break;
            case 4:
                this.questionConstant = GameState.Instance.ConfigurationGlobal.HardQuestionConstant;
                break;
        }
	}
	
    public void VerifyState(GameObject explosionPref, OperationType ot)
    {
        int cont = this.questionClass.Answers2.Count; //La cantidad de respuestas posibles

        for (int i = 0; i < cont; i++)
        {
            if (this.questionClass.Answers2.ContainsKey(ot))
            {
                if (this.questionClass.Answers2[ot] == false)
                {
                } else if(this.questionClass.Answers2[ot] == true) {
                    cont--;
                }
            }
            
        }

        if(cont <= 0)
        {
            GameState.Instance.MyPlayerState.PlayerScore += questionConstant * 5;
            GameObject expl = Instantiate(explosionPref, transform.position, Quaternion.identity) as GameObject;
            expl.GetComponent<Explosion>().changeColor(ot);
            //if(GameObject.Find("EnemySpawner").GetComponent<EnemySpawner>().startToGenerate == false)
            //{
            //    GameObject.Find("EnemySpawner").GetComponent<EnemySpawner>().startToGenerate = true;
            //}
            Destroy(gameObject);
        }
    }

    public void Damaged(OperationType bulletType)
    {
        for(int i = 0; i < this.questionClass.Answers.Length; i++)
        {
            this.questionClass.Answers[i] = bulletType;
            this.questionClass.Answers2[bulletType] = true;
        }
    }
}
