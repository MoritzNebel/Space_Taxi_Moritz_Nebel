using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeDamageHandler : MonoBehaviour
{

    public Text Leben;
    public float health = 1;
    public static float live = 1;
    public GameObject Blocks;
    public float timeLeft = 5;
    public Text Zeit;
    // Use this for initialization

    void Start()
    {

    }
    void OnTriggerEnter2D(Collider2D Player)
    {

        //GameObject player = GameObject.FindWithTag("PlayerShip");
        if (Player.tag == "Enemy")
        {
            health--;
            
        }

        if (Player.tag == "Bullet2")
        {
            health--;
        }

    }

    void Update()
    {
        if (live <= 10 && live > 0)
        {
            timeLeft -= Time.deltaTime;
            Leben.text = "Leben: " + live;

            //            Zeit.text = "Zeit: " + (int)timeLeft
            Zeit.text = "Zeit: " + timeLeft.ToString("0.0");
            if (health <= 0 || timeLeft < 0.1)
            {
                //Destroy(Music);
                Destroy(gameObject);
                Destroy(Blocks);
                //i = 0;
                live--;
                Application.LoadLevel(Application.loadedLevel);
                if (live == 0)
                {
                    Destroy(GameObject.FindWithTag("Music"));
                    Application.LoadLevel("Main");
                    live = 5;
                }
            }
        }
        if (live == 0)
        {
            timeLeft -= Time.deltaTime;
            Leben.text = "";

            Zeit.text = "Zeit: " + timeLeft.ToString("0.0");
            if (health <= 0 || timeLeft < 0.1)
            {
                Destroy(gameObject);
                Destroy(Blocks);
                Application.LoadLevel("Menu");
            }
        }
    }
    // Update is called once per frame

    
}
