using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public Transform plane;
    private Vector3 offset;
    public float smoothSpeed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - plane.position;
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        MoveCamWithLerp();
    }

    private void MoveCamWithoutLerp()
    {
        transform.position = plane.transform.position + offset;
    }

    private void MoveCamWithLerp()
    {
        Vector3 expectedPosition = plane.position + offset;

        Vector3 smoothPosition = Vector3.Lerp(transform.position, expectedPosition, smoothSpeed);

        transform.position = smoothPosition;
    }
}
