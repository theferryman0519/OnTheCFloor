using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

public class Buttons04 : MonoBehaviour {

// ------------------------------ START: LIST OF VARIABLES ------------------------------
// -------------------- PUBLIC VARIABLES --------------------
    // Main Objects
    public Button MainMenuButton;
    public Button SettingsButton;
    public Button ReplayNoteButton;

    public Text ResultsText;

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

    // Results Tries
    public int ResultsIdentifyInt;
    public static int CheckCorrectInt;

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

        // ReplayNoteButton
        Button ReplayNoteButtonClick = ReplayNoteButton.GetComponent<Button>();
        ReplayNoteButtonClick.onClick.AddListener(ReplayNoteButtonClicking);

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

        CheckCorrectInt = 0;

        // IEnumerator
        StartCoroutine(PlayByEarNotes());
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
        EnableObjects04.SettingPanelOnOff = 1;
    }

    public void BubbleNotesAOffClicking() {
        EnableObjects04.CoralAOnOff = 0;
        EnableObjects04.CoralBOnOff = 0;
        EnableObjects04.CoralCOnOff = 0;
        EnableObjects04.CoralDOnOff = 0;
        EnableObjects04.CoralEOnOff = 0;
        EnableObjects04.CoralFOnOff = 0;
        EnableObjects04.CoralGOnOff = 0;
        EnableObjects04.CoralAOnOff = 1;

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

        if (EnableObjects04.CoralOctaveOnOff == 1) {
            PianoNoteA5.volume = 3.0f;
            PianoNoteA5.Play();
            CheckCorrectInt = 8;
            CheckCorrectResult();
            BubblesA.Play();
        }

        else if (EnableObjects04.CoralOctaveOnOff == 0) {
            PianoNoteA4.volume = 3.0f;
            PianoNoteA4.Play();
            CheckCorrectInt = 1;
            CheckCorrectResult();
            BubblesA.Play();
        }
    }

    public void BubbleNotesBOffClicking() {
        EnableObjects04.CoralAOnOff = 0;
        EnableObjects04.CoralBOnOff = 0;
        EnableObjects04.CoralCOnOff = 0;
        EnableObjects04.CoralDOnOff = 0;
        EnableObjects04.CoralEOnOff = 0;
        EnableObjects04.CoralFOnOff = 0;
        EnableObjects04.CoralGOnOff = 0;
        EnableObjects04.CoralBOnOff = 1;

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

        if (EnableObjects04.CoralOctaveOnOff == 1) {
            PianoNoteB5.volume = 3.0f;
            PianoNoteB5.Play();
            CheckCorrectInt = 9;
            CheckCorrectResult();
            BubblesB.Play();
        }

        else if (EnableObjects04.CoralOctaveOnOff == 0) {
            PianoNoteB4.volume = 3.0f;
            PianoNoteB4.Play();
            CheckCorrectInt = 2;
            CheckCorrectResult();
            BubblesB.Play();
        }
    }

    public void BubbleNotesCOffClicking() {
        EnableObjects04.CoralAOnOff = 0;
        EnableObjects04.CoralBOnOff = 0;
        EnableObjects04.CoralCOnOff = 0;
        EnableObjects04.CoralDOnOff = 0;
        EnableObjects04.CoralEOnOff = 0;
        EnableObjects04.CoralFOnOff = 0;
        EnableObjects04.CoralGOnOff = 0;
        EnableObjects04.CoralCOnOff = 1;

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

        if (EnableObjects04.CoralOctaveOnOff == 1) {
            PianoNoteC5.volume = 3.0f;
            PianoNoteC5.Play();
            CheckCorrectInt = 10;
            CheckCorrectResult();
            BubblesC.Play();
        }

        else if (EnableObjects04.CoralOctaveOnOff == 0) {
            PianoNoteC4.volume = 3.0f;
            PianoNoteC4.Play();
            CheckCorrectInt = 3;
            CheckCorrectResult();
            BubblesC.Play();
        }
    }

    public void BubbleNotesDOffClicking() {
        EnableObjects04.CoralAOnOff = 0;
        EnableObjects04.CoralBOnOff = 0;
        EnableObjects04.CoralCOnOff = 0;
        EnableObjects04.CoralDOnOff = 0;
        EnableObjects04.CoralEOnOff = 0;
        EnableObjects04.CoralFOnOff = 0;
        EnableObjects04.CoralGOnOff = 0;
        EnableObjects04.CoralDOnOff = 1;

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

        if (EnableObjects04.CoralOctaveOnOff == 1) {
            PianoNoteD5.volume = 3.0f;
            PianoNoteD5.Play();
            CheckCorrectInt = 11;
            CheckCorrectResult();
            BubblesD.Play();
        }

        else if (EnableObjects04.CoralOctaveOnOff == 0) {
            PianoNoteD4.volume = 3.0f;
            PianoNoteD4.Play();
            CheckCorrectInt = 4;
            CheckCorrectResult();
            BubblesD.Play();
        }
    }

    public void BubbleNotesEOffClicking() {
        EnableObjects04.CoralAOnOff = 0;
        EnableObjects04.CoralBOnOff = 0;
        EnableObjects04.CoralCOnOff = 0;
        EnableObjects04.CoralDOnOff = 0;
        EnableObjects04.CoralEOnOff = 0;
        EnableObjects04.CoralFOnOff = 0;
        EnableObjects04.CoralGOnOff = 0;
        EnableObjects04.CoralEOnOff = 1;

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

        if (EnableObjects04.CoralOctaveOnOff == 1) {
            PianoNoteE5.volume = 3.0f;
            PianoNoteE5.Play();
            CheckCorrectInt = 12;
            CheckCorrectResult();
            BubblesE.Play();
        }

        else if (EnableObjects04.CoralOctaveOnOff == 0) {
            PianoNoteE4.volume = 3.0f;
            PianoNoteE4.Play();
            CheckCorrectInt = 5;
            CheckCorrectResult();
            BubblesE.Play();
        }
    }

    public void BubbleNotesFOffClicking() {
        EnableObjects04.CoralAOnOff = 0;
        EnableObjects04.CoralBOnOff = 0;
        EnableObjects04.CoralCOnOff = 0;
        EnableObjects04.CoralDOnOff = 0;
        EnableObjects04.CoralEOnOff = 0;
        EnableObjects04.CoralFOnOff = 0;
        EnableObjects04.CoralGOnOff = 0;
        EnableObjects04.CoralFOnOff = 1;

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

        if (EnableObjects04.CoralOctaveOnOff == 1) {
            PianoNoteF5.volume = 3.0f;
            PianoNoteF5.Play();
            CheckCorrectInt = 13;
            CheckCorrectResult();
            BubblesF.Play();
        }

        else if (EnableObjects04.CoralOctaveOnOff == 0) {
            PianoNoteF4.volume = 3.0f;
            PianoNoteF4.Play();
            CheckCorrectInt = 6;
            CheckCorrectResult();
            BubblesF.Play();
        }
    }

    public void BubbleNotesGOffClicking() {
        EnableObjects04.CoralAOnOff = 0;
        EnableObjects04.CoralBOnOff = 0;
        EnableObjects04.CoralCOnOff = 0;
        EnableObjects04.CoralDOnOff = 0;
        EnableObjects04.CoralEOnOff = 0;
        EnableObjects04.CoralFOnOff = 0;
        EnableObjects04.CoralGOnOff = 0;
        EnableObjects04.CoralGOnOff = 1;

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

        if (EnableObjects04.CoralOctaveOnOff == 1) {
            PianoNoteG5.volume = 3.0f;
            PianoNoteG5.Play();
            CheckCorrectInt = 14;
            CheckCorrectResult();
            BubblesG.Play();
        }

        else if (EnableObjects04.CoralOctaveOnOff == 0) {
            PianoNoteG4.volume = 3.0f;
            PianoNoteG4.Play();
            CheckCorrectInt = 7;
            CheckCorrectResult();
            BubblesG.Play();
        }
    }

    public void BubbleNotesOctaveOffClicking() {
        EnableObjects04.CoralOctaveOnOff = 1;
        BubblesOctave.Play();
    }

    public void BubbleNotesAOnClicking() {
        EnableObjects04.CoralAOnOff = 0;
        EnableObjects04.CoralBOnOff = 0;
        EnableObjects04.CoralCOnOff = 0;
        EnableObjects04.CoralDOnOff = 0;
        EnableObjects04.CoralEOnOff = 0;
        EnableObjects04.CoralFOnOff = 0;
        EnableObjects04.CoralGOnOff = 0;
        EnableObjects04.CoralAOnOff = 1;

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

        if (EnableObjects04.CoralOctaveOnOff == 1) {
            PianoNoteA5.volume = 3.0f;
            PianoNoteA5.Play();
            CheckCorrectInt = 8;
            CheckCorrectResult();
            BubblesA.Play();
        }

        else if (EnableObjects04.CoralOctaveOnOff == 0) {
            PianoNoteA4.volume = 3.0f;
            PianoNoteA4.Play();
            CheckCorrectInt = 1;
            CheckCorrectResult();
            BubblesA.Play();
        }
    }

    public void BubbleNotesBOnClicking() {
        EnableObjects04.CoralAOnOff = 0;
        EnableObjects04.CoralBOnOff = 0;
        EnableObjects04.CoralCOnOff = 0;
        EnableObjects04.CoralDOnOff = 0;
        EnableObjects04.CoralEOnOff = 0;
        EnableObjects04.CoralFOnOff = 0;
        EnableObjects04.CoralGOnOff = 0;
        EnableObjects04.CoralBOnOff = 1;

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

        if (EnableObjects04.CoralOctaveOnOff == 1) {
            PianoNoteB5.volume = 3.0f;
            PianoNoteB5.Play();
            CheckCorrectInt = 9;
            CheckCorrectResult();
            BubblesB.Play();
        }

        else if (EnableObjects04.CoralOctaveOnOff == 0) {
            PianoNoteB4.volume = 3.0f;
            PianoNoteB4.Play();
            CheckCorrectInt = 2;
            CheckCorrectResult();
            BubblesB.Play();
        }
    }

    public void BubbleNotesCOnClicking() {
        EnableObjects04.CoralAOnOff = 0;
        EnableObjects04.CoralBOnOff = 0;
        EnableObjects04.CoralCOnOff = 0;
        EnableObjects04.CoralDOnOff = 0;
        EnableObjects04.CoralEOnOff = 0;
        EnableObjects04.CoralFOnOff = 0;
        EnableObjects04.CoralGOnOff = 0;
        EnableObjects04.CoralCOnOff = 1;

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

        if (EnableObjects04.CoralOctaveOnOff == 1) {
            PianoNoteC5.volume = 3.0f;
            PianoNoteC5.Play();
            CheckCorrectInt = 10;
            CheckCorrectResult();
            BubblesC.Play();
        }

        else if (EnableObjects04.CoralOctaveOnOff == 0) {
            PianoNoteC4.volume = 3.0f;
            PianoNoteC4.Play();
            CheckCorrectInt = 3;
            CheckCorrectResult();
            BubblesC.Play();
        }
    }

    public void BubbleNotesDOnClicking() {
        EnableObjects04.CoralAOnOff = 0;
        EnableObjects04.CoralBOnOff = 0;
        EnableObjects04.CoralCOnOff = 0;
        EnableObjects04.CoralDOnOff = 0;
        EnableObjects04.CoralEOnOff = 0;
        EnableObjects04.CoralFOnOff = 0;
        EnableObjects04.CoralGOnOff = 0;
        EnableObjects04.CoralDOnOff = 1;

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

        if (EnableObjects04.CoralOctaveOnOff == 1) {
            PianoNoteD5.volume = 3.0f;
            PianoNoteD5.Play();
            CheckCorrectInt = 11;
            CheckCorrectResult();
            BubblesD.Play();
        }

        else if (EnableObjects04.CoralOctaveOnOff == 0) {
            PianoNoteD4.volume = 3.0f;
            PianoNoteD4.Play();
            CheckCorrectInt = 4;
            CheckCorrectResult();
            BubblesD.Play();
        }
    }

    public void BubbleNotesEOnClicking() {
        EnableObjects04.CoralAOnOff = 0;
        EnableObjects04.CoralBOnOff = 0;
        EnableObjects04.CoralCOnOff = 0;
        EnableObjects04.CoralDOnOff = 0;
        EnableObjects04.CoralEOnOff = 0;
        EnableObjects04.CoralFOnOff = 0;
        EnableObjects04.CoralGOnOff = 0;
        EnableObjects04.CoralEOnOff = 1;

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

        if (EnableObjects04.CoralOctaveOnOff == 1) {
            PianoNoteE5.volume = 3.0f;
            PianoNoteE5.Play();
            CheckCorrectInt = 12;
            CheckCorrectResult();
            BubblesE.Play();
        }

        else if (EnableObjects04.CoralOctaveOnOff == 0) {
            PianoNoteE4.volume = 3.0f;
            PianoNoteE4.Play();
            CheckCorrectInt = 5;
            CheckCorrectResult();
            BubblesE.Play();
        }
    }

    public void BubbleNotesFOnClicking() {
        EnableObjects04.CoralAOnOff = 0;
        EnableObjects04.CoralBOnOff = 0;
        EnableObjects04.CoralCOnOff = 0;
        EnableObjects04.CoralDOnOff = 0;
        EnableObjects04.CoralEOnOff = 0;
        EnableObjects04.CoralFOnOff = 0;
        EnableObjects04.CoralGOnOff = 0;
        EnableObjects04.CoralFOnOff = 1;

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

        if (EnableObjects04.CoralOctaveOnOff == 1) {
            PianoNoteF5.volume = 3.0f;
            PianoNoteF5.Play();
            CheckCorrectInt = 13;
            CheckCorrectResult();
            BubblesF.Play();
        }

        else if (EnableObjects04.CoralOctaveOnOff == 0) {
            PianoNoteF4.volume = 3.0f;
            PianoNoteF4.Play();
            CheckCorrectInt = 6;
            CheckCorrectResult();
            BubblesF.Play();
        }
    }

    public void BubbleNotesGOnClicking() {
        EnableObjects04.CoralAOnOff = 0;
        EnableObjects04.CoralBOnOff = 0;
        EnableObjects04.CoralCOnOff = 0;
        EnableObjects04.CoralDOnOff = 0;
        EnableObjects04.CoralEOnOff = 0;
        EnableObjects04.CoralFOnOff = 0;
        EnableObjects04.CoralGOnOff = 0;
        EnableObjects04.CoralGOnOff = 1;

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

        if (EnableObjects04.CoralOctaveOnOff == 1) {
            PianoNoteG5.volume = 3.0f;
            PianoNoteG5.Play();
            CheckCorrectInt = 14;
            CheckCorrectResult();
            BubblesG.Play();
        }

        else if (EnableObjects04.CoralOctaveOnOff == 0) {
            PianoNoteG4.volume = 3.0f;
            PianoNoteG4.Play();
            CheckCorrectInt = 7;
            CheckCorrectResult();
            BubblesG.Play();
        }
    }

    public void BubbleNotesOctaveOnClicking() {
        EnableObjects04.CoralOctaveOnOff = 0;
    }

    public void CoralAOffClicking() {
        EnableObjects04.CoralAOnOff = 0;
        EnableObjects04.CoralBOnOff = 0;
        EnableObjects04.CoralCOnOff = 0;
        EnableObjects04.CoralDOnOff = 0;
        EnableObjects04.CoralEOnOff = 0;
        EnableObjects04.CoralFOnOff = 0;
        EnableObjects04.CoralGOnOff = 0;
        EnableObjects04.CoralAOnOff = 1;

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

        if (EnableObjects04.CoralOctaveOnOff == 1) {
            PianoNoteA5.volume = 3.0f;
            PianoNoteA5.Play();
            CheckCorrectInt = 8;
            CheckCorrectResult();
            BubblesA.Play();
        }

        else if (EnableObjects04.CoralOctaveOnOff == 0) {
            PianoNoteA4.volume = 3.0f;
            PianoNoteA4.Play();
            CheckCorrectInt = 1;
            CheckCorrectResult();
            BubblesA.Play();
        }
    }

    public void CoralBOffClicking() {
        EnableObjects04.CoralAOnOff = 0;
        EnableObjects04.CoralBOnOff = 0;
        EnableObjects04.CoralCOnOff = 0;
        EnableObjects04.CoralDOnOff = 0;
        EnableObjects04.CoralEOnOff = 0;
        EnableObjects04.CoralFOnOff = 0;
        EnableObjects04.CoralGOnOff = 0;
        EnableObjects04.CoralBOnOff = 1;

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

        if (EnableObjects04.CoralOctaveOnOff == 1) {
            PianoNoteB5.volume = 3.0f;
            PianoNoteB5.Play();
            CheckCorrectInt = 9;
            CheckCorrectResult();
            BubblesB.Play();
        }

        else if (EnableObjects04.CoralOctaveOnOff == 0) {
            PianoNoteB4.volume = 3.0f;
            PianoNoteB4.Play();
            CheckCorrectInt = 2;
            CheckCorrectResult();
            BubblesB.Play();
        }
    }

    public void CoralCOffClicking() {
        EnableObjects04.CoralAOnOff = 0;
        EnableObjects04.CoralBOnOff = 0;
        EnableObjects04.CoralCOnOff = 0;
        EnableObjects04.CoralDOnOff = 0;
        EnableObjects04.CoralEOnOff = 0;
        EnableObjects04.CoralFOnOff = 0;
        EnableObjects04.CoralGOnOff = 0;
        EnableObjects04.CoralCOnOff = 1;

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

        if (EnableObjects04.CoralOctaveOnOff == 1) {
            PianoNoteC5.volume = 3.0f;
            PianoNoteC5.Play();
            CheckCorrectInt = 10;
            CheckCorrectResult();
            BubblesC.Play();
        }

        else if (EnableObjects04.CoralOctaveOnOff == 0) {
            PianoNoteC4.volume = 3.0f;
            PianoNoteC4.Play();
            CheckCorrectInt = 3;
            CheckCorrectResult();
            BubblesC.Play();
        }
    }

    public void CoralDOffClicking() {
        EnableObjects04.CoralAOnOff = 0;
        EnableObjects04.CoralBOnOff = 0;
        EnableObjects04.CoralCOnOff = 0;
        EnableObjects04.CoralDOnOff = 0;
        EnableObjects04.CoralEOnOff = 0;
        EnableObjects04.CoralFOnOff = 0;
        EnableObjects04.CoralGOnOff = 0;
        EnableObjects04.CoralDOnOff = 1;

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

        if (EnableObjects04.CoralOctaveOnOff == 1) {
            PianoNoteD5.volume = 3.0f;
            PianoNoteD5.Play();
            CheckCorrectInt = 11;
            CheckCorrectResult();
            BubblesD.Play();
        }

        else if (EnableObjects04.CoralOctaveOnOff == 0) {
            PianoNoteD4.volume = 3.0f;
            PianoNoteD4.Play();
            CheckCorrectInt = 4;
            CheckCorrectResult();
            BubblesD.Play();
        }
    }

    public void CoralEOffClicking() {
        EnableObjects04.CoralAOnOff = 0;
        EnableObjects04.CoralBOnOff = 0;
        EnableObjects04.CoralCOnOff = 0;
        EnableObjects04.CoralDOnOff = 0;
        EnableObjects04.CoralEOnOff = 0;
        EnableObjects04.CoralFOnOff = 0;
        EnableObjects04.CoralGOnOff = 0;
        EnableObjects04.CoralEOnOff = 1;

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

        if (EnableObjects04.CoralOctaveOnOff == 1) {
            PianoNoteE5.volume = 3.0f;
            PianoNoteE5.Play();
            CheckCorrectInt = 12;
            CheckCorrectResult();
            BubblesE.Play();
        }

        else if (EnableObjects04.CoralOctaveOnOff == 0) {
            PianoNoteE4.volume = 3.0f;
            PianoNoteE4.Play();
            CheckCorrectInt = 5;
            CheckCorrectResult();
            BubblesE.Play();
        }
    }

    public void CoralFOffClicking() {
        EnableObjects04.CoralAOnOff = 0;
        EnableObjects04.CoralBOnOff = 0;
        EnableObjects04.CoralCOnOff = 0;
        EnableObjects04.CoralDOnOff = 0;
        EnableObjects04.CoralEOnOff = 0;
        EnableObjects04.CoralFOnOff = 0;
        EnableObjects04.CoralGOnOff = 0;
        EnableObjects04.CoralFOnOff = 1;

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

        if (EnableObjects04.CoralOctaveOnOff == 1) {
            PianoNoteF5.volume = 3.0f;
            PianoNoteF5.Play();
            CheckCorrectInt = 13;
            CheckCorrectResult();
            BubblesF.Play();
        }

        else if (EnableObjects04.CoralOctaveOnOff == 0) {
            PianoNoteF4.volume = 3.0f;
            PianoNoteF4.Play();
            CheckCorrectInt = 6;
            CheckCorrectResult();
            BubblesF.Play();
        }
    }

    public void CoralGOffClicking() {
        EnableObjects04.CoralAOnOff = 0;
        EnableObjects04.CoralBOnOff = 0;
        EnableObjects04.CoralCOnOff = 0;
        EnableObjects04.CoralDOnOff = 0;
        EnableObjects04.CoralEOnOff = 0;
        EnableObjects04.CoralFOnOff = 0;
        EnableObjects04.CoralGOnOff = 0;
        EnableObjects04.CoralGOnOff = 1;

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

        if (EnableObjects04.CoralOctaveOnOff == 1) {
            PianoNoteG5.volume = 3.0f;
            PianoNoteG5.Play();
            CheckCorrectInt = 14;
            CheckCorrectResult();
            BubblesG.Play();
        }

        else if (EnableObjects04.CoralOctaveOnOff == 0) {
            PianoNoteG4.volume = 3.0f;
            PianoNoteG4.Play();
            CheckCorrectInt = 7;
            CheckCorrectResult();
            BubblesG.Play();
        }
    }

    public void CoralOctaveOffClicking() {
        EnableObjects04.CoralOctaveOnOff = 1;
        BubblesOctave.Play();
    }

    public void CoralAOnClicking() {
        EnableObjects04.CoralAOnOff = 0;
        EnableObjects04.CoralBOnOff = 0;
        EnableObjects04.CoralCOnOff = 0;
        EnableObjects04.CoralDOnOff = 0;
        EnableObjects04.CoralEOnOff = 0;
        EnableObjects04.CoralFOnOff = 0;
        EnableObjects04.CoralGOnOff = 0;
        EnableObjects04.CoralAOnOff = 1;

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

        if (EnableObjects04.CoralOctaveOnOff == 1) {
            PianoNoteA5.volume = 3.0f;
            PianoNoteA5.Play();
            CheckCorrectInt = 8;
            CheckCorrectResult();
            BubblesA.Play();
        }

        else if (EnableObjects04.CoralOctaveOnOff == 0) {
            PianoNoteA4.volume = 3.0f;
            PianoNoteA4.Play();
            CheckCorrectInt = 1;
            CheckCorrectResult();
            BubblesA.Play();
        }
    }

    public void CoralBOnClicking() {
        EnableObjects04.CoralAOnOff = 0;
        EnableObjects04.CoralBOnOff = 0;
        EnableObjects04.CoralCOnOff = 0;
        EnableObjects04.CoralDOnOff = 0;
        EnableObjects04.CoralEOnOff = 0;
        EnableObjects04.CoralFOnOff = 0;
        EnableObjects04.CoralGOnOff = 0;
        EnableObjects04.CoralBOnOff = 1;

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

        if (EnableObjects04.CoralOctaveOnOff == 1) {
            PianoNoteB5.volume = 3.0f;
            PianoNoteB5.Play();
            CheckCorrectInt = 9;
            CheckCorrectResult();
            BubblesB.Play();
        }

        else if (EnableObjects04.CoralOctaveOnOff == 0) {
            PianoNoteB4.volume = 3.0f;
            PianoNoteB4.Play();
            CheckCorrectInt = 2;
            CheckCorrectResult();
            BubblesB.Play();
        }
    }

    public void CoralCOnClicking() {
        EnableObjects04.CoralAOnOff = 0;
        EnableObjects04.CoralBOnOff = 0;
        EnableObjects04.CoralCOnOff = 0;
        EnableObjects04.CoralDOnOff = 0;
        EnableObjects04.CoralEOnOff = 0;
        EnableObjects04.CoralFOnOff = 0;
        EnableObjects04.CoralGOnOff = 0;
        EnableObjects04.CoralCOnOff = 1;

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

        if (EnableObjects04.CoralOctaveOnOff == 1) {
            PianoNoteC5.volume = 3.0f;
            PianoNoteC5.Play();
            CheckCorrectInt = 10;
            CheckCorrectResult();
            BubblesC.Play();
        }

        else if (EnableObjects04.CoralOctaveOnOff == 0) {
            PianoNoteC4.volume = 3.0f;
            PianoNoteC4.Play();
            CheckCorrectInt = 3;
            CheckCorrectResult();
            BubblesC.Play();
        }
    }

    public void CoralDOnClicking() {
        EnableObjects04.CoralAOnOff = 0;
        EnableObjects04.CoralBOnOff = 0;
        EnableObjects04.CoralCOnOff = 0;
        EnableObjects04.CoralDOnOff = 0;
        EnableObjects04.CoralEOnOff = 0;
        EnableObjects04.CoralFOnOff = 0;
        EnableObjects04.CoralGOnOff = 0;
        EnableObjects04.CoralDOnOff = 1;

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

        if (EnableObjects04.CoralOctaveOnOff == 1) {
            PianoNoteD5.volume = 3.0f;
            PianoNoteD5.Play();
            CheckCorrectInt = 11;
            CheckCorrectResult();
            BubblesD.Play();
        }

        else if (EnableObjects04.CoralOctaveOnOff == 0) {
            PianoNoteD4.volume = 3.0f;
            PianoNoteD4.Play();
            CheckCorrectInt = 4;
            CheckCorrectResult();
            BubblesD.Play();
        }
    }

    public void CoralEOnClicking() {
        EnableObjects04.CoralAOnOff = 0;
        EnableObjects04.CoralBOnOff = 0;
        EnableObjects04.CoralCOnOff = 0;
        EnableObjects04.CoralDOnOff = 0;
        EnableObjects04.CoralEOnOff = 0;
        EnableObjects04.CoralFOnOff = 0;
        EnableObjects04.CoralGOnOff = 0;
        EnableObjects04.CoralEOnOff = 1;

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

        if (EnableObjects04.CoralOctaveOnOff == 1) {
            PianoNoteE5.volume = 3.0f;
            PianoNoteE5.Play();
            CheckCorrectInt = 12;
            CheckCorrectResult();
            BubblesE.Play();
        }

        else if (EnableObjects04.CoralOctaveOnOff == 0) {
            PianoNoteE4.volume = 3.0f;
            PianoNoteE4.Play();
            CheckCorrectInt = 5;
            CheckCorrectResult();
            BubblesE.Play();
        }
    }

    public void CoralFOnClicking() {
        EnableObjects04.CoralAOnOff = 0;
        EnableObjects04.CoralBOnOff = 0;
        EnableObjects04.CoralCOnOff = 0;
        EnableObjects04.CoralDOnOff = 0;
        EnableObjects04.CoralEOnOff = 0;
        EnableObjects04.CoralFOnOff = 0;
        EnableObjects04.CoralGOnOff = 0;
        EnableObjects04.CoralFOnOff = 1;

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

        if (EnableObjects04.CoralOctaveOnOff == 1) {
            PianoNoteF5.volume = 3.0f;
            PianoNoteF5.Play();
            CheckCorrectInt = 13;
            CheckCorrectResult();
            BubblesF.Play();
        }

        else if (EnableObjects04.CoralOctaveOnOff == 0) {
            PianoNoteF4.volume = 3.0f;
            PianoNoteF4.Play();
            CheckCorrectInt = 6;
            CheckCorrectResult();
            BubblesF.Play();
        }
    }

    public void CoralGOnClicking() {
        EnableObjects04.CoralAOnOff = 0;
        EnableObjects04.CoralBOnOff = 0;
        EnableObjects04.CoralCOnOff = 0;
        EnableObjects04.CoralDOnOff = 0;
        EnableObjects04.CoralEOnOff = 0;
        EnableObjects04.CoralFOnOff = 0;
        EnableObjects04.CoralGOnOff = 0;
        EnableObjects04.CoralGOnOff = 1;

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

        if (EnableObjects04.CoralOctaveOnOff == 1) {
            PianoNoteG5.volume = 3.0f;
            PianoNoteG5.Play();
            CheckCorrectInt = 14;
            CheckCorrectResult();
            BubblesG.Play();
        }

        else if (EnableObjects04.CoralOctaveOnOff == 0) {
            PianoNoteG4.volume = 3.0f;
            PianoNoteG4.Play();
            CheckCorrectInt = 7;
            CheckCorrectResult();
            BubblesG.Play();
        }
    }

    public void CoralOctaveOnClicking() {
        EnableObjects04.CoralOctaveOnOff = 0;
    }

    public void SettingsOnButtonClicking() {
        EnableObjects04.SettingNotesOnOff = 0;
    }

    public void SettingsOffButtonClicking() {
        EnableObjects04.SettingNotesOnOff = 1;
    }

    public void SettingsBackButtonClicking() {
        EnableObjects04.SettingPanelOnOff = 0;
    }

    public void ReplayNoteButtonClicking() {
        PlayNotes();
    }

// -------------------- IENUMERATOR FUNCTIONS --------------------
    public IEnumerator PlayByEarNotes() {
        yield return new WaitForSeconds(1.5f);
        ResultsIdentifyInt = Random.Range(1,15);
        PlayNotes();
    }

    public void PlayNotes() {
        CheckCorrectInt = 0;
        
        if (ResultsIdentifyInt == 1) {
            // Mute All
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

            // Play Note
            PianoNoteA4.volume = 3.0f;
            PianoNoteA4.Play();
        }

        else if (ResultsIdentifyInt == 2) {
            // Mute All
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

            // Play Note
            PianoNoteB4.volume = 3.0f;
            PianoNoteB4.Play();
        }

        else if (ResultsIdentifyInt == 3) {
            // Mute All
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

            // Play Note
            PianoNoteC4.volume = 3.0f;
            PianoNoteC4.Play();
        }

        else if (ResultsIdentifyInt == 4) {
            // Mute All
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

            // Play Note
            PianoNoteD4.volume = 3.0f;
            PianoNoteD4.Play();
        }

        else if (ResultsIdentifyInt == 5) {
            // Mute All
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

            // Play Note
            PianoNoteE4.volume = 3.0f;
            PianoNoteE4.Play();
        }

        else if (ResultsIdentifyInt == 6) {
            // Mute All
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

            // Play Note
            PianoNoteF4.volume = 3.0f;
            PianoNoteF4.Play();
        }

        else if (ResultsIdentifyInt == 7) {
            // Mute All
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

            // Play Note
            PianoNoteG4.volume = 3.0f;
            PianoNoteG4.Play();
        }

        else if (ResultsIdentifyInt == 8) {
            // Mute All
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

            // Play Note
            PianoNoteA5.volume = 3.0f;
            PianoNoteA5.Play();
        }

        else if (ResultsIdentifyInt == 9) {
            // Mute All
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

            // Play Note
            PianoNoteB5.volume = 3.0f;
            PianoNoteB5.Play();
        }

        else if (ResultsIdentifyInt == 10) {
            // Mute All
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

            // Play Note
            PianoNoteC5.volume = 3.0f;
            PianoNoteC5.Play();
        }

        else if (ResultsIdentifyInt == 11) {
            // Mute All
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

            // Play Note
            PianoNoteD5.volume = 3.0f;
            PianoNoteD5.Play();
        }

        else if (ResultsIdentifyInt == 12) {
            // Mute All
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

            // Play Note
            PianoNoteE5.volume = 3.0f;
            PianoNoteE5.Play();
        }

        else if (ResultsIdentifyInt == 13) {
            // Mute All
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

            // Play Note
            PianoNoteF5.volume = 3.0f;
            PianoNoteF5.Play();
        }

        else if (ResultsIdentifyInt == 14) {
            // Mute All
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

            // Play Note
            PianoNoteG5.volume = 3.0f;
            PianoNoteG5.Play();
        }
    }

    public void CheckCorrectResult() {
        if (CheckCorrectInt == 1) {
            if (ResultsIdentifyInt == 1) {
                ResultsText.text = "Perfect!" + "\n" + "The lower A was the correct note.";
                StartCoroutine(PlayByEarNotes());
            }

            else if ((ResultsIdentifyInt == (1 + 1)) || (ResultsIdentifyInt == (1 - 1))) {
                ResultsText.text = "Almost there";
            }

            else if ((ResultsIdentifyInt == (1 + 2)) || (ResultsIdentifyInt == (1 - 2))) {
                ResultsText.text = "Not quite, keep trying";
            }

            else if ((ResultsIdentifyInt == (1 + 7)) || (ResultsIdentifyInt == (1 - 7))) {
                ResultsText.text = "Check your Octave coral";
            }

            else {
                CheckCorrectInt = 0;
            }
        }

        else if (CheckCorrectInt == 2) {
            if (ResultsIdentifyInt == 2) {
                ResultsText.text = "Perfect!" + "\n" + "The lower B was the correct note.";
                StartCoroutine(PlayByEarNotes());
            }

            else if ((ResultsIdentifyInt == (2 + 1)) || (ResultsIdentifyInt == (2 - 1))) {
                ResultsText.text = "Almost there";
            }

            else if ((ResultsIdentifyInt == (2 + 2)) || (ResultsIdentifyInt == (2 - 2))) {
                ResultsText.text = "Not quite, keep trying";
            }

            else if ((ResultsIdentifyInt == (2 + 7)) || (ResultsIdentifyInt == (2 - 7))) {
                ResultsText.text = "Check your Octave coral";
            }

            else {
                CheckCorrectInt = 0;
            }
        }

        else if (CheckCorrectInt == 3) {
            if (ResultsIdentifyInt == 3) {
                ResultsText.text = "Perfect!" + "\n" + "The lower C was the correct note.";
                StartCoroutine(PlayByEarNotes());
            }

            else if ((ResultsIdentifyInt == (3 + 1)) || (ResultsIdentifyInt == (3 - 1))) {
                ResultsText.text = "Almost there";
            }

            else if ((ResultsIdentifyInt == (3 + 2)) || (ResultsIdentifyInt == (3 - 2))) {
                ResultsText.text = "Not quite, keep trying";
            }

            else if ((ResultsIdentifyInt == (3 + 7)) || (ResultsIdentifyInt == (3 - 7))) {
                ResultsText.text = "Check your Octave coral";
            }

            else {
                CheckCorrectInt = 0;
            }
        }

        else if (CheckCorrectInt == 4) {
            if (ResultsIdentifyInt == 4) {
                ResultsText.text = "Perfect!" + "\n" + "The lower D was the correct note.";
                StartCoroutine(PlayByEarNotes());
            }

            else if ((ResultsIdentifyInt == (4 + 1)) || (ResultsIdentifyInt == (4 - 1))) {
                ResultsText.text = "Almost there";
            }

            else if ((ResultsIdentifyInt == (4 + 2)) || (ResultsIdentifyInt == (4 - 2))) {
                ResultsText.text = "Not quite, keep trying";
            }

            else if ((ResultsIdentifyInt == (4 + 7)) || (ResultsIdentifyInt == (4 - 7))) {
                ResultsText.text = "Check your Octave coral";
            }

            else {
                CheckCorrectInt = 0;
            }
        }

        else if (CheckCorrectInt == 5) {
            if (ResultsIdentifyInt == 5) {
                ResultsText.text = "Perfect!" + "\n" + "The lower E was the correct note.";
                StartCoroutine(PlayByEarNotes());
            }

            else if ((ResultsIdentifyInt == (5 + 1)) || (ResultsIdentifyInt == (5 - 1))) {
                ResultsText.text = "Almost there";
            }

            else if ((ResultsIdentifyInt == (5 + 2)) || (ResultsIdentifyInt == (5 - 2))) {
                ResultsText.text = "Not quite, keep trying";
            }

            else if ((ResultsIdentifyInt == (5 + 7)) || (ResultsIdentifyInt == (5 - 7))) {
                ResultsText.text = "Check your Octave coral";
            }

            else {
                CheckCorrectInt = 0;
            }
        }

        else if (CheckCorrectInt == 6) {
            if (ResultsIdentifyInt == 6) {
                ResultsText.text = "Perfect!" + "\n" + "The lower F was the correct note.";
                StartCoroutine(PlayByEarNotes());
            }

            else if ((ResultsIdentifyInt == (6 + 1)) || (ResultsIdentifyInt == (6 - 1))) {
                ResultsText.text = "Almost there";
            }

            else if ((ResultsIdentifyInt == (6 + 2)) || (ResultsIdentifyInt == (6 - 2))) {
                ResultsText.text = "Not quite, keep trying";
            }

            else if ((ResultsIdentifyInt == (6 + 7)) || (ResultsIdentifyInt == (6 - 7))) {
                ResultsText.text = "Check your Octave coral";
            }

            else {
                CheckCorrectInt = 0;
            }
        }

        else if (CheckCorrectInt == 7) {
            if (ResultsIdentifyInt == 7) {
                ResultsText.text = "Perfect!" + "\n" + "The lower G was the correct note.";
                StartCoroutine(PlayByEarNotes());
            }

            else if ((ResultsIdentifyInt == (7 + 1)) || (ResultsIdentifyInt == (7 - 1))) {
                ResultsText.text = "Almost there";
            }

            else if ((ResultsIdentifyInt == (7 + 2)) || (ResultsIdentifyInt == (7 - 2))) {
                ResultsText.text = "Not quite, keep trying";
            }

            else if ((ResultsIdentifyInt == (7 + 7)) || (ResultsIdentifyInt == (7 - 7))) {
                ResultsText.text = "Check your Octave coral";
            }

            else {
                CheckCorrectInt = 0;
            }
        }

        else if (CheckCorrectInt == 8) {
            if (ResultsIdentifyInt == 8) {
                ResultsText.text = "Perfect!" + "\n" + "The higher A was the correct note.";
                StartCoroutine(PlayByEarNotes());
            }

            else if ((ResultsIdentifyInt == (8 + 1)) || (ResultsIdentifyInt == (8 - 1))) {
                ResultsText.text = "Almost there";
            }

            else if ((ResultsIdentifyInt == (8 + 2)) || (ResultsIdentifyInt == (8 - 2))) {
                ResultsText.text = "Not quite, keep trying";
            }

            else if ((ResultsIdentifyInt == (8 + 7)) || (ResultsIdentifyInt == (8 - 7))) {
                ResultsText.text = "Check your Octave coral";
            }

            else {
                CheckCorrectInt = 0;
            }
        }

        else if (CheckCorrectInt == 9) {
            if (ResultsIdentifyInt == 9) {
                ResultsText.text = "Perfect!" + "\n" + "The higher B was the correct note.";
                StartCoroutine(PlayByEarNotes());
            }

            else if ((ResultsIdentifyInt == (9 + 1)) || (ResultsIdentifyInt == (9 - 1))) {
                ResultsText.text = "Almost there";
            }

            else if ((ResultsIdentifyInt == (9 + 2)) || (ResultsIdentifyInt == (9 - 2))) {
                ResultsText.text = "Not quite, keep trying";
            }

            else if ((ResultsIdentifyInt == (9 + 7)) || (ResultsIdentifyInt == (9 - 7))) {
                ResultsText.text = "Check your Octave coral";
            }

            else {
                CheckCorrectInt = 0;
            }
        }

        else if (CheckCorrectInt == 10) {
            if (ResultsIdentifyInt == 10) {
                ResultsText.text = "Perfect!" + "\n" + "The higher C was the correct note.";
                StartCoroutine(PlayByEarNotes());
            }

            else if ((ResultsIdentifyInt == (10 + 1)) || (ResultsIdentifyInt == (10 - 1))) {
                ResultsText.text = "Almost there";
            }

            else if ((ResultsIdentifyInt == (10 + 2)) || (ResultsIdentifyInt == (10 - 2))) {
                ResultsText.text = "Not quite, keep trying";
            }

            else if ((ResultsIdentifyInt == (10 + 7)) || (ResultsIdentifyInt == (10 - 7))) {
                ResultsText.text = "Check your Octave coral";
            }

            else {
                CheckCorrectInt = 0;
            }
        }

        else if (CheckCorrectInt == 11) {
            if (ResultsIdentifyInt == 11) {
                ResultsText.text = "Perfect!" + "\n" + "The higher D was the correct note.";
                StartCoroutine(PlayByEarNotes());
            }

            else if ((ResultsIdentifyInt == (11 + 1)) || (ResultsIdentifyInt == (11 - 1))) {
                ResultsText.text = "Almost there";
            }

            else if ((ResultsIdentifyInt == (11 + 2)) || (ResultsIdentifyInt == (11 - 2))) {
                ResultsText.text = "Not quite, keep trying";
            }

            else if ((ResultsIdentifyInt == (11 + 7)) || (ResultsIdentifyInt == (11 - 7))) {
                ResultsText.text = "Check your Octave coral";
            }

            else {
                CheckCorrectInt = 0;
            }
        }

        else if (CheckCorrectInt == 12) {
            if (ResultsIdentifyInt == 12) {
                ResultsText.text = "Perfect!" + "\n" + "The higher E was the correct note.";
                StartCoroutine(PlayByEarNotes());
            }

            else if ((ResultsIdentifyInt == (12 + 1)) || (ResultsIdentifyInt == (12 - 1))) {
                ResultsText.text = "Almost there";
            }

            else if ((ResultsIdentifyInt == (12 + 2)) || (ResultsIdentifyInt == (12 - 2))) {
                ResultsText.text = "Not quite, keep trying";
            }

            else if ((ResultsIdentifyInt == (12 + 7)) || (ResultsIdentifyInt == (12 - 7))) {
                ResultsText.text = "Check your Octave coral";
            }

            else {
                CheckCorrectInt = 0;
            }
        }

        else if (CheckCorrectInt == 13) {
            if (ResultsIdentifyInt == 13) {
                ResultsText.text = "Perfect!" + "\n" + "The higher F was the correct note.";
                StartCoroutine(PlayByEarNotes());
            }

            else if ((ResultsIdentifyInt == (13 + 1)) || (ResultsIdentifyInt == (13 - 1))) {
                ResultsText.text = "Almost there";
            }

            else if ((ResultsIdentifyInt == (13 + 2)) || (ResultsIdentifyInt == (13 - 2))) {
                ResultsText.text = "Not quite, keep trying";
            }

            else if ((ResultsIdentifyInt == (13 + 7)) || (ResultsIdentifyInt == (13 - 7))) {
                ResultsText.text = "Check your Octave coral";
            }

            else {
                CheckCorrectInt = 0;
            }
        }

        else if (CheckCorrectInt == 14) {
            if (ResultsIdentifyInt == 14) {
                ResultsText.text = "Perfect!" + "\n" + "The higher G was the correct note.";
                StartCoroutine(PlayByEarNotes());
            }

            else if ((ResultsIdentifyInt == (14 + 1)) || (ResultsIdentifyInt == (14 - 1))) {
                ResultsText.text = "Almost there";
            }

            else if ((ResultsIdentifyInt == (14 + 2)) || (ResultsIdentifyInt == (14 - 2))) {
                ResultsText.text = "Not quite, keep trying";
            }

            else if ((ResultsIdentifyInt == (14 + 7)) || (ResultsIdentifyInt == (14 - 7))) {
                ResultsText.text = "Check your Octave coral";
            }

            else {
                CheckCorrectInt = 0;
            }
        }
    }

// ------------------------------ END: OTHER FUNCTIONS ------------------------------

}