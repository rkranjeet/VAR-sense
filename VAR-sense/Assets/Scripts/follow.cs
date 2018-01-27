using UnityEngine;
using System.Collections;
using UnityEngine.AI;
public class follow : MonoBehaviour
{
	Transform player;
	NavMeshAgent nav;


	void Awake ()
	{
		player = GameObject.FindGameObjectWithTag ("MainCamera").transform;
		nav = GetComponent <NavMeshAgent> ();
	}


	void Update ()
	{
		nav.SetDestination (player.position);
	} 
}