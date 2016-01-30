#pragma strict

var fadeTime = 0.01;
var textNum = 3;

function Start () {
    while (textNum > 0)
    {
        Debug.Log("Calling FadeOut");
        yield FadeOut();
        --textNum;
        GetComponent.<UnityEngine.UI.Text>().text = textNum + "!";
        GetComponent.<UnityEngine.UI.Text>().color.a = 1;
    }
    GetComponent.<UnityEngine.UI.Text>().text = "GO!";
    GetComponent.<UnityEngine.UI.Text>().color.a = 1;
    yield FadeOut();

}

function Update () {

}

function FadeOut(){
    while ( GetComponent.<UnityEngine.UI.Text>().color.a > 0 )
    {
        //Debug.Log("Decrement alpha");
        GetComponent.<UnityEngine.UI.Text>().color.a -= fadeTime + Time.deltaTime;
        yield;
    }
    Debug.Log("FadeOut complete");
    // Destroy(gameObject);
}