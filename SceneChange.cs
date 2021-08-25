using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

public class SceneChange : MonoBehaviour {

// ------------------------------ START: LIST OF VARIABLES ------------------------------
// -------------------- PUBLIC VARIABLES --------------------


// -------------------- PRIVATE VARIABLES --------------------


// -------------------- STATIC VARIABLES --------------------
    // List of Scenes
    public static string Scene00 = "00FerrymanLogo";
    public static string Scene01 = "01MainLogo";
    public static string Scene02 = "02MainMenu";
    public static string Scene03 = "03LearnToPlay";
    public static string Scene04 = "04PlayByEar";
    public static string Scene05 = "05Performance";
    public static string Scene06 = "06FreeJam";

// ------------------------------ END: LIST OF VARIABLES ------------------------------
// ------------------------------ START: CALLING OTHER SCRIPTS ------------------------------



// ------------------------------ END: CALLING OTHER SCRIPTS ------------------------------
// ------------------------------ START: CALLING INITIAL FUNCTIONS ------------------------------
// -------------------- START FUNCTION --------------------
    void Start() {

    }

// -------------------- AWAKE FUNCTION --------------------
    void Awake() {
        
    }

// -------------------- UPDATE FUNCTION --------------------
    void Update() {
        
    }

// ------------------------------ END: CALLING INITIAL FUNCTIONS ------------------------------
// ------------------------------ START: OTHER FUNCTIONS ------------------------------
// -------------------- SCENE CHANGE FUNCTIONS --------------------
    // Load Scene00 - Ferryman Logo Scene
    public void Scene00Load() {
        SceneManager.LoadScene(Scene00);
    }

    // Load Scene01 - Main Logo Scene
    public void Scene01Load() {
        SceneManager.LoadScene(Scene01);
    }

    // Load Scene02 - Main Menu Scene
    public void Scene02Load() {
        SceneManager.LoadScene(Scene02);
    }

    // Load Scene03 - Learn To Play Scene
    public void Scene03Load() {
        SceneManager.LoadScene(Scene03);
    }

    // Load Scene04 - Play By Ear Scene
    public void Scene04Load() {
        SceneManager.LoadScene(Scene04);
    }

    // Load Scene05 - Performance Scene
    public void Scene05Load() {
        SceneManager.LoadScene(Scene05);
    }

    // Load Scene06 - Free Jam Scene
    public void Scene06Load() {
        SceneManager.LoadScene(Scene06);
    }

// ------------------------------ END: OTHER FUNCTIONS ------------------------------

}