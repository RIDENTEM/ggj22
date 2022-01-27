using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerStats : MonoBehaviour
{

    [SerializeField] Text cashText;
    [SerializeField] GameObject spawnPos;
    [SerializeField] GameObject tower;
    [SerializeField] GameObject[] spawners;

    GameObject player; 
    int currentCash = 0;
    public bool playerDead;
    public static playerStats s;

    private void Start()
    {
        s = this;
        player = GameObject.FindGameObjectWithTag("Player");
    }

    public void resetGame()
    {
        player.transform.position = spawnPos.transform.position;
        tower.transform.rotation = Quaternion.identity;
        currentCash = 0;
        cashText.text = "Cash: $" + currentCash;
        foreach(GameObject g in spawners)
        {
            g.GetComponent<enemySpawnScript>().DestroyAll();
        }
            
    }

    public void gatherCash()
    {
        currentCash += 1;
        cashText.text = "Cash: $" + currentCash;
    }
}
