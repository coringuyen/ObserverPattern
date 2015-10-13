using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    public float health;
    public Button attack;
    public Button special;

    void Start()
    {
        attack.gameObject.SetActive(false);
        special.gameObject.SetActive(false);
    }

}
