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

    // Piano Notes
    public AudioSource PianoNoteA4;
    public AudioSource PianoNoteB4;
    public AudioSource PianoNoteC4;
    public AudioSource PianoNoteD4;
    public AudioSource PianoNoteE4;
    public AudioSource PianoNoteF4;
    public AudioSource PianoNoteG4;
    public AudioSource PianoNoteA5;
    public AudioSource PianoNoteB5;
    public AudioSource PianoNoteC5;
    public AudioSource PianoNoteD5;
    public AudioSource PianoNoteE5;
    public AudioSource PianoNoteF5;
    public AudioSource PianoNoteG5;

    // Particle Systems
    public ParticleSystem BubblesA;
    public ParticleSystem BubblesB;
    public ParticleSystem BubblesC;
    public ParticleSystem BubblesD;
    public ParticleSystem BubblesE;
    public ParticleSystem BubblesF;
    public ParticleSystem BubblesG;
    public ParticleSystem BubblesOctave;

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

        // Piano Notes
        PianoNoteA4.Stop();
        PianoNoteB4.Stop();
        PianoNoteC4.Stop();
        PianoNoteD4.Stop();
        PianoNoteE4.Stop();
        PianoNoteF4.Stop();
        PianoNoteG4.Stop();
        PianoNoteA5.Stop();
        PianoNoteB5.Stop();
        PianoNoteC5.Stop();
        PianoNoteD5.Stop();
        PianoNoteE5.Stop();
        PianoNoteF5.Stop();
        PianoNoteG5.Stop();
        PianoNoteA4.volume = 0.0f;
        PianoNoteB4.volume = 0.0f;
        PianoNoteC4.volume = 0.0f;
        PianoNoteD4.volume = 0.0f;
        PianoNoteE4.volume = 0.0f;
        PianoNoteF4.volume = 0.0f;
        PianoNoteG4.volume = 0.0f;
        PianoNoteA5.volume = 0.0f;
        PianoNoteB5.volume = 0.0f;
        PianoNoteC5.volume = 0.0f;
        PianoNoteD5.volume = 0.0f;
        PianoNoteE5.volume = 0.0f;
        PianoNoteF5.volume = 0.0f;
        PianoNoteG5.volume = 0.0f;
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
        if ((EnableObjects03.ActionNoteInt == 1) || (EnableObjects03.ActionNoteInt == 8) || (EnableObjects03.ActionNoteInt == 15)) {
            EnableObjects03.CoralAOnOff = 0;
            EnableObjects03.CoralBOnOff = 0;
            EnableObjects03.CoralCOnOff = 0;
            EnableObjects03.CoralDOnOff = 0;
            EnableObjects03.CoralEOnOff = 0;
            EnableObjects03.CoralFOnOff = 0;
            EnableObjects03.CoralGOnOff = 0;
            EnableObjects03.CoralAOnOff = 1;

            PianoNoteA4.Stop();
            PianoNoteB4.Stop();
            PianoNoteC4.Stop();
            PianoNoteD4.Stop();
            PianoNoteE4.Stop();
            PianoNoteF4.Stop();
            PianoNoteG4.Stop();
            PianoNoteA5.Stop();
            PianoNoteB5.Stop();
            PianoNoteC5.Stop();
            PianoNoteD5.Stop();
            PianoNoteE5.Stop();
            PianoNoteF5.Stop();
            PianoNoteG5.Stop();
        }

        if (EnableObjects03.CoralOctaveOnOff == 1) {
            if (EnableObjects03.ActionNoteInt == 8) {
                PianoNoteA5.volume = 3.0f;
                PianoNoteA5.Play();
                BubblesA.Play();
                EnableObjects03.ActionNoteInt = 9;
            }
        }

        else if (EnableObjects03.CoralOctaveOnOff == 0) {
            if ((EnableObjects03.ActionNoteInt == 1) || (EnableObjects03.ActionNoteInt == 15)) {
                PianoNoteA4.volume = 3.0f;
                PianoNoteA4.Play();
                BubblesA.Play();

                if (EnableObjects03.ActionNoteInt == 1) {
                    EnableObjects03.ActionNoteInt = 2;
                }

                else if (EnableObjects03.ActionNoteInt == 15) {
                    EnableObjects03.ActionNoteInt = 16;
                }
            }
        }
    }

    public void BubbleNotesBOffClicking() {
        if ((EnableObjects03.ActionNoteInt == 4) || (EnableObjects03.ActionNoteInt == 11)) {
            EnableObjects03.CoralAOnOff = 0;
            EnableObjects03.CoralBOnOff = 0;
            EnableObjects03.CoralCOnOff = 0;
            EnableObjects03.CoralDOnOff = 0;
            EnableObjects03.CoralEOnOff = 0;
            EnableObjects03.CoralFOnOff = 0;
            EnableObjects03.CoralGOnOff = 0;
            EnableObjects03.CoralBOnOff = 1;

            PianoNoteA4.Stop();
            PianoNoteB4.Stop();
            PianoNoteC4.Stop();
            PianoNoteD4.Stop();
            PianoNoteE4.Stop();
            PianoNoteF4.Stop();
            PianoNoteG4.Stop();
            PianoNoteA5.Stop();
            PianoNoteB5.Stop();
            PianoNoteC5.Stop();
            PianoNoteD5.Stop();
            PianoNoteE5.Stop();
            PianoNoteF5.Stop();
            PianoNoteG5.Stop();
        }

        if (EnableObjects03.CoralOctaveOnOff == 1) {
            if (EnableObjects03.ActionNoteInt == 11) {
                PianoNoteB5.volume = 3.0f;
                PianoNoteB5.Play();
                BubblesB.Play();
                EnableObjects03.ActionNoteInt = 12;
            }
        }

        else if (EnableObjects03.CoralOctaveOnOff == 0) {
            if (EnableObjects03.ActionNoteInt == 4) {
                PianoNoteB4.volume = 3.0f;
                PianoNoteB4.Play();
                BubblesB.Play();
                EnableObjects03.ActionNoteInt = 5;
            }
        }
    }

    public void BubbleNotesCOffClicking() {
        if ((EnableObjects03.ActionNoteInt == 6) || (EnableObjects03.ActionNoteInt == 13)) {
            EnableObjects03.CoralAOnOff = 0;
            EnableObjects03.CoralBOnOff = 0;
            EnableObjects03.CoralCOnOff = 0;
            EnableObjects03.CoralDOnOff = 0;
            EnableObjects03.CoralEOnOff = 0;
            EnableObjects03.CoralFOnOff = 0;
            EnableObjects03.CoralGOnOff = 0;
            EnableObjects03.CoralCOnOff = 1;

            PianoNoteA4.Stop();
            PianoNoteB4.Stop();
            PianoNoteC4.Stop();
            PianoNoteD4.Stop();
            PianoNoteE4.Stop();
            PianoNoteF4.Stop();
            PianoNoteG4.Stop();
            PianoNoteA5.Stop();
            PianoNoteB5.Stop();
            PianoNoteC5.Stop();
            PianoNoteD5.Stop();
            PianoNoteE5.Stop();
            PianoNoteF5.Stop();
            PianoNoteG5.Stop();
        }

        if (EnableObjects03.CoralOctaveOnOff == 1) {
            if (EnableObjects03.ActionNoteInt == 13) {
                PianoNoteC5.volume = 3.0f;
                PianoNoteC5.Play();
                BubblesC.Play();
                EnableObjects03.ActionNoteInt = 14;
            }
        }

        else if (EnableObjects03.CoralOctaveOnOff == 0) {
            if (EnableObjects03.ActionNoteInt == 6) {
                PianoNoteC4.volume = 3.0f;
                PianoNoteC4.Play();
                BubblesC.Play();
                EnableObjects03.ActionNoteInt = 7;
            }
        }
    }

    public void BubbleNotesDOffClicking() {
        if ((EnableObjects03.ActionNoteInt == 2) || (EnableObjects03.ActionNoteInt == 10)) {
            EnableObjects03.CoralAOnOff = 0;
            EnableObjects03.CoralBOnOff = 0;
            EnableObjects03.CoralCOnOff = 0;
            EnableObjects03.CoralDOnOff = 0;
            EnableObjects03.CoralEOnOff = 0;
            EnableObjects03.CoralFOnOff = 0;
            EnableObjects03.CoralGOnOff = 0;
            EnableObjects03.CoralDOnOff = 1;

            PianoNoteA4.Stop();
            PianoNoteB4.Stop();
            PianoNoteC4.Stop();
            PianoNoteD4.Stop();
            PianoNoteE4.Stop();
            PianoNoteF4.Stop();
            PianoNoteG4.Stop();
            PianoNoteA5.Stop();
            PianoNoteB5.Stop();
            PianoNoteC5.Stop();
            PianoNoteD5.Stop();
            PianoNoteE5.Stop();
            PianoNoteF5.Stop();
            PianoNoteG5.Stop();
        }

        if (EnableObjects03.CoralOctaveOnOff == 1) {
            if (EnableObjects03.ActionNoteInt == 10) {
                PianoNoteD5.volume = 3.0f;
                PianoNoteD5.Play();
                BubblesD.Play();
                EnableObjects03.ActionNoteInt = 11;
            }
        }

        else if (EnableObjects03.CoralOctaveOnOff == 0) {
            if (EnableObjects03.ActionNoteInt == 2) {
                PianoNoteD4.volume = 3.0f;
                PianoNoteD4.Play();
                BubblesD.Play();
                EnableObjects03.ActionNoteInt = 3;
            }
        }
    }

    public void BubbleNotesEOffClicking() {
        if ((EnableObjects03.ActionNoteInt == 5) || (EnableObjects03.ActionNoteInt == 14)) {
            EnableObjects03.CoralAOnOff = 0;
            EnableObjects03.CoralBOnOff = 0;
            EnableObjects03.CoralCOnOff = 0;
            EnableObjects03.CoralDOnOff = 0;
            EnableObjects03.CoralEOnOff = 0;
            EnableObjects03.CoralFOnOff = 0;
            EnableObjects03.CoralGOnOff = 0;
            EnableObjects03.CoralEOnOff = 1;

            PianoNoteA4.Stop();
            PianoNoteB4.Stop();
            PianoNoteC4.Stop();
            PianoNoteD4.Stop();
            PianoNoteE4.Stop();
            PianoNoteF4.Stop();
            PianoNoteG4.Stop();
            PianoNoteA5.Stop();
            PianoNoteB5.Stop();
            PianoNoteC5.Stop();
            PianoNoteD5.Stop();
            PianoNoteE5.Stop();
            PianoNoteF5.Stop();
            PianoNoteG5.Stop();
        }

        if (EnableObjects03.CoralOctaveOnOff == 1) {
            if (EnableObjects03.ActionNoteInt == 14) {
                PianoNoteE5.volume = 3.0f;
                PianoNoteE5.Play();
                BubblesE.Play();
                EnableObjects03.ActionNoteInt = 15;
            }
        }

        else if (EnableObjects03.CoralOctaveOnOff == 0) {
            if (EnableObjects03.ActionNoteInt == 5) {
                PianoNoteE4.volume = 3.0f;
                PianoNoteE4.Play();
                BubblesE.Play();
                EnableObjects03.ActionNoteInt = 6;
            }
        }
    }

    public void BubbleNotesFOffClicking() {
        if ((EnableObjects03.ActionNoteInt == 7) || (EnableObjects03.ActionNoteInt == 12)) {
            EnableObjects03.CoralAOnOff = 0;
            EnableObjects03.CoralBOnOff = 0;
            EnableObjects03.CoralCOnOff = 0;
            EnableObjects03.CoralDOnOff = 0;
            EnableObjects03.CoralEOnOff = 0;
            EnableObjects03.CoralFOnOff = 0;
            EnableObjects03.CoralGOnOff = 0;
            EnableObjects03.CoralFOnOff = 1;

            PianoNoteA4.Stop();
            PianoNoteB4.Stop();
            PianoNoteC4.Stop();
            PianoNoteD4.Stop();
            PianoNoteE4.Stop();
            PianoNoteF4.Stop();
            PianoNoteG4.Stop();
            PianoNoteA5.Stop();
            PianoNoteB5.Stop();
            PianoNoteC5.Stop();
            PianoNoteD5.Stop();
            PianoNoteE5.Stop();
            PianoNoteF5.Stop();
            PianoNoteG5.Stop();
        }

        if (EnableObjects03.CoralOctaveOnOff == 1) {
            if (EnableObjects03.ActionNoteInt == 12) {
                PianoNoteF5.volume = 3.0f;
                PianoNoteF5.Play();
                BubblesF.Play();
                EnableObjects03.ActionNoteInt = 13;
            }
        }

        else if (EnableObjects03.CoralOctaveOnOff == 0) {
            if (EnableObjects03.ActionNoteInt == 7) {
                PianoNoteF4.volume = 3.0f;
                PianoNoteF4.Play();
                BubblesF.Play();
                EnableObjects03.ActionNoteInt = 8;
            }
        }
    }

    public void BubbleNotesGOffClicking() {
        if ((EnableObjects03.ActionNoteInt == 3) || (EnableObjects03.ActionNoteInt == 9)) {
            EnableObjects03.CoralAOnOff = 0;
            EnableObjects03.CoralBOnOff = 0;
            EnableObjects03.CoralCOnOff = 0;
            EnableObjects03.CoralDOnOff = 0;
            EnableObjects03.CoralEOnOff = 0;
            EnableObjects03.CoralFOnOff = 0;
            EnableObjects03.CoralGOnOff = 0;
            EnableObjects03.CoralGOnOff = 1;

            PianoNoteA4.Stop();
            PianoNoteB4.Stop();
            PianoNoteC4.Stop();
            PianoNoteD4.Stop();
            PianoNoteE4.Stop();
            PianoNoteF4.Stop();
            PianoNoteG4.Stop();
            PianoNoteA5.Stop();
            PianoNoteB5.Stop();
            PianoNoteC5.Stop();
            PianoNoteD5.Stop();
            PianoNoteE5.Stop();
            PianoNoteF5.Stop();
            PianoNoteG5.Stop();
        }

        if (EnableObjects03.CoralOctaveOnOff == 1) {
            if (EnableObjects03.ActionNoteInt == 9) {
                PianoNoteG5.volume = 3.0f;
                PianoNoteG5.Play();
                BubblesG.Play();
                EnableObjects03.ActionNoteInt = 10;
            }
        }

        else if (EnableObjects03.CoralOctaveOnOff == 0) {
            if (EnableObjects03.ActionNoteInt == 3) {
                PianoNoteG4.volume = 3.0f;
                PianoNoteG4.Play();
                BubblesG.Play();
                EnableObjects03.ActionNoteInt = 4;
            }
        }
    }

    public void BubbleNotesOctaveOffClicking() {
        EnableObjects03.CoralOctaveOnOff = 1;
        BubblesOctave.Play();
    }

    public void BubbleNotesAOnClicking() {
        if ((EnableObjects03.ActionNoteInt == 1) || (EnableObjects03.ActionNoteInt == 8) || (EnableObjects03.ActionNoteInt == 15)) {
            EnableObjects03.CoralAOnOff = 0;
            EnableObjects03.CoralBOnOff = 0;
            EnableObjects03.CoralCOnOff = 0;
            EnableObjects03.CoralDOnOff = 0;
            EnableObjects03.CoralEOnOff = 0;
            EnableObjects03.CoralFOnOff = 0;
            EnableObjects03.CoralGOnOff = 0;
            EnableObjects03.CoralAOnOff = 1;

            PianoNoteA4.Stop();
            PianoNoteB4.Stop();
            PianoNoteC4.Stop();
            PianoNoteD4.Stop();
            PianoNoteE4.Stop();
            PianoNoteF4.Stop();
            PianoNoteG4.Stop();
            PianoNoteA5.Stop();
            PianoNoteB5.Stop();
            PianoNoteC5.Stop();
            PianoNoteD5.Stop();
            PianoNoteE5.Stop();
            PianoNoteF5.Stop();
            PianoNoteG5.Stop();
        }

        if (EnableObjects03.CoralOctaveOnOff == 1) {
            if (EnableObjects03.ActionNoteInt == 8) {
                PianoNoteA5.volume = 3.0f;
                PianoNoteA5.Play();
                BubblesA.Play();
                EnableObjects03.ActionNoteInt = 9;
            }
        }

        else if (EnableObjects03.CoralOctaveOnOff == 0) {
            if ((EnableObjects03.ActionNoteInt == 1) || (EnableObjects03.ActionNoteInt == 15)) {
                PianoNoteA4.volume = 3.0f;
                PianoNoteA4.Play();
                BubblesA.Play();

                if (EnableObjects03.ActionNoteInt == 1) {
                    EnableObjects03.ActionNoteInt = 2;
                }

                else if (EnableObjects03.ActionNoteInt == 15) {
                    EnableObjects03.ActionNoteInt = 16;
                }
            }
        }
    }

    public void BubbleNotesBOnClicking() {
        if ((EnableObjects03.ActionNoteInt == 4) || (EnableObjects03.ActionNoteInt == 11)) {
            EnableObjects03.CoralAOnOff = 0;
            EnableObjects03.CoralBOnOff = 0;
            EnableObjects03.CoralCOnOff = 0;
            EnableObjects03.CoralDOnOff = 0;
            EnableObjects03.CoralEOnOff = 0;
            EnableObjects03.CoralFOnOff = 0;
            EnableObjects03.CoralGOnOff = 0;
            EnableObjects03.CoralBOnOff = 1;

            PianoNoteA4.Stop();
            PianoNoteB4.Stop();
            PianoNoteC4.Stop();
            PianoNoteD4.Stop();
            PianoNoteE4.Stop();
            PianoNoteF4.Stop();
            PianoNoteG4.Stop();
            PianoNoteA5.Stop();
            PianoNoteB5.Stop();
            PianoNoteC5.Stop();
            PianoNoteD5.Stop();
            PianoNoteE5.Stop();
            PianoNoteF5.Stop();
            PianoNoteG5.Stop();
        }

        if (EnableObjects03.CoralOctaveOnOff == 1) {
            if (EnableObjects03.ActionNoteInt == 11) {
                PianoNoteB5.volume = 3.0f;
                PianoNoteB5.Play();
                BubblesB.Play();
                EnableObjects03.ActionNoteInt = 12;
            }
        }

        else if (EnableObjects03.CoralOctaveOnOff == 0) {
            if (EnableObjects03.ActionNoteInt == 4) {
                PianoNoteB4.volume = 3.0f;
                PianoNoteB4.Play();
                BubblesB.Play();
                EnableObjects03.ActionNoteInt = 5;
            }
        }
    }

    public void BubbleNotesCOnClicking() {
        if ((EnableObjects03.ActionNoteInt == 6) || (EnableObjects03.ActionNoteInt == 13)) {
            EnableObjects03.CoralAOnOff = 0;
            EnableObjects03.CoralBOnOff = 0;
            EnableObjects03.CoralCOnOff = 0;
            EnableObjects03.CoralDOnOff = 0;
            EnableObjects03.CoralEOnOff = 0;
            EnableObjects03.CoralFOnOff = 0;
            EnableObjects03.CoralGOnOff = 0;
            EnableObjects03.CoralCOnOff = 1;

            PianoNoteA4.Stop();
            PianoNoteB4.Stop();
            PianoNoteC4.Stop();
            PianoNoteD4.Stop();
            PianoNoteE4.Stop();
            PianoNoteF4.Stop();
            PianoNoteG4.Stop();
            PianoNoteA5.Stop();
            PianoNoteB5.Stop();
            PianoNoteC5.Stop();
            PianoNoteD5.Stop();
            PianoNoteE5.Stop();
            PianoNoteF5.Stop();
            PianoNoteG5.Stop();
        }

        if (EnableObjects03.CoralOctaveOnOff == 1) {
            if (EnableObjects03.ActionNoteInt == 13) {
                PianoNoteC5.volume = 3.0f;
                PianoNoteC5.Play();
                BubblesC.Play();
                EnableObjects03.ActionNoteInt = 14;
            }
        }

        else if (EnableObjects03.CoralOctaveOnOff == 0) {
            if (EnableObjects03.ActionNoteInt == 6) {
                PianoNoteC4.volume = 3.0f;
                PianoNoteC4.Play();
                BubblesC.Play();
                EnableObjects03.ActionNoteInt = 7;
            }
        }
    }

    public void BubbleNotesDOnClicking() {
        if ((EnableObjects03.ActionNoteInt == 2) || (EnableObjects03.ActionNoteInt == 10)) {
            EnableObjects03.CoralAOnOff = 0;
            EnableObjects03.CoralBOnOff = 0;
            EnableObjects03.CoralCOnOff = 0;
            EnableObjects03.CoralDOnOff = 0;
            EnableObjects03.CoralEOnOff = 0;
            EnableObjects03.CoralFOnOff = 0;
            EnableObjects03.CoralGOnOff = 0;
            EnableObjects03.CoralDOnOff = 1;

            PianoNoteA4.Stop();
            PianoNoteB4.Stop();
            PianoNoteC4.Stop();
            PianoNoteD4.Stop();
            PianoNoteE4.Stop();
            PianoNoteF4.Stop();
            PianoNoteG4.Stop();
            PianoNoteA5.Stop();
            PianoNoteB5.Stop();
            PianoNoteC5.Stop();
            PianoNoteD5.Stop();
            PianoNoteE5.Stop();
            PianoNoteF5.Stop();
            PianoNoteG5.Stop();
        }

        if (EnableObjects03.CoralOctaveOnOff == 1) {
            if (EnableObjects03.ActionNoteInt == 10) {
                PianoNoteD5.volume = 3.0f;
                PianoNoteD5.Play();
                BubblesD.Play();
                EnableObjects03.ActionNoteInt = 11;
            }
        }

        else if (EnableObjects03.CoralOctaveOnOff == 0) {
            if (EnableObjects03.ActionNoteInt == 2) {
                PianoNoteD4.volume = 3.0f;
                PianoNoteD4.Play();
                BubblesD.Play();
                EnableObjects03.ActionNoteInt = 3;
            }
        }
    }

    public void BubbleNotesEOnClicking() {
        if ((EnableObjects03.ActionNoteInt == 5) || (EnableObjects03.ActionNoteInt == 14)) {
            EnableObjects03.CoralAOnOff = 0;
            EnableObjects03.CoralBOnOff = 0;
            EnableObjects03.CoralCOnOff = 0;
            EnableObjects03.CoralDOnOff = 0;
            EnableObjects03.CoralEOnOff = 0;
            EnableObjects03.CoralFOnOff = 0;
            EnableObjects03.CoralGOnOff = 0;
            EnableObjects03.CoralEOnOff = 1;

            PianoNoteA4.Stop();
            PianoNoteB4.Stop();
            PianoNoteC4.Stop();
            PianoNoteD4.Stop();
            PianoNoteE4.Stop();
            PianoNoteF4.Stop();
            PianoNoteG4.Stop();
            PianoNoteA5.Stop();
            PianoNoteB5.Stop();
            PianoNoteC5.Stop();
            PianoNoteD5.Stop();
            PianoNoteE5.Stop();
            PianoNoteF5.Stop();
            PianoNoteG5.Stop();
        }

        if (EnableObjects03.CoralOctaveOnOff == 1) {
            if (EnableObjects03.ActionNoteInt == 14) {
                PianoNoteE5.volume = 3.0f;
                PianoNoteE5.Play();
                BubblesE.Play();
                EnableObjects03.ActionNoteInt = 15;
            }
        }

        else if (EnableObjects03.CoralOctaveOnOff == 0) {
            if (EnableObjects03.ActionNoteInt == 5) {
                PianoNoteE4.volume = 3.0f;
                PianoNoteE4.Play();
                BubblesE.Play();
                EnableObjects03.ActionNoteInt = 6;
            }
        }
    }

    public void BubbleNotesFOnClicking() {
        if ((EnableObjects03.ActionNoteInt == 7) || (EnableObjects03.ActionNoteInt == 12)) {
            EnableObjects03.CoralAOnOff = 0;
            EnableObjects03.CoralBOnOff = 0;
            EnableObjects03.CoralCOnOff = 0;
            EnableObjects03.CoralDOnOff = 0;
            EnableObjects03.CoralEOnOff = 0;
            EnableObjects03.CoralFOnOff = 0;
            EnableObjects03.CoralGOnOff = 0;
            EnableObjects03.CoralFOnOff = 1;

            PianoNoteA4.Stop();
            PianoNoteB4.Stop();
            PianoNoteC4.Stop();
            PianoNoteD4.Stop();
            PianoNoteE4.Stop();
            PianoNoteF4.Stop();
            PianoNoteG4.Stop();
            PianoNoteA5.Stop();
            PianoNoteB5.Stop();
            PianoNoteC5.Stop();
            PianoNoteD5.Stop();
            PianoNoteE5.Stop();
            PianoNoteF5.Stop();
            PianoNoteG5.Stop();
        }

        if (EnableObjects03.CoralOctaveOnOff == 1) {
            if (EnableObjects03.ActionNoteInt == 12) {
                PianoNoteF5.volume = 3.0f;
                PianoNoteF5.Play();
                BubblesF.Play();
                EnableObjects03.ActionNoteInt = 13;
            }
        }

        else if (EnableObjects03.CoralOctaveOnOff == 0) {
            if (EnableObjects03.ActionNoteInt == 7) {
                PianoNoteF4.volume = 3.0f;
                PianoNoteF4.Play();
                BubblesF.Play();
                EnableObjects03.ActionNoteInt = 8;
            }
        }
    }

    public void BubbleNotesGOnClicking() {
        if ((EnableObjects03.ActionNoteInt == 3) || (EnableObjects03.ActionNoteInt == 9)) {
            EnableObjects03.CoralAOnOff = 0;
            EnableObjects03.CoralBOnOff = 0;
            EnableObjects03.CoralCOnOff = 0;
            EnableObjects03.CoralDOnOff = 0;
            EnableObjects03.CoralEOnOff = 0;
            EnableObjects03.CoralFOnOff = 0;
            EnableObjects03.CoralGOnOff = 0;
            EnableObjects03.CoralGOnOff = 1;

            PianoNoteA4.Stop();
            PianoNoteB4.Stop();
            PianoNoteC4.Stop();
            PianoNoteD4.Stop();
            PianoNoteE4.Stop();
            PianoNoteF4.Stop();
            PianoNoteG4.Stop();
            PianoNoteA5.Stop();
            PianoNoteB5.Stop();
            PianoNoteC5.Stop();
            PianoNoteD5.Stop();
            PianoNoteE5.Stop();
            PianoNoteF5.Stop();
            PianoNoteG5.Stop();
        }

        if (EnableObjects03.CoralOctaveOnOff == 1) {
            if (EnableObjects03.ActionNoteInt == 9) {
                PianoNoteG5.volume = 3.0f;
                PianoNoteG5.Play();
                BubblesG.Play();
                EnableObjects03.ActionNoteInt = 10;
            }
        }

        else if (EnableObjects03.CoralOctaveOnOff == 0) {
            if (EnableObjects03.ActionNoteInt == 3) {
                PianoNoteG4.volume = 3.0f;
                PianoNoteG4.Play();
                BubblesG.Play();
                EnableObjects03.ActionNoteInt = 4;
            }
        }
    }

    public void BubbleNotesOctaveOnClicking() {
        EnableObjects03.CoralOctaveOnOff = 0;
    }

    public void CoralAOffClicking() {
        if ((EnableObjects03.ActionNoteInt == 1) || (EnableObjects03.ActionNoteInt == 8) || (EnableObjects03.ActionNoteInt == 15)) {
            EnableObjects03.CoralAOnOff = 0;
            EnableObjects03.CoralBOnOff = 0;
            EnableObjects03.CoralCOnOff = 0;
            EnableObjects03.CoralDOnOff = 0;
            EnableObjects03.CoralEOnOff = 0;
            EnableObjects03.CoralFOnOff = 0;
            EnableObjects03.CoralGOnOff = 0;
            EnableObjects03.CoralAOnOff = 1;

            PianoNoteA4.Stop();
            PianoNoteB4.Stop();
            PianoNoteC4.Stop();
            PianoNoteD4.Stop();
            PianoNoteE4.Stop();
            PianoNoteF4.Stop();
            PianoNoteG4.Stop();
            PianoNoteA5.Stop();
            PianoNoteB5.Stop();
            PianoNoteC5.Stop();
            PianoNoteD5.Stop();
            PianoNoteE5.Stop();
            PianoNoteF5.Stop();
            PianoNoteG5.Stop();
        }

        if (EnableObjects03.CoralOctaveOnOff == 1) {
            if (EnableObjects03.ActionNoteInt == 8) {
                PianoNoteA5.volume = 3.0f;
                PianoNoteA5.Play();
                BubblesA.Play();
                EnableObjects03.ActionNoteInt = 9;
            }
        }

        else if (EnableObjects03.CoralOctaveOnOff == 0) {
            if ((EnableObjects03.ActionNoteInt == 1) || (EnableObjects03.ActionNoteInt == 15)) {
                PianoNoteA4.volume = 3.0f;
                PianoNoteA4.Play();
                BubblesA.Play();

                if (EnableObjects03.ActionNoteInt == 1) {
                    EnableObjects03.ActionNoteInt = 2;
                }

                else if (EnableObjects03.ActionNoteInt == 15) {
                    EnableObjects03.ActionNoteInt = 16;
                }
            }
        }
    }

    public void CoralBOffClicking() {
        if ((EnableObjects03.ActionNoteInt == 4) || (EnableObjects03.ActionNoteInt == 11)) {
            EnableObjects03.CoralAOnOff = 0;
            EnableObjects03.CoralBOnOff = 0;
            EnableObjects03.CoralCOnOff = 0;
            EnableObjects03.CoralDOnOff = 0;
            EnableObjects03.CoralEOnOff = 0;
            EnableObjects03.CoralFOnOff = 0;
            EnableObjects03.CoralGOnOff = 0;
            EnableObjects03.CoralBOnOff = 1;

            PianoNoteA4.Stop();
            PianoNoteB4.Stop();
            PianoNoteC4.Stop();
            PianoNoteD4.Stop();
            PianoNoteE4.Stop();
            PianoNoteF4.Stop();
            PianoNoteG4.Stop();
            PianoNoteA5.Stop();
            PianoNoteB5.Stop();
            PianoNoteC5.Stop();
            PianoNoteD5.Stop();
            PianoNoteE5.Stop();
            PianoNoteF5.Stop();
            PianoNoteG5.Stop();
        }

        if (EnableObjects03.CoralOctaveOnOff == 1) {
            if (EnableObjects03.ActionNoteInt == 11) {
                PianoNoteB5.volume = 3.0f;
                PianoNoteB5.Play();
                BubblesB.Play();
                EnableObjects03.ActionNoteInt = 12;
            }
        }

        else if (EnableObjects03.CoralOctaveOnOff == 0) {
            if (EnableObjects03.ActionNoteInt == 4) {
                PianoNoteB4.volume = 3.0f;
                PianoNoteB4.Play();
                BubblesB.Play();
                EnableObjects03.ActionNoteInt = 5;
            }
        }
    }

    public void CoralCOffClicking() {
        if ((EnableObjects03.ActionNoteInt == 6) || (EnableObjects03.ActionNoteInt == 13)) {
            EnableObjects03.CoralAOnOff = 0;
            EnableObjects03.CoralBOnOff = 0;
            EnableObjects03.CoralCOnOff = 0;
            EnableObjects03.CoralDOnOff = 0;
            EnableObjects03.CoralEOnOff = 0;
            EnableObjects03.CoralFOnOff = 0;
            EnableObjects03.CoralGOnOff = 0;
            EnableObjects03.CoralCOnOff = 1;

            PianoNoteA4.Stop();
            PianoNoteB4.Stop();
            PianoNoteC4.Stop();
            PianoNoteD4.Stop();
            PianoNoteE4.Stop();
            PianoNoteF4.Stop();
            PianoNoteG4.Stop();
            PianoNoteA5.Stop();
            PianoNoteB5.Stop();
            PianoNoteC5.Stop();
            PianoNoteD5.Stop();
            PianoNoteE5.Stop();
            PianoNoteF5.Stop();
            PianoNoteG5.Stop();
        }

        if (EnableObjects03.CoralOctaveOnOff == 1) {
            if (EnableObjects03.ActionNoteInt == 13) {
                PianoNoteC5.volume = 3.0f;
                PianoNoteC5.Play();
                BubblesC.Play();
                EnableObjects03.ActionNoteInt = 14;
            }
        }

        else if (EnableObjects03.CoralOctaveOnOff == 0) {
            if (EnableObjects03.ActionNoteInt == 6) {
                PianoNoteC4.volume = 3.0f;
                PianoNoteC4.Play();
                BubblesC.Play();
                EnableObjects03.ActionNoteInt = 7;
            }
        }
    }

    public void CoralDOffClicking() {
        if ((EnableObjects03.ActionNoteInt == 2) || (EnableObjects03.ActionNoteInt == 10)) {
            EnableObjects03.CoralAOnOff = 0;
            EnableObjects03.CoralBOnOff = 0;
            EnableObjects03.CoralCOnOff = 0;
            EnableObjects03.CoralDOnOff = 0;
            EnableObjects03.CoralEOnOff = 0;
            EnableObjects03.CoralFOnOff = 0;
            EnableObjects03.CoralGOnOff = 0;
            EnableObjects03.CoralDOnOff = 1;

            PianoNoteA4.Stop();
            PianoNoteB4.Stop();
            PianoNoteC4.Stop();
            PianoNoteD4.Stop();
            PianoNoteE4.Stop();
            PianoNoteF4.Stop();
            PianoNoteG4.Stop();
            PianoNoteA5.Stop();
            PianoNoteB5.Stop();
            PianoNoteC5.Stop();
            PianoNoteD5.Stop();
            PianoNoteE5.Stop();
            PianoNoteF5.Stop();
            PianoNoteG5.Stop();
        }

        if (EnableObjects03.CoralOctaveOnOff == 1) {
            if (EnableObjects03.ActionNoteInt == 10) {
                PianoNoteD5.volume = 3.0f;
                PianoNoteD5.Play();
                BubblesD.Play();
                EnableObjects03.ActionNoteInt = 11;
            }
        }

        else if (EnableObjects03.CoralOctaveOnOff == 0) {
            if (EnableObjects03.ActionNoteInt == 2) {
                PianoNoteD4.volume = 3.0f;
                PianoNoteD4.Play();
                BubblesD.Play();
                EnableObjects03.ActionNoteInt = 3;
            }
        }
    }

    public void CoralEOffClicking() {
        if ((EnableObjects03.ActionNoteInt == 5) || (EnableObjects03.ActionNoteInt == 14)) {
            EnableObjects03.CoralAOnOff = 0;
            EnableObjects03.CoralBOnOff = 0;
            EnableObjects03.CoralCOnOff = 0;
            EnableObjects03.CoralDOnOff = 0;
            EnableObjects03.CoralEOnOff = 0;
            EnableObjects03.CoralFOnOff = 0;
            EnableObjects03.CoralGOnOff = 0;
            EnableObjects03.CoralEOnOff = 1;

            PianoNoteA4.Stop();
            PianoNoteB4.Stop();
            PianoNoteC4.Stop();
            PianoNoteD4.Stop();
            PianoNoteE4.Stop();
            PianoNoteF4.Stop();
            PianoNoteG4.Stop();
            PianoNoteA5.Stop();
            PianoNoteB5.Stop();
            PianoNoteC5.Stop();
            PianoNoteD5.Stop();
            PianoNoteE5.Stop();
            PianoNoteF5.Stop();
            PianoNoteG5.Stop();
        }

        if (EnableObjects03.CoralOctaveOnOff == 1) {
            if (EnableObjects03.ActionNoteInt == 14) {
                PianoNoteE5.volume = 3.0f;
                PianoNoteE5.Play();
                BubblesE.Play();
                EnableObjects03.ActionNoteInt = 15;
            }
        }

        else if (EnableObjects03.CoralOctaveOnOff == 0) {
            if (EnableObjects03.ActionNoteInt == 5) {
                PianoNoteE4.volume = 3.0f;
                PianoNoteE4.Play();
                BubblesE.Play();
                EnableObjects03.ActionNoteInt = 6;
            }
        }
    }

    public void CoralFOffClicking() {
        if ((EnableObjects03.ActionNoteInt == 7) || (EnableObjects03.ActionNoteInt == 12)) {
            EnableObjects03.CoralAOnOff = 0;
            EnableObjects03.CoralBOnOff = 0;
            EnableObjects03.CoralCOnOff = 0;
            EnableObjects03.CoralDOnOff = 0;
            EnableObjects03.CoralEOnOff = 0;
            EnableObjects03.CoralFOnOff = 0;
            EnableObjects03.CoralGOnOff = 0;
            EnableObjects03.CoralFOnOff = 1;

            PianoNoteA4.Stop();
            PianoNoteB4.Stop();
            PianoNoteC4.Stop();
            PianoNoteD4.Stop();
            PianoNoteE4.Stop();
            PianoNoteF4.Stop();
            PianoNoteG4.Stop();
            PianoNoteA5.Stop();
            PianoNoteB5.Stop();
            PianoNoteC5.Stop();
            PianoNoteD5.Stop();
            PianoNoteE5.Stop();
            PianoNoteF5.Stop();
            PianoNoteG5.Stop();
        }

        if (EnableObjects03.CoralOctaveOnOff == 1) {
            if (EnableObjects03.ActionNoteInt == 12) {
                PianoNoteF5.volume = 3.0f;
                PianoNoteF5.Play();
                BubblesF.Play();
                EnableObjects03.ActionNoteInt = 13;
            }
        }

        else if (EnableObjects03.CoralOctaveOnOff == 0) {
            if (EnableObjects03.ActionNoteInt == 7) {
                PianoNoteF4.volume = 3.0f;
                PianoNoteF4.Play();
                BubblesF.Play();
                EnableObjects03.ActionNoteInt = 8;
            }
        }
    }

    public void CoralGOffClicking() {
        if ((EnableObjects03.ActionNoteInt == 3) || (EnableObjects03.ActionNoteInt == 9)) {
            EnableObjects03.CoralAOnOff = 0;
            EnableObjects03.CoralBOnOff = 0;
            EnableObjects03.CoralCOnOff = 0;
            EnableObjects03.CoralDOnOff = 0;
            EnableObjects03.CoralEOnOff = 0;
            EnableObjects03.CoralFOnOff = 0;
            EnableObjects03.CoralGOnOff = 0;
            EnableObjects03.CoralGOnOff = 1;

            PianoNoteA4.Stop();
            PianoNoteB4.Stop();
            PianoNoteC4.Stop();
            PianoNoteD4.Stop();
            PianoNoteE4.Stop();
            PianoNoteF4.Stop();
            PianoNoteG4.Stop();
            PianoNoteA5.Stop();
            PianoNoteB5.Stop();
            PianoNoteC5.Stop();
            PianoNoteD5.Stop();
            PianoNoteE5.Stop();
            PianoNoteF5.Stop();
            PianoNoteG5.Stop();
        }

        if (EnableObjects03.CoralOctaveOnOff == 1) {
            if (EnableObjects03.ActionNoteInt == 9) {
                PianoNoteG5.volume = 3.0f;
                PianoNoteG5.Play();
                BubblesG.Play();
                EnableObjects03.ActionNoteInt = 10;
            }
        }

        else if (EnableObjects03.CoralOctaveOnOff == 0) {
            if (EnableObjects03.ActionNoteInt == 3) {
                PianoNoteG4.volume = 3.0f;
                PianoNoteG4.Play();
                BubblesG.Play();
                EnableObjects03.ActionNoteInt = 4;
            }
        }
    }

    public void CoralOctaveOffClicking() {
        EnableObjects03.CoralOctaveOnOff = 1;
        BubblesOctave.Play();
    }

    public void CoralAOnClicking() {
        if ((EnableObjects03.ActionNoteInt == 1) || (EnableObjects03.ActionNoteInt == 8) || (EnableObjects03.ActionNoteInt == 15)) {
            EnableObjects03.CoralAOnOff = 0;
            EnableObjects03.CoralBOnOff = 0;
            EnableObjects03.CoralCOnOff = 0;
            EnableObjects03.CoralDOnOff = 0;
            EnableObjects03.CoralEOnOff = 0;
            EnableObjects03.CoralFOnOff = 0;
            EnableObjects03.CoralGOnOff = 0;
            EnableObjects03.CoralAOnOff = 1;

            PianoNoteA4.Stop();
            PianoNoteB4.Stop();
            PianoNoteC4.Stop();
            PianoNoteD4.Stop();
            PianoNoteE4.Stop();
            PianoNoteF4.Stop();
            PianoNoteG4.Stop();
            PianoNoteA5.Stop();
            PianoNoteB5.Stop();
            PianoNoteC5.Stop();
            PianoNoteD5.Stop();
            PianoNoteE5.Stop();
            PianoNoteF5.Stop();
            PianoNoteG5.Stop();
        }

        if (EnableObjects03.CoralOctaveOnOff == 1) {
            if (EnableObjects03.ActionNoteInt == 8) {
                PianoNoteA5.volume = 3.0f;
                PianoNoteA5.Play();
                BubblesA.Play();
                EnableObjects03.ActionNoteInt = 9;
            }
        }

        else if (EnableObjects03.CoralOctaveOnOff == 0) {
            if ((EnableObjects03.ActionNoteInt == 1) || (EnableObjects03.ActionNoteInt == 15)) {
                PianoNoteA4.volume = 3.0f;
                PianoNoteA4.Play();
                BubblesA.Play();

                if (EnableObjects03.ActionNoteInt == 1) {
                    EnableObjects03.ActionNoteInt = 2;
                }

                else if (EnableObjects03.ActionNoteInt == 15) {
                    EnableObjects03.ActionNoteInt = 16;
                }
            }
        }
    }

    public void CoralBOnClicking() {
        if ((EnableObjects03.ActionNoteInt == 4) || (EnableObjects03.ActionNoteInt == 11)) {
            EnableObjects03.CoralAOnOff = 0;
            EnableObjects03.CoralBOnOff = 0;
            EnableObjects03.CoralCOnOff = 0;
            EnableObjects03.CoralDOnOff = 0;
            EnableObjects03.CoralEOnOff = 0;
            EnableObjects03.CoralFOnOff = 0;
            EnableObjects03.CoralGOnOff = 0;
            EnableObjects03.CoralBOnOff = 1;

            PianoNoteA4.Stop();
            PianoNoteB4.Stop();
            PianoNoteC4.Stop();
            PianoNoteD4.Stop();
            PianoNoteE4.Stop();
            PianoNoteF4.Stop();
            PianoNoteG4.Stop();
            PianoNoteA5.Stop();
            PianoNoteB5.Stop();
            PianoNoteC5.Stop();
            PianoNoteD5.Stop();
            PianoNoteE5.Stop();
            PianoNoteF5.Stop();
            PianoNoteG5.Stop();
        }

        if (EnableObjects03.CoralOctaveOnOff == 1) {
            if (EnableObjects03.ActionNoteInt == 11) {
                PianoNoteB5.volume = 3.0f;
                PianoNoteB5.Play();
                BubblesB.Play();
                EnableObjects03.ActionNoteInt = 12;
            }
        }

        else if (EnableObjects03.CoralOctaveOnOff == 0) {
            if (EnableObjects03.ActionNoteInt == 4) {
                PianoNoteB4.volume = 3.0f;
                PianoNoteB4.Play();
                BubblesB.Play();
                EnableObjects03.ActionNoteInt = 5;
            }
        }
    }

    public void CoralCOnClicking() {
        if ((EnableObjects03.ActionNoteInt == 6) || (EnableObjects03.ActionNoteInt == 13)) {
            EnableObjects03.CoralAOnOff = 0;
            EnableObjects03.CoralBOnOff = 0;
            EnableObjects03.CoralCOnOff = 0;
            EnableObjects03.CoralDOnOff = 0;
            EnableObjects03.CoralEOnOff = 0;
            EnableObjects03.CoralFOnOff = 0;
            EnableObjects03.CoralGOnOff = 0;
            EnableObjects03.CoralCOnOff = 1;

            PianoNoteA4.Stop();
            PianoNoteB4.Stop();
            PianoNoteC4.Stop();
            PianoNoteD4.Stop();
            PianoNoteE4.Stop();
            PianoNoteF4.Stop();
            PianoNoteG4.Stop();
            PianoNoteA5.Stop();
            PianoNoteB5.Stop();
            PianoNoteC5.Stop();
            PianoNoteD5.Stop();
            PianoNoteE5.Stop();
            PianoNoteF5.Stop();
            PianoNoteG5.Stop();
        }

        if (EnableObjects03.CoralOctaveOnOff == 1) {
            if (EnableObjects03.ActionNoteInt == 13) {
                PianoNoteC5.volume = 3.0f;
                PianoNoteC5.Play();
                BubblesC.Play();
                EnableObjects03.ActionNoteInt = 14;
            }
        }

        else if (EnableObjects03.CoralOctaveOnOff == 0) {
            if (EnableObjects03.ActionNoteInt == 6) {
                PianoNoteC4.volume = 3.0f;
                PianoNoteC4.Play();
                BubblesC.Play();
                EnableObjects03.ActionNoteInt = 7;
            }
        }
    }

    public void CoralDOnClicking() {
        if ((EnableObjects03.ActionNoteInt == 2) || (EnableObjects03.ActionNoteInt == 10)) {
            EnableObjects03.CoralAOnOff = 0;
            EnableObjects03.CoralBOnOff = 0;
            EnableObjects03.CoralCOnOff = 0;
            EnableObjects03.CoralDOnOff = 0;
            EnableObjects03.CoralEOnOff = 0;
            EnableObjects03.CoralFOnOff = 0;
            EnableObjects03.CoralGOnOff = 0;
            EnableObjects03.CoralDOnOff = 1;

            PianoNoteA4.Stop();
            PianoNoteB4.Stop();
            PianoNoteC4.Stop();
            PianoNoteD4.Stop();
            PianoNoteE4.Stop();
            PianoNoteF4.Stop();
            PianoNoteG4.Stop();
            PianoNoteA5.Stop();
            PianoNoteB5.Stop();
            PianoNoteC5.Stop();
            PianoNoteD5.Stop();
            PianoNoteE5.Stop();
            PianoNoteF5.Stop();
            PianoNoteG5.Stop();
        }

        if (EnableObjects03.CoralOctaveOnOff == 1) {
            if (EnableObjects03.ActionNoteInt == 10) {
                PianoNoteD5.volume = 3.0f;
                PianoNoteD5.Play();
                BubblesD.Play();
                EnableObjects03.ActionNoteInt = 11;
            }
        }

        else if (EnableObjects03.CoralOctaveOnOff == 0) {
            if (EnableObjects03.ActionNoteInt == 2) {
                PianoNoteD4.volume = 3.0f;
                PianoNoteD4.Play();
                BubblesD.Play();
                EnableObjects03.ActionNoteInt = 3;
            }
        }
    }

    public void CoralEOnClicking() {
        if ((EnableObjects03.ActionNoteInt == 5) || (EnableObjects03.ActionNoteInt == 14)) {
            EnableObjects03.CoralAOnOff = 0;
            EnableObjects03.CoralBOnOff = 0;
            EnableObjects03.CoralCOnOff = 0;
            EnableObjects03.CoralDOnOff = 0;
            EnableObjects03.CoralEOnOff = 0;
            EnableObjects03.CoralFOnOff = 0;
            EnableObjects03.CoralGOnOff = 0;
            EnableObjects03.CoralEOnOff = 1;

            PianoNoteA4.Stop();
            PianoNoteB4.Stop();
            PianoNoteC4.Stop();
            PianoNoteD4.Stop();
            PianoNoteE4.Stop();
            PianoNoteF4.Stop();
            PianoNoteG4.Stop();
            PianoNoteA5.Stop();
            PianoNoteB5.Stop();
            PianoNoteC5.Stop();
            PianoNoteD5.Stop();
            PianoNoteE5.Stop();
            PianoNoteF5.Stop();
            PianoNoteG5.Stop();
        }

        if (EnableObjects03.CoralOctaveOnOff == 1) {
            if (EnableObjects03.ActionNoteInt == 14) {
                PianoNoteE5.volume = 3.0f;
                PianoNoteE5.Play();
                BubblesE.Play();
                EnableObjects03.ActionNoteInt = 15;
            }
        }

        else if (EnableObjects03.CoralOctaveOnOff == 0) {
            if (EnableObjects03.ActionNoteInt == 5) {
                PianoNoteE4.volume = 3.0f;
                PianoNoteE4.Play();
                BubblesE.Play();
                EnableObjects03.ActionNoteInt = 6;
            }
        }
    }

    public void CoralFOnClicking() {
        if ((EnableObjects03.ActionNoteInt == 7) || (EnableObjects03.ActionNoteInt == 12)) {
            EnableObjects03.CoralAOnOff = 0;
            EnableObjects03.CoralBOnOff = 0;
            EnableObjects03.CoralCOnOff = 0;
            EnableObjects03.CoralDOnOff = 0;
            EnableObjects03.CoralEOnOff = 0;
            EnableObjects03.CoralFOnOff = 0;
            EnableObjects03.CoralGOnOff = 0;
            EnableObjects03.CoralFOnOff = 1;

            PianoNoteA4.Stop();
            PianoNoteB4.Stop();
            PianoNoteC4.Stop();
            PianoNoteD4.Stop();
            PianoNoteE4.Stop();
            PianoNoteF4.Stop();
            PianoNoteG4.Stop();
            PianoNoteA5.Stop();
            PianoNoteB5.Stop();
            PianoNoteC5.Stop();
            PianoNoteD5.Stop();
            PianoNoteE5.Stop();
            PianoNoteF5.Stop();
            PianoNoteG5.Stop();
        }

        if (EnableObjects03.CoralOctaveOnOff == 1) {
            if (EnableObjects03.ActionNoteInt == 12) {
                PianoNoteF5.volume = 3.0f;
                PianoNoteF5.Play();
                BubblesF.Play();
                EnableObjects03.ActionNoteInt = 13;
            }
        }

        else if (EnableObjects03.CoralOctaveOnOff == 0) {
            if (EnableObjects03.ActionNoteInt == 7) {
                PianoNoteF4.volume = 3.0f;
                PianoNoteF4.Play();
                BubblesF.Play();
                EnableObjects03.ActionNoteInt = 8;
            }
        }
    }

    public void CoralGOnClicking() {
        if ((EnableObjects03.ActionNoteInt == 3) || (EnableObjects03.ActionNoteInt == 9)) {
            EnableObjects03.CoralAOnOff = 0;
            EnableObjects03.CoralBOnOff = 0;
            EnableObjects03.CoralCOnOff = 0;
            EnableObjects03.CoralDOnOff = 0;
            EnableObjects03.CoralEOnOff = 0;
            EnableObjects03.CoralFOnOff = 0;
            EnableObjects03.CoralGOnOff = 0;
            EnableObjects03.CoralGOnOff = 1;

            PianoNoteA4.Stop();
            PianoNoteB4.Stop();
            PianoNoteC4.Stop();
            PianoNoteD4.Stop();
            PianoNoteE4.Stop();
            PianoNoteF4.Stop();
            PianoNoteG4.Stop();
            PianoNoteA5.Stop();
            PianoNoteB5.Stop();
            PianoNoteC5.Stop();
            PianoNoteD5.Stop();
            PianoNoteE5.Stop();
            PianoNoteF5.Stop();
            PianoNoteG5.Stop();
        }

        if (EnableObjects03.CoralOctaveOnOff == 1) {
            if (EnableObjects03.ActionNoteInt == 9) {
                PianoNoteG5.volume = 3.0f;
                PianoNoteG5.Play();
                BubblesG.Play();
                EnableObjects03.ActionNoteInt = 10;
            }
        }

        else if (EnableObjects03.CoralOctaveOnOff == 0) {
            if (EnableObjects03.ActionNoteInt == 3) {
                PianoNoteG4.volume = 3.0f;
                PianoNoteG4.Play();
                BubblesG.Play();
                EnableObjects03.ActionNoteInt = 4;
            }
        }
    }

    public void CoralOctaveOnClicking() {
        EnableObjects03.CoralOctaveOnOff = 0;
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