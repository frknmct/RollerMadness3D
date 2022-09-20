using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    private bool isCollided = false;
    void Start()
    {
        
    }
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (isCollided == false && collision.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
            ScoreManager scoreManager = FindObjectOfType<ScoreManager>();
            scoreManager.score --;
            isCollided = true;
        }
        

    }
}
