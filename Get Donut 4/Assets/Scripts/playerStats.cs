using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerStats : MonoBehaviour
{

    int currentCash = 0;
    [SerializeField] Text cashText;
    GameObject player; 
    [SerializeField] GameObject spawnPos;
    [SerializeField] GameObject tower;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    public void resetGame()
    {
        player.transform.position = spawnPos.transform.position;
        tower.transform.rotation = Quaternion.identity;
        currentCash = 0;
        cashText.text = "Cash: $" + currentCash;
    }

    public void gatherCash()
    {
        currentCash += 1;
        cashText.text = "Cash: $" + currentCash;
    }
}
