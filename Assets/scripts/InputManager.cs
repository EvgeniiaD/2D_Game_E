using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private PlayerBehaviour player;

	// Use this for initialization
	void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerBehaviour>();
    }
    // Update is called once per frame
    void Update()
    {
        // Pause game
        InputPause();
        // Movement
        InputMovement();
        // Jump
        InputJump();
        // Speed
        InputSpeed();
    }

    #region Controls
    void InputPause()
    {
        if(Input.GetButtonDown("Cancel")) Debug.Log("Pause game");
    }

    void InputMovement()
    {
        Vector2 axis = Vector2.zero;
        axis.x = Input.GetAxis("Horizontal");
        axis.y = Input.GetAxis("Vertical");
        player.SetAxis(axis);
    }

    void InputJump()
    {
        if(Input.GetButtonDown("Jump")) player.JumpStart();
    }

    void InputSpeed()
    {
        if(Input.GetButtonDown("Run")) player.running = true;
        else if(Input.GetButtonUp("Run")) player.running = false;
    }
    #endregion


/*
        // Update is called once per frame
        void Update()
        {
            InputPause();
            InputMovement();
            InputJump();
            InputSpeed();

        }
        void InputPause()
        {
            if(Input.GetButtonDown("Cancel")) Debug.Log("Pause game");
        }
        void InputMovement()
        {
            Vector2 axis = Vector2.zero;
            axis.x = Input.GetAxis("Horizondal");
            axis.y = Input.GetAxis("Vertical");
        }
        void InputPause()
        {
            if(Input.GetButtonDown("Jump")) Player.JumpStart();
        }
        void InputPause()
        {
           // if(Input.GetButtonDown("Run")) PlayerBejaviour.running = true;
           // if(Input.GetButtonUp("Run")) PlayerBejaviour.running = false;
        }
        */
}

