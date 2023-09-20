using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneResetManager : MonoBehaviour
{
    private static List<GameObject> objectsToReset = new List<GameObject>();

    public static void RegisterObject(GameObject obj)
    {
        objectsToReset.Add(obj);
    }

    public static void ResetScene()
    {
        foreach (GameObject obj in objectsToReset)
        {
            obj.SendMessage("ResetObject", SendMessageOptions.DontRequireReceiver);
        }
    }
}
