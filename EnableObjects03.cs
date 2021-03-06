using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

public class EnableObjects03 : MonoBehaviour {

// ------------------------------ START: LIST OF VARIABLES ------------------------------
// -------------------- PUBLIC VARIABLES --------------------
    // Main Objects
    public Image BackgroundImage;
    public Text TitleText;
    public Image MainMenuButton;
    public Image SettingsButton;

    // Coral
    public Image CoralAOff;
    public Image CoralBOff;
    public Image CoralCOff;
    public Image CoralDOff;
    public Image CoralEOff;
    public Image CoralFOff;
    public Image CoralGOff;
    public Image CoralOctaveOff;
    public Image CoralAOn;
    public Image CoralBOn;
    public Image CoralCOn;
    public Image CoralDOn;
    public Image CoralEOn;
    public Image CoralFOn;
    public Image CoralGOn;
    public Image CoralOctaveOn;

    // Bubble Notes
    public Text BubbleNotesAOn;
    public Text BubbleNotesBOn;
    public Text BubbleNotesCOn;
    public Text BubbleNotesDOn;
    public Text BubbleNotesEOn;
    public Text BubbleNotesFOn;
    public Text BubbleNotesGOn;
    public Text BubbleNotesOctaveOn;
    public Text BubbleNotesAOff;
    public Text BubbleNotesBOff;
    public Text BubbleNotesCOff;
    public Text BubbleNotesDOff;
    public Text BubbleNotesEOff;
    public Text BubbleNotesFOff;
    public Text BubbleNotesGOff;
    public Text BubbleNotesOctaveOff;

    // Duke
    public Image DukeBody;
    public Image DukeArmA;
    public Image DukeArmB;
    public Image DukeArmC;
    public Image DukeArmD;
    public Image DukeArmE;
    public Image DukeArmF;
    public Image DukeArmG;
    public Image DukeArmOctave;

    // Action Texts
    public Text ActionText;
    public Text ActionNoteText;

    // Intro Panel
    public Image BackgroundOverlay;
    public Image IntroPanel;
    public Text IntroTitleText;
    public Text IntroTextA;
    public Text IntroTextB;
    public Image IntroImageB;
    public Text IntroTextC;
    public Text IntroTextD;
    public Image IntroPriorButton;
    public Image IntroNextButton;
    public Image IntroPlayButton;

    // Settings Panel
    public Image BackgroundOverlaySettings;
    public Image SettingsPanel;
    public Text SettingsTitleText;
    public Text SettingsMainText;
    public Image SettingsOnButton;
    public Image SettingsOffButton;
    public Image SettingsBackButton;

// -------------------- PRIVATE VARIABLES --------------------
    

// -------------------- STATIC VARIABLES --------------------
    public static int CoralAOnOff;
    public static int CoralBOnOff;
    public static int CoralCOnOff;
    public static int CoralDOnOff;
    public static int CoralEOnOff;
    public static int CoralFOnOff;
    public static int CoralGOnOff;
    public static int CoralOctaveOnOff;
    public static int SettingPanelOnOff;
    public static int SettingNotesOnOff;
    public static int ActionNoteInt;

// ------------------------------ END: LIST OF VARIABLES ------------------------------
// ------------------------------ START: CALLING OTHER SCRIPTS ------------------------------



// ------------------------------ END: CALLING OTHER SCRIPTS ------------------------------
// ------------------------------ START: CALLING INITIAL FUNCTIONS ------------------------------
// -------------------- START FUNCTION --------------------
    void Start() {
        EnableMain();
        EnableDuke();

        CoralAOnOff = 0;
        CoralBOnOff = 0;
        CoralCOnOff = 0;
        CoralDOnOff = 0;
        CoralEOnOff = 0;
        CoralFOnOff = 0;
        CoralGOnOff = 0;
        CoralOctaveOnOff = 0;
        SettingPanelOnOff = 0;
        SettingNotesOnOff = 0;
        ActionNoteInt = 1;

        PlaySounds.BackgroundMusicIsMute = 1;
    }

// -------------------- AWAKE FUNCTION --------------------
    void Awake() {
        
    }

// -------------------- UPDATE FUNCTION --------------------
    void Update() {
        IntroPanelUpdate();
        CoralOnOffUpdate();
        SettingPanelUpdate();
        ActionTextsUpdate();
    }

// ------------------------------ END: CALLING INITIAL FUNCTIONS ------------------------------
// ------------------------------ START: OTHER FUNCTIONS ------------------------------
// -------------------- ENABLING OBJECT FUNCTIONS --------------------
    public void EnableMain() {
        BackgroundImage.enabled = true;
        TitleText.enabled = true;
        MainMenuButton.enabled = true;
        SettingsButton.enabled = true;
    }

    public void EnableCoralAOff() {
        CoralAOff.enabled = true;

        if (SettingNotesOnOff == 0) {
            BubbleNotesAOff.enabled = true;
        }

        else if (SettingNotesOnOff == 1) {
            BubbleNotesAOff.enabled = false;
        }
    }

    public void EnableCoralBOff() {
        CoralBOff.enabled = true;
        
        if (SettingNotesOnOff == 0) {
            BubbleNotesBOff.enabled = true;
        }

        else if (SettingNotesOnOff == 1) {
            BubbleNotesBOff.enabled = false;
        }
    }

    public void EnableCoralCOff() {
        CoralCOff.enabled = true;
        
        if (SettingNotesOnOff == 0) {
            BubbleNotesCOff.enabled = true;
        }

        else if (SettingNotesOnOff == 1) {
            BubbleNotesCOff.enabled = false;
        }
    }

    public void EnableCoralDOff() {
        CoralDOff.enabled = true;
        
        if (SettingNotesOnOff == 0) {
            BubbleNotesDOff.enabled = true;
        }

        else if (SettingNotesOnOff == 1) {
            BubbleNotesDOff.enabled = false;
        }
    }

    public void EnableCoralEOff() {
        CoralEOff.enabled = true;
        
        if (SettingNotesOnOff == 0) {
            BubbleNotesEOff.enabled = true;
        }

        else if (SettingNotesOnOff == 1) {
            BubbleNotesEOff.enabled = false;
        }
    }

    public void EnableCoralFOff() {
        CoralFOff.enabled = true;
        
        if (SettingNotesOnOff == 0) {
            BubbleNotesFOff.enabled = true;
        }

        else if (SettingNotesOnOff == 1) {
            BubbleNotesFOff.enabled = false;
        }
    }

    public void EnableCoralGOff() {
        CoralGOff.enabled = true;
        
        if (SettingNotesOnOff == 0) {
            BubbleNotesGOff.enabled = true;
        }

        else if (SettingNotesOnOff == 1) {
            BubbleNotesGOff.enabled = false;
        }
    }

    public void EnableCoralOctaveOff() {
        CoralOctaveOff.enabled = true;
        
        if (SettingNotesOnOff == 0) {
            BubbleNotesOctaveOff.enabled = true;
        }

        else if (SettingNotesOnOff == 1) {
            BubbleNotesOctaveOff.enabled = false;
        }
    }

    public void EnableCoralAOn() {
        CoralAOn.enabled = true;

        if (SettingNotesOnOff == 0) {
            BubbleNotesAOn.enabled = true;
        }

        else if (SettingNotesOnOff == 1) {
            BubbleNotesAOn.enabled = false;
        }
    }

    public void EnableCoralBOn() {
        CoralBOn.enabled = true;
        
        if (SettingNotesOnOff == 0) {
            BubbleNotesBOn.enabled = true;
        }

        else if (SettingNotesOnOff == 1) {
            BubbleNotesBOn.enabled = false;
        }
    }

    public void EnableCoralCOn() {
        CoralCOn.enabled = true;
        
        if (SettingNotesOnOff == 0) {
            BubbleNotesCOn.enabled = true;
        }

        else if (SettingNotesOnOff == 1) {
            BubbleNotesCOn.enabled = false;
        }
    }

    public void EnableCoralDOn() {
        CoralDOn.enabled = true;
        
        if (SettingNotesOnOff == 0) {
            BubbleNotesDOn.enabled = true;
        }

        else if (SettingNotesOnOff == 1) {
            BubbleNotesDOn.enabled = false;
        }
    }

    public void EnableCoralEOn() {
        CoralEOn.enabled = true;
        
        if (SettingNotesOnOff == 0) {
            BubbleNotesEOn.enabled = true;
        }

        else if (SettingNotesOnOff == 1) {
            BubbleNotesEOn.enabled = false;
        }
    }

    public void EnableCoralFOn() {
        CoralFOn.enabled = true;
        
        if (SettingNotesOnOff == 0) {
            BubbleNotesFOn.enabled = true;
        }

        else if (SettingNotesOnOff == 1) {
            BubbleNotesFOn.enabled = false;
        }
    }

    public void EnableCoralGOn() {
        CoralGOn.enabled = true;
        
        if (SettingNotesOnOff == 0) {
            BubbleNotesGOn.enabled = true;
        }

        else if (SettingNotesOnOff == 1) {
            BubbleNotesGOn.enabled = false;
        }
    }

    public void EnableCoralOctaveOn() {
        CoralOctaveOn.enabled = true;
        
        if (SettingNotesOnOff == 0) {
            BubbleNotesOctaveOn.enabled = true;
        }

        else if (SettingNotesOnOff == 1) {
            BubbleNotesOctaveOn.enabled = false;
        }
    }

    public void EnableDuke() {
        DukeBody.enabled = true;
        DukeArmA.enabled = true;
        DukeArmB.enabled = true;
        DukeArmC.enabled = true;
        DukeArmD.enabled = true;
        DukeArmE.enabled = true;
        DukeArmF.enabled = true;
        DukeArmG.enabled = true;
        DukeArmOctave.enabled = true;
        ActionText.enabled = true;
        ActionNoteText.enabled = true;
    }

    public void EnableIntroPanelMain() {
        BackgroundOverlay.enabled = true;
        IntroPanel.enabled = true;
        IntroTitleText.enabled = true;
    }

    public void EnableIntroPanelSlideA() {
        IntroTextA.enabled = true;
        IntroNextButton.enabled = true;
    }

    public void EnableIntroPanelSlideB() {
        IntroTextB.enabled = true;
        IntroImageB.enabled = true;
        IntroPriorButton.enabled = true;
        IntroNextButton.enabled = true;
    }

    public void EnableIntroPanelSlideC() {
        IntroTextC.enabled = true;
        IntroPriorButton.enabled = true;
        IntroNextButton.enabled = true;
    }

    public void EnableIntroPanelSlideD() {
        IntroTextD.enabled = true;
        IntroPriorButton.enabled = true;
        IntroPlayButton.enabled = true;
    }

    public void EnableSettingsPanel() {
        BackgroundOverlaySettings.enabled = true;
        SettingsPanel.enabled = true;
        SettingsTitleText.enabled = true;
        SettingsMainText.enabled = true;
        SettingsBackButton.enabled = true;
    }

    public void EnableSettingsNotesOn() {
        SettingsOnButton.enabled = true;
    }

    public void EnableSettingsNotesOff() {
        SettingsOffButton.enabled = true;
    }

// -------------------- DISABLING OBJECT FUNCTIONS --------------------
    public void DisableMain() {
        BackgroundImage.enabled = false;
        TitleText.enabled = false;
        MainMenuButton.enabled = false;
        SettingsButton.enabled = false;
    }

    public void DisableCoralAOff() {
        CoralAOff.enabled = false;
        BubbleNotesAOff.enabled = false;
    }

    public void DisableCoralBOff() {
        CoralBOff.enabled = false;
        BubbleNotesBOff.enabled = false;
    }

    public void DisableCoralCOff() {
        CoralCOff.enabled = false;
        BubbleNotesCOff.enabled = false;
    }

    public void DisableCoralDOff() {
        CoralDOff.enabled = false;
        BubbleNotesDOff.enabled = false;
    }

    public void DisableCoralEOff() {
        CoralEOff.enabled = false;
        BubbleNotesEOff.enabled = false;
    }

    public void DisableCoralFOff() {
        CoralFOff.enabled = false;
        BubbleNotesFOff.enabled = false;
    }

    public void DisableCoralGOff() {
        CoralGOff.enabled = false;
        BubbleNotesGOff.enabled = false;
    }

    public void DisableCoralOctaveOff() {
        CoralOctaveOff.enabled = false;
        BubbleNotesOctaveOff.enabled = false;
    }

    public void DisableCoralAOn() {
        CoralAOn.enabled = false;
        BubbleNotesAOn.enabled = false;
    }

    public void DisableCoralBOn() {
        CoralBOn.enabled = false;
        BubbleNotesBOn.enabled = false;
    }

    public void DisableCoralCOn() {
        CoralCOn.enabled = false;
        BubbleNotesCOn.enabled = false;
    }

    public void DisableCoralDOn() {
        CoralDOn.enabled = false;
        BubbleNotesDOn.enabled = false;
    }

    public void DisableCoralEOn() {
        CoralEOn.enabled = false;
        BubbleNotesEOn.enabled = false;
    }

    public void DisableCoralFOn() {
        CoralFOn.enabled = false;
        BubbleNotesFOn.enabled = false;
    }

    public void DisableCoralGOn() {
        CoralGOn.enabled = false;
        BubbleNotesGOn.enabled = false;
    }

    public void DisableCoralOctaveOn() {
        CoralOctaveOn.enabled = false;
        BubbleNotesOctaveOn.enabled = false;
    }

    public void DisableDuke() {
        DukeBody.enabled = false;
        DukeArmA.enabled = false;
        DukeArmB.enabled = false;
        DukeArmC.enabled = false;
        DukeArmD.enabled = false;
        DukeArmE.enabled = false;
        DukeArmF.enabled = false;
        DukeArmG.enabled = false;
        DukeArmOctave.enabled = false;
        ActionText.enabled = false;
        ActionNoteText.enabled = false;
    }

    public void DisableIntroPanelMain() {
        BackgroundOverlay.enabled = false;
        IntroPanel.enabled = false;
        IntroTitleText.enabled = false;
    }

    public void DisableIntroPanelSlideA() {
        IntroTextA.enabled = false;
        IntroNextButton.enabled = false;
    }

    public void DisableIntroPanelSlideB() {
        IntroTextB.enabled = false;
        IntroImageB.enabled = false;
        IntroPriorButton.enabled = false;
        IntroNextButton.enabled = false;
    }

    public void DisableIntroPanelSlideC() {
        IntroTextC.enabled = false;
        IntroPriorButton.enabled = false;
        IntroNextButton.enabled = false;
    }

    public void DisableIntroPanelSlideD() {
        IntroTextD.enabled = false;
        IntroPriorButton.enabled = false;
        IntroPlayButton.enabled = false;
    }

    public void DisableSettingsPanel() {
        BackgroundOverlaySettings.enabled = false;
        SettingsPanel.enabled = false;
        SettingsTitleText.enabled = false;
        SettingsMainText.enabled = false;
        SettingsBackButton.enabled = false;
    }

    public void DisableSettingsNotesOn() {
        SettingsOnButton.enabled = false;
    }

    public void DisableSettingsNotesOff() {
        SettingsOffButton.enabled = false;
    }

// -------------------- UPDATE FUNCTIONS --------------------
    public void IntroPanelUpdate() {
        if ((EnableObjects00.IntroSlideInt == 0) || (EnableObjects00.IntroSlideInt == 5)) {
            DisableIntroPanelMain();
            DisableIntroPanelSlideA();
            DisableIntroPanelSlideB();
            DisableIntroPanelSlideC();
            DisableIntroPanelSlideD();

            PlaySounds.BackgroundMusicIsMute = 0;
        }

        else if (EnableObjects00.IntroSlideInt == 1) {
            DisableIntroPanelSlideB();
            DisableIntroPanelSlideC();
            DisableIntroPanelSlideD();

            EnableIntroPanelMain();
            EnableIntroPanelSlideA();
        }

        else if (EnableObjects00.IntroSlideInt == 2) {
            DisableIntroPanelSlideA();
            DisableIntroPanelSlideC();
            DisableIntroPanelSlideD();

            EnableIntroPanelMain();
            EnableIntroPanelSlideB();
        }

        else if (EnableObjects00.IntroSlideInt == 3) {
            DisableIntroPanelSlideA();
            DisableIntroPanelSlideB();
            DisableIntroPanelSlideD();

            EnableIntroPanelMain();
            EnableIntroPanelSlideC();
        }

        else if (EnableObjects00.IntroSlideInt == 4) {
            DisableIntroPanelSlideA();
            DisableIntroPanelSlideB();
            DisableIntroPanelSlideC();

            EnableIntroPanelMain();
            EnableIntroPanelSlideD();
        }
    }

    public void SettingPanelUpdate() {
        if (SettingPanelOnOff == 0) {
            DisableSettingsPanel();
            DisableSettingsNotesOn();
            DisableSettingsNotesOff();
        }

        else if (SettingPanelOnOff == 1) {
            if (SettingNotesOnOff == 0) {
                DisableSettingsNotesOn();
                EnableSettingsPanel();
                EnableSettingsNotesOff();
                SettingsMainText.text = "You may turn off the music note texts for each coral";
            }

            else if (SettingNotesOnOff == 1) {
                DisableSettingsNotesOff();
                EnableSettingsPanel();
                EnableSettingsNotesOn();
                SettingsMainText.text = "You may turn on the music note texts for each coral";
            }
        }
    }

    public void CoralOnOffUpdate() {
        // CoralA
        if (CoralAOnOff == 0) {
            DisableCoralAOn();
            EnableCoralAOff();
        }

        else if (CoralAOnOff == 1) {
            DisableCoralAOff();
            EnableCoralAOn();
        }

        // CoralB
        if (CoralBOnOff == 0) {
            DisableCoralBOn();
            EnableCoralBOff();
        }

        else if (CoralBOnOff == 1) {
            DisableCoralBOff();
            EnableCoralBOn();
        }

        // CoralC
        if (CoralCOnOff == 0) {
            DisableCoralCOn();
            EnableCoralCOff();
        }

        else if (CoralCOnOff == 1) {
            DisableCoralCOff();
            EnableCoralCOn();
        }

        // CoralD
        if (CoralDOnOff == 0) {
            DisableCoralDOn();
            EnableCoralDOff();
        }

        else if (CoralDOnOff == 1) {
            DisableCoralDOff();
            EnableCoralDOn();
        }

        // CoralE
        if (CoralEOnOff == 0) {
            DisableCoralEOn();
            EnableCoralEOff();
        }

        else if (CoralEOnOff == 1) {
            DisableCoralEOff();
            EnableCoralEOn();
        }

        // CoralF
        if (CoralFOnOff == 0) {
            DisableCoralFOn();
            EnableCoralFOff();
        }

        else if (CoralFOnOff == 1) {
            DisableCoralFOff();
            EnableCoralFOn();
        }

        // CoralG
        if (CoralGOnOff == 0) {
            DisableCoralGOn();
            EnableCoralGOff();
        }

        else if (CoralGOnOff == 1) {
            DisableCoralGOff();
            EnableCoralGOn();
        }

        // CoralOctave
        if (CoralOctaveOnOff == 0) {
            DisableCoralOctaveOn();
            EnableCoralOctaveOff();
        }

        else if (CoralOctaveOnOff == 1) {
            DisableCoralOctaveOff();
            EnableCoralOctaveOn();
        }
    }

    public void ActionTextsUpdate() {
        if (ActionNoteInt == 1) {
            ActionText.text = "Click the coral that corresponds with the note above Duke.";
            ActionNoteText.text = "A";
        }

        else if (ActionNoteInt == 2) {
            ActionText.text = "Very good! Keep following along with the notes above Duke.";
            ActionNoteText.text = "D";
        }

        else if (ActionNoteInt == 3) {
            ActionText.text = "Click the coral that corresponds with the note above Duke.";
            ActionNoteText.text = "G";
        }

        else if (ActionNoteInt == 4) {
            ActionText.text = "Click the coral that corresponds with the note above Duke.";
            ActionNoteText.text = "B";
        }

        else if (ActionNoteInt == 5) {
            ActionText.text = "Click the coral that corresponds with the note above Duke.";
            ActionNoteText.text = "E";
        }

        else if (ActionNoteInt == 6) {
            ActionText.text = "Click the coral that corresponds with the note above Duke.";
            ActionNoteText.text = "C";
        }

        else if (ActionNoteInt == 7) {
            ActionText.text = "Click the coral that corresponds with the note above Duke.";
            ActionNoteText.text = "F";
        }

        else if (ActionNoteInt == 8) {
            ActionText.text = "Awesome job! Now, click the Octave coral to make your notes go higher.";
            ActionNoteText.text = "Oct & A";
        }

        else if (ActionNoteInt == 9) {
            ActionText.text = "Perfect! Just leave the Octave coral turned on to keep your notes higher.";
            ActionNoteText.text = "G";
        }

        else if (ActionNoteInt == 10) {
            ActionText.text = "Leave the Octave coral turned on to keep your notes higher.";
            ActionNoteText.text = "D";
        }

        else if (ActionNoteInt == 11) {
            ActionText.text = "Leave the Octave coral turned on to keep your notes higher.";
            ActionNoteText.text = "B";
        }

        else if (ActionNoteInt == 12) {
            ActionText.text = "Leave the Octave coral turned on to keep your notes higher.";
            ActionNoteText.text = "F";
        }

        else if (ActionNoteInt == 13) {
            ActionText.text = "Leave the Octave coral turned on to keep your notes higher.";
            ActionNoteText.text = "C";
        }

        else if (ActionNoteInt == 14) {
            ActionText.text = "Leave the Octave coral turned on to keep your notes higher.";
            ActionNoteText.text = "E";
        }

        else if (ActionNoteInt == 15) {
            ActionText.text = "Click the Octave coral to turn it off and make your notes lower again.";
            ActionNoteText.text = "Oct & A";
        }

        else if (ActionNoteInt == 16) {
            ActionText.text = "Well done! Go to the Main Menu to start making music with Duke!";
            ActionNoteText.text = "";
        }
    }

// ------------------------------ END: OTHER FUNCTIONS ------------------------------

}