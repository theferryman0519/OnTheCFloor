using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

public class EnableObjects02 : MonoBehaviour {

// ------------------------------ START: LIST OF VARIABLES ------------------------------
// -------------------- PUBLIC VARIABLES --------------------
    public Image BackgroundImage;
    public Image BackgroundBubblesA;
    public Image BackgroundBubblesB;
    public Text LogoText;
    public Text VersionText;
    public Image LearnToPlayButton;
    public Image PlayByEarButton;
    public Image PerformanceButton;
    public Image FreeJamButton;

// -------------------- PRIVATE VARIABLES --------------------
    float BubbleASpeed;
    float BubbleBSpeed;

// -------------------- STATIC VARIABLES --------------------


// ------------------------------ END: LIST OF VARIABLES ------------------------------
// ------------------------------ START: CALLING OTHER SCRIPTS ------------------------------



// ------------------------------ END: CALLING OTHER SCRIPTS ------------------------------
// ------------------------------ START: CALLING INITIAL FUNCTIONS ------------------------------
// -------------------- START FUNCTION --------------------
    void Start() {
        EnableMain();
        EnableBackgroundBubblesA();
        EnableBackgroundBubblesB();

        PlaySounds.BackgroundMusicIsMute = 1;

        BubbleASpeed = 0.25f;
        BubbleBSpeed = 0.50f;
    }

// -------------------- AWAKE FUNCTION --------------------
    void Awake() {
        
    }

// -------------------- UPDATE FUNCTION --------------------
    void Update() {
        MovingBubblesA();
        MovingBubblesB();
        
        VersionText.text = "Version: 1.0";
    }

// ------------------------------ END: CALLING INITIAL FUNCTIONS ------------------------------
// ------------------------------ START: OTHER FUNCTIONS ------------------------------
// -------------------- ENABLING OBJECT FUNCTIONS --------------------
    public void EnableMain() {
        BackgroundImage.enabled = true;
        LogoText.enabled = true;
        VersionText.enabled = true;
        LearnToPlayButton.enabled = true;
        PlayByEarButton.enabled = true;
        PerformanceButton.enabled = true;
        FreeJamButton.enabled = true;
    }

    public void EnableBackgroundBubblesA() {
        BackgroundBubblesA.enabled = true;
    }

    public void EnableBackgroundBubblesB() {
        BackgroundBubblesB.enabled = true;
    }

// -------------------- DISABLING OBJECT FUNCTIONS --------------------
    public void DisableMain() {
        BackgroundImage.enabled = false;
        LogoText.enabled = false;
        VersionText.enabled = false;
        LearnToPlayButton.enabled = false;
        PlayByEarButton.enabled = false;
        PerformanceButton.enabled = false;
        FreeJamButton.enabled = false;
    }

    public void DisableBackgroundBubblesA() {
        BackgroundBubblesA.enabled = false;
    }

    public void DisableBackgroundBubblesB() {
        BackgroundBubblesB.enabled = false;
    }

// -------------------- MOVEMENT FUNCTIONS --------------------
    public void MovingBubblesA() {
        BackgroundBubblesA.transform.Translate(0.0f, Time.deltaTime * BubbleASpeed, 0.0f);
    }

    public void MovingBubblesB() {
        BackgroundBubblesB.transform.Translate(0.0f, Time.deltaTime * BubbleBSpeed, 0.0f);
    }

// ------------------------------ END: OTHER FUNCTIONS ------------------------------

}