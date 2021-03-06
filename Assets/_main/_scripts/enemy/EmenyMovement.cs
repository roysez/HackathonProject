﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmenyMovement : MonoBehaviour {

	Transform player;
	PlayerHealth playerHealth;
	// EnemyHealth enemyHealth;
	UnityEngine.AI.NavMeshAgent nav;


	void Awake ()
	{
		player = GameObject.FindGameObjectWithTag ("Player").transform;
		playerHealth = player.GetComponent <PlayerHealth> ();
	    // enemyHealth = GetComponent <EnemyHealth> ();
		nav = GetComponent <UnityEngine.AI.NavMeshAgent> ();
	}


	void Update ()
	{
		if(/* enemyHealth.currentHealth > 0 && */ playerHealth.currentHealth > 0 )
		{
			Debug.Log (player.position);
			nav.SetDestination (player.position);
		}
		else
		{
			nav.enabled = false;
		}
	}
}
