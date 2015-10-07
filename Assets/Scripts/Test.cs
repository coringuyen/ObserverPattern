using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

    //EventSystem events = new EventSystem();
    
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
        EventSystem.subscribe("Key A", KeyA);
        EventSystem.subscribe("Key S", KeyS);
	}
	
	void KeyA()
    {
        playSound(musicA);
    }

    void KeyS()
    {
        playSound(musicS);
    }


}
