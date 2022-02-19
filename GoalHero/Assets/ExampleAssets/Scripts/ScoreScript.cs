using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public static int scoreValue = 0;
    string score;
    public GameObject txtObject;
    // Start is called before the first frame update
    void Start()
    {
        txtObject = GameObject.Find("ScoreBoard");
        txtObject.GetComponent<TextMesh>().text = "Updated ScoreBoard!";

        //GameObject txt = UnityEngine.Object.FindObjectsOfType(TextMesh);
        //score = txtObject.GetComponent<TextMesh>();
        //GetComponent<TextMesh>().text = "Hello World";
        //Debug.Log(txt);
    }

    // Update is called once per frame
    void Update()
    {
        //txtObject = GameObject.Find("ScoreBoard");
        txtObject.GetComponent<TextMesh>().text = "ScoreBoard :" + scoreValue;
    }
}
