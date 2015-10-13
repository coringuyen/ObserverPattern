using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Enemy : MonoBehaviour {

    public int health;
    public Slider healthbar;

    void Start()
    {
        health = 100;
        healthbar.value = health;
    }
}
