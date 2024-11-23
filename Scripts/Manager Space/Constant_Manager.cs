// Main Dependencies
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

// Game Dependencies

namespace ManagerSpace {
public class Constant_Manager : MonoBehaviour {
		
#region Variables
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- PUBLIC VARIABLES ---------------
	// Time Constants
    public const float FadeMultiplier = 2.0f;
    public const float MoveMultiplier = 2.0f;
    public const float ShiftMultiplier = 1.25f;
	
// --------------- STATIC VARIABLES ---------------
	public static Constant_Manager Inst
    {
        get { return ConstantManagerInstance; }
    }
    
    private static Constant_Manager ConstantManagerInstance = null;
	
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
		if ((ConstantManagerInstance != null) && (ConstantManagerInstance != this))
        {
            Destroy(this.gameObject);
            return;
        }
        
        else
        {
            ConstantManagerInstance = this;
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
	
	
// ---------------------------------------- END: METHOD FUNCTIONS ----------------------------------------
#endregion
}}