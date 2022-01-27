using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript : MonoBehaviour
{
    float speed = 0.2f;

    void Update()
    {
        gameObject.transform.Translate(Vector3.up * speed);
        if (gameObject.transform.position.y >= 25.0f) Destroy(this.gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            if(gameObject.tag == "Cash")
            {
                //Player function to gather cash
                other.gameObject.GetComponent<playerStats>().gatherCash();
                Destroy(this.gameObject);
            }

            if(gameObject.tag == "Enemy")
            {
                other.gameObject.GetComponent<playerStats>().resetGame();
            }
        }
    }
}
