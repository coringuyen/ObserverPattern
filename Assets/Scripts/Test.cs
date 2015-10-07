using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

    EventSystem events = new EventSystem();
    
    public AudioSource manager;
    public AudioClip musicA;
    public AudioClip musicS;

    void playSound(AudioClip music)
    {
        manager.clip = music;
        manager.Play();
    }

	void Start ()
    {
        events.subscriber("Key A", KeyA);
        events.subscriber("Key S", KeyS);
	}
	
	void KeyA()
    {
        playSound(musicA);
    }

    void KeyS()
    {
        playSound(musicS);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            events.publish("Key A");
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            events.publish("Key S");
        }
    }
}
