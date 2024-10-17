using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalScene : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision crystal_17_2)
    {
        if (crystal_17_2.gameObject.name == "FirstPersonPlayer")
        {
            Debug.Log("Collision Detected It Works");
            SceneManager.LoadScene("End Game");
        }
    }

}