using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{

    private GameManager gameManager;

    void Start()
    {
     gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    
    
    void OnTriggerEnter(Collider other)
    {
        // Instead of destroying the projectile when it collides with an animal
        //Destroy(other.gameObject); 

        // Just deactivate the food and destroy the animal
        if (other.CompareTag("Player")) //check if other tag was player, if it was remove a life
         {
        gameManager.AddLives(-1);
        Destroy(gameObject);
         }
        else if (other.CompareTag("Animal")) //check if other tag was an animal, if it was add points to score
        {
        other.GetComponent<AnimalHunger>().FeedAnimal(1);
        other.gameObject.SetActive(false);
        }
                
    }

}
