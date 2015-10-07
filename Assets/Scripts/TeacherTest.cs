using UnityEngine;
using System.Collections;

public class TeacherTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
        EventSystem.subscribe("Key A", doit);
	}
	
	void doit()
    {
        print("doing it");
    }
}
