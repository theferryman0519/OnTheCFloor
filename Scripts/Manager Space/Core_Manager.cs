// Main Dependencies
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

// Game Dependencies

namespace ManagerSpace {
public class Core_Manager : MonoBehaviour {
		
#region Variables
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- PUBLIC VARIABLES ---------------
	public string Scene_00 = "00_StudioLogo";
    public string Scene_01 = "01_GameLogo";
    public string Scene_02 = "02_MainMenu";
    public string Scene_03 = "03_TutorialChat";
    public string Scene_04 = "04_TutorialPlay";
    public string Scene_05 = "05_FreePlay";
    public string Scene_06 = "06_Perform";
    public string Scene_07 = "07_PlayByEar";
	
// --------------- STATIC VARIABLES ---------------
	public static Core_Manager Inst
    {
        get { return CoreManagerInstance; }
    }
    
    private static Core_Manager CoreManagerInstance = null;
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
#endregion
#region Functions
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start()
	{
		
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake()
	{
		if ((CoreManagerInstance != null) && (CoreManagerInstance != this))
        {
            Destroy(this.gameObject);
            return;
        }
        
        else
        {
            CoreManagerInstance = this;
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
	public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void WriteLog(string fileName, string content)
    {
#if UNITY_EDITOR
        Debug.Log(fileName + ": " + content);
#endif
    }
	
// ---------------------------------------- END: METHOD FUNCTIONS ----------------------------------------
#endregion
}}