using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript : MonoBehaviour
{
    float speed = 0.2f;
    bool playerDied = false;

    void Update()
    {
        gameObject.transform.Translate(Vector3.up * speed);
        if (gameObject.transform.position.y >= 25.0f) Destroy(this.gameObject);
        if (playerDied) Destroy(this.gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("Hit player");
            if(gameObject.tag == "Cash")
            {
                //Player function to gather cash
                other.gameObject.GetComponent<playerStats>().gatherCash();
                Destroy(this.gameObject);
            }

            if(gameObject.tag == "Enemy")
            {
                playerDied = true;
                other.gameObject.GetComponent<playerStats>().resetGame();
            }
            //Reset game?
            //Spawn player elsewhere?
            //Clear all spawned objects?
        }
    }
}
