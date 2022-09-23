using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeDropping : MonoBehaviour
{
    public Transform cubesParent;
    public float dropTime;
    private void OnTriggerEnter(Collider other) // cube returns to old parent
    {
        if (other.CompareTag("Cube"))
        {
            StartCoroutine(Dropping(other));
        }
    }
    private IEnumerator Dropping(Collider other)
    {
        yield return new WaitForSeconds(dropTime);
        other.transform.parent = cubesParent;
        other.GetComponent<CubeSticking>().stickMode = false;
    }
}
