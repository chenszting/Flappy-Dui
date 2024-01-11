using UnityEditor;
using UnityEngine;

public class GameAssets : MonoBehaviour
{
    private static GameAssets instance;

    public static GameAssets GetInstance()
    { 
        return instance; 
    }

    public void Awake()
    {
        instance = this;
    }

    public AudioClip duisound;
}
