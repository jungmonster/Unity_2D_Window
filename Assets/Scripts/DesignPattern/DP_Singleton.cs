using UnityEngine;
using System.Collections;

public class DP_Singleton <T> : MonoBehaviour where T : MonoBehaviour {

    protected static T instance = null;
    public static T GetIstance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType(typeof(T)) as T;

                if(instance == null)
                {
                    GameObject obj = new GameObject("SingletonObject");
                    instance = obj.AddComponent(typeof(T)) as T;
                }
            }

            return instance;
        }
    }
}
