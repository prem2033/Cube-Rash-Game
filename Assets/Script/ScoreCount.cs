using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour
{
    public Transform palyer;
    public Text scoretext;

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(palyer.position.z);
        scoretext.text= "Score : " + (palyer.position.z-0.8).ToString("0");
    }
}
