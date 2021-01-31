using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneFader : MonoBehaviour
{

    public Animator animator;

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetMouseButtonDown(0))
        {
            FadeToLevel();
        }*/
    }

    public void FadeToLevel()
    {
        animator.SetTrigger("FadeOut");
    }
    
}
