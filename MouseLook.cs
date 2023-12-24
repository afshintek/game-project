
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MouseLook : MonoBehaviour {

    public float MouseSens = 80f;
    public Transform PlayerBody;

    public float Xrotatin = 0f;

        void Start(){

            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;

        }

        void Update(){

            float MouseX = Input.GetAxis("Mouse X") * MouseSens * Time.deltaTime;
            float MouseY = Input.GetAxis("Mouse Y") * MouseSens * Time.deltaTime;

            Xrotatin -= MouseY;
            Xrotatin = Mathf.Clamp(Xrotatin, -90f ,90f );

            transform.localRotation = Quaternion.Euler(Xrotatin,0f,0f);
            PlayerBody.Rotate(Vector3.up * MouseX);

        }
}
