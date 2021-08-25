using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

public class EnableObjects06 : MonoBehaviour {

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

        PlaySounds.BackgroundMusicIsMute = 0;
    }

// -------------------- AWAKE FUNCTION --------------------
    void Awake() {
        
    }

// -------------------- UPDATE FUNCTION --------------------
    void Update() {
        CoralOnOffUpdate();
        SettingPanelUpdate();
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

// ------------------------------ END: OTHER FUNCTIONS ------------------------------

}