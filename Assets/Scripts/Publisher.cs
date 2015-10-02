using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Publisher : MonoBehaviour
{
    Dictionary<string, string> publish = new Dictionary<string, string>(); 

    public void publisher(string a_publish)
    {
        Debug.Log(a_publish.ToString());
        publish.Add(a_publish, a_publish);
    }
	
}
