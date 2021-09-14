using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

public class Buttons06 : MonoBehaviour {

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
        EnableObjects06.SettingPanelOnOff = 1;
    }

    public void BubbleNotesAOffClicking() {
        EnableObjects06.CoralAOnOff = 0;
        EnableObjects06.CoralBOnOff = 0;
        EnableObjects06.CoralCOnOff = 0;
        EnableObjects06.CoralDOnOff = 0;
        EnableObjects06.CoralEOnOff = 0;
        EnableObjects06.CoralFOnOff = 0;
        EnableObjects06.CoralGOnOff = 0;
        EnableObjects06.CoralAOnOff = 1;

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

        if (EnableObjects06.CoralOctaveOnOff == 1) {
            PianoNoteA5.volume = 3.0f;
            PianoNoteA5.Play();
            BubblesA.Play();
        }

        else if (EnableObjects06.CoralOctaveOnOff == 0) {
            PianoNoteA4.volume = 3.0f;
            PianoNoteA4.Play();
            BubblesA.Play();
        }
    }

    public void BubbleNotesBOffClicking() {
        EnableObjects06.CoralAOnOff = 0;
        EnableObjects06.CoralBOnOff = 0;
        EnableObjects06.CoralCOnOff = 0;
        EnableObjects06.CoralDOnOff = 0;
        EnableObjects06.CoralEOnOff = 0;
        EnableObjects06.CoralFOnOff = 0;
        EnableObjects06.CoralGOnOff = 0;
        EnableObjects06.CoralBOnOff = 1;

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

        if (EnableObjects06.CoralOctaveOnOff == 1) {
            PianoNoteB5.volume = 3.0f;
            PianoNoteB5.Play();
            BubblesB.Play();
        }

        else if (EnableObjects06.CoralOctaveOnOff == 0) {
            PianoNoteB4.volume = 3.0f;
            PianoNoteB4.Play();
            BubblesB.Play();
        }
    }

    public void BubbleNotesCOffClicking() {
        EnableObjects06.CoralAOnOff = 0;
        EnableObjects06.CoralBOnOff = 0;
        EnableObjects06.CoralCOnOff = 0;
        EnableObjects06.CoralDOnOff = 0;
        EnableObjects06.CoralEOnOff = 0;
        EnableObjects06.CoralFOnOff = 0;
        EnableObjects06.CoralGOnOff = 0;
        EnableObjects06.CoralCOnOff = 1;

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

        if (EnableObjects06.CoralOctaveOnOff == 1) {
            PianoNoteC5.volume = 3.0f;
            PianoNoteC5.Play();
            BubblesC.Play();
        }

        else if (EnableObjects06.CoralOctaveOnOff == 0) {
            PianoNoteC4.volume = 3.0f;
            PianoNoteC4.Play();
            BubblesC.Play();
        }
    }

    public void BubbleNotesDOffClicking() {
        EnableObjects06.CoralAOnOff = 0;
        EnableObjects06.CoralBOnOff = 0;
        EnableObjects06.CoralCOnOff = 0;
        EnableObjects06.CoralDOnOff = 0;
        EnableObjects06.CoralEOnOff = 0;
        EnableObjects06.CoralFOnOff = 0;
        EnableObjects06.CoralGOnOff = 0;
        EnableObjects06.CoralDOnOff = 1;

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

        if (EnableObjects06.CoralOctaveOnOff == 1) {
            PianoNoteD5.volume = 3.0f;
            PianoNoteD5.Play();
            BubblesD.Play();
        }

        else if (EnableObjects06.CoralOctaveOnOff == 0) {
            PianoNoteD4.volume = 3.0f;
            PianoNoteD4.Play();
            BubblesD.Play();
        }
    }

    public void BubbleNotesEOffClicking() {
        EnableObjects06.CoralAOnOff = 0;
        EnableObjects06.CoralBOnOff = 0;
        EnableObjects06.CoralCOnOff = 0;
        EnableObjects06.CoralDOnOff = 0;
        EnableObjects06.CoralEOnOff = 0;
        EnableObjects06.CoralFOnOff = 0;
        EnableObjects06.CoralGOnOff = 0;
        EnableObjects06.CoralEOnOff = 1;

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

        if (EnableObjects06.CoralOctaveOnOff == 1) {
            PianoNoteE5.volume = 3.0f;
            PianoNoteE5.Play();
            BubblesE.Play();
        }

        else if (EnableObjects06.CoralOctaveOnOff == 0) {
            PianoNoteE4.volume = 3.0f;
            PianoNoteE4.Play();
            BubblesE.Play();
        }
    }

    public void BubbleNotesFOffClicking() {
        EnableObjects06.CoralAOnOff = 0;
        EnableObjects06.CoralBOnOff = 0;
        EnableObjects06.CoralCOnOff = 0;
        EnableObjects06.CoralDOnOff = 0;
        EnableObjects06.CoralEOnOff = 0;
        EnableObjects06.CoralFOnOff = 0;
        EnableObjects06.CoralGOnOff = 0;
        EnableObjects06.CoralFOnOff = 1;

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

        if (EnableObjects06.CoralOctaveOnOff == 1) {
            PianoNoteF5.volume = 3.0f;
            PianoNoteF5.Play();
            BubblesF.Play();
        }

        else if (EnableObjects06.CoralOctaveOnOff == 0) {
            PianoNoteF4.volume = 3.0f;
            PianoNoteF4.Play();
            BubblesF.Play();
        }
    }

    public void BubbleNotesGOffClicking() {
        EnableObjects06.CoralAOnOff = 0;
        EnableObjects06.CoralBOnOff = 0;
        EnableObjects06.CoralCOnOff = 0;
        EnableObjects06.CoralDOnOff = 0;
        EnableObjects06.CoralEOnOff = 0;
        EnableObjects06.CoralFOnOff = 0;
        EnableObjects06.CoralGOnOff = 0;
        EnableObjects06.CoralGOnOff = 1;

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

        if (EnableObjects06.CoralOctaveOnOff == 1) {
            PianoNoteG5.volume = 3.0f;
            PianoNoteG5.Play();
            BubblesG.Play();
        }

        else if (EnableObjects06.CoralOctaveOnOff == 0) {
            PianoNoteG4.volume = 3.0f;
            PianoNoteG4.Play();
            BubblesG.Play();
        }
    }

    public void BubbleNotesOctaveOffClicking() {
        EnableObjects06.CoralOctaveOnOff = 1;
        BubblesOctave.Play();
    }

    public void BubbleNotesAOnClicking() {
        EnableObjects06.CoralAOnOff = 0;
        EnableObjects06.CoralBOnOff = 0;
        EnableObjects06.CoralCOnOff = 0;
        EnableObjects06.CoralDOnOff = 0;
        EnableObjects06.CoralEOnOff = 0;
        EnableObjects06.CoralFOnOff = 0;
        EnableObjects06.CoralGOnOff = 0;
        EnableObjects06.CoralAOnOff = 1;

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

        if (EnableObjects06.CoralOctaveOnOff == 1) {
            PianoNoteA5.volume = 3.0f;
            PianoNoteA5.Play();
            BubblesA.Play();
        }

        else if (EnableObjects06.CoralOctaveOnOff == 0) {
            PianoNoteA4.volume = 3.0f;
            PianoNoteA4.Play();
            BubblesA.Play();
        }
    }

    public void BubbleNotesBOnClicking() {
        EnableObjects06.CoralAOnOff = 0;
        EnableObjects06.CoralBOnOff = 0;
        EnableObjects06.CoralCOnOff = 0;
        EnableObjects06.CoralDOnOff = 0;
        EnableObjects06.CoralEOnOff = 0;
        EnableObjects06.CoralFOnOff = 0;
        EnableObjects06.CoralGOnOff = 0;
        EnableObjects06.CoralBOnOff = 1;

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

        if (EnableObjects06.CoralOctaveOnOff == 1) {
            PianoNoteB5.volume = 3.0f;
            PianoNoteB5.Play();
            BubblesB.Play();
        }

        else if (EnableObjects06.CoralOctaveOnOff == 0) {
            PianoNoteB4.volume = 3.0f;
            PianoNoteB4.Play();
            BubblesB.Play();
        }
    }

    public void BubbleNotesCOnClicking() {
        EnableObjects06.CoralAOnOff = 0;
        EnableObjects06.CoralBOnOff = 0;
        EnableObjects06.CoralCOnOff = 0;
        EnableObjects06.CoralDOnOff = 0;
        EnableObjects06.CoralEOnOff = 0;
        EnableObjects06.CoralFOnOff = 0;
        EnableObjects06.CoralGOnOff = 0;
        EnableObjects06.CoralCOnOff = 1;

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

        if (EnableObjects06.CoralOctaveOnOff == 1) {
            PianoNoteC5.volume = 3.0f;
            PianoNoteC5.Play();
            BubblesC.Play();
        }

        else if (EnableObjects06.CoralOctaveOnOff == 0) {
            PianoNoteC4.volume = 3.0f;
            PianoNoteC4.Play();
            BubblesC.Play();
        }
    }

    public void BubbleNotesDOnClicking() {
        EnableObjects06.CoralAOnOff = 0;
        EnableObjects06.CoralBOnOff = 0;
        EnableObjects06.CoralCOnOff = 0;
        EnableObjects06.CoralDOnOff = 0;
        EnableObjects06.CoralEOnOff = 0;
        EnableObjects06.CoralFOnOff = 0;
        EnableObjects06.CoralGOnOff = 0;
        EnableObjects06.CoralDOnOff = 1;

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

        if (EnableObjects06.CoralOctaveOnOff == 1) {
            PianoNoteD5.volume = 3.0f;
            PianoNoteD5.Play();
            BubblesD.Play();
        }

        else if (EnableObjects06.CoralOctaveOnOff == 0) {
            PianoNoteD4.volume = 3.0f;
            PianoNoteD4.Play();
            BubblesD.Play();
        }
    }

    public void BubbleNotesEOnClicking() {
        EnableObjects06.CoralAOnOff = 0;
        EnableObjects06.CoralBOnOff = 0;
        EnableObjects06.CoralCOnOff = 0;
        EnableObjects06.CoralDOnOff = 0;
        EnableObjects06.CoralEOnOff = 0;
        EnableObjects06.CoralFOnOff = 0;
        EnableObjects06.CoralGOnOff = 0;
        EnableObjects06.CoralEOnOff = 1;

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

        if (EnableObjects06.CoralOctaveOnOff == 1) {
            PianoNoteE5.volume = 3.0f;
            PianoNoteE5.Play();
            BubblesE.Play();
        }

        else if (EnableObjects06.CoralOctaveOnOff == 0) {
            PianoNoteE4.volume = 3.0f;
            PianoNoteE4.Play();
            BubblesE.Play();
        }
    }

    public void BubbleNotesFOnClicking() {
        EnableObjects06.CoralAOnOff = 0;
        EnableObjects06.CoralBOnOff = 0;
        EnableObjects06.CoralCOnOff = 0;
        EnableObjects06.CoralDOnOff = 0;
        EnableObjects06.CoralEOnOff = 0;
        EnableObjects06.CoralFOnOff = 0;
        EnableObjects06.CoralGOnOff = 0;
        EnableObjects06.CoralFOnOff = 1;

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

        if (EnableObjects06.CoralOctaveOnOff == 1) {
            PianoNoteF5.volume = 3.0f;
            PianoNoteF5.Play();
            BubblesF.Play();
        }

        else if (EnableObjects06.CoralOctaveOnOff == 0) {
            PianoNoteF4.volume = 3.0f;
            PianoNoteF4.Play();
            BubblesF.Play();
        }
    }

    public void BubbleNotesGOnClicking() {
        EnableObjects06.CoralAOnOff = 0;
        EnableObjects06.CoralBOnOff = 0;
        EnableObjects06.CoralCOnOff = 0;
        EnableObjects06.CoralDOnOff = 0;
        EnableObjects06.CoralEOnOff = 0;
        EnableObjects06.CoralFOnOff = 0;
        EnableObjects06.CoralGOnOff = 0;
        EnableObjects06.CoralGOnOff = 1;

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

        if (EnableObjects06.CoralOctaveOnOff == 1) {
            PianoNoteG5.volume = 3.0f;
            PianoNoteG5.Play();
            BubblesG.Play();
        }

        else if (EnableObjects06.CoralOctaveOnOff == 0) {
            PianoNoteG4.volume = 3.0f;
            PianoNoteG4.Play();
            BubblesG.Play();
        }
    }

    public void BubbleNotesOctaveOnClicking() {
        EnableObjects06.CoralOctaveOnOff = 0;
    }

    public void CoralAOffClicking() {
        EnableObjects06.CoralAOnOff = 0;
        EnableObjects06.CoralBOnOff = 0;
        EnableObjects06.CoralCOnOff = 0;
        EnableObjects06.CoralDOnOff = 0;
        EnableObjects06.CoralEOnOff = 0;
        EnableObjects06.CoralFOnOff = 0;
        EnableObjects06.CoralGOnOff = 0;
        EnableObjects06.CoralAOnOff = 1;

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

        if (EnableObjects06.CoralOctaveOnOff == 1) {
            PianoNoteA5.volume = 3.0f;
            PianoNoteA5.Play();
            BubblesA.Play();
        }

        else if (EnableObjects06.CoralOctaveOnOff == 0) {
            PianoNoteA4.volume = 3.0f;
            PianoNoteA4.Play();
            BubblesA.Play();
        }
    }

    public void CoralBOffClicking() {
        EnableObjects06.CoralAOnOff = 0;
        EnableObjects06.CoralBOnOff = 0;
        EnableObjects06.CoralCOnOff = 0;
        EnableObjects06.CoralDOnOff = 0;
        EnableObjects06.CoralEOnOff = 0;
        EnableObjects06.CoralFOnOff = 0;
        EnableObjects06.CoralGOnOff = 0;
        EnableObjects06.CoralBOnOff = 1;

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

        if (EnableObjects06.CoralOctaveOnOff == 1) {
            PianoNoteB5.volume = 3.0f;
            PianoNoteB5.Play();
            BubblesB.Play();
        }

        else if (EnableObjects06.CoralOctaveOnOff == 0) {
            PianoNoteB4.volume = 3.0f;
            PianoNoteB4.Play();
            BubblesB.Play();
        }
    }

    public void CoralCOffClicking() {
        EnableObjects06.CoralAOnOff = 0;
        EnableObjects06.CoralBOnOff = 0;
        EnableObjects06.CoralCOnOff = 0;
        EnableObjects06.CoralDOnOff = 0;
        EnableObjects06.CoralEOnOff = 0;
        EnableObjects06.CoralFOnOff = 0;
        EnableObjects06.CoralGOnOff = 0;
        EnableObjects06.CoralCOnOff = 1;

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

        if (EnableObjects06.CoralOctaveOnOff == 1) {
            PianoNoteC5.volume = 3.0f;
            PianoNoteC5.Play();
            BubblesC.Play();
        }

        else if (EnableObjects06.CoralOctaveOnOff == 0) {
            PianoNoteC4.volume = 3.0f;
            PianoNoteC4.Play();
            BubblesC.Play();
        }
    }

    public void CoralDOffClicking() {
        EnableObjects06.CoralAOnOff = 0;
        EnableObjects06.CoralBOnOff = 0;
        EnableObjects06.CoralCOnOff = 0;
        EnableObjects06.CoralDOnOff = 0;
        EnableObjects06.CoralEOnOff = 0;
        EnableObjects06.CoralFOnOff = 0;
        EnableObjects06.CoralGOnOff = 0;
        EnableObjects06.CoralDOnOff = 1;

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

        if (EnableObjects06.CoralOctaveOnOff == 1) {
            PianoNoteD5.volume = 3.0f;
            PianoNoteD5.Play();
            BubblesD.Play();
        }

        else if (EnableObjects06.CoralOctaveOnOff == 0) {
            PianoNoteD4.volume = 3.0f;
            PianoNoteD4.Play();
            BubblesD.Play();
        }
    }

    public void CoralEOffClicking() {
        EnableObjects06.CoralAOnOff = 0;
        EnableObjects06.CoralBOnOff = 0;
        EnableObjects06.CoralCOnOff = 0;
        EnableObjects06.CoralDOnOff = 0;
        EnableObjects06.CoralEOnOff = 0;
        EnableObjects06.CoralFOnOff = 0;
        EnableObjects06.CoralGOnOff = 0;
        EnableObjects06.CoralEOnOff = 1;

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

        if (EnableObjects06.CoralOctaveOnOff == 1) {
            PianoNoteE5.volume = 3.0f;
            PianoNoteE5.Play();
            BubblesE.Play();
        }

        else if (EnableObjects06.CoralOctaveOnOff == 0) {
            PianoNoteE4.volume = 3.0f;
            PianoNoteE4.Play();
            BubblesE.Play();
        }
    }

    public void CoralFOffClicking() {
        EnableObjects06.CoralAOnOff = 0;
        EnableObjects06.CoralBOnOff = 0;
        EnableObjects06.CoralCOnOff = 0;
        EnableObjects06.CoralDOnOff = 0;
        EnableObjects06.CoralEOnOff = 0;
        EnableObjects06.CoralFOnOff = 0;
        EnableObjects06.CoralGOnOff = 0;
        EnableObjects06.CoralFOnOff = 1;

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

        if (EnableObjects06.CoralOctaveOnOff == 1) {
            PianoNoteF5.volume = 3.0f;
            PianoNoteF5.Play();
            BubblesF.Play();
        }

        else if (EnableObjects06.CoralOctaveOnOff == 0) {
            PianoNoteF4.volume = 3.0f;
            PianoNoteF4.Play();
            BubblesF.Play();
        }
    }

    public void CoralGOffClicking() {
        EnableObjects06.CoralAOnOff = 0;
        EnableObjects06.CoralBOnOff = 0;
        EnableObjects06.CoralCOnOff = 0;
        EnableObjects06.CoralDOnOff = 0;
        EnableObjects06.CoralEOnOff = 0;
        EnableObjects06.CoralFOnOff = 0;
        EnableObjects06.CoralGOnOff = 0;
        EnableObjects06.CoralGOnOff = 1;

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

        if (EnableObjects06.CoralOctaveOnOff == 1) {
            PianoNoteG5.volume = 3.0f;
            PianoNoteG5.Play();
            BubblesG.Play();
        }

        else if (EnableObjects06.CoralOctaveOnOff == 0) {
            PianoNoteG4.volume = 3.0f;
            PianoNoteG4.Play();
            BubblesG.Play();
        }
    }

    public void CoralOctaveOffClicking() {
        EnableObjects06.CoralOctaveOnOff = 1;
        BubblesOctave.Play();
    }

    public void CoralAOnClicking() {
        EnableObjects06.CoralAOnOff = 0;
        EnableObjects06.CoralBOnOff = 0;
        EnableObjects06.CoralCOnOff = 0;
        EnableObjects06.CoralDOnOff = 0;
        EnableObjects06.CoralEOnOff = 0;
        EnableObjects06.CoralFOnOff = 0;
        EnableObjects06.CoralGOnOff = 0;
        EnableObjects06.CoralAOnOff = 1;

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

        if (EnableObjects06.CoralOctaveOnOff == 1) {
            PianoNoteA5.volume = 3.0f;
            PianoNoteA5.Play();
            BubblesA.Play();
        }

        else if (EnableObjects06.CoralOctaveOnOff == 0) {
            PianoNoteA4.volume = 3.0f;
            PianoNoteA4.Play();
            BubblesA.Play();
        }
    }

    public void CoralBOnClicking() {
        EnableObjects06.CoralAOnOff = 0;
        EnableObjects06.CoralBOnOff = 0;
        EnableObjects06.CoralCOnOff = 0;
        EnableObjects06.CoralDOnOff = 0;
        EnableObjects06.CoralEOnOff = 0;
        EnableObjects06.CoralFOnOff = 0;
        EnableObjects06.CoralGOnOff = 0;
        EnableObjects06.CoralBOnOff = 1;

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

        if (EnableObjects06.CoralOctaveOnOff == 1) {
            PianoNoteB5.volume = 3.0f;
            PianoNoteB5.Play();
            BubblesB.Play();
        }

        else if (EnableObjects06.CoralOctaveOnOff == 0) {
            PianoNoteB4.volume = 3.0f;
            PianoNoteB4.Play();
            BubblesB.Play();
        }
    }

    public void CoralCOnClicking() {
        EnableObjects06.CoralAOnOff = 0;
        EnableObjects06.CoralBOnOff = 0;
        EnableObjects06.CoralCOnOff = 0;
        EnableObjects06.CoralDOnOff = 0;
        EnableObjects06.CoralEOnOff = 0;
        EnableObjects06.CoralFOnOff = 0;
        EnableObjects06.CoralGOnOff = 0;
        EnableObjects06.CoralCOnOff = 1;

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

        if (EnableObjects06.CoralOctaveOnOff == 1) {
            PianoNoteC5.volume = 3.0f;
            PianoNoteC5.Play();
            BubblesC.Play();
        }

        else if (EnableObjects06.CoralOctaveOnOff == 0) {
            PianoNoteC4.volume = 3.0f;
            PianoNoteC4.Play();
            BubblesC.Play();
        }
    }

    public void CoralDOnClicking() {
        EnableObjects06.CoralAOnOff = 0;
        EnableObjects06.CoralBOnOff = 0;
        EnableObjects06.CoralCOnOff = 0;
        EnableObjects06.CoralDOnOff = 0;
        EnableObjects06.CoralEOnOff = 0;
        EnableObjects06.CoralFOnOff = 0;
        EnableObjects06.CoralGOnOff = 0;
        EnableObjects06.CoralDOnOff = 1;

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

        if (EnableObjects06.CoralOctaveOnOff == 1) {
            PianoNoteD5.volume = 3.0f;
            PianoNoteD5.Play();
            BubblesD.Play();
        }

        else if (EnableObjects06.CoralOctaveOnOff == 0) {
            PianoNoteD4.volume = 3.0f;
            PianoNoteD4.Play();
            BubblesD.Play();
        }
    }

    public void CoralEOnClicking() {
        EnableObjects06.CoralAOnOff = 0;
        EnableObjects06.CoralBOnOff = 0;
        EnableObjects06.CoralCOnOff = 0;
        EnableObjects06.CoralDOnOff = 0;
        EnableObjects06.CoralEOnOff = 0;
        EnableObjects06.CoralFOnOff = 0;
        EnableObjects06.CoralGOnOff = 0;
        EnableObjects06.CoralEOnOff = 1;

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

        if (EnableObjects06.CoralOctaveOnOff == 1) {
            PianoNoteE5.volume = 3.0f;
            PianoNoteE5.Play();
            BubblesE.Play();
        }

        else if (EnableObjects06.CoralOctaveOnOff == 0) {
            PianoNoteE4.volume = 3.0f;
            PianoNoteE4.Play();
            BubblesE.Play();
        }
    }

    public void CoralFOnClicking() {
        EnableObjects06.CoralAOnOff = 0;
        EnableObjects06.CoralBOnOff = 0;
        EnableObjects06.CoralCOnOff = 0;
        EnableObjects06.CoralDOnOff = 0;
        EnableObjects06.CoralEOnOff = 0;
        EnableObjects06.CoralFOnOff = 0;
        EnableObjects06.CoralGOnOff = 0;
        EnableObjects06.CoralFOnOff = 1;

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

        if (EnableObjects06.CoralOctaveOnOff == 1) {
            PianoNoteF5.volume = 3.0f;
            PianoNoteF5.Play();
            BubblesF.Play();
        }

        else if (EnableObjects06.CoralOctaveOnOff == 0) {
            PianoNoteF4.volume = 3.0f;
            PianoNoteF4.Play();
            BubblesF.Play();
        }
    }

    public void CoralGOnClicking() {
        EnableObjects06.CoralAOnOff = 0;
        EnableObjects06.CoralBOnOff = 0;
        EnableObjects06.CoralCOnOff = 0;
        EnableObjects06.CoralDOnOff = 0;
        EnableObjects06.CoralEOnOff = 0;
        EnableObjects06.CoralFOnOff = 0;
        EnableObjects06.CoralGOnOff = 0;
        EnableObjects06.CoralGOnOff = 1;

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

        if (EnableObjects06.CoralOctaveOnOff == 1) {
            PianoNoteG5.volume = 3.0f;
            PianoNoteG5.Play();
            BubblesG.Play();
        }

        else if (EnableObjects06.CoralOctaveOnOff == 0) {
            PianoNoteG4.volume = 3.0f;
            PianoNoteG4.Play();
            BubblesG.Play();
        }
    }

    public void CoralOctaveOnClicking() {
        EnableObjects06.CoralOctaveOnOff = 0;
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
        EnableObjects06.SettingNotesOnOff = 0;
    }

    public void SettingsOffButtonClicking() {
        EnableObjects06.SettingNotesOnOff = 1;
    }

    public void SettingsBackButtonClicking() {
        EnableObjects06.SettingPanelOnOff = 0;
    }

// ------------------------------ END: OTHER FUNCTIONS ------------------------------

}