using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D game)
    {
        if (game.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("SceneChange"); 
        }
    }

}
