using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    //Physics2D.OverlapBox
    /*[Header("Physics2D.OverlapBox")]
    public Vector2 boxPos;
    public Vector2 boxSize;
    public LayerMask mask;
    //Physics2D.OverlapCollider;
    [Header("Physics2D.OverlapCollider")]
    public Collider2D col;
    public ContactFilter2D filter;
    public Collider[] cols;
    public Collider results;*/

    [Header("StateGround")]
    public bool isGrounded;
    public bool wasGrounded;
    public bool justGotGrounded;
    public bool justNOTGrounded;
    public bool IsFalling;
    public bool wasGroundedLastFrame;
    [Header("StateWall")]
    public bool isTouchingWall;
    public bool wasTouchingWallLastFrame;
    public bool justGotWalled;
    public bool justNOTWalled;
    [Header("StateCeiling")]
    public bool isCeiling;
    public bool wasCeiling;
    public bool justGotCeiling;
    public bool justNOTCeiling;


    [Header("Filter Properties")]
    public ContactFilter2D groundFilter;
    public ContactFilter2D CeilingFilter;
    public ContactFilter2D SideFilter;
    public int maxHits;

    [Header("Bottom Box")]
    public Vector2 groundBoxPos;
    public Vector2 groundBoxSize;

    [Header("Side Box")]
    public Vector2 WallBoxPos;
    public Vector2 WallBoxSize;

    [Header("Ceiling Box")]
    public Vector2 CeilingBoxPos;
    public Vector2 CeilingBoxSize;

    void ResetState()
    {
        wasGroundedLastFrame = isGrounded;
        wasTouchingWallLastFrame = isTouchingWall;
        wasCeiling = isCeiling;

        isGrounded = false;
        justGotGrounded = false;
        justNOTGrounded = false;
        IsFalling = true;

        isCeiling = false;
        justGotCeiling = false;
        justNOTCeiling = false;


        isTouchingWall = false;
       // justGotWalled = false;
        //justNOTWalled = false;
    }
    // Use this for initialization
    void Start()
    {
        ResetState();

    }
    void MyStart()
    {


    }

    // Update is called once per frame
    void Update()
    {

    }
    private void FixedUpdate()
    {
        ResetState();
        GroundDetection();
        WallDetection();
        CeilingDetection();
        //Collider[] results = new Collider2D[5];
        //results = new Collider2D[1];
        //int numHits = Physics2D.OverlapBox(this.transform.position, boxSize, 0, filter, results);
        //if(numHits > 0) Debug.Log("Se ha detectado la collider");

        //Rigidbody rb;
        //rb.OverlapCollider;
        //Physics2D.OverlapCollider(col,filter,results;
    }
    void GroundDetection()
    {


        Collider2D[] results = new Collider2D[maxHits];
        Vector2 pos = this.transform.position;
        int numHits = Physics2D.OverlapBox(pos + groundBoxPos, groundBoxSize, 0, groundFilter, results);

        if(numHits > 0)
        {
            isGrounded = true;
        }
        if(isGrounded) IsFalling = false;
        if(isGrounded && !wasGroundedLastFrame) justGotGrounded = true;
        if(!isGrounded && wasGroundedLastFrame) justNOTGrounded = true;
    }

    void CeilingDetection()
    {


        Collider2D[] results = new Collider2D[maxHits];
        Vector2 pos = this.transform.position;
        int numHits = Physics2D.OverlapBox(pos + CeilingBoxPos, CeilingBoxSize, 0, CeilingFilter, results);

        if (numHits > 0)
        {
            isCeiling = true;
        }

    }

    void WallDetection()
    {


        Collider2D[] results = new Collider2D[maxHits];
        Vector2 pos = this.transform.position;
        int numHits = Physics2D.OverlapBox(pos + WallBoxPos, WallBoxSize, 0, SideFilter, results);

        if (numHits > 0)
        {
            isTouchingWall = true;
        }

    }
    private void OnDrawGizmosSelected()
    {
        Vector2 pos = this.transform.position;
        Gizmos.DrawWireCube(pos + groundBoxPos,groundBoxSize);
        Gizmos.DrawWireCube(pos + CeilingBoxPos, CeilingBoxSize);
        Gizmos.DrawWireCube(pos + WallBoxPos, WallBoxSize);
        //Gizmos.DrawWireCube(this.transform.position, boxSize);
    }
}
