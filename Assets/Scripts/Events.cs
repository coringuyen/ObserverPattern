using UnityEngine;
using System.Collections;

public class Events : MonoBehaviour
{
    Publisher _publidh;

    void Start()
    {
        _publidh = GetComponent<Publisher>();
    }

	void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            _publidh.publisher("Key A been press");
        }
    }
}
