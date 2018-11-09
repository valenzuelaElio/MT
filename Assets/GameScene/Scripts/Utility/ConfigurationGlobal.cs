using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ConfigGlobal", menuName = "Math_Tank/ConfigurationGlobal")]
public class ConfigurationGlobal : ScriptableObject {

    [SerializeField] int m_initialLives;
    public int InitialLives { get { return m_initialLives; } }

    [SerializeField] bool m_tutorialEnabled;
    public bool TutorialIsEnabled { get { return m_tutorialEnabled; } }

    [SerializeField] string[] m_scenes;
    public string[] Scenes { get { return m_scenes; } }

    [SerializeField] int savedScore = 0;
    public int SavedScore { get { return savedScore; } set { savedScore = value; } }

    [SerializeField] string userName;
    public string UserName { get { return userName; } set { userName = value; } }

    [SerializeField] int easyQuestionConstant;
    public int EasyQuestionConstant { get { return easyQuestionConstant; } }

    [SerializeField] int midQuestionConstant;
    public int MidQuestionConstant { get { return midQuestionConstant; } }

    [SerializeField] int hardQuestionConstant;
    public int HardQuestionConstant { get { return hardQuestionConstant; } }

    [SerializeField] string[] questions;
    public string[] Questions { get { return questions; } }

    [SerializeField] OperationType[] answer;
    public OperationType[] Answer { get { return answer; } }

}
