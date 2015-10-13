using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    public int health;
    int attack_damage;
    int special_damage;
    public Button attack;
    public Button special;
    public Slider healthBar;

    void Start()
    {
        health = 100;
        attack_damage = 10;
        special_damage = 15;
        healthBar.value = health;
    }


    public void Attack()
    {
       health -= attack_damage;
    }

    public void Special()
    {
        health -= special_damage;
    }

    public void setCamera()
    {
        Camera.main.transform.position = transform.position;
        Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, 2.5f, -4.5f);
    }

    
}
