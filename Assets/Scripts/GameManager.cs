using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public UnityEvent FinishLevel;

    public void ExitButton()
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;

        #endif
        Application.Quit();
    }

    public void LevelFinish()
    {
        FinishLevel.Invoke();
    }
}
