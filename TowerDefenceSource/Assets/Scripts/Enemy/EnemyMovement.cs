using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour
{
    //Transform player;
    //PlayerHealth playerHealth;
    //EnemyHealth enemyHealth;
   // NavMeshAgent nav;
	private Transform destination;

    void Awake ()
    {
       destination = GameObject.FindGameObjectWithTag ("Finish").transform;
        //playerHealth = player.GetComponent <PlayerHealth> ();
        //enemyHealth = GetComponent <EnemyHealth> ();
//		nav = GetComponent <NavMeshAgent> ();
//		nav.SetDestination (player.position);
    }


    void Update ()
    {
        //if(enemyHealth.currentHealth > 0 && playerHealth.currentHealth > 0)
        //{
		transform.GetComponent<NavMeshAgent> ().destination = destination.transform.position;  
        //}
        //else
        //{
        //    nav.enabled = false;
        //}
    }
}
