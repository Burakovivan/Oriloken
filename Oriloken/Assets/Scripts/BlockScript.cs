using UnityEngine;
using System.Collections;

public class BlockScript : MonoBehaviour
{

    public int hitsToKill;
    public int points;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            hitsToKill--;

            if (0 == hitsToKill)
            {

                // get reference of player object
                GameObject player = GameObject.FindGameObjectsWithTag("Player")[0];

                // send message
                player.SendMessage("addPoints", points);

                // destroy the object
                Destroy(this.gameObject);
                return;
            }
            //switch (hitsToKill)
            //{
            //    case 3: GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>(Application.dataPath + @"/Sprites/Cubes/Yellow.png"); break;
            //    case 2: GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>(Application.dataPath + @"/Sprites/Cubes/Green.png"); break;
            //    case 1: GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>(Application.dataPath + @"/Sprites/Cubes/Blue.png"); break;
            //}

        }
    }

}
