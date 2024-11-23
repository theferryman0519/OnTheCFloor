// Main Dependencies
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

// Game Dependencies
using ManagerSpace;

namespace UISpace {
public class GameLogoUI : MonoBehaviour {
		
#region Variables
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PRIVATE VARIABLES ---------------
	[SerializeField] private List<Image> allImages;
	[SerializeField] private List<TMP_Text> allWhiteTexts;
	[SerializeField] private List<TMP_Text> allCharcoalTexts;

	[SerializeField] private Image gameLogo;

	[SerializeField] private TMP_Text versionText;

	private string nextSceneName = string.Empty;

	private Action changeScene;
	private Action pauseAndFadeOut;
	
// --------------- PUBLIC VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
#endregion
#region Functions
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start()
	{
		changeScene = () => { ChangeScene(); };
		pauseAndFadeOut = () => { StartCoroutine(PausingToFadeOut()); };

		UI_Manager.Inst.FadeInAllObjects(allImages, allWhiteTexts, allCharcoalTexts, pauseAndFadeOut);
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake()
	{
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update()
	{
		
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: ENUMERATOR FUNCTIONS ----------------------------------------
	private IEnumerator PausingToFadeOut()
	{
		yield return new WaitForSeconds(1.5f);

		UI_Manager.Inst.FadeOutAllObjects(allImages, allWhiteTexts, allCharcoalTexts, changeScene);
	}
	
// ---------------------------------------- END: ENUMERATOR FUNCTIONS ----------------------------------------
// ---------------------------------------- START: METHOD FUNCTIONS ----------------------------------------
	private void ChangeScene()
	{
		Core_Manager.Inst.WriteLog(this.GetType().Name, "Changing to next scene.");

		nextSceneName = Core_Manager.Inst.Scene_02;

		Core_Manager.Inst.ChangeScene(nextSceneName);
	}
	
// ---------------------------------------- END: METHOD FUNCTIONS ----------------------------------------
#endregion
}}