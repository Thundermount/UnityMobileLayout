using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine;


public class MovePadScript : MonoBehaviour {

    public RawImage MoveStick;
    Vector3 pos;
    bool hold = false;
	// Use this for initialization
	void Start () {
        pos = MoveStick.rectTransform.position; // Начальная позиция стика
	}
	
	// Update is called once per frame
	void Update () {
        if(hold)MoveStick.rectTransform.position = Vector3.ClampMagnitude(Input.mousePosition - pos, 59.0f) + pos;
    }
    public void HoldDown()
    {
        hold = true;
    }
    public void HoldUp()
    {
        MoveStick.rectTransform.position = pos;
        hold = false;
    }

}
