﻿using UnityEngine;

using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    public float playerVelocity;
    private Vector3 playerPosition;
    public float boundary;

    private int playerLives;
    private int playerPoints;

    public AudioClip pointSound;
    public AudioClip lifeSound;

    public Text liveText;
    public Text scoreText;

    // Use this for initialization
    void Start()
    {
        // get the initial position of the game object
        playerPosition = gameObject.transform.position;
        playerLives = 3;
        playerPoints = 0;

    }

    // Update is called once per frame
    void Update()
    {

        // horizontal movement
        playerPosition.x += playerPosition.x >= boundary ? Input.GetAxis("Horizontal") > 0 ?
            0 : Input.GetAxis("Horizontal") * playerVelocity :
            playerPosition.x <= -boundary ? Input.GetAxis("Horizontal") < 0 ?
            0 : Input.GetAxis("Horizontal") * playerVelocity :
            Input.GetAxis("Horizontal") * playerVelocity;

        // leave the game
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.LoadLevel("Menu_play");
        }

        // update the game object transform
        transform.position = playerPosition;

        // boundaries
        if (playerPosition.x < -boundary)
        {
            transform.position = new Vector3(-boundary, playerPosition.y, playerPosition.z);
        }
        if (playerPosition.x > boundary)
        {
            transform.position = new Vector3(boundary, playerPosition.y, playerPosition.z);
        }

        // Check game state
        WinLose();
    }

    void addPoints(int points)
    {
        playerPoints += points;
        GetComponent<AudioSource>().PlayOneShot(pointSound);
    }

    void OnGUI()
    {
        liveText.text = playerLives.ToString();
        scoreText.text = playerPoints.ToString();
    }

    void TakeLife()
    {
        playerLives--;
        GetComponent<AudioSource>().PlayOneShot(lifeSound);
    }

    void WinLose()
    {
        // restart the game
        if (playerLives == 0)
        {
            Application.LoadLevel(Application.loadedLevelName);
        }

        // blocks destroyed
        if ((GameObject.FindGameObjectsWithTag("Block")).Length == 0)
        {
            // check the current level
            if (Application.loadedLevelName == "Level1")
            {
                Application.LoadLevel("Level2");
            }
            else if (Application.loadedLevelName == "Level2")
            {
                Application.LoadLevel("Level3");
            }
            else {
                Application.LoadLevel("Menu_play");
            }
        }
    }
}
