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
public class MainMenuUI : MonoBehaviour {
		
#region Variables
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PRIVATE VARIABLES ---------------
	[SerializeField] private List<Image> allImages;
	[SerializeField] private List<TMP_Text> allWhiteTexts;
	[SerializeField] private List<TMP_Text> allCharcoalTexts;

	[SerializeField] private Button freePlayButton;
	[SerializeField] private Button performButton;
	[SerializeField] private Button playByEarButton;
	[SerializeField] private Button learnToPlayButton;

	[SerializeField] private ParticleSystem bubbles;

	private string nextSceneName = string.Empty;

	private Action changeScene;
	
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

		freePlayButton.onClick.AddListener(FreePlayButtonClicking);
		performButton.onClick.AddListener(PerformButtonClicking);
		playByEarButton.onClick.AddListener(PlayByEarButtonClicking);
		learnToPlayButton.onClick.AddListener(LearnToPlayButtonClicking);

		UI_Manager.Inst.FadeInAllObjects(allImages, allWhiteTexts, allCharcoalTexts, null);

		bubbles.Play();
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
	
	
// ---------------------------------------- END: ENUMERATOR FUNCTIONS ----------------------------------------
// ---------------------------------------- START: METHOD FUNCTIONS ----------------------------------------
	private void ChangeScene()
	{
		Core_Manager.Inst.WriteLog(this.GetType().Name, "Changing to next scene.");

		Core_Manager.Inst.ChangeScene(nextSceneName);
	}

	private void FreePlayButtonClicking()
	{
		Core_Manager.Inst.WriteLog(this.GetType().Name, "Free Play button has been pressed.");

		nextSceneName = Core_Manager.Inst.Scene_05;

		UI_Manager.Inst.FadeOutAllObjects(allImages, allWhiteTexts, allCharcoalTexts, changeScene);
	}

	private void PerformButtonClicking()
	{
		Core_Manager.Inst.WriteLog(this.GetType().Name, "Perform button has been pressed.");

		nextSceneName = Core_Manager.Inst.Scene_06;

		UI_Manager.Inst.FadeOutAllObjects(allImages, allWhiteTexts, allCharcoalTexts, changeScene);
	}

	private void PlayByEarButtonClicking()
	{
		Core_Manager.Inst.WriteLog(this.GetType().Name, "Play By Ear button has been pressed.");

		nextSceneName = Core_Manager.Inst.Scene_07;

		UI_Manager.Inst.FadeOutAllObjects(allImages, allWhiteTexts, allCharcoalTexts, changeScene);
	}

	private void LearnToPlayButtonClicking()
	{
		Core_Manager.Inst.WriteLog(this.GetType().Name, "Learn To Play button has been pressed.");

		nextSceneName = Core_Manager.Inst.Scene_03;

		UI_Manager.Inst.FadeOutAllObjects(allImages, allWhiteTexts, allCharcoalTexts, changeScene);
	}
	
// ---------------------------------------- END: METHOD FUNCTIONS ----------------------------------------
#endregion
}}