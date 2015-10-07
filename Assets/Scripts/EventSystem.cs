using UnityEngine;
using System.Collections.Generic;

public static class EventSystem
{
    // key : publish message
    // value : subcriber function
    static Dictionary<string, Callback> events = new Dictionary<string, Callback>();

    static public void subscribe(string message, Callback function)
    {
        //if the key does not exist then add it to the dictionary
        if (!events.ContainsKey(message))
        {
            events.Add(message, function);
        }

        //if the key already exists you must add the callback "multicast" to the entry
        else if(events.ContainsKey(message))
        {
            
        }
    }

    static public void publish(string publish)
    {
        Debug.Log(publish);
        if(events.ContainsKey(publish))
        {
            events[publish]();
        }
    }
	
}
