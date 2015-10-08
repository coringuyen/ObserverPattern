using System;
using UnityEngine;
using System.Collections.Generic;

public static class EventSystem
{
    // key : publish message
    // value : subcriber function
    static Dictionary<string, Delegate> events = new Dictionary<string, Delegate>();

    static public void subscribe(string message, Callback function)
    {
        //if the key already exists you must add the callback "multicast" to the entry
        if(events.ContainsKey(message))
        {
            events[message] = (Callback)events[message] + function;
        }

        //if the key does not exist then add it to the dictionary
        else events.Add(message, function);
    }

    static public void removeSub(string message, Callback function)
    {
        if (events.ContainsKey(message))
        {
            events[message] = (Callback)events[message] - function;
        }
    }

    static public void publish(string publish)
    {
        Debug.Log(publish);

        // execute the subs
        if(events.ContainsKey(publish))
        {
            events[publish].DynamicInvoke();
        }
    }

}
