using UnityEngine;
using System.Collections;

public class InputHandler : MonoBehaviour {

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            EventSystem.publish("Key A");
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            EventSystem.publish("Key S");
        }
    }
}
