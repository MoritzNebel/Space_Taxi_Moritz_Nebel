using UnityEngine;
using System.Collections;

public class LoadNextLevel : MonoBehaviour
{
    //public GameObject Music;
    public int currentLevel;
    

    void OnTriggerEnter2D(Collider2D PlayerShip)
    {
               

        if (PlayerShip.tag == "FinalGoal")
        {
            if (GameObject.FindGameObjectsWithTag("Goal").Length == 0)
            {
                Application.LoadLevel("Game2." + (currentLevel +1));
                
            }
        }

   


    }


}
