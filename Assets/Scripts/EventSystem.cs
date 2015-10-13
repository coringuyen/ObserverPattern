﻿using System;
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
    /// Add this pair of Tkey, Tvalue to the Dictionary
    /// </summary>
    /// <param string ="message"></param>
    /// <param delegate ="function"></param>
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
    /// Remove this pair of TKey, TValue from the Dictionary
    /// </summary>
    /// <param string ="message"></param>
    /// <param delegate ="function"></param>
    static public void removeSub(string message, Callback function)
    {
        if (events.ContainsKey(message))
        {
            events[message] = (Callback)events[message] - function;
        }
    }

    /// <summary>
    /// print the message and also will execute TValue of this message(TKey)
    /// </summary>
    /// <param string ="publish"></param>
    static public void publish(string publish)
    {
        Debug.Log(publish);

        if(events.ContainsKey(publish))
        {
            // execute the subs
            events[publish].DynamicInvoke();
        }
    }

}
