using UnityEngine;
using System.Collections;

public class EnemyAIScripts : MonoBehaviour
{

    public Transform player;
    public float playerDistance;
    public float rotationDamping = 15;
    public float moveSpeed = 5;

	// Use this for initialization
	void Start ()
    {
	


	}
	
	// Update is called once per frame
	void Update ()
    {

        playerDistance = Vector3.Distance(player.position, transform.position);
        // have the enemy look at the player
        if (playerDistance < 150.0f)
        {

            lookAtPlayer();

        }
        if (playerDistance < 150.0f)
        {

            chasePlayer();

        }
        
	}

    void lookAtPlayer()
    {

        Quaternion rotation = Quaternion.LookRotation(player.position - transform.position);
        //rotate the enemy

        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * rotationDamping);

    }

    void chasePlayer()
    {

        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

    }

}

