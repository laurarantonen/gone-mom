using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public string sceneName;
    public float waitTime;
    void Start()
    {
        Invoke("GoToNext", waitTime);
    }

    void GoToNext()
    {
        SceneManager.LoadScene(sceneName);
    }
}
