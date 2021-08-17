using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

public class Buttons02 : MonoBehaviour {

// ------------------------------ START: LIST OF VARIABLES ------------------------------
// -------------------- PUBLIC VARIABLES --------------------
    public Button LearnToPlayButton;
    public Button PlayByEarButton;
    public Button PerformanceButton;
    public Button FreeJamButton;
    public Button SettingsButton;

// -------------------- PRIVATE VARIABLES --------------------


// -------------------- STATIC VARIABLES --------------------


// ------------------------------ END: LIST OF VARIABLES ------------------------------
// ------------------------------ START: CALLING OTHER SCRIPTS ------------------------------
    // Scene Change
    public SceneChange Scene03LoadRun;
    public SceneChange Scene04LoadRun;
    public SceneChange Scene05LoadRun;
    public SceneChange Scene06LoadRun;
    public SceneChange Scene07LoadRun;

// ------------------------------ END: CALLING OTHER SCRIPTS ------------------------------
// ------------------------------ START: CALLING INITIAL FUNCTIONS ------------------------------
// -------------------- START FUNCTION --------------------
    void Start() {
        // LearnToPlayButton
        Button LearnToPlayButtonClick = LearnToPlayButton.GetComponent<Button>();
        LearnToPlayButtonClick.onClick.AddListener(LearnToPlayButtonClicking);

        // PlayByEarButton
        Button PlayByEarButtonClick = PlayByEarButton.GetComponent<Button>();
        PlayByEarButtonClick.onClick.AddListener(PlayByEarButtonClicking);

        // PerformanceButton
        Button PerformanceButtonClick = PerformanceButton.GetComponent<Button>();
        PerformanceButtonClick.onClick.AddListener(PerformanceButtonClicking);

        // FreeJamButton
        Button FreeJamButtonClick = FreeJamButton.GetComponent<Button>();
        FreeJamButtonClick.onClick.AddListener(FreeJamButtonClicking);

        // SettingsButton
        Button SettingsButtonClick = SettingsButton.GetComponent<Button>();
        SettingsButtonClick.onClick.AddListener(SettingsButtonClicking);
    }

// -------------------- AWAKE FUNCTION --------------------
    void Awake() {
        
    }

// -------------------- UPDATE FUNCTION --------------------
    void Update() {
        
    }

// ------------------------------ END: CALLING INITIAL FUNCTIONS ------------------------------
// ------------------------------ START: OTHER FUNCTIONS ------------------------------
// -------------------- BUTTON FUNCTIONS --------------------
    public void LearnToPlayButtonClicking() {
        Scene03LoadRun.Scene03Load();
    }

    public void PlayByEarButtonClicking() {
        Scene04LoadRun.Scene04Load();
    }

    public void PerformanceButtonClicking() {
        Scene05LoadRun.Scene05Load();
    }

    public void FreeJamButtonClicking() {
        Scene06LoadRun.Scene06Load();
    }

    public void SettingsButtonClicking() {
        Scene07LoadRun.Scene07Load();
    }

// ------------------------------ END: OTHER FUNCTIONS ------------------------------

}