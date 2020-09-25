using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    bool gameended =false;
    public GameObject completeleveUI;
    public playerMovement movement;
        public void EndGame(){
            if(gameended==false){
               Debug.Log("Game Over");
               gameended=true;
               //restart the game

               Invoke("restart",5f);  //dealy 
            }
    }
    void restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void levelComplete(){
         Debug.Log("level complete");
         completeleveUI.SetActive(true);
         movement.enabled=false;
    }
}