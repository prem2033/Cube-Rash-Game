using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnLevelCompleteNextScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void NextLevel(){
        Debug.Log("next level");
        Invoke("loadNextLevel",4);
    }
    public void loadNextLevel(){
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
