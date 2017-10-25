using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collision))]
public class PlayerBejaviour : MonoBehaviour
{
    public enum State { Default, Dead, God}
    public State state;

    [Header("Physics")]
    public Rigidbody2D rb;
    [Header("State")]
    public bool canMove = true;
    public bool canJump = true;
    public bool runing = false;
    public bool isFacingRight = true;
    publiv bool isJumping = false;
    [Header("Speed properties")]
    public float walkSpeed = 2;
    public float runSpeed = 3;
    public float movementSpeed;
    [Header("Force properties")]
    public float jumpWalkForce;
    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
 
}
