#pragma strict

var circle_transition_menu_start : AnimationClip;
var button : GameObject;

function OnTriggerEnter() {
    GetComponent.<Animation>().Play("circle_transition_menu_start");
}

function Start () {

}

function Update () {

}