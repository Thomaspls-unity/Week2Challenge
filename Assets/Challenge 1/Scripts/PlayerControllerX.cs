using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float propellerSpeed;
    public float verticalInput;
    public float horizontalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        MovePlaneForwards();
        TiltPlane();
        SpinPropeller();
    }

    private void MovePlaneForwards()
    {
        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed * Time.fixedDeltaTime);
    }

    private void TiltPlane()
    {
        verticalInput = Input.GetAxis("Vertical");
        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * verticalInput * rotationSpeed * Time.fixedDeltaTime);
    }

    private void SpinPropeller()
    {
        transform.Rotate(Vector3.back * propellerSpeed * Time.fixedDeltaTime);
    }
}
