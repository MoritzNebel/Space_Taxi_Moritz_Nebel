using UnityEngine;
using System.Collections;

public class Start : MonoBehaviour {

    void Update () {
        if (Input.GetMouseButton(0) || Input.GetButton("Submit"))
        {
            Application.LoadLevel("Game2.1");
        }


    }
}
