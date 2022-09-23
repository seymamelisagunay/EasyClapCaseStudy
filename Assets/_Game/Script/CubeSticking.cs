using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CubeSticking : MonoBehaviour
{
    public bool stickMode = true;
    public Transform playerParent;
    
    public void OnCollisionEnter(Collision col) // cube becomes the child of the player
    {
        if (stickMode == true && col.gameObject.CompareTag("Player"))
        {
            transform.parent = playerParent;
        }
    }
}
