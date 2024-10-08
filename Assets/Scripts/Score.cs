using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    int hits = 0;

    private void OnCollisionEnter(Collision other)
    {
        hits++;

        Debug.Log("Bateu em " + hits + " obstaculos");
    }
}
