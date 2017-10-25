using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
        Player = GameObject.FindGameObjectsWithTag("Player").GetComponent<PlayerBehaviour>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
