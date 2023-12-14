using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float gameDuration;
    
    private float currentTime = 0;
    private bool isGameOver = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if(!isGameOver)
        {
            currentTime += Time.deltaTime;

            if(currentTime >= gameDuration) 
            {
                EndGame();           
            }

        }

        void EndGame()
        {
            isGameOver = true;
            Debug.Log("Game Over");
        }

    }
}
