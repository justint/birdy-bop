using UnityEngine;
using System.Collections;
using TouchScript.Gestures;
using System;

public class Menu_TapStart : MonoBehaviour {

    private TapGesture tapGesture;

    private void OnEnable()
    {
        tapGesture = GetComponent<TapGesture>();

        tapGesture.Tapped += tappedHandler;

        Debug.Log("Subscribed to tap");

    }

    private void OnDisable()
    {
       tapGesture.Tapped -= tappedHandler;
    }

    private void tappedHandler(object sender, EventArgs e)
    {
        Debug.Log("Tap registered");
        FadeOut();
    }

    private void FadeOut()
    {
        // Insert fade out
        
        Application.LoadLevel(1);
    }

}
