using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class Subscriber : MonoBehaviour
{
    Dictionary<string, Callback> Sub = new Dictionary<string, Callback>();

    public void subscriber(string a_event, Callback function)
    {
         Sub.Add(a_event, function);
    }

    public void notify(string pulish)
    {
        if (Sub.ContainsKey(pulish))
        {
            Sub[pulish]();
        }
    }
}
