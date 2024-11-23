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
public class StudioLogoUI : MonoBehaviour {
		
#region Variables
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PRIVATE VARIABLES ---------------
	[SerializeField] private List<Image> allImages;
	[SerializeField] private List<TMP_Text> allWhiteTexts;
	[SerializeField] private List<TMP_Text> allCharcoalTexts;

	[SerializeField] private Image background;
	[SerializeField] private Image oceanFloor;
	[SerializeField] private Image ocean;
	[SerializeField] private Image studioLogo;

	[SerializeField] private ParticleSystem bubblesPage;

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
		background.color = UI_Manager.Inst.DarkTealColor;
		studioLogo.color = UI_Manager.Inst.WhiteColor;
		oceanFloor.color = UI_Manager.Inst.WhiteAlpha;

		changeScene = () => { ChangeScene(); };

		StartCoroutine(FadeInStudioLogo());
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
	private IEnumerator FadeInStudioLogo()
	{
		float ElapsedTime = 0.0f;

		while (ElapsedTime < 1.0f)
		{
			ElapsedTime += Time.deltaTime * Constant_Manager.FadeMultiplier;

            studioLogo.color = Color.Lerp(UI_Manager.Inst.WhiteAlpha, UI_Manager.Inst.WhiteColor, ElapsedTime);

            yield return null;
        }

		yield return new WaitForSeconds(1.5f);

		StartCoroutine(ShiftingOcean());
	}

	private IEnumerator FadeOutStudioLogo()
	{
		float ElapsedTime = 0.0f;

		while (ElapsedTime < 1.0f)
		{
			ElapsedTime += Time.deltaTime * Constant_Manager.FadeMultiplier;

            studioLogo.color = Color.Lerp(UI_Manager.Inst.WhiteColor, UI_Manager.Inst.WhiteAlpha, ElapsedTime);

            yield return null;
        }
	}

	private IEnumerator ShiftingOcean()
	{
		RectTransform oceanRect = ocean.gameObject.GetComponent<RectTransform>();

		Vector2 oceanShiftPos = new Vector2(0, (UI_Manager.Inst.ScreenHeight + 300));

		while (Vector2.Distance(oceanRect.anchoredPosition, oceanShiftPos) > 1000.0f)
		{
			oceanRect.anchoredPosition = Vector2.Lerp(oceanRect.anchoredPosition, oceanShiftPos, Time.deltaTime / Constant_Manager.ShiftMultiplier);

			yield return null;
		}

		StartBubbles();

		while (Vector2.Distance(oceanRect.anchoredPosition, oceanShiftPos) > 700.0f)
		{
			oceanRect.anchoredPosition = Vector2.Lerp(oceanRect.anchoredPosition, oceanShiftPos, Time.deltaTime / Constant_Manager.ShiftMultiplier);

			yield return null;
		}

		Audio_Manager.Inst.PlayBubblesEffect();

		while (Vector2.Distance(oceanRect.anchoredPosition, oceanShiftPos) > 200.0f)
		{
			oceanRect.anchoredPosition = Vector2.Lerp(oceanRect.anchoredPosition, oceanShiftPos, Time.deltaTime / Constant_Manager.ShiftMultiplier);

			yield return null;
		}

		StartCoroutine(FadeOutStudioLogo());

		while (Vector2.Distance(oceanRect.anchoredPosition, oceanShiftPos) > 75.0f)
		{
			oceanRect.anchoredPosition = Vector2.Lerp(oceanRect.anchoredPosition, oceanShiftPos, Time.deltaTime / Constant_Manager.ShiftMultiplier);

			yield return null;
		}

		StartCoroutine(FadeToOcean());

		while (Vector2.Distance(oceanRect.anchoredPosition, oceanShiftPos) > 0.01f)
		{
			oceanRect.anchoredPosition = Vector2.Lerp(oceanRect.anchoredPosition, oceanShiftPos, Time.deltaTime / Constant_Manager.ShiftMultiplier);

			yield return null;
		}
	}

	private IEnumerator FadeToOcean()
	{
		float ElapsedTime = 0.0f;

		while (ElapsedTime < 1.0f)
		{
			ElapsedTime += Time.deltaTime * Constant_Manager.FadeMultiplier;

            background.color = Color.Lerp(UI_Manager.Inst.DarkTealColor, UI_Manager.Inst.LightTealColor, ElapsedTime);
			oceanFloor.color = Color.Lerp(UI_Manager.Inst.WhiteAlpha, UI_Manager.Inst.WhiteColor, ElapsedTime);

            yield return null;
        }

		ChangeScene();
	}
	
// ---------------------------------------- END: ENUMERATOR FUNCTIONS ----------------------------------------
// ---------------------------------------- START: METHOD FUNCTIONS ----------------------------------------
	private void ChangeScene()
	{
		Core_Manager.Inst.WriteLog(this.GetType().Name, "Changing to next scene.");

		nextSceneName = Core_Manager.Inst.Scene_01;

		Core_Manager.Inst.ChangeScene(nextSceneName);
	}

	private void StartBubbles()
	{
		Core_Manager.Inst.WriteLog(this.GetType().Name, "Bubble wall has been triggered.");

		bubblesPage.Play();
	}
	
// ---------------------------------------- END: METHOD FUNCTIONS ----------------------------------------
#endregion
}}