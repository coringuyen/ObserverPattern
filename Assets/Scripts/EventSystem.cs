using UnityEngine;
using System.Collections.Generic;

public static class EventSystem
{
    // key : publish message
    // value : subcriber function
    static Dictionary<string, Callback> events = new Dictionary<string, Callback>();

    static public void subscribe(string message, Callback function)
    {
        //if the key already exists you must add the callback "multicast" to the entry
        if(events.ContainsKey(message))
        {
            events[message] += function;
        }

        //if the key does not exist then add it to the dictionary
        else events.Add(message, function);
    }

    static public void publish(string publish)
    {
        Debug.Log(publish);

        // execute the subs
        if(events.ContainsKey(publish))
        {
            events[publish]();
        }
    }
	
}
