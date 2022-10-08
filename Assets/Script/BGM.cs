using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour
{
    public static BGM instance;

    void awake()
    {
        if (instance != null)
        {
            Destroy(instance.gameObject);
        }
        
        else
        {
            DontDestroyOnLoad(instance.gameObject);
        }
    }
}
