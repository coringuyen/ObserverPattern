using UnityEngine;
using System.Collections.Generic;

public class EventSystem
{
    Dictionary<string, Callback> events = new Dictionary<string, Callback>();

    public void subscriber(string message, Callback function)
    {
        events.Add(message, function);
    }

    public void publish(string publish)
    {
        Debug.Log(publish);
        if(events.ContainsKey(publish))
        {
            events[publish]();
        }
    }
	
}
