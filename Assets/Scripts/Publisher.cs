using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Publisher : MonoBehaviour
{
    Subscriber sub;
    
    void Start()
    {
        Events.printStuff();
        sub = GetComponent<Subscriber>();
    }
   
    // when this call is when the publisher happen then i need to notify the sub
    public void publisher(string a_publish)
    {
        Debug.Log(a_publish);
        sub.notify(a_publish);
    }

}
