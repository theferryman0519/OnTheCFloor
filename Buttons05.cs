using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

public class Buttons05 : MonoBehaviour {

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
    public Button SongButton01;
    public Button SongButton02;
    public Button SongButton03;
    public Button SongButton04;
    public Button SongButton05;
    public Button SongButton06;
    public Button SongButton07;
    public Button SongButton08;
    public Button SongButton09;
    public Button SongButton10;
    public Button SongButton11;
    public Button SongButton12;
    public Button SongButton13;

    // Settings Panel
    public Button SettingsOnButton;
    public Button SettingsOffButton;
    public Button SettingsBackButton;

    // After Song Buttons
    public Button ReplayButton;
    public Button ReselectButton;

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

    // Fish Prefabs
    public GameObject FishLowerA;
    public GameObject FishLowerB;
    public GameObject FishLowerC;
    public GameObject FishLowerD;
    public GameObject FishLowerE;
    public GameObject FishLowerF;
    public GameObject FishLowerG;
    public GameObject FishUpperA;
    public GameObject FishUpperB;
    public GameObject FishUpperC;
    public GameObject FishUpperD;
    public GameObject FishUpperE;
    public GameObject FishUpperF;
    public GameObject FishUpperG;

    // Fish Note Bools
    bool FishNote01Moving;
    bool FishNote02Moving;
    bool FishNote03Moving;
    bool FishNote04Moving;
    bool FishNote05Moving;
    bool FishNote06Moving;
    bool FishNote07Moving;
    bool FishNote08Moving;
    bool FishNote09Moving;
    bool FishNote10Moving;
    bool FishNote11Moving;
    bool FishNote12Moving;
    bool FishNote13Moving;
    bool FishNote14Moving;
    bool FishNote15Moving;
    bool FishNote16Moving;
    bool FishNote17Moving;
    bool FishNote18Moving;
    bool FishNote19Moving;
    bool FishNote20Moving;
    bool FishNote21Moving;
    bool FishNote22Moving;
    bool FishNote23Moving;
    bool FishNote24Moving;
    bool FishNote25Moving;
    bool FishNote26Moving;
    bool FishNote27Moving;
    bool FishNote28Moving;
    bool FishNote29Moving;
    bool FishNote30Moving;
    bool FishNote31Moving;
    bool FishNote32Moving;
    bool FishNote33Moving;
    bool FishNote34Moving;
    bool FishNote35Moving;
    bool FishNote36Moving;
    bool FishNote37Moving;
    bool FishNote38Moving;
    bool FishNote39Moving;
    bool FishNote40Moving;
    bool FishNote41Moving;
    bool FishNote42Moving;

    // Fish Note Objects
    GameObject FishNote01;
    GameObject FishNote02;
    GameObject FishNote03;
    GameObject FishNote04;
    GameObject FishNote05;
    GameObject FishNote06;
    GameObject FishNote07;
    GameObject FishNote08;
    GameObject FishNote09;
    GameObject FishNote10;
    GameObject FishNote11;
    GameObject FishNote12;
    GameObject FishNote13;
    GameObject FishNote14;
    GameObject FishNote15;
    GameObject FishNote16;
    GameObject FishNote17;
    GameObject FishNote18;
    GameObject FishNote19;
    GameObject FishNote20;
    GameObject FishNote21;
    GameObject FishNote22;
    GameObject FishNote23;
    GameObject FishNote24;
    GameObject FishNote25;
    GameObject FishNote26;
    GameObject FishNote27;
    GameObject FishNote28;
    GameObject FishNote29;
    GameObject FishNote30;
    GameObject FishNote31;
    GameObject FishNote32;
    GameObject FishNote33;
    GameObject FishNote34;
    GameObject FishNote35;
    GameObject FishNote36;
    GameObject FishNote37;
    GameObject FishNote38;
    GameObject FishNote39;
    GameObject FishNote40;
    GameObject FishNote41;
    GameObject FishNote42;

    // Fish Note Info
    float FishNoteSpeed = 3.0f;
    float FishEndTime = 9.0f;
    float FishNoteStart = 800.0f;
    float BetweenFishNotes = 0.6f;

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

        // SettingsOnButton
        Button SettingsOnButtonClick = SettingsOnButton.GetComponent<Button>();
        SettingsOnButtonClick.onClick.AddListener(SettingsOnButtonClicking);

        // SettingsOffButton
        Button SettingsOffButtonClick = SettingsOffButton.GetComponent<Button>();
        SettingsOffButtonClick.onClick.AddListener(SettingsOffButtonClicking);

        // SettingsBackButton
        Button SettingsBackButtonClick = SettingsBackButton.GetComponent<Button>();
        SettingsBackButtonClick.onClick.AddListener(SettingsBackButtonClicking);

        // SongButton01
        Button SongButton01Click = SongButton01.GetComponent<Button>();
        SongButton01Click.onClick.AddListener(SongButton01Clicking);

        // SongButton02
        Button SongButton02Click = SongButton02.GetComponent<Button>();
        SongButton02Click.onClick.AddListener(SongButton02Clicking);

        // SongButton03
        Button SongButton03Click = SongButton03.GetComponent<Button>();
        SongButton03Click.onClick.AddListener(SongButton03Clicking);

        // SongButton04
        Button SongButton04Click = SongButton04.GetComponent<Button>();
        SongButton04Click.onClick.AddListener(SongButton04Clicking);

        // SongButton05
        Button SongButton05Click = SongButton05.GetComponent<Button>();
        SongButton05Click.onClick.AddListener(SongButton05Clicking);

        // SongButton06
        Button SongButton06Click = SongButton06.GetComponent<Button>();
        SongButton06Click.onClick.AddListener(SongButton06Clicking);

        // SongButton07
        Button SongButton07Click = SongButton07.GetComponent<Button>();
        SongButton07Click.onClick.AddListener(SongButton07Clicking);

        // SongButton08
        Button SongButton08Click = SongButton08.GetComponent<Button>();
        SongButton08Click.onClick.AddListener(SongButton08Clicking);

        // SongButton09
        Button SongButton09Click = SongButton09.GetComponent<Button>();
        SongButton09Click.onClick.AddListener(SongButton09Clicking);

        // SongButton10
        Button SongButton10Click = SongButton10.GetComponent<Button>();
        SongButton10Click.onClick.AddListener(SongButton10Clicking);

        // SongButton11
        Button SongButton11Click = SongButton11.GetComponent<Button>();
        SongButton11Click.onClick.AddListener(SongButton11Clicking);

        // SongButton12
        Button SongButton12Click = SongButton12.GetComponent<Button>();
        SongButton12Click.onClick.AddListener(SongButton12Clicking);

        // SongButton13
        Button SongButton13Click = SongButton13.GetComponent<Button>();
        SongButton13Click.onClick.AddListener(SongButton13Clicking);

        // ReplayButton
        Button ReplayButtonClick = ReplayButton.GetComponent<Button>();
        ReplayButtonClick.onClick.AddListener(ReplayButtonClicking);

        // ReselectButton
        Button ReselectButtonClick = ReselectButton.GetComponent<Button>();
        ReselectButtonClick.onClick.AddListener(ReselectButtonClicking);

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
        // FishNote01
        if (FishNote01 != null) {
            if (FishNote01Moving == true) {
                FishNote01.transform.Translate(Vector3.left * FishNoteSpeed * Time.deltaTime);
                Destroy(FishNote01, FishEndTime);
            }
        }

        else if (FishNote01 == null) {
            FishNote01Moving = false;
        }

        // FishNote02
        if (FishNote02 != null) {
            if (FishNote02Moving == true) {
                FishNote02.transform.Translate(Vector3.left * FishNoteSpeed * Time.deltaTime);
                Destroy(FishNote02, FishEndTime);
            }
        }

        else if (FishNote02 == null) {
            FishNote02Moving = false;
        }

        // FishNote03
        if (FishNote03 != null) {
            if (FishNote03Moving == true) {
                FishNote03.transform.Translate(Vector3.left * FishNoteSpeed * Time.deltaTime);
                Destroy(FishNote03, FishEndTime);
            }
        }

        else if (FishNote03 == null) {
            FishNote03Moving = false;
        }

        // FishNote04
        if (FishNote04 != null) {
            if (FishNote04Moving == true) {
                FishNote04.transform.Translate(Vector3.left * FishNoteSpeed * Time.deltaTime);
                Destroy(FishNote04, FishEndTime);
            }
        }

        else if (FishNote04 == null) {
            FishNote04Moving = false;
        }

        // FishNote05
        if (FishNote05 != null) {
            if (FishNote05Moving == true) {
                FishNote05.transform.Translate(Vector3.left * FishNoteSpeed * Time.deltaTime);
                Destroy(FishNote05, FishEndTime);
            }
        }

        else if (FishNote05 == null) {
            FishNote05Moving = false;
        }

        // FishNote06
        if (FishNote06 != null) {
            if (FishNote06Moving == true) {
                FishNote06.transform.Translate(Vector3.left * FishNoteSpeed * Time.deltaTime);
                Destroy(FishNote06, FishEndTime);
            }
        }

        else if (FishNote06 == null) {
            FishNote06Moving = false;
        }

        // FishNote07
        if (FishNote07 != null) {
            if (FishNote07Moving == true) {
                FishNote07.transform.Translate(Vector3.left * FishNoteSpeed * Time.deltaTime);
                Destroy(FishNote07, FishEndTime);
            }
        }

        else if (FishNote07 == null) {
            FishNote07Moving = false;
        }

        // FishNote08
        if (FishNote08 != null) {
            if (FishNote08Moving == true) {
                FishNote08.transform.Translate(Vector3.left * FishNoteSpeed * Time.deltaTime);
                Destroy(FishNote08, FishEndTime);
            }
        }

        else if (FishNote08 == null) {
            FishNote08Moving = false;
        }

        // FishNote09
        if (FishNote09 != null) {
            if (FishNote09Moving == true) {
                FishNote09.transform.Translate(Vector3.left * FishNoteSpeed * Time.deltaTime);
                Destroy(FishNote09, FishEndTime);
            }
        }

        else if (FishNote09 == null) {
            FishNote09Moving = false;
        }

        // FishNote10
        if (FishNote10 != null) {
            if (FishNote10Moving == true) {
                FishNote10.transform.Translate(Vector3.left * FishNoteSpeed * Time.deltaTime);
                Destroy(FishNote10, FishEndTime);
            }
        }

        else if (FishNote10 == null) {
            FishNote10Moving = false;
        }

        // FishNote11
        if (FishNote11 != null) {
            if (FishNote11Moving == true) {
                FishNote11.transform.Translate(Vector3.left * FishNoteSpeed * Time.deltaTime);
                Destroy(FishNote11, FishEndTime);
            }
        }

        else if (FishNote11 == null) {
            FishNote11Moving = false;
        }

        // FishNote12
        if (FishNote12 != null) {
            if (FishNote12Moving == true) {
                FishNote12.transform.Translate(Vector3.left * FishNoteSpeed * Time.deltaTime);
                Destroy(FishNote12, FishEndTime);
            }
        }

        else if (FishNote12 == null) {
            FishNote12Moving = false;
        }

        // FishNote13
        if (FishNote13 != null) {
            if (FishNote13Moving == true) {
                FishNote13.transform.Translate(Vector3.left * FishNoteSpeed * Time.deltaTime);
                Destroy(FishNote13, FishEndTime);
            }
        }

        else if (FishNote13 == null) {
            FishNote13Moving = false;
        }

        // FishNote14
        if (FishNote14 != null) {
            if (FishNote14Moving == true) {
                FishNote14.transform.Translate(Vector3.left * FishNoteSpeed * Time.deltaTime);
                Destroy(FishNote14, FishEndTime);
            }
        }

        else if (FishNote14 == null) {
            FishNote14Moving = false;
        }

        // FishNote15
        if (FishNote15 != null) {
            if (FishNote15Moving == true) {
                FishNote15.transform.Translate(Vector3.left * FishNoteSpeed * Time.deltaTime);
                Destroy(FishNote15, FishEndTime);
            }
        }

        else if (FishNote15 == null) {
            FishNote15Moving = false;
        }

        // FishNote16
        if (FishNote16 != null) {
            if (FishNote16Moving == true) {
                FishNote16.transform.Translate(Vector3.left * FishNoteSpeed * Time.deltaTime);
                Destroy(FishNote16, FishEndTime);
            }
        }

        else if (FishNote16 == null) {
            FishNote16Moving = false;
        }

        // FishNote17
        if (FishNote17 != null) {
            if (FishNote17Moving == true) {
                FishNote17.transform.Translate(Vector3.left * FishNoteSpeed * Time.deltaTime);
                Destroy(FishNote17, FishEndTime);
            }
        }

        else if (FishNote17 == null) {
            FishNote17Moving = false;
        }

        // FishNote18
        if (FishNote18 != null) {
            if (FishNote18Moving == true) {
                FishNote18.transform.Translate(Vector3.left * FishNoteSpeed * Time.deltaTime);
                Destroy(FishNote18, FishEndTime);
            }
        }

        else if (FishNote18 == null) {
            FishNote18Moving = false;
        }

        // FishNote19
        if (FishNote19 != null) {
            if (FishNote19Moving == true) {
                FishNote19.transform.Translate(Vector3.left * FishNoteSpeed * Time.deltaTime);
                Destroy(FishNote19, FishEndTime);
            }
        }

        else if (FishNote19 == null) {
            FishNote19Moving = false;
        }

        // FishNote20
        if (FishNote20 != null) {
            if (FishNote20Moving == true) {
                FishNote20.transform.Translate(Vector3.left * FishNoteSpeed * Time.deltaTime);
                Destroy(FishNote20, FishEndTime);
            }
        }

        else if (FishNote20 == null) {
            FishNote20Moving = false;
        }

        // FishNote21
        if (FishNote21 != null) {
            if (FishNote21Moving == true) {
                FishNote21.transform.Translate(Vector3.left * FishNoteSpeed * Time.deltaTime);
                Destroy(FishNote21, FishEndTime);
            }
        }

        else if (FishNote21 == null) {
            FishNote21Moving = false;
        }

        // FishNote22
        if (FishNote22 != null) {
            if (FishNote22Moving == true) {
                FishNote22.transform.Translate(Vector3.left * FishNoteSpeed * Time.deltaTime);
                Destroy(FishNote22, FishEndTime);
            }
        }

        else if (FishNote22 == null) {
            FishNote22Moving = false;
        }

        // FishNote23
        if (FishNote23 != null) {
            if (FishNote23Moving == true) {
                FishNote23.transform.Translate(Vector3.left * FishNoteSpeed * Time.deltaTime);
                Destroy(FishNote23, FishEndTime);
            }
        }

        else if (FishNote23 == null) {
            FishNote23Moving = false;
        }

        // FishNote24
        if (FishNote24 != null) {
            if (FishNote24Moving == true) {
                FishNote24.transform.Translate(Vector3.left * FishNoteSpeed * Time.deltaTime);
                Destroy(FishNote24, FishEndTime);
            }
        }

        else if (FishNote24 == null) {
            FishNote24Moving = false;
        }

        // FishNote25
        if (FishNote25 != null) {
            if (FishNote25Moving == true) {
                FishNote25.transform.Translate(Vector3.left * FishNoteSpeed * Time.deltaTime);
                Destroy(FishNote25, FishEndTime);
            }
        }

        else if (FishNote25 == null) {
            FishNote25Moving = false;
        }

        // FishNote26
        if (FishNote26 != null) {
            if (FishNote26Moving == true) {
                FishNote26.transform.Translate(Vector3.left * FishNoteSpeed * Time.deltaTime);
                Destroy(FishNote26, FishEndTime);
            }
        }

        else if (FishNote26 == null) {
            FishNote26Moving = false;
        }

        // FishNote27
        if (FishNote27 != null) {
            if (FishNote27Moving == true) {
                FishNote27.transform.Translate(Vector3.left * FishNoteSpeed * Time.deltaTime);
                Destroy(FishNote27, FishEndTime);
            }
        }

        else if (FishNote27 == null) {
            FishNote27Moving = false;
        }

        // FishNote28
        if (FishNote28 != null) {
            if (FishNote28Moving == true) {
                FishNote28.transform.Translate(Vector3.left * FishNoteSpeed * Time.deltaTime);
                Destroy(FishNote28, FishEndTime);
            }
        }

        else if (FishNote28 == null) {
            FishNote28Moving = false;
        }

        // FishNote29
        if (FishNote29 != null) {
            if (FishNote29Moving == true) {
                FishNote29.transform.Translate(Vector3.left * FishNoteSpeed * Time.deltaTime);
                Destroy(FishNote29, FishEndTime);
            }
        }

        else if (FishNote29 == null) {
            FishNote29Moving = false;
        }

        // FishNote30
        if (FishNote30 != null) {
            if (FishNote30Moving == true) {
                FishNote30.transform.Translate(Vector3.left * FishNoteSpeed * Time.deltaTime);
                Destroy(FishNote30, FishEndTime);
            }
        }

        else if (FishNote30 == null) {
            FishNote30Moving = false;
        }

        // FishNote31
        if (FishNote31 != null) {
            if (FishNote31Moving == true) {
                FishNote31.transform.Translate(Vector3.left * FishNoteSpeed * Time.deltaTime);
                Destroy(FishNote31, FishEndTime);
            }
        }

        else if (FishNote31 == null) {
            FishNote31Moving = false;
        }

        // FishNote32
        if (FishNote32 != null) {
            if (FishNote32Moving == true) {
                FishNote32.transform.Translate(Vector3.left * FishNoteSpeed * Time.deltaTime);
                Destroy(FishNote32, FishEndTime);
            }
        }

        else if (FishNote32 == null) {
            FishNote32Moving = false;
        }

        // FishNote33
        if (FishNote33 != null) {
            if (FishNote33Moving == true) {
                FishNote33.transform.Translate(Vector3.left * FishNoteSpeed * Time.deltaTime);
                Destroy(FishNote33, FishEndTime);
            }
        }

        else if (FishNote33 == null) {
            FishNote33Moving = false;
        }

        // FishNote34
        if (FishNote34 != null) {
            if (FishNote34Moving == true) {
                FishNote34.transform.Translate(Vector3.left * FishNoteSpeed * Time.deltaTime);
                Destroy(FishNote34, FishEndTime);
            }
        }

        else if (FishNote34 == null) {
            FishNote34Moving = false;
        }

        // FishNote35
        if (FishNote35 != null) {
            if (FishNote35Moving == true) {
                FishNote35.transform.Translate(Vector3.left * FishNoteSpeed * Time.deltaTime);
                Destroy(FishNote35, FishEndTime);
            }
        }

        else if (FishNote35 == null) {
            FishNote35Moving = false;
        }

        // FishNote36
        if (FishNote36 != null) {
            if (FishNote36Moving == true) {
                FishNote36.transform.Translate(Vector3.left * FishNoteSpeed * Time.deltaTime);
                Destroy(FishNote36, FishEndTime);
            }
        }

        else if (FishNote36 == null) {
            FishNote36Moving = false;
        }

        // FishNote37
        if (FishNote37 != null) {
            if (FishNote37Moving == true) {
                FishNote37.transform.Translate(Vector3.left * FishNoteSpeed * Time.deltaTime);
                Destroy(FishNote37, FishEndTime);
            }
        }

        else if (FishNote37 == null) {
            FishNote37Moving = false;
        }

        // FishNote38
        if (FishNote38 != null) {
            if (FishNote38Moving == true) {
                FishNote38.transform.Translate(Vector3.left * FishNoteSpeed * Time.deltaTime);
                Destroy(FishNote38, FishEndTime);
            }
        }

        else if (FishNote38 == null) {
            FishNote38Moving = false;
        }

        // FishNote39
        if (FishNote39 != null) {
            if (FishNote39Moving == true) {
                FishNote39.transform.Translate(Vector3.left * FishNoteSpeed * Time.deltaTime);
                Destroy(FishNote39, FishEndTime);
            }
        }

        else if (FishNote39 == null) {
            FishNote39Moving = false;
        }

        // FishNote40
        if (FishNote40 != null) {
            if (FishNote40Moving == true) {
                FishNote40.transform.Translate(Vector3.left * FishNoteSpeed * Time.deltaTime);
                Destroy(FishNote40, FishEndTime);
            }
        }

        else if (FishNote40 == null) {
            FishNote40Moving = false;
        }

        // FishNote41
        if (FishNote41 != null) {
            if (FishNote41Moving == true) {
                FishNote41.transform.Translate(Vector3.left * FishNoteSpeed * Time.deltaTime);
                Destroy(FishNote41, FishEndTime);
            }
        }

        else if (FishNote41 == null) {
            FishNote41Moving = false;
        }

        // FishNote42
        if (FishNote42 != null) {
            if (FishNote42Moving == true) {
                FishNote42.transform.Translate(Vector3.left * FishNoteSpeed * Time.deltaTime);
                Destroy(FishNote42, FishEndTime);
            }
        }

        else if (FishNote42 == null) {
            FishNote42Moving = false;
        }
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
        EnableObjects05.CoralAOnOff = 0;
        EnableObjects05.CoralBOnOff = 0;
        EnableObjects05.CoralCOnOff = 0;
        EnableObjects05.CoralDOnOff = 0;
        EnableObjects05.CoralEOnOff = 0;
        EnableObjects05.CoralFOnOff = 0;
        EnableObjects05.CoralGOnOff = 0;
        EnableObjects05.CoralAOnOff = 1;

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

        if (EnableObjects05.CoralOctaveOnOff == 1) {
            PianoNoteA5.volume = 3.0f;
            PianoNoteA5.Play();
            BubblesA.Play();
        }

        else if (EnableObjects05.CoralOctaveOnOff == 0) {
            PianoNoteA4.volume = 3.0f;
            PianoNoteA4.Play();
            BubblesA.Play();
        }
    }

    public void BubbleNotesBOffClicking() {
        EnableObjects05.CoralAOnOff = 0;
        EnableObjects05.CoralBOnOff = 0;
        EnableObjects05.CoralCOnOff = 0;
        EnableObjects05.CoralDOnOff = 0;
        EnableObjects05.CoralEOnOff = 0;
        EnableObjects05.CoralFOnOff = 0;
        EnableObjects05.CoralGOnOff = 0;
        EnableObjects05.CoralBOnOff = 1;

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

        if (EnableObjects05.CoralOctaveOnOff == 1) {
            PianoNoteB5.volume = 3.0f;
            PianoNoteB5.Play();
            BubblesB.Play();
        }

        else if (EnableObjects05.CoralOctaveOnOff == 0) {
            PianoNoteB4.volume = 3.0f;
            PianoNoteB4.Play();
            BubblesB.Play();
        }
    }

    public void BubbleNotesCOffClicking() {
        EnableObjects05.CoralAOnOff = 0;
        EnableObjects05.CoralBOnOff = 0;
        EnableObjects05.CoralCOnOff = 0;
        EnableObjects05.CoralDOnOff = 0;
        EnableObjects05.CoralEOnOff = 0;
        EnableObjects05.CoralFOnOff = 0;
        EnableObjects05.CoralGOnOff = 0;
        EnableObjects05.CoralCOnOff = 1;

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

        if (EnableObjects05.CoralOctaveOnOff == 1) {
            PianoNoteC5.volume = 3.0f;
            PianoNoteC5.Play();
            BubblesC.Play();
        }

        else if (EnableObjects05.CoralOctaveOnOff == 0) {
            PianoNoteC4.volume = 3.0f;
            PianoNoteC4.Play();
            BubblesC.Play();
        }
    }

    public void BubbleNotesDOffClicking() {
        EnableObjects05.CoralAOnOff = 0;
        EnableObjects05.CoralBOnOff = 0;
        EnableObjects05.CoralCOnOff = 0;
        EnableObjects05.CoralDOnOff = 0;
        EnableObjects05.CoralEOnOff = 0;
        EnableObjects05.CoralFOnOff = 0;
        EnableObjects05.CoralGOnOff = 0;
        EnableObjects05.CoralDOnOff = 1;

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

        if (EnableObjects05.CoralOctaveOnOff == 1) {
            PianoNoteD5.volume = 3.0f;
            PianoNoteD5.Play();
            BubblesD.Play();
        }

        else if (EnableObjects05.CoralOctaveOnOff == 0) {
            PianoNoteD4.volume = 3.0f;
            PianoNoteD4.Play();
            BubblesD.Play();
        }
    }

    public void BubbleNotesEOffClicking() {
        EnableObjects05.CoralAOnOff = 0;
        EnableObjects05.CoralBOnOff = 0;
        EnableObjects05.CoralCOnOff = 0;
        EnableObjects05.CoralDOnOff = 0;
        EnableObjects05.CoralEOnOff = 0;
        EnableObjects05.CoralFOnOff = 0;
        EnableObjects05.CoralGOnOff = 0;
        EnableObjects05.CoralEOnOff = 1;

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

        if (EnableObjects05.CoralOctaveOnOff == 1) {
            PianoNoteE5.volume = 3.0f;
            PianoNoteE5.Play();
            BubblesE.Play();
        }

        else if (EnableObjects05.CoralOctaveOnOff == 0) {
            PianoNoteE4.volume = 3.0f;
            PianoNoteE4.Play();
            BubblesE.Play();
        }
    }

    public void BubbleNotesFOffClicking() {
        EnableObjects05.CoralAOnOff = 0;
        EnableObjects05.CoralBOnOff = 0;
        EnableObjects05.CoralCOnOff = 0;
        EnableObjects05.CoralDOnOff = 0;
        EnableObjects05.CoralEOnOff = 0;
        EnableObjects05.CoralFOnOff = 0;
        EnableObjects05.CoralGOnOff = 0;
        EnableObjects05.CoralFOnOff = 1;

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

        if (EnableObjects05.CoralOctaveOnOff == 1) {
            PianoNoteF5.volume = 3.0f;
            PianoNoteF5.Play();
            BubblesF.Play();
        }

        else if (EnableObjects05.CoralOctaveOnOff == 0) {
            PianoNoteF4.volume = 3.0f;
            PianoNoteF4.Play();
            BubblesF.Play();
        }
    }

    public void BubbleNotesGOffClicking() {
        EnableObjects05.CoralAOnOff = 0;
        EnableObjects05.CoralBOnOff = 0;
        EnableObjects05.CoralCOnOff = 0;
        EnableObjects05.CoralDOnOff = 0;
        EnableObjects05.CoralEOnOff = 0;
        EnableObjects05.CoralFOnOff = 0;
        EnableObjects05.CoralGOnOff = 0;
        EnableObjects05.CoralGOnOff = 1;

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

        if (EnableObjects05.CoralOctaveOnOff == 1) {
            PianoNoteG5.volume = 3.0f;
            PianoNoteG5.Play();
            BubblesG.Play();
        }

        else if (EnableObjects05.CoralOctaveOnOff == 0) {
            PianoNoteG4.volume = 3.0f;
            PianoNoteG4.Play();
            BubblesG.Play();
        }
    }

    public void BubbleNotesOctaveOffClicking() {
        EnableObjects05.CoralOctaveOnOff = 1;
        BubblesOctave.Play();
    }

    public void BubbleNotesAOnClicking() {
        EnableObjects05.CoralAOnOff = 0;
        EnableObjects05.CoralBOnOff = 0;
        EnableObjects05.CoralCOnOff = 0;
        EnableObjects05.CoralDOnOff = 0;
        EnableObjects05.CoralEOnOff = 0;
        EnableObjects05.CoralFOnOff = 0;
        EnableObjects05.CoralGOnOff = 0;
        EnableObjects05.CoralAOnOff = 1;

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

        if (EnableObjects05.CoralOctaveOnOff == 1) {
            PianoNoteA5.volume = 3.0f;
            PianoNoteA5.Play();
            BubblesA.Play();
        }

        else if (EnableObjects05.CoralOctaveOnOff == 0) {
            PianoNoteA4.volume = 3.0f;
            PianoNoteA4.Play();
            BubblesA.Play();
        }
    }

    public void BubbleNotesBOnClicking() {
        EnableObjects05.CoralAOnOff = 0;
        EnableObjects05.CoralBOnOff = 0;
        EnableObjects05.CoralCOnOff = 0;
        EnableObjects05.CoralDOnOff = 0;
        EnableObjects05.CoralEOnOff = 0;
        EnableObjects05.CoralFOnOff = 0;
        EnableObjects05.CoralGOnOff = 0;
        EnableObjects05.CoralBOnOff = 1;

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

        if (EnableObjects05.CoralOctaveOnOff == 1) {
            PianoNoteB5.volume = 3.0f;
            PianoNoteB5.Play();
            BubblesB.Play();
        }

        else if (EnableObjects05.CoralOctaveOnOff == 0) {
            PianoNoteB4.volume = 3.0f;
            PianoNoteB4.Play();
            BubblesB.Play();
        }
    }

    public void BubbleNotesCOnClicking() {
        EnableObjects05.CoralAOnOff = 0;
        EnableObjects05.CoralBOnOff = 0;
        EnableObjects05.CoralCOnOff = 0;
        EnableObjects05.CoralDOnOff = 0;
        EnableObjects05.CoralEOnOff = 0;
        EnableObjects05.CoralFOnOff = 0;
        EnableObjects05.CoralGOnOff = 0;
        EnableObjects05.CoralCOnOff = 1;

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

        if (EnableObjects05.CoralOctaveOnOff == 1) {
            PianoNoteC5.volume = 3.0f;
            PianoNoteC5.Play();
            BubblesC.Play();
        }

        else if (EnableObjects05.CoralOctaveOnOff == 0) {
            PianoNoteC4.volume = 3.0f;
            PianoNoteC4.Play();
            BubblesC.Play();
        }
    }

    public void BubbleNotesDOnClicking() {
        EnableObjects05.CoralAOnOff = 0;
        EnableObjects05.CoralBOnOff = 0;
        EnableObjects05.CoralCOnOff = 0;
        EnableObjects05.CoralDOnOff = 0;
        EnableObjects05.CoralEOnOff = 0;
        EnableObjects05.CoralFOnOff = 0;
        EnableObjects05.CoralGOnOff = 0;
        EnableObjects05.CoralDOnOff = 1;

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

        if (EnableObjects05.CoralOctaveOnOff == 1) {
            PianoNoteD5.volume = 3.0f;
            PianoNoteD5.Play();
            BubblesD.Play();
        }

        else if (EnableObjects05.CoralOctaveOnOff == 0) {
            PianoNoteD4.volume = 3.0f;
            PianoNoteD4.Play();
            BubblesD.Play();
        }
    }

    public void BubbleNotesEOnClicking() {
        EnableObjects05.CoralAOnOff = 0;
        EnableObjects05.CoralBOnOff = 0;
        EnableObjects05.CoralCOnOff = 0;
        EnableObjects05.CoralDOnOff = 0;
        EnableObjects05.CoralEOnOff = 0;
        EnableObjects05.CoralFOnOff = 0;
        EnableObjects05.CoralGOnOff = 0;
        EnableObjects05.CoralEOnOff = 1;

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

        if (EnableObjects05.CoralOctaveOnOff == 1) {
            PianoNoteE5.volume = 3.0f;
            PianoNoteE5.Play();
            BubblesE.Play();
        }

        else if (EnableObjects05.CoralOctaveOnOff == 0) {
            PianoNoteE4.volume = 3.0f;
            PianoNoteE4.Play();
            BubblesE.Play();
        }
    }

    public void BubbleNotesFOnClicking() {
        EnableObjects05.CoralAOnOff = 0;
        EnableObjects05.CoralBOnOff = 0;
        EnableObjects05.CoralCOnOff = 0;
        EnableObjects05.CoralDOnOff = 0;
        EnableObjects05.CoralEOnOff = 0;
        EnableObjects05.CoralFOnOff = 0;
        EnableObjects05.CoralGOnOff = 0;
        EnableObjects05.CoralFOnOff = 1;

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

        if (EnableObjects05.CoralOctaveOnOff == 1) {
            PianoNoteF5.volume = 3.0f;
            PianoNoteF5.Play();
            BubblesF.Play();
        }

        else if (EnableObjects05.CoralOctaveOnOff == 0) {
            PianoNoteF4.volume = 3.0f;
            PianoNoteF4.Play();
            BubblesF.Play();
        }
    }

    public void BubbleNotesGOnClicking() {
        EnableObjects05.CoralAOnOff = 0;
        EnableObjects05.CoralBOnOff = 0;
        EnableObjects05.CoralCOnOff = 0;
        EnableObjects05.CoralDOnOff = 0;
        EnableObjects05.CoralEOnOff = 0;
        EnableObjects05.CoralFOnOff = 0;
        EnableObjects05.CoralGOnOff = 0;
        EnableObjects05.CoralGOnOff = 1;

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

        if (EnableObjects05.CoralOctaveOnOff == 1) {
            PianoNoteG5.volume = 3.0f;
            PianoNoteG5.Play();
            BubblesG.Play();
        }

        else if (EnableObjects05.CoralOctaveOnOff == 0) {
            PianoNoteG4.volume = 3.0f;
            PianoNoteG4.Play();
            BubblesG.Play();
        }
    }

    public void BubbleNotesOctaveOnClicking() {
        EnableObjects05.CoralOctaveOnOff = 0;
    }

    public void CoralAOffClicking() {
        EnableObjects05.CoralAOnOff = 0;
        EnableObjects05.CoralBOnOff = 0;
        EnableObjects05.CoralCOnOff = 0;
        EnableObjects05.CoralDOnOff = 0;
        EnableObjects05.CoralEOnOff = 0;
        EnableObjects05.CoralFOnOff = 0;
        EnableObjects05.CoralGOnOff = 0;
        EnableObjects05.CoralAOnOff = 1;

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

        if (EnableObjects05.CoralOctaveOnOff == 1) {
            PianoNoteA5.volume = 3.0f;
            PianoNoteA5.Play();
            BubblesA.Play();
        }

        else if (EnableObjects05.CoralOctaveOnOff == 0) {
            PianoNoteA4.volume = 3.0f;
            PianoNoteA4.Play();
            BubblesA.Play();
        }
    }

    public void CoralBOffClicking() {
        EnableObjects05.CoralAOnOff = 0;
        EnableObjects05.CoralBOnOff = 0;
        EnableObjects05.CoralCOnOff = 0;
        EnableObjects05.CoralDOnOff = 0;
        EnableObjects05.CoralEOnOff = 0;
        EnableObjects05.CoralFOnOff = 0;
        EnableObjects05.CoralGOnOff = 0;
        EnableObjects05.CoralBOnOff = 1;

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

        if (EnableObjects05.CoralOctaveOnOff == 1) {
            PianoNoteB5.volume = 3.0f;
            PianoNoteB5.Play();
            BubblesB.Play();
        }

        else if (EnableObjects05.CoralOctaveOnOff == 0) {
            PianoNoteB4.volume = 3.0f;
            PianoNoteB4.Play();
            BubblesB.Play();
        }
    }

    public void CoralCOffClicking() {
        EnableObjects05.CoralAOnOff = 0;
        EnableObjects05.CoralBOnOff = 0;
        EnableObjects05.CoralCOnOff = 0;
        EnableObjects05.CoralDOnOff = 0;
        EnableObjects05.CoralEOnOff = 0;
        EnableObjects05.CoralFOnOff = 0;
        EnableObjects05.CoralGOnOff = 0;
        EnableObjects05.CoralCOnOff = 1;

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

        if (EnableObjects05.CoralOctaveOnOff == 1) {
            PianoNoteC5.volume = 3.0f;
            PianoNoteC5.Play();
            BubblesC.Play();
        }

        else if (EnableObjects05.CoralOctaveOnOff == 0) {
            PianoNoteC4.volume = 3.0f;
            PianoNoteC4.Play();
            BubblesC.Play();
        }
    }

    public void CoralDOffClicking() {
        EnableObjects05.CoralAOnOff = 0;
        EnableObjects05.CoralBOnOff = 0;
        EnableObjects05.CoralCOnOff = 0;
        EnableObjects05.CoralDOnOff = 0;
        EnableObjects05.CoralEOnOff = 0;
        EnableObjects05.CoralFOnOff = 0;
        EnableObjects05.CoralGOnOff = 0;
        EnableObjects05.CoralDOnOff = 1;

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

        if (EnableObjects05.CoralOctaveOnOff == 1) {
            PianoNoteD5.volume = 3.0f;
            PianoNoteD5.Play();
            BubblesD.Play();
        }

        else if (EnableObjects05.CoralOctaveOnOff == 0) {
            PianoNoteD4.volume = 3.0f;
            PianoNoteD4.Play();
            BubblesD.Play();
        }
    }

    public void CoralEOffClicking() {
        EnableObjects05.CoralAOnOff = 0;
        EnableObjects05.CoralBOnOff = 0;
        EnableObjects05.CoralCOnOff = 0;
        EnableObjects05.CoralDOnOff = 0;
        EnableObjects05.CoralEOnOff = 0;
        EnableObjects05.CoralFOnOff = 0;
        EnableObjects05.CoralGOnOff = 0;
        EnableObjects05.CoralEOnOff = 1;

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

        if (EnableObjects05.CoralOctaveOnOff == 1) {
            PianoNoteE5.volume = 3.0f;
            PianoNoteE5.Play();
            BubblesE.Play();
        }

        else if (EnableObjects05.CoralOctaveOnOff == 0) {
            PianoNoteE4.volume = 3.0f;
            PianoNoteE4.Play();
            BubblesE.Play();
        }
    }

    public void CoralFOffClicking() {
        EnableObjects05.CoralAOnOff = 0;
        EnableObjects05.CoralBOnOff = 0;
        EnableObjects05.CoralCOnOff = 0;
        EnableObjects05.CoralDOnOff = 0;
        EnableObjects05.CoralEOnOff = 0;
        EnableObjects05.CoralFOnOff = 0;
        EnableObjects05.CoralGOnOff = 0;
        EnableObjects05.CoralFOnOff = 1;

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

        if (EnableObjects05.CoralOctaveOnOff == 1) {
            PianoNoteF5.volume = 3.0f;
            PianoNoteF5.Play();
            BubblesF.Play();
        }

        else if (EnableObjects05.CoralOctaveOnOff == 0) {
            PianoNoteF4.volume = 3.0f;
            PianoNoteF4.Play();
            BubblesF.Play();
        }
    }

    public void CoralGOffClicking() {
        EnableObjects05.CoralAOnOff = 0;
        EnableObjects05.CoralBOnOff = 0;
        EnableObjects05.CoralCOnOff = 0;
        EnableObjects05.CoralDOnOff = 0;
        EnableObjects05.CoralEOnOff = 0;
        EnableObjects05.CoralFOnOff = 0;
        EnableObjects05.CoralGOnOff = 0;
        EnableObjects05.CoralGOnOff = 1;

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

        if (EnableObjects05.CoralOctaveOnOff == 1) {
            PianoNoteG5.volume = 3.0f;
            PianoNoteG5.Play();
            BubblesG.Play();
        }

        else if (EnableObjects05.CoralOctaveOnOff == 0) {
            PianoNoteG4.volume = 3.0f;
            PianoNoteG4.Play();
            BubblesG.Play();
        }
    }

    public void CoralOctaveOffClicking() {
        EnableObjects05.CoralOctaveOnOff = 1;
        BubblesOctave.Play();
    }

    public void CoralAOnClicking() {
        EnableObjects05.CoralAOnOff = 0;
        EnableObjects05.CoralBOnOff = 0;
        EnableObjects05.CoralCOnOff = 0;
        EnableObjects05.CoralDOnOff = 0;
        EnableObjects05.CoralEOnOff = 0;
        EnableObjects05.CoralFOnOff = 0;
        EnableObjects05.CoralGOnOff = 0;
        EnableObjects05.CoralAOnOff = 1;

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

        if (EnableObjects05.CoralOctaveOnOff == 1) {
            PianoNoteA5.volume = 3.0f;
            PianoNoteA5.Play();
            BubblesA.Play();
        }

        else if (EnableObjects05.CoralOctaveOnOff == 0) {
            PianoNoteA4.volume = 3.0f;
            PianoNoteA4.Play();
            BubblesA.Play();
        }
    }

    public void CoralBOnClicking() {
        EnableObjects05.CoralAOnOff = 0;
        EnableObjects05.CoralBOnOff = 0;
        EnableObjects05.CoralCOnOff = 0;
        EnableObjects05.CoralDOnOff = 0;
        EnableObjects05.CoralEOnOff = 0;
        EnableObjects05.CoralFOnOff = 0;
        EnableObjects05.CoralGOnOff = 0;
        EnableObjects05.CoralBOnOff = 1;

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

        if (EnableObjects05.CoralOctaveOnOff == 1) {
            PianoNoteB5.volume = 3.0f;
            PianoNoteB5.Play();
            BubblesB.Play();
        }

        else if (EnableObjects05.CoralOctaveOnOff == 0) {
            PianoNoteB4.volume = 3.0f;
            PianoNoteB4.Play();
            BubblesB.Play();
        }
    }

    public void CoralCOnClicking() {
        EnableObjects05.CoralAOnOff = 0;
        EnableObjects05.CoralBOnOff = 0;
        EnableObjects05.CoralCOnOff = 0;
        EnableObjects05.CoralDOnOff = 0;
        EnableObjects05.CoralEOnOff = 0;
        EnableObjects05.CoralFOnOff = 0;
        EnableObjects05.CoralGOnOff = 0;
        EnableObjects05.CoralCOnOff = 1;

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

        if (EnableObjects05.CoralOctaveOnOff == 1) {
            PianoNoteC5.volume = 3.0f;
            PianoNoteC5.Play();
            BubblesC.Play();
        }

        else if (EnableObjects05.CoralOctaveOnOff == 0) {
            PianoNoteC4.volume = 3.0f;
            PianoNoteC4.Play();
            BubblesC.Play();
        }
    }

    public void CoralDOnClicking() {
        EnableObjects05.CoralAOnOff = 0;
        EnableObjects05.CoralBOnOff = 0;
        EnableObjects05.CoralCOnOff = 0;
        EnableObjects05.CoralDOnOff = 0;
        EnableObjects05.CoralEOnOff = 0;
        EnableObjects05.CoralFOnOff = 0;
        EnableObjects05.CoralGOnOff = 0;
        EnableObjects05.CoralDOnOff = 1;

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

        if (EnableObjects05.CoralOctaveOnOff == 1) {
            PianoNoteD5.volume = 3.0f;
            PianoNoteD5.Play();
            BubblesD.Play();
        }

        else if (EnableObjects05.CoralOctaveOnOff == 0) {
            PianoNoteD4.volume = 3.0f;
            PianoNoteD4.Play();
            BubblesD.Play();
        }
    }

    public void CoralEOnClicking() {
        EnableObjects05.CoralAOnOff = 0;
        EnableObjects05.CoralBOnOff = 0;
        EnableObjects05.CoralCOnOff = 0;
        EnableObjects05.CoralDOnOff = 0;
        EnableObjects05.CoralEOnOff = 0;
        EnableObjects05.CoralFOnOff = 0;
        EnableObjects05.CoralGOnOff = 0;
        EnableObjects05.CoralEOnOff = 1;

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

        if (EnableObjects05.CoralOctaveOnOff == 1) {
            PianoNoteE5.volume = 3.0f;
            PianoNoteE5.Play();
            BubblesE.Play();
        }

        else if (EnableObjects05.CoralOctaveOnOff == 0) {
            PianoNoteE4.volume = 3.0f;
            PianoNoteE4.Play();
            BubblesE.Play();
        }
    }

    public void CoralFOnClicking() {
        EnableObjects05.CoralAOnOff = 0;
        EnableObjects05.CoralBOnOff = 0;
        EnableObjects05.CoralCOnOff = 0;
        EnableObjects05.CoralDOnOff = 0;
        EnableObjects05.CoralEOnOff = 0;
        EnableObjects05.CoralFOnOff = 0;
        EnableObjects05.CoralGOnOff = 0;
        EnableObjects05.CoralFOnOff = 1;

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

        if (EnableObjects05.CoralOctaveOnOff == 1) {
            PianoNoteF5.volume = 3.0f;
            PianoNoteF5.Play();
            BubblesF.Play();
        }

        else if (EnableObjects05.CoralOctaveOnOff == 0) {
            PianoNoteF4.volume = 3.0f;
            PianoNoteF4.Play();
            BubblesF.Play();
        }
    }

    public void CoralGOnClicking() {
        EnableObjects05.CoralAOnOff = 0;
        EnableObjects05.CoralBOnOff = 0;
        EnableObjects05.CoralCOnOff = 0;
        EnableObjects05.CoralDOnOff = 0;
        EnableObjects05.CoralEOnOff = 0;
        EnableObjects05.CoralFOnOff = 0;
        EnableObjects05.CoralGOnOff = 0;
        EnableObjects05.CoralGOnOff = 1;

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

        if (EnableObjects05.CoralOctaveOnOff == 1) {
            PianoNoteG5.volume = 3.0f;
            PianoNoteG5.Play();
            BubblesG.Play();
        }

        else if (EnableObjects05.CoralOctaveOnOff == 0) {
            PianoNoteG4.volume = 3.0f;
            PianoNoteG4.Play();
            BubblesG.Play();
        }
    }

    public void CoralOctaveOnClicking() {
        EnableObjects05.CoralOctaveOnOff = 0;
    }

    public void IntroPriorButtonClicking() {
        if (EnableObjects05.IntroSlideInt == 2) {
            EnableObjects05.IntroSlideInt = 1;
        }

        else if (EnableObjects05.IntroSlideInt == 3) {
            EnableObjects05.IntroSlideInt = 2;
        }

        else if (EnableObjects05.IntroSlideInt == 4) {
            EnableObjects05.IntroSlideInt = 3;
        }

        else if (EnableObjects05.IntroSlideInt == 5) {
            EnableObjects05.IntroSlideInt = 4;
        }
    }

    public void IntroNextButtonClicking() {
        if (EnableObjects05.IntroSlideInt == 1) {
            EnableObjects05.IntroSlideInt = 2;
        }

        else if (EnableObjects05.IntroSlideInt == 2) {
            EnableObjects05.IntroSlideInt = 3;
        }

        else if (EnableObjects05.IntroSlideInt == 3) {
            EnableObjects05.IntroSlideInt = 4;
        }

        else if (EnableObjects05.IntroSlideInt == 4) {
            EnableObjects05.IntroSlideInt = 5;
        }
    }

    public void ReplayButtonClicking() {
        EnableObjects05.AfterSongInt = 0;

        // Determine Song to Replay
        if (EnableObjects05.ChosenSong == 1) {
            StartCoroutine(PlaySong01());
        }

        else if (EnableObjects05.ChosenSong == 2) {
            StartCoroutine(PlaySong02());
        }

        else if (EnableObjects05.ChosenSong == 3) {
            StartCoroutine(PlaySong03());
        }

        else if (EnableObjects05.ChosenSong == 4) {
            StartCoroutine(PlaySong04());
        }

        else if (EnableObjects05.ChosenSong == 5) {
            StartCoroutine(PlaySong05());
        }

        else if (EnableObjects05.ChosenSong == 6) {
            StartCoroutine(PlaySong06());
        }

        else if (EnableObjects05.ChosenSong == 7) {
            StartCoroutine(PlaySong07());
        }

        else if (EnableObjects05.ChosenSong == 8) {
            StartCoroutine(PlaySong08());
        }

        else if (EnableObjects05.ChosenSong == 9) {
            StartCoroutine(PlaySong09());
        }

        else if (EnableObjects05.ChosenSong == 10) {
            StartCoroutine(PlaySong10());
        }

        else if (EnableObjects05.ChosenSong == 11) {
            StartCoroutine(PlaySong11());
        }

        else if (EnableObjects05.ChosenSong == 12) {
            StartCoroutine(PlaySong12());
        }

        else if (EnableObjects05.ChosenSong == 13) {
            StartCoroutine(PlaySong13());
        }
    }

    public void ReselectButtonClicking() {
        EnableObjects05.AfterSongInt = 0;
        EnableObjects05.IntroSlideInt = 5;
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

    public void SongButton01Clicking() {
        EnableObjects05.IntroSlideInt = 6;
        EnableObjects05.ChosenSong = 1;
        StartCoroutine(PlaySong01());
    }

    public void SongButton02Clicking() {
        EnableObjects05.IntroSlideInt = 6;
        EnableObjects05.ChosenSong = 2;
        StartCoroutine(PlaySong02());
    }

    public void SongButton03Clicking() {
        EnableObjects05.IntroSlideInt = 6;
        EnableObjects05.ChosenSong = 3;
        StartCoroutine(PlaySong03());
    }

    public void SongButton04Clicking() {
        EnableObjects05.IntroSlideInt = 6;
        EnableObjects05.ChosenSong = 4;
        StartCoroutine(PlaySong04());
    }

    public void SongButton05Clicking() {
        EnableObjects05.IntroSlideInt = 6;
        EnableObjects05.ChosenSong = 5;
        StartCoroutine(PlaySong05());
    }

    public void SongButton06Clicking() {
        EnableObjects05.IntroSlideInt = 6;
        EnableObjects05.ChosenSong = 6;
        StartCoroutine(PlaySong06());
    }

    public void SongButton07Clicking() {
        EnableObjects05.IntroSlideInt = 6;
        EnableObjects05.ChosenSong = 7;
        StartCoroutine(PlaySong07());
    }

    public void SongButton08Clicking() {
        EnableObjects05.IntroSlideInt = 6;
        EnableObjects05.ChosenSong = 8;
        StartCoroutine(PlaySong08());
    }

    public void SongButton09Clicking() {
        EnableObjects05.IntroSlideInt = 6;
        EnableObjects05.ChosenSong = 9;
        StartCoroutine(PlaySong09());
    }

    public void SongButton10Clicking() {
        EnableObjects05.IntroSlideInt = 6;
        EnableObjects05.ChosenSong = 10;
        StartCoroutine(PlaySong10());
    }

    public void SongButton11Clicking() {
        EnableObjects05.IntroSlideInt = 6;
        EnableObjects05.ChosenSong = 11;
        StartCoroutine(PlaySong11());
    }

    public void SongButton12Clicking() {
        EnableObjects05.IntroSlideInt = 6;
        EnableObjects05.ChosenSong = 12;
        StartCoroutine(PlaySong12());
    }

    public void SongButton13Clicking() {
        EnableObjects05.IntroSlideInt = 6;
        EnableObjects05.ChosenSong = 13;
        StartCoroutine(PlaySong13());
    }

    // Adeste Fideles
    public IEnumerator PlaySong01() {
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote01 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote01.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote01Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote02 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote02.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote02Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2);
        FishNote03 = Instantiate(FishLowerG, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote03.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote03Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote04 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote04.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote04Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote05 = Instantiate(FishUpperD, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote05.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote05Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2);
        FishNote06 = Instantiate(FishLowerG, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote06.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote06Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2);
        FishNote07 = Instantiate(FishUpperE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote07.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote07Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote08 = Instantiate(FishUpperD, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote08.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote08Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote09 = Instantiate(FishUpperE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote09.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote09Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote10 = Instantiate(FishUpperF, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote10.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote10Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote11 = Instantiate(FishUpperE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote11.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote11Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2);
        FishNote12 = Instantiate(FishUpperD, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote12.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote12Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote13 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote13.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote13Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote14 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote14.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote14Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2);
        FishNote15 = Instantiate(FishLowerB, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote15.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote15Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote16 = Instantiate(FishLowerA, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote16.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote16Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote17 = Instantiate(FishLowerB, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote17.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote17Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote18 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote18.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote18Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote19 = Instantiate(FishUpperD, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote19.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote19Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote20 = Instantiate(FishUpperE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote20.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote20Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote21 = Instantiate(FishLowerB, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote21.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote21Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2);
        FishNote22 = Instantiate(FishLowerA, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote22.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote22Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2);
        FishNote23 = Instantiate(FishLowerG, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote23.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote23Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 6);
        EnableObjects05.AfterSongInt = 1;
    }

    // Auld Lang Syne
    public IEnumerator PlaySong02() {
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote01 = Instantiate(FishLowerG, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote01.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote01Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote02 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote02.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote02Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2);
        FishNote03 = Instantiate(FishLowerB, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote03.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote03Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote04 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote04.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote04Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2);
        FishNote05 = Instantiate(FishUpperE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote05.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote05Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote06 = Instantiate(FishUpperD, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote06.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote06Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2);
        FishNote07 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote07.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote07Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote08 = Instantiate(FishUpperD, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote08.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote08Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2);
        FishNote09 = Instantiate(FishUpperE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote09.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote09Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote10 = Instantiate(FishUpperD, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote10.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote10Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote11 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote11.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote11Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2);
        FishNote12 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote12.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote12Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote13 = Instantiate(FishUpperE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote13.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote13Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2);
        FishNote14 = Instantiate(FishUpperG, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote14.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote14Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2);
        FishNote15 = Instantiate(FishUpperA, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote15.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote15Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 3);
        FishNote16 = Instantiate(FishUpperA, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote16.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote16Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote17 = Instantiate(FishUpperG, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote17.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote17Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2);
        FishNote18 = Instantiate(FishUpperE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote18.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote18Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote19 = Instantiate(FishUpperE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote19.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote19Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2);
        FishNote20 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote20.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote20Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote21 = Instantiate(FishUpperD, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote21.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote21Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2);
        FishNote22 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote22.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote22Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote23 = Instantiate(FishUpperD, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote23.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote23Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2);
        FishNote24 = Instantiate(FishUpperE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote24.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote24Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote25 = Instantiate(FishUpperD, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote25.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote25Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote26 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote26.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote26Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2);
        FishNote27 = Instantiate(FishLowerA, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote27.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote27Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote28 = Instantiate(FishLowerA, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote28.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote28Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2);
        FishNote29 = Instantiate(FishLowerG, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote29.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote29Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2);
        FishNote30 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote30.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote30Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 6);
        EnableObjects05.AfterSongInt = 1;
    }

    // Camptown Races
    public IEnumerator PlaySong03() {
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote01 = Instantiate(FishLowerG, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote01.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote01Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote02 = Instantiate(FishLowerG, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote02.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote02Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote03 = Instantiate(FishLowerE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote03.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote03Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote04 = Instantiate(FishLowerG, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote04.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote04Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote05 = Instantiate(FishLowerA, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote05.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote05Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote06 = Instantiate(FishLowerG, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote06.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote06Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote07 = Instantiate(FishLowerE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote07.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote07Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2);
        FishNote08 = Instantiate(FishLowerE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote08.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote08Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote09 = Instantiate(FishLowerD, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote09.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote09Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2);
        FishNote10 = Instantiate(FishLowerE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote10.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote10Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote11 = Instantiate(FishLowerD, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote11.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote11Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2);
        FishNote12 = Instantiate(FishLowerG, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote12.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote12Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote13 = Instantiate(FishLowerG, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote13.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote13Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote14 = Instantiate(FishLowerE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote14.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote14Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote15 = Instantiate(FishLowerG, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote15.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote15Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote16 = Instantiate(FishLowerA, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote16.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote16Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote17 = Instantiate(FishLowerG, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote17.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote17Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote18 = Instantiate(FishLowerE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote18.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote18Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2);
        FishNote19 = Instantiate(FishLowerD, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote19.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote19Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote20 = Instantiate(FishLowerE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote20.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote20Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote21 = Instantiate(FishLowerF, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote21.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote21Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote22 = Instantiate(FishLowerE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote22.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote22Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote23 = Instantiate(FishLowerD, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote23.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote23Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote24 = Instantiate(FishLowerC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote24.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote24Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 6);
        EnableObjects05.AfterSongInt = 1;
    }

    // Farmer in the Dell
    public IEnumerator PlaySong04() {
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote01 = Instantiate(FishLowerG, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote01.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote01Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote02 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote02.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote02Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1.5f);
        FishNote03 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote03.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote03Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote04 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote04.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote04Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1.5f);
        FishNote05 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote05.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote05Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote06 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote06.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote06Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2);
        FishNote07 = Instantiate(FishUpperD, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote07.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote07Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote08 = Instantiate(FishUpperE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote08.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote08Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1.5f);
        FishNote09 = Instantiate(FishUpperE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote09.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote09Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote10 = Instantiate(FishUpperE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote10.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote10Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1.5f);
        FishNote11 = Instantiate(FishUpperE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote11.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote11Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote12 = Instantiate(FishUpperE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote12.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote12Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2);
        FishNote13 = Instantiate(FishUpperG, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote13.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote13Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1.5f);
        FishNote14 = Instantiate(FishUpperG, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote14.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote14Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1.5f);
        FishNote15 = Instantiate(FishUpperA, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote15.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote15Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote16 = Instantiate(FishUpperG, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote16.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote16Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1.5f);
        FishNote17 = Instantiate(FishUpperE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote17.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote17Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote18 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote18.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote18Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1.5f);
        FishNote19 = Instantiate(FishUpperD, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote19.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote19Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote20 = Instantiate(FishUpperE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote20.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote20Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1.5f);
        FishNote21 = Instantiate(FishUpperE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote21.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote21Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote22 = Instantiate(FishUpperD, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote22.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote22Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1.5f);
        FishNote23 = Instantiate(FishUpperD, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote23.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote23Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote24 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote24.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote24Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 6);
        EnableObjects05.AfterSongInt = 1;
    }

    // Happy Birthday
    public IEnumerator PlaySong05() {
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote01 = Instantiate(FishLowerG, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote01.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote01Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2);
        FishNote02 = Instantiate(FishLowerG, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote02.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote02Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote03 = Instantiate(FishLowerA, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote03.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote03Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote04 = Instantiate(FishLowerG, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote04.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote04Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote05 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote05.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote05Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote06 = Instantiate(FishLowerB, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote06.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote06Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2);
        FishNote07 = Instantiate(FishLowerG, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote07.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote07Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2);
        FishNote08 = Instantiate(FishLowerG, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote08.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote08Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote09 = Instantiate(FishLowerA, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote09.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote09Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote10 = Instantiate(FishLowerG, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote10.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote10Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote11 = Instantiate(FishUpperD, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote11.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote11Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote12 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote12.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote12Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2);
        FishNote13 = Instantiate(FishLowerG, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote13.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote13Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2);
        FishNote14 = Instantiate(FishLowerG, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote14.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote14Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote15 = Instantiate(FishUpperG, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote15.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote15Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote16 = Instantiate(FishUpperE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote16.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote16Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote17 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote17.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote17Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote18 = Instantiate(FishLowerB, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote18.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote18Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote19 = Instantiate(FishLowerA, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote19.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote19Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2);
        FishNote20 = Instantiate(FishUpperF, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote20.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote20Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2);
        FishNote21 = Instantiate(FishUpperF, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote21.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote21Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote22 = Instantiate(FishUpperE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote22.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote22Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote23 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote23.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote23Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote24 = Instantiate(FishUpperD, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote24.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote24Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote25 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote25.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote25Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 6);
        EnableObjects05.AfterSongInt = 1;
    }

    // I Saw Three Ships
    public IEnumerator PlaySong06() {
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote01 = Instantiate(FishLowerG, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote01.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote01Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote02 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote02.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote02Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2);
        FishNote03 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote03.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote03Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote04 = Instantiate(FishUpperD, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote04.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote04Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2);
        FishNote05 = Instantiate(FishUpperE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote05.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote05Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote06 = Instantiate(FishUpperG, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote06.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote06Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2);
        FishNote07 = Instantiate(FishUpperE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote07.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote07Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote08 = Instantiate(FishUpperD, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote08.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote08Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2);
        FishNote09 = Instantiate(FishUpperF, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote09.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote09Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote10 = Instantiate(FishUpperE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote10.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote10Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2);
        FishNote11 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote11.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote11Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote12 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote12.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote12Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2);
        FishNote13 = Instantiate(FishUpperE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote13.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote13Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote14 = Instantiate(FishUpperD, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote14.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote14Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2);
        FishNote15 = Instantiate(FishLowerB, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote15.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote15Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote16 = Instantiate(FishLowerG, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote16.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote16Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 3);
        FishNote17 = Instantiate(FishLowerG, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote17.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote17Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote18 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote18.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote18Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2);
        FishNote19 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote19.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote19Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote20 = Instantiate(FishUpperD, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote20.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote20Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2);
        FishNote21 = Instantiate(FishUpperE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote21.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote21Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote22 = Instantiate(FishUpperG, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote22.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote22Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2);
        FishNote23 = Instantiate(FishUpperE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote23.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote23Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote24 = Instantiate(FishUpperD, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote24.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote24Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2);
        FishNote25 = Instantiate(FishUpperF, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote25.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote25Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote26 = Instantiate(FishUpperE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote26.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote26Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2);
        FishNote27 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote27.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote27Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote28 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote28.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote28Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote29 = Instantiate(FishUpperD, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote29.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote29Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote30 = Instantiate(FishUpperE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote30.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote30Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote31 = Instantiate(FishUpperD, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote31.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote31Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 3);
        FishNote32 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote32.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote32Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 6);
        EnableObjects05.AfterSongInt = 1;
    }

    // London Bridge
    public IEnumerator PlaySong07() {
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote01 = Instantiate(FishLowerG, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote01.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote01Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1.5f);
        FishNote02 = Instantiate(FishLowerA, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote02.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote02Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote03 = Instantiate(FishLowerG, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote03.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote03Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote04 = Instantiate(FishLowerF, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote04.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote04Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote05 = Instantiate(FishLowerE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote05.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote05Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote06 = Instantiate(FishLowerF, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote06.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote06Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote07 = Instantiate(FishLowerG, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote07.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote07Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2);
        FishNote08 = Instantiate(FishLowerD, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote08.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote08Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote09 = Instantiate(FishLowerE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote09.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote09Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote10 = Instantiate(FishLowerF, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote10.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote10Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2);
        FishNote11 = Instantiate(FishLowerE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote11.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote11Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote12 = Instantiate(FishLowerF, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote12.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote12Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote13 = Instantiate(FishLowerG, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote13.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote13Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2);
        FishNote14 = Instantiate(FishLowerG, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote14.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote14Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1.5f);
        FishNote15 = Instantiate(FishLowerA, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote15.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote15Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote16 = Instantiate(FishLowerG, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote16.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote16Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote17 = Instantiate(FishLowerF, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote17.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote17Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote18 = Instantiate(FishLowerE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote18.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote18Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote19 = Instantiate(FishLowerF, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote19.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote19Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote20 = Instantiate(FishLowerG, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote20.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote20Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2);
        FishNote21 = Instantiate(FishLowerD, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote21.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote21Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2);
        FishNote22 = Instantiate(FishLowerG, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote22.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote22Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2);
        FishNote23 = Instantiate(FishLowerE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote23.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote23Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote24 = Instantiate(FishLowerC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote24.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote24Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 6);
        EnableObjects05.AfterSongInt = 1;
    }

    // Old MacDonald
    public IEnumerator PlaySong08() {
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote01 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote01.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote01Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote02 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote02.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote02Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote03 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote03.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote03Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote04 = Instantiate(FishLowerG, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote04.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote04Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote05 = Instantiate(FishLowerA, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote05.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote05Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote06 = Instantiate(FishLowerA, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote06.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote06Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote07 = Instantiate(FishLowerG, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote07.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote07Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2);
        FishNote08 = Instantiate(FishUpperE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote08.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote08Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote09 = Instantiate(FishUpperE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote09.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote09Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote10 = Instantiate(FishUpperD, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote10.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote10Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote11 = Instantiate(FishUpperD, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote11.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote11Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote12 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote12.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote12Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2);
        FishNote13 = Instantiate(FishLowerG, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote13.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote13Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote14 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote14.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote14Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote15 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote15.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote15Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote16 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote16.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote16Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote17 = Instantiate(FishLowerG, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote17.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote17Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote18 = Instantiate(FishLowerA, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote18.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote18Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote19 = Instantiate(FishLowerA, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote19.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote19Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote20 = Instantiate(FishLowerG, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote20.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote20Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2);
        FishNote21 = Instantiate(FishUpperE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote21.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote21Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote22 = Instantiate(FishUpperE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote22.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote22Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote23 = Instantiate(FishUpperD, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote23.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote23Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote24 = Instantiate(FishUpperD, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote24.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote24Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote25 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote25.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote25Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 6);
        EnableObjects05.AfterSongInt = 1;
    }

    // Pop Goes the Weasel
    public IEnumerator PlaySong09() {
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote01 = Instantiate(FishLowerG, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote01.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote01Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote02 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote02.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote02Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1.5f);
        FishNote03 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote03.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote03Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote04 = Instantiate(FishUpperD, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote04.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote04Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1.5f);
        FishNote05 = Instantiate(FishUpperD, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote05.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote05Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote06 = Instantiate(FishUpperE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote06.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote06Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote07 = Instantiate(FishUpperG, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote07.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote07Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote08 = Instantiate(FishUpperE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote08.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote08Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote09 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote09.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote09Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1.5f);
        FishNote10 = Instantiate(FishLowerG, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote10.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote10Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote11 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote11.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote11Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1.5f);
        FishNote12 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote12.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote12Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote13 = Instantiate(FishUpperD, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote13.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote13Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1.5f);
        FishNote14 = Instantiate(FishUpperF, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote14.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote14Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote15 = Instantiate(FishUpperE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote15.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote15Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2);
        FishNote16 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote16.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote16Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2);
        FishNote17 = Instantiate(FishLowerG, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote17.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote17Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote18 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote18.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote18Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1.5f);
        FishNote19 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote19.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote19Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote20 = Instantiate(FishUpperD, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote20.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote20Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1.5f);
        FishNote21 = Instantiate(FishUpperD, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote21.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote21Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote22 = Instantiate(FishUpperE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote22.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote22Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote23 = Instantiate(FishUpperG, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote23.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote23Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote24 = Instantiate(FishUpperE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote24.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote24Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote25 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote25.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote25Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1.5f);
        FishNote26 = Instantiate(FishUpperA, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote26.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote26Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2);
        FishNote27 = Instantiate(FishUpperD, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote27.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote27Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1.5f);
        FishNote28 = Instantiate(FishUpperF, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote28.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote28Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote29 = Instantiate(FishUpperE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote29.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote29Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2);
        FishNote30 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote30.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote30Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 6);
        EnableObjects05.AfterSongInt = 1;
    }

    // Skip to My Lou
    public IEnumerator PlaySong10() {
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote01 = Instantiate(FishUpperE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote01.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote01Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2.5f);
        FishNote02 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote02.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote02Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2.5f);
        FishNote03 = Instantiate(FishUpperE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote03.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote03Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1.5f);
        FishNote04 = Instantiate(FishUpperE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote04.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote04Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote05 = Instantiate(FishUpperE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote05.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote05Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote06 = Instantiate(FishUpperG, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote06.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote06Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2.5f);
        FishNote07 = Instantiate(FishUpperD, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote07.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote07Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2.5f);
        FishNote08 = Instantiate(FishLowerB, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote08.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote08Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2.5f);
        FishNote09 = Instantiate(FishUpperD, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote09.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote09Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1.5f);
        FishNote10 = Instantiate(FishUpperD, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote10.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote10Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote11 = Instantiate(FishUpperD, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote11.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote11Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote12 = Instantiate(FishUpperF, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote12.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote12Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2.5f);
        FishNote13 = Instantiate(FishUpperE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote13.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote13Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2.5f);
        FishNote14 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote14.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote14Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2.5f);
        FishNote15 = Instantiate(FishUpperE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote15.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote15Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1.5f);
        FishNote16 = Instantiate(FishUpperE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote16.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote16Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote17 = Instantiate(FishUpperE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote17.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote17Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote18 = Instantiate(FishUpperG, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote18.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote18Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2.5f);
        FishNote19 = Instantiate(FishUpperD, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote19.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote19Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1.5f);
        FishNote20 = Instantiate(FishUpperE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote20.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote20Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote21 = Instantiate(FishUpperF, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote21.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote21Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote22 = Instantiate(FishUpperE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote22.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote22Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2);
        FishNote23 = Instantiate(FishUpperD, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote23.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote23Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2);
        FishNote24 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote24.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote24Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2);
        FishNote25 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote25.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote25Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 6);
        EnableObjects05.AfterSongInt = 1;
    }

    // Twinkle Twinkle
    public IEnumerator PlaySong11() {
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote01 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote01.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote01Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote02 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote02.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote02Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote03 = Instantiate(FishUpperG, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote03.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote03Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote04 = Instantiate(FishUpperG, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote04.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote04Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote05 = Instantiate(FishUpperA, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote05.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote05Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote06 = Instantiate(FishUpperA, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote06.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote06Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote07 = Instantiate(FishUpperG, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote07.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote07Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2);
        FishNote08 = Instantiate(FishUpperF, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote08.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote08Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote09 = Instantiate(FishUpperF, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote09.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote09Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote10 = Instantiate(FishUpperE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote10.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote10Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote11 = Instantiate(FishUpperE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote11.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote11Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote12 = Instantiate(FishUpperD, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote12.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote12Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote13 = Instantiate(FishUpperD, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote13.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote13Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote14 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote14.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote14Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2);
        FishNote15 = Instantiate(FishUpperG, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote15.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote15Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote16 = Instantiate(FishUpperG, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote16.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote16Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote17 = Instantiate(FishUpperF, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote17.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote17Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote18 = Instantiate(FishUpperF, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote18.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote18Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote19 = Instantiate(FishUpperE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote19.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote19Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote20 = Instantiate(FishUpperE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote20.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote20Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote21 = Instantiate(FishUpperD, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote21.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote21Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2);
        FishNote22 = Instantiate(FishUpperG, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote22.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote22Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote23 = Instantiate(FishUpperG, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote23.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote23Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote24 = Instantiate(FishUpperF, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote24.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote24Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote25 = Instantiate(FishUpperF, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote25.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote25Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote26 = Instantiate(FishUpperE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote26.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote26Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote27 = Instantiate(FishUpperE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote27.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote27Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote28 = Instantiate(FishUpperD, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote28.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote28Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2);
        FishNote29 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote29.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote29Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote30 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote30.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote30Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote31 = Instantiate(FishUpperG, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote31.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote31Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote32 = Instantiate(FishUpperG, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote32.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote32Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote33 = Instantiate(FishUpperA, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote33.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote33Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote34 = Instantiate(FishUpperA, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote34.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote34Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote35 = Instantiate(FishUpperG, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote35.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote35Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2);
        FishNote36 = Instantiate(FishUpperF, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote36.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote36Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote37 = Instantiate(FishUpperF, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote37.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote37Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote38 = Instantiate(FishUpperE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote38.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote38Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote39 = Instantiate(FishUpperE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote39.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote39Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote40 = Instantiate(FishUpperD, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote40.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote40Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote41 = Instantiate(FishUpperD, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote41.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote41Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote42 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote42.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote01Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 6);
        EnableObjects05.AfterSongInt = 1;
    }

    // When the Saints Go Marching In
    public IEnumerator PlaySong12() {
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote01 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote01.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote01Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote02 = Instantiate(FishUpperE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote02.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote02Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote03 = Instantiate(FishUpperF, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote03.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote03Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote04 = Instantiate(FishUpperG, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote04.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote04Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2.5f);
        FishNote05 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote05.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote05Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote06 = Instantiate(FishUpperE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote06.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote06Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote07 = Instantiate(FishUpperF, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote07.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote07Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote08 = Instantiate(FishUpperG, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote08.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote08Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2.5f);
        FishNote09 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote09.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote09Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote10 = Instantiate(FishUpperE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote10.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote10Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote11 = Instantiate(FishUpperF, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote11.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote11Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote12 = Instantiate(FishUpperG, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote12.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote12Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1.5f);
        FishNote13 = Instantiate(FishUpperE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote13.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote13Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1.5f);
        FishNote14 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote14.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote14Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1.5f);
        FishNote15 = Instantiate(FishUpperE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote15.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote15Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1.5f);
        FishNote16 = Instantiate(FishUpperD, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote16.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote16Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2.5f);
        FishNote17 = Instantiate(FishUpperE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote17.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote17Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote18 = Instantiate(FishUpperD, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote18.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote18Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote19 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote19.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote19Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1.5f);
        FishNote20 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote20.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote20Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote21 = Instantiate(FishUpperE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote21.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote21Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1.5f);
        FishNote22 = Instantiate(FishUpperG, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote22.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote22Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1.5f);
        FishNote23 = Instantiate(FishUpperG, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote23.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote23Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote24 = Instantiate(FishUpperF, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote24.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote24Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2.5f);
        FishNote25 = Instantiate(FishUpperE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote25.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote25Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote26 = Instantiate(FishUpperF, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote26.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote26Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote27 = Instantiate(FishUpperG, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote27.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote27Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1.5f);
        FishNote28 = Instantiate(FishUpperE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote28.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote28Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1.5f);
        FishNote29 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote29.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote29Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1.5f);
        FishNote30 = Instantiate(FishUpperD, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote30.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote30Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1.5f);
        FishNote31 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote31.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote31Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 6);
        EnableObjects05.AfterSongInt = 1;
    }

    // Yankee Doodle
    public IEnumerator PlaySong13() {
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote01 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote01.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote01Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote02 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote02.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote02Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote03 = Instantiate(FishUpperD, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote03.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote03Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote04 = Instantiate(FishUpperE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote04.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote04Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote05 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote05.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote05Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote06 = Instantiate(FishUpperE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote06.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote06Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote07 = Instantiate(FishUpperD, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote07.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote07Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote08 = Instantiate(FishLowerG, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote08.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote08Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote09 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote09.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote09Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote10 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote10.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote10Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote11 = Instantiate(FishUpperD, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote11.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote11Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote12 = Instantiate(FishUpperE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote12.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote12Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote13 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote13.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote13Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2);
        FishNote14 = Instantiate(FishLowerB, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote14.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote14Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2);
        FishNote15 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote15.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote15Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote16 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote16.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote16Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote17 = Instantiate(FishUpperD, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote17.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote17Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote18 = Instantiate(FishUpperE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote18.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote18Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote19 = Instantiate(FishUpperF, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote19.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote19Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote20 = Instantiate(FishUpperE, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote20.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote20Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote21 = Instantiate(FishUpperD, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote21.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote21Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote22 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote22.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote22Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote23 = Instantiate(FishLowerB, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote23.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote23Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote24 = Instantiate(FishLowerG, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote24.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote24Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote25 = Instantiate(FishLowerA, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote25.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote25Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote26 = Instantiate(FishLowerB, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote26.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote26Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 1);
        FishNote27 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote27.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote27Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 2);
        FishNote28 = Instantiate(FishUpperC, new Vector3(FishNoteStart, 0, 0), Quaternion.identity) as GameObject;
        FishNote28.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform, false);
        FishNote28Moving = true;
        yield return new WaitForSeconds(BetweenFishNotes * 6);
        EnableObjects05.AfterSongInt = 1;
    }

// ------------------------------ END: OTHER FUNCTIONS ------------------------------

}