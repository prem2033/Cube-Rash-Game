using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelComplete : MonoBehaviour
{
    // Start is called before the first frame update
    public GameManagerScript gameManagerScript;
    public void OnTriggerEnter(Collider other) {
        gameManagerScript.levelComplete();

    }
}
