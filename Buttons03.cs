using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

public class Buttons03 : MonoBehaviour {

// ------------------------------ START: LIST OF VARIABLES ------------------------------
// -------------------- PUBLIC VARIABLES --------------------
    // Main Objects
    public Button MainMenuButton;
    public Button SettingsButton;

    // Duke
    public Button BubbleNotesAOn;
    public Button BubbleNotesBOn;
    public Button BubbleNotesCOn;
    public Button BubbleNotesDOn;
    public Button BubbleNotesEOn;
    public Button BubbleNotesFOn;
    public Button BubbleNotesGOn;
    public Button BubbleNotesOctaveOn;
    public Button BubbleNotesAOff;
    public Button BubbleNotesBOff;
    public Button BubbleNotesCOff;
    public Button BubbleNotesDOff;
    public Button BubbleNotesEOff;
    public Button BubbleNotesFOff;
    public Button BubbleNotesGOff;
    public Button BubbleNotesOctaveOff;

    // Coral
    public Button CoralAOff;
    public Button CoralBOff;
    public Button CoralCOff;
    public Button CoralDOff;
    public Button CoralEOff;
    public Button CoralFOff;
    public Button CoralGOff;
    public Button CoralOctaveOff;
    public Button CoralAOn;
    public Button CoralBOn;
    public Button CoralCOn;
    public Button CoralDOn;
    public Button CoralEOn;
    public Button CoralFOn;
    public Button CoralGOn;
    public Button CoralOctaveOn;

    // Intro Panel
    public Button IntroPriorButton;
    public Button IntroNextButton;
    public Button IntroPlayButton;

    // Settings Panel
    public Button SettingsOnButton;
    public Button SettingsOffButton;
    public Button SettingsBackButton;

// -------------------- PRIVATE VARIABLES --------------------


// -------------------- STATIC VARIABLES --------------------


// ------------------------------ END: LIST OF VARIABLES ------------------------------
// ------------------------------ START: CALLING OTHER SCRIPTS ------------------------------
    // Scene Change
    public SceneChange Scene02LoadRun;

// ------------------------------ END: CALLING OTHER SCRIPTS ------------------------------
// ------------------------------ START: CALLING INITIAL FUNCTIONS ------------------------------
// -------------------- START FUNCTION --------------------
    void Start() {
        // MainMenuButton
        Button MainMenuButtonClick = MainMenuButton.GetComponent<Button>();
        MainMenuButtonClick.onClick.AddListener(MainMenuButtonClicking);

        // SettingsButton
        Button SettingsButtonClick = SettingsButton.GetComponent<Button>();
        SettingsButtonClick.onClick.AddListener(SettingsButtonClicking);

        // BubbleNotesAOff
        Button BubbleNotesAOffClick = BubbleNotesAOff.GetComponent<Button>();
        BubbleNotesAOffClick.onClick.AddListener(BubbleNotesAOffClicking);

        // BubbleNotesBOff
        Button BubbleNotesBOffClick = BubbleNotesBOff.GetComponent<Button>();
        BubbleNotesBOffClick.onClick.AddListener(BubbleNotesBOffClicking);

        // BubbleNotesCOff
        Button BubbleNotesCOffClick = BubbleNotesCOff.GetComponent<Button>();
        BubbleNotesCOffClick.onClick.AddListener(BubbleNotesCOffClicking);

        // BubbleNotesDOff
        Button BubbleNotesDOffClick = BubbleNotesDOff.GetComponent<Button>();
        BubbleNotesDOffClick.onClick.AddListener(BubbleNotesDOffClicking);

        // BubbleNotesEOff
        Button BubbleNotesEOffClick = BubbleNotesEOff.GetComponent<Button>();
        BubbleNotesEOffClick.onClick.AddListener(BubbleNotesEOffClicking);

        // BubbleNotesFOff
        Button BubbleNotesFOffClick = BubbleNotesFOff.GetComponent<Button>();
        BubbleNotesFOffClick.onClick.AddListener(BubbleNotesFOffClicking);

        // BubbleNotesGOff
        Button BubbleNotesGOffClick = BubbleNotesGOff.GetComponent<Button>();
        BubbleNotesGOffClick.onClick.AddListener(BubbleNotesGOffClicking);

        // BubbleNotesOctaveOff
        Button BubbleNotesOctaveOffClick = BubbleNotesOctaveOff.GetComponent<Button>();
        BubbleNotesOctaveOffClick.onClick.AddListener(BubbleNotesOctaveOffClicking);

        // BubbleNotesAOn
        Button BubbleNotesAOnClick = BubbleNotesAOn.GetComponent<Button>();
        BubbleNotesAOnClick.onClick.AddListener(BubbleNotesAOnClicking);

        // BubbleNotesBOn
        Button BubbleNotesBOnClick = BubbleNotesBOn.GetComponent<Button>();
        BubbleNotesBOnClick.onClick.AddListener(BubbleNotesBOnClicking);

        // BubbleNotesCOn
        Button BubbleNotesCOnClick = BubbleNotesCOn.GetComponent<Button>();
        BubbleNotesCOnClick.onClick.AddListener(BubbleNotesCOnClicking);

        // BubbleNotesDOn
        Button BubbleNotesDOnClick = BubbleNotesDOn.GetComponent<Button>();
        BubbleNotesDOnClick.onClick.AddListener(BubbleNotesDOnClicking);

        // BubbleNotesEOn
        Button BubbleNotesEOnClick = BubbleNotesEOn.GetComponent<Button>();
        BubbleNotesEOnClick.onClick.AddListener(BubbleNotesEOnClicking);

        // BubbleNotesFOn
        Button BubbleNotesFOnClick = BubbleNotesFOn.GetComponent<Button>();
        BubbleNotesFOnClick.onClick.AddListener(BubbleNotesFOnClicking);

        // BubbleNotesGOn
        Button BubbleNotesGOnClick = BubbleNotesGOn.GetComponent<Button>();
        BubbleNotesGOnClick.onClick.AddListener(BubbleNotesGOnClicking);

        // BubbleNotesOctaveOn
        Button BubbleNotesOctaveOnClick = BubbleNotesOctaveOn.GetComponent<Button>();
        BubbleNotesOctaveOnClick.onClick.AddListener(BubbleNotesOctaveOnClicking);

        // CoralAOff
        Button CoralAOffClick = CoralAOff.GetComponent<Button>();
        CoralAOffClick.onClick.AddListener(CoralAOffClicking);

        // CoralBOff
        Button CoralBOffClick = CoralBOff.GetComponent<Button>();
        CoralBOffClick.onClick.AddListener(CoralBOffClicking);

        // CoralCOff
        Button CoralCOffClick = CoralCOff.GetComponent<Button>();
        CoralCOffClick.onClick.AddListener(CoralCOffClicking);

        // CoralDOff
        Button CoralDOffClick = CoralDOff.GetComponent<Button>();
        CoralDOffClick.onClick.AddListener(CoralDOffClicking);

        // CoralEOff
        Button CoralEOffClick = CoralEOff.GetComponent<Button>();
        CoralEOffClick.onClick.AddListener(CoralEOffClicking);

        // CoralFOff
        Button CoralFOffClick = CoralFOff.GetComponent<Button>();
        CoralFOffClick.onClick.AddListener(CoralFOffClicking);

        // CoralGOff
        Button CoralGOffClick = CoralGOff.GetComponent<Button>();
        CoralGOffClick.onClick.AddListener(CoralGOffClicking);

        // CoralOctaveOff
        Button CoralOctaveOffClick = CoralOctaveOff.GetComponent<Button>();
        CoralOctaveOffClick.onClick.AddListener(CoralOctaveOffClicking);

        // CoralAOn
        Button CoralAOnClick = CoralAOn.GetComponent<Button>();
        CoralAOnClick.onClick.AddListener(CoralAOnClicking);

        // CoralBOn
        Button CoralBOnClick = CoralBOn.GetComponent<Button>();
        CoralBOnClick.onClick.AddListener(CoralBOnClicking);

        // CoralCOn
        Button CoralCOnClick = CoralCOn.GetComponent<Button>();
        CoralCOnClick.onClick.AddListener(CoralCOnClicking);

        // CoralDOn
        Button CoralDOnClick = CoralDOn.GetComponent<Button>();
        CoralDOnClick.onClick.AddListener(CoralDOnClicking);

        // CoralEOn
        Button CoralEOnClick = CoralEOn.GetComponent<Button>();
        CoralEOnClick.onClick.AddListener(CoralEOnClicking);

        // CoralFOn
        Button CoralFOnClick = CoralFOn.GetComponent<Button>();
        CoralFOnClick.onClick.AddListener(CoralFOnClicking);

        // CoralGOn
        Button CoralGOnClick = CoralGOn.GetComponent<Button>();
        CoralGOnClick.onClick.AddListener(CoralGOnClicking);

        // CoralOctaveOn
        Button CoralOctaveOnClick = CoralOctaveOn.GetComponent<Button>();
        CoralOctaveOnClick.onClick.AddListener(CoralOctaveOnClicking);

        // IntroPriorButton
        Button IntroPriorButtonClick = IntroPriorButton.GetComponent<Button>();
        IntroPriorButtonClick.onClick.AddListener(IntroPriorButtonClicking);

        // IntroNextButton
        Button IntroNextButtonClick = IntroNextButton.GetComponent<Button>();
        IntroNextButtonClick.onClick.AddListener(IntroNextButtonClicking);

        // IntroPlayButton
        Button IntroPlayButtonClick = IntroPlayButton.GetComponent<Button>();
        IntroPlayButtonClick.onClick.AddListener(IntroPlayButtonClicking);

        // SettingsOnButton
        Button SettingsOnButtonClick = SettingsOnButton.GetComponent<Button>();
        SettingsOnButtonClick.onClick.AddListener(SettingsOnButtonClicking);

        // SettingsOffButton
        Button SettingsOffButtonClick = SettingsOffButton.GetComponent<Button>();
        SettingsOffButtonClick.onClick.AddListener(SettingsOffButtonClicking);

        // SettingsBackButton
        Button SettingsBackButtonClick = SettingsBackButton.GetComponent<Button>();
        SettingsBackButtonClick.onClick.AddListener(SettingsBackButtonClicking);
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
    public void MainMenuButtonClicking() {
        Scene02LoadRun.Scene02Load();
    }

    public void SettingsButtonClicking() {
        EnableObjects03.SettingPanelOnOff = 1;
    }

    public void BubbleNotesAOffClicking() {
        EnableObjects03.CoralAOnOff = 0;
        EnableObjects03.CoralBOnOff = 0;
        EnableObjects03.CoralCOnOff = 0;
        EnableObjects03.CoralDOnOff = 0;
        EnableObjects03.CoralEOnOff = 0;
        EnableObjects03.CoralFOnOff = 0;
        EnableObjects03.CoralGOnOff = 0;
        EnableObjects03.CoralOctaveOnOff = 0;
        EnableObjects03.CoralAOnOff = 1;
        // Unmute A Note
    }

    public void BubbleNotesBOffClicking() {
        EnableObjects03.CoralAOnOff = 0;
        EnableObjects03.CoralBOnOff = 0;
        EnableObjects03.CoralCOnOff = 0;
        EnableObjects03.CoralDOnOff = 0;
        EnableObjects03.CoralEOnOff = 0;
        EnableObjects03.CoralFOnOff = 0;
        EnableObjects03.CoralGOnOff = 0;
        EnableObjects03.CoralOctaveOnOff = 0;
        EnableObjects03.CoralBOnOff = 1;
        // Unmute B Note
    }

    public void BubbleNotesCOffClicking() {
        EnableObjects03.CoralAOnOff = 0;
        EnableObjects03.CoralBOnOff = 0;
        EnableObjects03.CoralCOnOff = 0;
        EnableObjects03.CoralDOnOff = 0;
        EnableObjects03.CoralEOnOff = 0;
        EnableObjects03.CoralFOnOff = 0;
        EnableObjects03.CoralGOnOff = 0;
        EnableObjects03.CoralOctaveOnOff = 0;
        EnableObjects03.CoralCOnOff = 1;
        // Unmute C Note
    }

    public void BubbleNotesDOffClicking() {
        EnableObjects03.CoralAOnOff = 0;
        EnableObjects03.CoralBOnOff = 0;
        EnableObjects03.CoralCOnOff = 0;
        EnableObjects03.CoralDOnOff = 0;
        EnableObjects03.CoralEOnOff = 0;
        EnableObjects03.CoralFOnOff = 0;
        EnableObjects03.CoralGOnOff = 0;
        EnableObjects03.CoralOctaveOnOff = 0;
        EnableObjects03.CoralDOnOff = 1;
        // Unmute D Note
    }

    public void BubbleNotesEOffClicking() {
        EnableObjects03.CoralAOnOff = 0;
        EnableObjects03.CoralBOnOff = 0;
        EnableObjects03.CoralCOnOff = 0;
        EnableObjects03.CoralDOnOff = 0;
        EnableObjects03.CoralEOnOff = 0;
        EnableObjects03.CoralFOnOff = 0;
        EnableObjects03.CoralGOnOff = 0;
        EnableObjects03.CoralOctaveOnOff = 0;
        EnableObjects03.CoralEOnOff = 1;
        // Unmute E Note
    }

    public void BubbleNotesFOffClicking() {
        EnableObjects03.CoralAOnOff = 0;
        EnableObjects03.CoralBOnOff = 0;
        EnableObjects03.CoralCOnOff = 0;
        EnableObjects03.CoralDOnOff = 0;
        EnableObjects03.CoralEOnOff = 0;
        EnableObjects03.CoralFOnOff = 0;
        EnableObjects03.CoralGOnOff = 0;
        EnableObjects03.CoralOctaveOnOff = 0;
        EnableObjects03.CoralFOnOff = 1;
        // Unmute F Note
    }

    public void BubbleNotesGOffClicking() {
        EnableObjects03.CoralAOnOff = 0;
        EnableObjects03.CoralBOnOff = 0;
        EnableObjects03.CoralCOnOff = 0;
        EnableObjects03.CoralDOnOff = 0;
        EnableObjects03.CoralEOnOff = 0;
        EnableObjects03.CoralFOnOff = 0;
        EnableObjects03.CoralGOnOff = 0;
        EnableObjects03.CoralOctaveOnOff = 0;
        EnableObjects03.CoralGOnOff = 1;
        // Unmute G Note
    }

    public void BubbleNotesOctaveOffClicking() {
        if ((EnableObjects03.CoralAOnOff == 1) || (EnableObjects03.CoralBOnOff == 1) || (EnableObjects03.CoralCOnOff == 1) || (EnableObjects03.CoralDOnOff == 1) || (EnableObjects03.CoralEOnOff == 1) || (EnableObjects03.CoralFOnOff == 1) || (EnableObjects03.CoralGOnOff == 1)) {
            EnableObjects03.CoralOctaveOnOff = 1;
        }

        else {
            EnableObjects03.CoralOctaveOnOff = 0;
        }
        // Unmute Octave Note
    }

    public void BubbleNotesAOnClicking() {
        EnableObjects03.CoralAOnOff = 0;
        EnableObjects03.CoralBOnOff = 0;
        EnableObjects03.CoralCOnOff = 0;
        EnableObjects03.CoralDOnOff = 0;
        EnableObjects03.CoralEOnOff = 0;
        EnableObjects03.CoralFOnOff = 0;
        EnableObjects03.CoralGOnOff = 0;
        EnableObjects03.CoralOctaveOnOff = 0;
        EnableObjects03.CoralAOnOff = 0;
        // Mute A Note
    }

    public void BubbleNotesBOnClicking() {
        EnableObjects03.CoralAOnOff = 0;
        EnableObjects03.CoralBOnOff = 0;
        EnableObjects03.CoralCOnOff = 0;
        EnableObjects03.CoralDOnOff = 0;
        EnableObjects03.CoralEOnOff = 0;
        EnableObjects03.CoralFOnOff = 0;
        EnableObjects03.CoralGOnOff = 0;
        EnableObjects03.CoralOctaveOnOff = 0;
        EnableObjects03.CoralBOnOff = 0;
        // Mute B Note
    }

    public void BubbleNotesCOnClicking() {
        EnableObjects03.CoralAOnOff = 0;
        EnableObjects03.CoralBOnOff = 0;
        EnableObjects03.CoralCOnOff = 0;
        EnableObjects03.CoralDOnOff = 0;
        EnableObjects03.CoralEOnOff = 0;
        EnableObjects03.CoralFOnOff = 0;
        EnableObjects03.CoralGOnOff = 0;
        EnableObjects03.CoralOctaveOnOff = 0;
        EnableObjects03.CoralCOnOff = 0;
        // Mute C Note
    }

    public void BubbleNotesDOnClicking() {
        EnableObjects03.CoralAOnOff = 0;
        EnableObjects03.CoralBOnOff = 0;
        EnableObjects03.CoralCOnOff = 0;
        EnableObjects03.CoralDOnOff = 0;
        EnableObjects03.CoralEOnOff = 0;
        EnableObjects03.CoralFOnOff = 0;
        EnableObjects03.CoralGOnOff = 0;
        EnableObjects03.CoralOctaveOnOff = 0;
        EnableObjects03.CoralDOnOff = 0;
        // Mute D Note
    }

    public void BubbleNotesEOnClicking() {
        EnableObjects03.CoralAOnOff = 0;
        EnableObjects03.CoralBOnOff = 0;
        EnableObjects03.CoralCOnOff = 0;
        EnableObjects03.CoralDOnOff = 0;
        EnableObjects03.CoralEOnOff = 0;
        EnableObjects03.CoralFOnOff = 0;
        EnableObjects03.CoralGOnOff = 0;
        EnableObjects03.CoralOctaveOnOff = 0;
        EnableObjects03.CoralEOnOff = 0;
        // Mute E Note
    }

    public void BubbleNotesFOnClicking() {
        EnableObjects03.CoralAOnOff = 0;
        EnableObjects03.CoralBOnOff = 0;
        EnableObjects03.CoralCOnOff = 0;
        EnableObjects03.CoralDOnOff = 0;
        EnableObjects03.CoralEOnOff = 0;
        EnableObjects03.CoralFOnOff = 0;
        EnableObjects03.CoralGOnOff = 0;
        EnableObjects03.CoralOctaveOnOff = 0;
        EnableObjects03.CoralFOnOff = 0;
        // Mute F Note
    }

    public void BubbleNotesGOnClicking() {
        EnableObjects03.CoralAOnOff = 0;
        EnableObjects03.CoralBOnOff = 0;
        EnableObjects03.CoralCOnOff = 0;
        EnableObjects03.CoralDOnOff = 0;
        EnableObjects03.CoralEOnOff = 0;
        EnableObjects03.CoralFOnOff = 0;
        EnableObjects03.CoralGOnOff = 0;
        EnableObjects03.CoralOctaveOnOff = 0;
        EnableObjects03.CoralGOnOff = 0;
        // Mute G Note
    }

    public void BubbleNotesOctaveOnClicking() {
        EnableObjects03.CoralOctaveOnOff = 0;
        // Mute Octave Note
    }

    public void CoralAOffClicking() {
        EnableObjects03.CoralAOnOff = 0;
        EnableObjects03.CoralBOnOff = 0;
        EnableObjects03.CoralCOnOff = 0;
        EnableObjects03.CoralDOnOff = 0;
        EnableObjects03.CoralEOnOff = 0;
        EnableObjects03.CoralFOnOff = 0;
        EnableObjects03.CoralGOnOff = 0;
        EnableObjects03.CoralOctaveOnOff = 0;
        EnableObjects03.CoralAOnOff = 1;
        // Unmute A Note
    }

    public void CoralBOffClicking() {
        EnableObjects03.CoralAOnOff = 0;
        EnableObjects03.CoralBOnOff = 0;
        EnableObjects03.CoralCOnOff = 0;
        EnableObjects03.CoralDOnOff = 0;
        EnableObjects03.CoralEOnOff = 0;
        EnableObjects03.CoralFOnOff = 0;
        EnableObjects03.CoralGOnOff = 0;
        EnableObjects03.CoralOctaveOnOff = 0;
        EnableObjects03.CoralBOnOff = 1;
        // Unmute B Note
    }

    public void CoralCOffClicking() {
        EnableObjects03.CoralAOnOff = 0;
        EnableObjects03.CoralBOnOff = 0;
        EnableObjects03.CoralCOnOff = 0;
        EnableObjects03.CoralDOnOff = 0;
        EnableObjects03.CoralEOnOff = 0;
        EnableObjects03.CoralFOnOff = 0;
        EnableObjects03.CoralGOnOff = 0;
        EnableObjects03.CoralOctaveOnOff = 0;
        EnableObjects03.CoralCOnOff = 1;
        // Unmute C Note
    }

    public void CoralDOffClicking() {
        EnableObjects03.CoralAOnOff = 0;
        EnableObjects03.CoralBOnOff = 0;
        EnableObjects03.CoralCOnOff = 0;
        EnableObjects03.CoralDOnOff = 0;
        EnableObjects03.CoralEOnOff = 0;
        EnableObjects03.CoralFOnOff = 0;
        EnableObjects03.CoralGOnOff = 0;
        EnableObjects03.CoralOctaveOnOff = 0;
        EnableObjects03.CoralDOnOff = 1;
        // Unmute D Note
    }

    public void CoralEOffClicking() {
        EnableObjects03.CoralAOnOff = 0;
        EnableObjects03.CoralBOnOff = 0;
        EnableObjects03.CoralCOnOff = 0;
        EnableObjects03.CoralDOnOff = 0;
        EnableObjects03.CoralEOnOff = 0;
        EnableObjects03.CoralFOnOff = 0;
        EnableObjects03.CoralGOnOff = 0;
        EnableObjects03.CoralOctaveOnOff = 0;
        EnableObjects03.CoralEOnOff = 1;
        // Unmute E Note
    }

    public void CoralFOffClicking() {
        EnableObjects03.CoralAOnOff = 0;
        EnableObjects03.CoralBOnOff = 0;
        EnableObjects03.CoralCOnOff = 0;
        EnableObjects03.CoralDOnOff = 0;
        EnableObjects03.CoralEOnOff = 0;
        EnableObjects03.CoralFOnOff = 0;
        EnableObjects03.CoralGOnOff = 0;
        EnableObjects03.CoralOctaveOnOff = 0;
        EnableObjects03.CoralFOnOff = 1;
        // Unmute F Note
    }

    public void CoralGOffClicking() {
        EnableObjects03.CoralAOnOff = 0;
        EnableObjects03.CoralBOnOff = 0;
        EnableObjects03.CoralCOnOff = 0;
        EnableObjects03.CoralDOnOff = 0;
        EnableObjects03.CoralEOnOff = 0;
        EnableObjects03.CoralFOnOff = 0;
        EnableObjects03.CoralGOnOff = 0;
        EnableObjects03.CoralOctaveOnOff = 0;
        EnableObjects03.CoralGOnOff = 1;
        // Unmute G Note
    }

    public void CoralOctaveOffClicking() {
        if ((EnableObjects03.CoralAOnOff == 1) || (EnableObjects03.CoralBOnOff == 1) || (EnableObjects03.CoralCOnOff == 1) || (EnableObjects03.CoralDOnOff == 1) || (EnableObjects03.CoralEOnOff == 1) || (EnableObjects03.CoralFOnOff == 1) || (EnableObjects03.CoralGOnOff == 1)) {
            EnableObjects03.CoralOctaveOnOff = 1;
        }

        else {
            EnableObjects03.CoralOctaveOnOff = 0;
        }
        // Unmute Octave Note
    }

    public void CoralAOnClicking() {
        EnableObjects03.CoralAOnOff = 0;
        EnableObjects03.CoralBOnOff = 0;
        EnableObjects03.CoralCOnOff = 0;
        EnableObjects03.CoralDOnOff = 0;
        EnableObjects03.CoralEOnOff = 0;
        EnableObjects03.CoralFOnOff = 0;
        EnableObjects03.CoralGOnOff = 0;
        EnableObjects03.CoralOctaveOnOff = 0;
        EnableObjects03.CoralAOnOff = 0;
        // Mute A Note
    }

    public void CoralBOnClicking() {
        EnableObjects03.CoralAOnOff = 0;
        EnableObjects03.CoralBOnOff = 0;
        EnableObjects03.CoralCOnOff = 0;
        EnableObjects03.CoralDOnOff = 0;
        EnableObjects03.CoralEOnOff = 0;
        EnableObjects03.CoralFOnOff = 0;
        EnableObjects03.CoralGOnOff = 0;
        EnableObjects03.CoralOctaveOnOff = 0;
        EnableObjects03.CoralBOnOff = 0;
        // Mute B Note
    }

    public void CoralCOnClicking() {
        EnableObjects03.CoralAOnOff = 0;
        EnableObjects03.CoralBOnOff = 0;
        EnableObjects03.CoralCOnOff = 0;
        EnableObjects03.CoralDOnOff = 0;
        EnableObjects03.CoralEOnOff = 0;
        EnableObjects03.CoralFOnOff = 0;
        EnableObjects03.CoralGOnOff = 0;
        EnableObjects03.CoralOctaveOnOff = 0;
        EnableObjects03.CoralCOnOff = 0;
        // Mute C Note
    }

    public void CoralDOnClicking() {
        EnableObjects03.CoralAOnOff = 0;
        EnableObjects03.CoralBOnOff = 0;
        EnableObjects03.CoralCOnOff = 0;
        EnableObjects03.CoralDOnOff = 0;
        EnableObjects03.CoralEOnOff = 0;
        EnableObjects03.CoralFOnOff = 0;
        EnableObjects03.CoralGOnOff = 0;
        EnableObjects03.CoralOctaveOnOff = 0;
        EnableObjects03.CoralDOnOff = 0;
        // Mute D Note
    }

    public void CoralEOnClicking() {
        EnableObjects03.CoralAOnOff = 0;
        EnableObjects03.CoralBOnOff = 0;
        EnableObjects03.CoralCOnOff = 0;
        EnableObjects03.CoralDOnOff = 0;
        EnableObjects03.CoralEOnOff = 0;
        EnableObjects03.CoralFOnOff = 0;
        EnableObjects03.CoralGOnOff = 0;
        EnableObjects03.CoralOctaveOnOff = 0;
        EnableObjects03.CoralEOnOff = 0;
        // Mute E Note
    }

    public void CoralFOnClicking() {
        EnableObjects03.CoralAOnOff = 0;
        EnableObjects03.CoralBOnOff = 0;
        EnableObjects03.CoralCOnOff = 0;
        EnableObjects03.CoralDOnOff = 0;
        EnableObjects03.CoralEOnOff = 0;
        EnableObjects03.CoralFOnOff = 0;
        EnableObjects03.CoralGOnOff = 0;
        EnableObjects03.CoralOctaveOnOff = 0;
        EnableObjects03.CoralFOnOff = 0;
        // Mute F Note
    }

    public void CoralGOnClicking() {
        EnableObjects03.CoralAOnOff = 0;
        EnableObjects03.CoralBOnOff = 0;
        EnableObjects03.CoralCOnOff = 0;
        EnableObjects03.CoralDOnOff = 0;
        EnableObjects03.CoralEOnOff = 0;
        EnableObjects03.CoralFOnOff = 0;
        EnableObjects03.CoralGOnOff = 0;
        EnableObjects03.CoralOctaveOnOff = 0;
        EnableObjects03.CoralGOnOff = 0;
        // Mute G Note
    }

    public void CoralOctaveOnClicking() {
        EnableObjects03.CoralOctaveOnOff = 0;
        // Mute Octave Note
    }

    public void IntroPriorButtonClicking() {
        if (EnableObjects00.IntroSlideInt == 2) {
            EnableObjects00.IntroSlideInt = 1;
        }

        else if (EnableObjects00.IntroSlideInt == 3) {
            EnableObjects00.IntroSlideInt = 2;
        }

        else if (EnableObjects00.IntroSlideInt == 4) {
            EnableObjects00.IntroSlideInt = 3;
        }
    }

    public void IntroNextButtonClicking() {
        if (EnableObjects00.IntroSlideInt == 1) {
            EnableObjects00.IntroSlideInt = 2;
        }

        else if (EnableObjects00.IntroSlideInt == 2) {
            EnableObjects00.IntroSlideInt = 3;
        }

        else if (EnableObjects00.IntroSlideInt == 3) {
            EnableObjects00.IntroSlideInt = 4;
        }
    }

    public void IntroPlayButtonClicking() {
        EnableObjects00.IntroSlideInt = 5;
    }

    public void SettingsOnButtonClicking() {
        EnableObjects03.SettingNotesOnOff = 0;
    }

    public void SettingsOffButtonClicking() {
        EnableObjects03.SettingNotesOnOff = 1;
    }

    public void SettingsBackButtonClicking() {
        EnableObjects03.SettingPanelOnOff = 0;
    }

// ------------------------------ END: OTHER FUNCTIONS ------------------------------

}