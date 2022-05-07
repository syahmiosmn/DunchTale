using UnityEngine.Audio;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;

    // Start is called before the first frame update
    void Awake()
    {
        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.audio;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }

    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();

        int scene = currentScene.buildIndex;
        //Play("Ambience");
        //Play("Main Theme");

        switch(scene)
        {
            case 0:
                Stop("battle");
                Play("Ambience");
                Play("Main Theme");
                break;
            case 1:
                Stop("battle");
                Play("Ambience");
                Play("Main Theme");
                break;
            case 2:
                Stop("Main Theme");
                Stop("Ambience");
                Play("battle");
                break;
            case 3:
                Stop("Main Theme");
                Stop("Ambience");
                Play("battle");
                break;
            case 4:
                Stop("Main Theme");
                Stop("Ambience");
                Play("battle");
                break;
        }
    }

    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.Log("Sound" + name + " not found");
            return;
        }
        s.source.Play();
    }

    public void Stop(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.Log("Sound" + name + " not found");
            return;
        }
        s.source.Stop();
    }

}

