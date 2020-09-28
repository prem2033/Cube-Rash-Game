using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitButtonClick : MonoBehaviour
{
    // Start is called before the first frame updatepubloic 
    public void QuitGame(){
        Application.Quit(); //quitting the game
        Debug.Log("quitting game");
    }
}
