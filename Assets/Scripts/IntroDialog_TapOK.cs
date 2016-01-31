using UnityEngine;
using System.Collections;
using TouchScript.Gestures;
using System;

public class IntroDialog_TapOK : MonoBehaviour {

	private TapGesture tapGesture;
	public GameObject intro_dialog;

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
		intro_dialog.GetComponent<Animator>().Play("intro_dialog_close");
	}
}
