// Main Dependencies
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

// Game Dependencies

namespace ManagerSpace {
public class Audio_Manager : MonoBehaviour {
		
#region Variables
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PRIVATE VARIABLES ---------------
	[SerializeField] private AudioSource backgroundMusic;
    [SerializeField] private AudioSource bubblesEffect;
    [SerializeField] private AudioSource musicNoteA;
    [SerializeField] private AudioSource musicNoteB;
    [SerializeField] private AudioSource musicNoteC;
    [SerializeField] private AudioSource musicNoteD;
    [SerializeField] private AudioSource musicNoteE;
    [SerializeField] private AudioSource musicNoteF;
    [SerializeField] private AudioSource musicNoteG;
	
// --------------- PUBLIC VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	public static Audio_Manager Inst
    {
        get { return AudioManagerInstance; }
    }
    
    private static Audio_Manager AudioManagerInstance = null;
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
#endregion
#region Functions
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start()
	{
		SetBackgroundMusic();
        SetBubblesEffect();
        SetMusicNoteA();
        SetMusicNoteB();
        SetMusicNoteC();
        SetMusicNoteD();
        SetMusicNoteE();
        SetMusicNoteF();
        SetMusicNoteG();
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake()
	{
		if ((AudioManagerInstance != null) && (AudioManagerInstance != this))
        {
            Destroy(this.gameObject);
            return;
        }
        
        else
        {
            AudioManagerInstance = this;
        }
        
        DontDestroyOnLoad(this.gameObject);
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update()
	{
		
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: ENUMERATOR FUNCTIONS ----------------------------------------
	
	
// ---------------------------------------- END: ENUMERATOR FUNCTIONS ----------------------------------------
// ---------------------------------------- START: METHOD FUNCTIONS ----------------------------------------
	public void SetBackgroundMusic()
    {
        Core_Manager.Inst.WriteLog(this.GetType().Name, "Setting the background music.");

        backgroundMusic.loop = true;
        backgroundMusic.volume = 0.4f;
    }

    public void SetBubblesEffect()
    {
        Core_Manager.Inst.WriteLog(this.GetType().Name, "Setting the bubbles sound effect.");

        bubblesEffect.loop = false;
        bubblesEffect.volume = 0.75f;
    }

    public void SetMusicNoteA()
    {
        Core_Manager.Inst.WriteLog(this.GetType().Name, "Setting the A musical note.");

        musicNoteA.loop = false;
        musicNoteA.volume = 1.5f;
    }

    public void SetMusicNoteB()
    {
        Core_Manager.Inst.WriteLog(this.GetType().Name, "Setting the B musical note.");

        musicNoteB.loop = false;
        musicNoteB.volume = 1.5f;
    }

    public void SetMusicNoteC()
    {
        Core_Manager.Inst.WriteLog(this.GetType().Name, "Setting the C musical note.");

        musicNoteC.loop = false;
        musicNoteC.volume = 1.5f;
    }

    public void SetMusicNoteD()
    {
        Core_Manager.Inst.WriteLog(this.GetType().Name, "Setting the D musical note.");

        musicNoteD.loop = false;
        musicNoteD.volume = 1.5f;
    }

    public void SetMusicNoteE()
    {
        Core_Manager.Inst.WriteLog(this.GetType().Name, "Setting the E musical note.");

        musicNoteE.loop = false;
        musicNoteE.volume = 1.5f;
    }

    public void SetMusicNoteF()
    {
        Core_Manager.Inst.WriteLog(this.GetType().Name, "Setting the F musical note.");

        musicNoteF.loop = false;
        musicNoteF.volume = 1.5f;
    }

    public void SetMusicNoteG()
    {
        Core_Manager.Inst.WriteLog(this.GetType().Name, "Setting the G musical note.");

        musicNoteG.loop = false;
        musicNoteG.volume = 1.5f;
    }

    public void PlayBubblesEffect()
    {
        Core_Manager.Inst.WriteLog(this.GetType().Name, "Playing the bubbles sound effect.");

        bubblesEffect.Play();
    }

    public void PlayMusicNoteA()
    {
        Core_Manager.Inst.WriteLog(this.GetType().Name, "Playing the A musical note.");

        musicNoteA.Play();
    }

    public void PlayMusicNoteB()
    {
        Core_Manager.Inst.WriteLog(this.GetType().Name, "Playing the B musical note.");

        musicNoteB.Play();
    }

    public void PlayMusicNoteC()
    {
        Core_Manager.Inst.WriteLog(this.GetType().Name, "Playing the C musical note.");

        musicNoteC.Play();
    }

    public void PlayMusicNoteD()
    {
        Core_Manager.Inst.WriteLog(this.GetType().Name, "Playing the D musical note.");

        musicNoteD.Play();
    }

    public void PlayMusicNoteE()
    {
        Core_Manager.Inst.WriteLog(this.GetType().Name, "Playing the E musical note.");

        musicNoteE.Play();
    }

    public void PlayMusicNoteF()
    {
        Core_Manager.Inst.WriteLog(this.GetType().Name, "Playing the F musical note.");

        musicNoteF.Play();
    }

    public void PlayMusicNoteG()
    {
        Core_Manager.Inst.WriteLog(this.GetType().Name, "Playing the G musical note.");

        musicNoteG.Play();
    }
	
// ---------------------------------------- END: METHOD FUNCTIONS ----------------------------------------
#endregion
}}