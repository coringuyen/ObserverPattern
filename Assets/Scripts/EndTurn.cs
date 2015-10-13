using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EndTurn : MonoBehaviour
{
    public List<GameObject> players = new List<GameObject>();
    public List<GameObject> enemy = new List<GameObject>();
    public GameObject previous_player;
    int current = 0;

    void Start()
    {
        SetPlayer(0);
        EventSystem.subscribe("EndTurn", back_to_idle);
        EventSystem.subscribe("EndTurn", healthbar_off);
    }

    public void endturn()
    {
        previous_player = players[current];
        EventSystem.publish("EndTurn");
        current++;

        if (current >= players.Count)
        {
            current = 0;
        }

        SetPlayer(current);
    }

   

    public void player_special()
    {
        players[current].GetComponent<Menu>().idle_to_special();
    }

    public void player_attack()
    {
        players[current].GetComponent<Menu>().idle_to_attack();
    }

    void back_to_idle()
    {
        previous_player.GetComponent<Menu>().auto_idle();
    }

    public void SetPlayer(int current)
    {
        players[current].GetComponent<Player>().setCamera();
        players[current].GetComponent<Player>().healthBar.gameObject.SetActive(true);
    }
    
    void healthbar_off()
    {
        players[current].GetComponent<Player>().healthBar.gameObject.SetActive(false);
    }
}
