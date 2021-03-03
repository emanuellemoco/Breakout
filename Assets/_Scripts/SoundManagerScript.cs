using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip hitSound, jumpSound, gameSound, winSound, endSound;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        hitSound = Resources.Load<AudioClip>("hit");
        jumpSound = Resources.Load<AudioClip>("jump");
        gameSound = Resources.Load<AudioClip>("music_game");
        winSound = Resources.Load<AudioClip>("win");
        endSound = Resources.Load<AudioClip>("end");

        audioSrc = GetComponent<AudioSource> ();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void PlaySound (string clip)
    {
            switch(clip){
            case "hit":
                audioSrc.PlayOneShot (hitSound);
                break;
            case "jump":
                audioSrc.PlayOneShot (jumpSound);
                break;
            case "music_game":
                audioSrc.PlayOneShot (gameSound);
                break;
            case "win":
                audioSrc.PlayOneShot (winSound);
                break;
            case "end":
                audioSrc.PlayOneShot (endSound);
                break;
        }
    }
}
