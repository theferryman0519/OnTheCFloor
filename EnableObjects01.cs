using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

public class EnableObjects01 : MonoBehaviour {

// ------------------------------ START: LIST OF VARIABLES ------------------------------
// -------------------- PUBLIC VARIABLES --------------------
    public Image BackgroundImage;
    public Image MainLogo;
    public Image BlankButton;

// -------------------- PRIVATE VARIABLES --------------------
    bool MainLogoFading;

// -------------------- STATIC VARIABLES --------------------


// ------------------------------ END: LIST OF VARIABLES ------------------------------
// ------------------------------ START: CALLING OTHER SCRIPTS ------------------------------
    // Scene Change
    public SceneChange Scene02LoadRun;

// ------------------------------ END: CALLING OTHER SCRIPTS ------------------------------
// ------------------------------ START: CALLING INITIAL FUNCTIONS ------------------------------
// -------------------- START FUNCTION --------------------
    void Start() {
        EnableBackgroundImage();
        EnableMainLogo();
        EnableBlankButton();

        MainLogo.canvasRenderer.SetAlpha(0.0f);
        MainLogoFading = true;
    }

// -------------------- AWAKE FUNCTION --------------------
    void Awake() {
        
    }

// -------------------- UPDATE FUNCTION --------------------
    void Update() {
        FadeMainLogo();
    }

// ------------------------------ END: CALLING INITIAL FUNCTIONS ------------------------------
// ------------------------------ START: OTHER FUNCTIONS ------------------------------
// -------------------- ENABLE OBJECT FUNCTIONS --------------------
    public void EnableBackgroundImage() {
        BackgroundImage.enabled = true;
    }

    public void EnableMainLogo() {
        MainLogo.enabled = true;
    }

    public void EnableBlankButton() {
        BlankButton.enabled = true;
    }

// -------------------- DISABLE OBJECT FUNCTIONS --------------------
    public void DisableBackgroundImage() {
        BackgroundImage.enabled = false;
    }

    public void DisableMainLogo() {
        MainLogo.enabled = false;
    }

    public void DisableBlankButton() {
        BlankButton.enabled = false;
    }

// -------------------- IENUMERATOR FUNCTIONS --------------------
    public IEnumerator FadingInMainLogoWait() {
        yield return new WaitForSeconds(3.0f);
        MainLogoFading = false;
    }

    public IEnumerator FadingOutMainLogoWait() {
        yield return new WaitForSeconds(4.0f);
        Scene02LoadRun.Scene02Load();
    }

// -------------------- FADING FUNCTIONS --------------------
    public void FadeMainLogo() {
        if (MainLogoFading == true) {
            MainLogo.CrossFadeAlpha(1.0f, 1.0f, false);
            StartCoroutine(FadingInMainLogoWait());
        }

        else if (MainLogoFading == false) {
            MainLogo.CrossFadeAlpha(0.0f, 1.0f, true);
            StartCoroutine(FadingOutMainLogoWait());
        }
    }

// ------------------------------ END: OTHER FUNCTIONS ------------------------------

}