using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour {
    public Vector3 GetStartPoint() {
        if (Input.GetMouseButtonDown(0)) {
            return Input.mousePosition;
        }
        return Vector3.zero;
    }

    public Vector3 GetEndPoint() {
        if (Input.GetMouseButtonUp(0)) {
            return Input.mousePosition;
        }
        return Vector3.zero;
    }
}
