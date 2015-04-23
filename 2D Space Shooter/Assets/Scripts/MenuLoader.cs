using UnityEngine;
using System.Collections;

public class MenuLoader : MonoBehaviour {



    void OnTriggerEnter2D(Collider2D PlayerShip)
    {


        if (PlayerShip.tag == "FinalGoal")
        {
            if (GameObject.FindGameObjectsWithTag("Goal").Length == 0)
            {
                Application.LoadLevel("Menu");
                TimeDamageHandler.live = 0;

            }


        }




    }
}
