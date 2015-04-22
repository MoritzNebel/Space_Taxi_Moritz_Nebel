using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public float maxSpeed = 5f;
    public float rotSpeed = 180f;

    float shipBoundaryRadius = 0.5f;

	void Start () {
	
	}
	

	void Update () {
        
       // Dreht die Spielfigur

        // Um Drehungen darzustellen
        Quaternion rot = transform.rotation;

        // übernimmt den Wert der z-Achse
        float z = rot.eulerAngles.z;

        // ändert den Wert für die z-Achsen
        z -= Input.GetAxis("Horizontal") * rotSpeed;
        
        // und schreibt ihn in die z-Achse
        rot = Quaternion.Euler(0, 0, z);

        // Feed the auternion into our rotation
        transform.rotation = rot;

        // Bewegt Spielobjekt nach oben und unten per Tastatur
        Vector3 pos = transform.position;
        
        Vector3 velocity = new Vector3(0, Input.GetAxis("Vertical") * maxSpeed * Time.deltaTime, 0); // Schnelligkeit
        //pos.x += Input.GetAxis("Horizontal") * maxSpeed * Time.deltaTime; 

        //Bewegung in Richtung der Drehung
        pos += rot * velocity;

        //RESTRICT the player to the camera's boundaries
        // Spielgrenze oben und unten GUI
        if (pos.y + shipBoundaryRadius > Camera.main.orthographicSize)
        {
            pos.y = Camera.main.orthographicSize - shipBoundaryRadius;
        }

        if (pos.y - shipBoundaryRadius < -Camera.main.orthographicSize)
        {
            pos.y = -Camera.main.orthographicSize + shipBoundaryRadius;
        }

        //calculate the orthographic width based on the screen ratio
        float screenRation = (float)Screen.width / (float)Screen.height; // Warning Will be weird
        float widthOrtho = Camera.main.orthographicSize * screenRation;

        // Spielgrenze links rechts GUI
        if (pos.x + shipBoundaryRadius > widthOrtho)
        {
            pos.x = widthOrtho - shipBoundaryRadius;
        }

        if (pos.x - shipBoundaryRadius < -widthOrtho)
        {
            pos.x = -widthOrtho + shipBoundaryRadius;
        }

        //Finally, update our position
        transform.position = pos;
        

       }
}
