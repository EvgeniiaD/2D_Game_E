using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private PlayerBejaviour player;

	// Use this for initialization
	void Start()
    {
        player = GameObject.FindGameObjectsWithTag("Player").GetComponent<PlayerBejaviour>();
    }

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
}

