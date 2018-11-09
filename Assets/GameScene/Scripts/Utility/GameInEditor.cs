using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInEditor : MonoBehaviour {

    #if UNITY_EDITOR
        [SerializeField] ConfigurationGlobal configurationGlobal;

        void Awake()
        {
            if(GameState.Instance == null)
            {
                GameState.CreateGame(configurationGlobal);
            }
            Destroy(this);
        }

    #endif
}
