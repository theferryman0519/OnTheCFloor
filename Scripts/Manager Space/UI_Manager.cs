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

namespace ManagerSpace {
public class UI_Manager : MonoBehaviour {
		
#region Variables
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- PUBLIC VARIABLES ---------------
	public int ScreenWidth;
    public int ScreenHeight;

    public Color WhiteColor = new Color(1.0f, 1.0f, 1.0f, 1.0f); // #ffffff
    public Color CharcoalColor = new Color(0.2f, 0.2f, 0.2f, 1.0f); // #333333
    public Color DarkTealColor = new Color(0.0f, 0.094f, 0.208f, 1.0f); // #001835
    public Color LightTealColor = new Color(0.047f, 0.459f, 0.588f, 1.0f); // #0C7596

    public Color WhiteAlpha = new Color(1.0f, 1.0f, 1.0f, 0.0f); // #ffffff
    public Color CharcoalAlpha = new Color(0.2f, 0.2f, 0.2f, 0.0f); // #333333
	
// --------------- STATIC VARIABLES ---------------
	public static UI_Manager Inst
    {
        get { return UIManagerInstance; }
    }
    
    private static UI_Manager UIManagerInstance = null;
	
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
		if ((UIManagerInstance != null) && (UIManagerInstance != this))
        {
            Destroy(this.gameObject);
            return;
        }
        
        else
        {
            UIManagerInstance = this;
        }
        
        DontDestroyOnLoad(this.gameObject);

        ScreenWidth = Screen.width;
        ScreenHeight = Screen.height;
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update()
	{
		
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: ENUMERATOR FUNCTIONS ----------------------------------------
	private IEnumerator ObjectsFadingIn(List<Image> allImages, List<TMP_Text> allWhiteTexts, List<TMP_Text> allCharcoalTexts, Action continueAction)
    {
        float ElapsedTime = 0.0f;

		while (ElapsedTime < 1.0f)
		{
			ElapsedTime += Time.deltaTime * Constant_Manager.FadeMultiplier;

            foreach (Image image in allImages) { image.color = Color.Lerp(WhiteAlpha, WhiteColor, ElapsedTime); }
            foreach (TMP_Text text in allWhiteTexts) { text.color = Color.Lerp(WhiteAlpha, WhiteColor, ElapsedTime); }
            foreach (TMP_Text text in allCharcoalTexts) { text.color = Color.Lerp(CharcoalAlpha, CharcoalColor, ElapsedTime); }

            yield return null;
        }

        continueAction?.Invoke();
    }

    private IEnumerator ObjectsFadingOut(List<Image> allImages, List<TMP_Text> allWhiteTexts, List<TMP_Text> allCharcoalTexts, Action continueAction)
    {
        float ElapsedTime = 0.0f;

		while (ElapsedTime < 1.0f)
		{
			ElapsedTime += Time.deltaTime * Constant_Manager.FadeMultiplier;

            foreach (Image image in allImages) { image.color = Color.Lerp(WhiteColor, WhiteAlpha, ElapsedTime); }
            foreach (TMP_Text text in allWhiteTexts) { text.color = Color.Lerp(WhiteColor, WhiteAlpha, ElapsedTime); }
            foreach (TMP_Text text in allCharcoalTexts) { text.color = Color.Lerp(CharcoalColor, CharcoalAlpha, ElapsedTime); }

            yield return null;
        }

        continueAction?.Invoke();
    }
	
// ---------------------------------------- END: ENUMERATOR FUNCTIONS ----------------------------------------
// ---------------------------------------- START: METHOD FUNCTIONS ----------------------------------------
	public void SetAllObjectsToAlpha(List<Image> allImages, List<TMP_Text> allWhiteTexts, List<TMP_Text> allCharcoalTexts)
    {
        foreach (Image image in allImages) { image.color = WhiteAlpha; }
        foreach (TMP_Text text in allWhiteTexts) { text.color = WhiteAlpha; }
        foreach (TMP_Text text in allCharcoalTexts) { text.color = CharcoalAlpha; }
    }

    public void FadeInAllObjects(List<Image> allImages, List<TMP_Text> allWhiteTexts, List<TMP_Text> allCharcoalTexts, Action continueAction)
    {
        StopAllCoroutines();

        SetAllObjectsToAlpha(allImages, allWhiteTexts, allCharcoalTexts);

        StartCoroutine(ObjectsFadingIn(allImages, allWhiteTexts, allCharcoalTexts, continueAction));
    }

    public void FadeOutAllObjects(List<Image> allImages, List<TMP_Text> allWhiteTexts, List<TMP_Text> allCharcoalTexts, Action continueAction)
    {
        StopAllCoroutines();

        StartCoroutine(ObjectsFadingOut(allImages, allWhiteTexts, allCharcoalTexts, continueAction));
    }
	
// ---------------------------------------- END: METHOD FUNCTIONS ----------------------------------------
#endregion
}}