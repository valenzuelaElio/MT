using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionClass {

    private string question; //Question to show;
    private OperationType[] answers; //The list of asnwers

    private Dictionary<OperationType, bool> answers2; 

    private int dificulty;

    public string Question { get { return question; } }
    public OperationType[] Answers { get { return answers; } }

    public Dictionary<OperationType, bool> Answers2 { get { return answers2; } }

    public int Dificutly { get { return dificulty; } }

    int a;
    int b;
    int c;
    int d;

    public int A { get { return a; } }
    public int B { get { return b; } }

    int res;

    public QuestionClass()
    {
        answers2 = new Dictionary<OperationType, bool>();

        //dificulty = (int)Random.Range(1 , 4);
        dificulty = 1;
        switch (dificulty)
        {
            case 1:
                answers = new OperationType[1];

                a = (int)Random.Range(1, 10);
                b = (int)Random.Range(1, a);

                int operation = (int)Random.Range(1, 5);
                switch (operation)
                {
                    case 1:
                        res = a + b;
                        answers[0] = OperationType.SUM;
                        answers2.Add(OperationType.SUM, false);
                        break;
                    case 2:
                        res = a - b;
                        answers[0] = OperationType.SUBSTRACTION;
                        answers2.Add(OperationType.SUBSTRACTION, false);
                        break;
                    case 3:
                        res = a * b;
                        answers[0] = OperationType.MULTIPLICATION;
                        answers2.Add(OperationType.MULTIPLICATION, false);
                        break;
                    case 4:
                        while (a%2 != 0)
                        {
                            a--;
                        }
                        while (b % 2 != 0)
                        {
                            b--;
                            if(b == 0)
                            {
                                b = 4;
                            }
                        }
                        res = a / b;
                        answers[0] = OperationType.DIVISION;
                        answers2.Add(OperationType.DIVISION, false);
                        break;
                }
                question = "" + a + " [?] " + b + " = " + res;
                break;
        }



    }







}
