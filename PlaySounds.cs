using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

public class PlaySounds : MonoBehaviour {

// ------------------------------ START: LIST OF VARIABLES ------------------------------
// -------------------- PUBLIC VARIABLES --------------------
    public AudioClip BackgroundMusicClip;
    public AudioSource BackgroundMusic;

// -------------------- PRIVATE VARIABLES --------------------


// -------------------- STATIC VARIABLES --------------------
    public static float BackgroundMusicVolume;
    public static int BackgroundMusicIsMute;
    public static PlaySounds BackgroundInstance {
        get {
            return BackgroundMusicInstance;
        }
    }
    
    private static PlaySounds BackgroundMusicInstance = null;

// ------------------------------ END: LIST OF VARIABLES ------------------------------
// ------------------------------ START: CALLING OTHER SCRIPTS ------------------------------



// ------------------------------ END: CALLING OTHER SCRIPTS ------------------------------
// ------------------------------ START: CALLING INITIAL FUNCTIONS ------------------------------
// -------------------- START FUNCTION --------------------
    void Start() {
        BackgroundMusicIsMute = 1;
        BackgroundMusicVolume = BackgroundMusic.volume;
        BackgroundMusicVolume = 3.0f;
    }

// -------------------- AWAKE FUNCTION --------------------
    void Awake() {
        if ((BackgroundMusicInstance != null) && (BackgroundMusicInstance != this)) {
            Destroy(this.gameObject);
            return;
        }
        
        else {
            BackgroundMusicInstance = this;
        }
        
        DontDestroyOnLoad(this.gameObject);
    }

// -------------------- UPDATE FUNCTION --------------------
    void Update() {
        if (BackgroundMusicIsMute == 0) {
            BackgroundMusic.volume = 0.05f;
        }

        else if (BackgroundMusicIsMute == 1) {
            BackgroundMusic.volume = 3.0f;
        }
    }

// ------------------------------ END: CALLING INITIAL FUNCTIONS ------------------------------
// ------------------------------ START: OTHER FUNCTIONS ------------------------------
// -------------------- SOUND FUNCTIONS --------------------
    public void BackgroundMusicPlay() {
        BackgroundMusic.Play();
        BackgroundMusic.loop = true;
        BackgroundMusicVolume = 3.0f;
    }

    public void BackgroundMusicMute() {
        BackgroundMusicVolume = 0.0f;
    }

    public void BackgroundMusicUnmute() {
        BackgroundMusicVolume = 3.0f;
    }

// ------------------------------ END: OTHER FUNCTIONS ------------------------------

}