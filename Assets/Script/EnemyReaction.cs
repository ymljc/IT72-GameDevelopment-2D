using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class EnemyReaction : MonoBehaviour {
    
    void Start () 
    {

    }
    void Update () 
    {

    }

    void OnTriggerEnter2D (Collider2D other){
        if (other.CompareTag ("Enemy")) {
        SceneManager.LoadScene ("SampleScene");
        }
    }
}