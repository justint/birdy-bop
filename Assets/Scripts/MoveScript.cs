using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {

        // If we have one touch
	    if(Input.touchCount == 1)
        {
            Touch touch = Input.GetTouch(0);

            // Magic numbers from Unity mobile tut (link on README)
            float x = -7.5f + 15f * touch.position.x / Screen.width;
            float y = -4.5f + 9f * touch.position.y / Screen.height;

            transform.position = new Vector3(x, y, 0);
        }
	}
}
