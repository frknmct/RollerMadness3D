using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] private Vector3 angle;
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Rotate(angle,Space.World);
    }
}
