using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter (Collision collision)
    {
        ScoreScript.scoreValue += 1;
    }
}
