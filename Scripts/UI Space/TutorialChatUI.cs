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
public class TutorialChatUI : MonoBehaviour {
		
#region Variables
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PRIVATE VARIABLES ---------------
	[SerializeField] private List<Image> allImages;
	[SerializeField] private List<TMP_Text> allWhiteTexts;
	[SerializeField] private List<TMP_Text> allCharcoalTexts;

	[SerializeField] private GameObject tutorialPageA;
	[SerializeField] private GameObject tutorialPageB;
	[SerializeField] private GameObject tutorialPageC;

	[SerializeField] private Button backButton;
	[SerializeField] private Button nextButton;

	[SerializeField] private ParticleSystem bubbles;

	private string nextSceneName = string.Empty;

	private int pageInt = 0;

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

		backButton.onClick.AddListener(BackButtonClicking);
		nextButton.onClick.AddListener(NextButtonClicking);

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
		if (pageInt == 0)
		{
			tutorialPageA.SetActive(true);
			tutorialPageB.SetActive(false);
			tutorialPageC.SetActive(false);

			backButton.gameObject.SetActive(false);
		}

		else if (pageInt == 1)
		{
			tutorialPageA.SetActive(false);
			tutorialPageB.SetActive(true);
			tutorialPageC.SetActive(false);

			backButton.gameObject.SetActive(true);
		}

		else if (pageInt == 2)
		{
			tutorialPageA.SetActive(false);
			tutorialPageB.SetActive(false);
			tutorialPageC.SetActive(true);

			backButton.gameObject.SetActive(true);
		}
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: ENUMERATOR FUNCTIONS ----------------------------------------
	private IEnumerator TransitioningPages(bool isNextPage)
	{
		float ElapsedTime = 0.0f;

		while (ElapsedTime < 1.0f)
		{
			ElapsedTime += Time.deltaTime * Constant_Manager.FadeMultiplier;

			if (pageInt == 0) { tutorialPageA.GetComponent<TMP_Text>().color = Color.Lerp(UI_Manager.Inst.WhiteColor, UI_Manager.Inst.WhiteAlpha, ElapsedTime); }
			else if (pageInt == 1) { tutorialPageB.GetComponent<TMP_Text>().color = Color.Lerp(UI_Manager.Inst.WhiteColor, UI_Manager.Inst.WhiteAlpha, ElapsedTime); }
			else if (pageInt == 2) { tutorialPageC.GetComponent<TMP_Text>().color = Color.Lerp(UI_Manager.Inst.WhiteColor, UI_Manager.Inst.WhiteAlpha, ElapsedTime); }

			yield return null;
		}

		ElapsedTime = 0.0f;

		if (isNextPage) { pageInt++; }
		else { pageInt--; }

		while (ElapsedTime < 1.0f)
		{
			ElapsedTime += Time.deltaTime * Constant_Manager.FadeMultiplier;

			if (pageInt == 0) { tutorialPageA.GetComponent<TMP_Text>().color = Color.Lerp(UI_Manager.Inst.WhiteAlpha, UI_Manager.Inst.WhiteColor, ElapsedTime); }
			else if (pageInt == 1) { tutorialPageB.GetComponent<TMP_Text>().color = Color.Lerp(UI_Manager.Inst.WhiteAlpha, UI_Manager.Inst.WhiteColor, ElapsedTime); }
			else if (pageInt == 2) { tutorialPageC.GetComponent<TMP_Text>().color = Color.Lerp(UI_Manager.Inst.WhiteAlpha, UI_Manager.Inst.WhiteColor, ElapsedTime); }

			yield return null;
		}
	}
	
// ---------------------------------------- END: ENUMERATOR FUNCTIONS ----------------------------------------
// ---------------------------------------- START: METHOD FUNCTIONS ----------------------------------------
	private void ChangeScene()
	{
		Core_Manager.Inst.WriteLog(this.GetType().Name, "Changing to next scene.");

		Core_Manager.Inst.ChangeScene(nextSceneName);
	}

	private void BackButtonClicking()
	{
		Core_Manager.Inst.WriteLog(this.GetType().Name, "Back button has been pressed.");

		StartCoroutine(TransitioningPages(false));
	}

	private void NextButtonClicking()
	{
		Core_Manager.Inst.WriteLog(this.GetType().Name, "Next button has been pressed.");

		if (pageInt == 2)
		{
			nextSceneName = Core_Manager.Inst.Scene_04;

			UI_Manager.Inst.FadeOutAllObjects(allImages, allWhiteTexts, allCharcoalTexts, changeScene);
		}

		else
		{
			StartCoroutine(TransitioningPages(true));
		}
	}
	
// ---------------------------------------- END: METHOD FUNCTIONS ----------------------------------------
#endregion
}}