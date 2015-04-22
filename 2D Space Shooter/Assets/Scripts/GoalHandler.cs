using UnityEngine;
using System.Collections;


public class GoalHandler : MonoBehaviour {

    //public Vector3 soundo = new Vector3(0, 0.5f, 0);

    public GameObject soundi;


    public GameObject Hindernis;


    void OnTriggerEnter2D(Collider2D Goal)
    {
        

        if (Goal.tag == "Player")
        {
            Destroy(gameObject);
            Destroy(Hindernis);

            //Vector3 offset = transform.rotation * bulletOffset;

            GameObject soundy = (GameObject)Instantiate(soundi, transform.position, transform.rotation);
            soundy.layer = gameObject.layer;
            //System.Diagnostics.Process.Start(@"C:\Users\Moritz\Documents\2D Space Shooter\Assets\Sounds\shanice - i love your smile.mp3");
        }


    }


}
