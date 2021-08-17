using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

public class EnableObjects00 : MonoBehaviour {

// ------------------------------ START: LIST OF VARIABLES ------------------------------
// -------------------- PUBLIC VARIABLES --------------------
    public Image BackgroundImage;
    public Image FerrymanLogo;
    public Image BlankButton;

// -------------------- PRIVATE VARIABLES --------------------
    bool FerrymanLogoFading;

// -------------------- STATIC VARIABLES --------------------
    public static int IntroSlideInt;

// ------------------------------ END: LIST OF VARIABLES ------------------------------
// ------------------------------ START: CALLING OTHER SCRIPTS ------------------------------
    // Scene Change
    public SceneChange Scene01LoadRun;

// ------------------------------ END: CALLING OTHER SCRIPTS ------------------------------
// ------------------------------ START: CALLING INITIAL FUNCTIONS ------------------------------
// -------------------- START FUNCTION --------------------
    void Start() {
        EnableBackgroundImage();
        EnableFerrymanLogo();
        EnableBlankButton();
        IntroSlideInt = 1;

        FerrymanLogo.canvasRenderer.SetAlpha(0.0f);
        FerrymanLogoFading = true;
    }

// -------------------- AWAKE FUNCTION --------------------
    void Awake() {
        
    }

// -------------------- UPDATE FUNCTION --------------------
    void Update() {
        FadeFerrymanLogo();
    }

// ------------------------------ END: CALLING INITIAL FUNCTIONS ------------------------------
// ------------------------------ START: OTHER FUNCTIONS ------------------------------
// -------------------- ENABLE OBJECT FUNCTIONS --------------------
    public void EnableBackgroundImage() {
        BackgroundImage.enabled = true;
    }

    public void EnableFerrymanLogo() {
        FerrymanLogo.enabled = true;
    }

    public void EnableBlankButton() {
        BlankButton.enabled = true;
    }

// -------------------- DISABLE OBJECT FUNCTIONS --------------------
    public void DisableBackgroundImage() {
        BackgroundImage.enabled = false;
    }

    public void DisableFerrymanLogo() {
        FerrymanLogo.enabled = false;
    }

    public void DisableBlankButton() {
        BlankButton.enabled = false;
    }

// -------------------- IENUMERATOR FUNCTIONS --------------------
    public IEnumerator FadingInFerrymanLogoWait() {
        yield return new WaitForSeconds(3.0f);
        FerrymanLogoFading = false;
    }

    public IEnumerator FadingOutFerrymanLogoWait() {
        yield return new WaitForSeconds(4.0f);
        Scene01LoadRun.Scene01Load();
    }

// -------------------- FADING FUNCTIONS --------------------
    public void FadeFerrymanLogo() {
        if (FerrymanLogoFading == true) {
            FerrymanLogo.CrossFadeAlpha(1.0f, 1.0f, false);
            StartCoroutine(FadingInFerrymanLogoWait());
        }

        else if (FerrymanLogoFading == false) {
            FerrymanLogo.CrossFadeAlpha(0.0f, 1.0f, true);
            StartCoroutine(FadingOutFerrymanLogoWait());
        }
    }

// ------------------------------ END: OTHER FUNCTIONS ------------------------------

}