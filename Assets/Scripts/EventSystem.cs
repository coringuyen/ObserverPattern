using System;
using UnityEngine;
using System.Collections.Generic;

public static class EventSystem
{
    /// <summary>
    /// key : publish message
    /// value : subscriber (function)
    /// using Dictionary to store Subscriber with a unique message that they are interested in
    /// </summary>
    static Dictionary<string, Delegate> events = new Dictionary<string, Delegate>();

    /// <summary>
    /// Add this pair of message, function to the Dictionary
    /// </summary>
    /// <param name="message">
    /// the message to subscribe to
    /// </param>
    /// <param name="function">
    /// the function to execute when the message is publish
    /// </param>
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


    /// <summary>
    /// Remove this pair of message, function from the Dictionary
    /// </summary>
    /// <param name ="message">
    /// the message to remove to
    /// </param>
    /// <param name ="function">
    /// the function to remove to
    /// </param>
    static public void removeSub(string message, Callback function)
    {
        if (events.ContainsKey(message))
        {
            events[message] = (Callback)events[message] - function;
        }
    }

    /// <summary>
    /// print the message and also will execute function of this message
    /// </summary>
    /// <param name ="message">
    /// message that need to publish
    /// </param>
    static public void publish(string message)
    {
        Debug.Log(message);

        if(events.ContainsKey(message))
        {
            // execute the subs
            events[message].DynamicInvoke();
        }
    }

}
