using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {

        if (Input.touchCount == 1)
        {
            // Magic numbers from Unity mobile tut (link on README)

            float x = -7.5f + 15f * Input.touches[0].position.x / Screen.width;
            float y = -4.5f + 9f * Input.touches[0].position.y / Screen.height;

            transform.position = new Vector3(x, y, 0);
        }
	}
}
