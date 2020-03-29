using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorSound : MonoBehaviour
{
    public AudioSource[] actorSounds;
    
    public void OnPlaySound(string name)
    {
        if (name == "swoosh")
        {
            actorSounds[0].Play();
        }
    }
}
