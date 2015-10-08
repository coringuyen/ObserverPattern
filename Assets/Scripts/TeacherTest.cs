using UnityEngine;
using System.Collections;

public class TeacherTest : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        EventSystem.subscribe("Key A", doit);
        EventSystem.subscribe("Key A", goHome);
    }
	
	void doit()
    {
        print("doing it");
    }

    void goHome()
    {
        print("I'm done");
    }
}
