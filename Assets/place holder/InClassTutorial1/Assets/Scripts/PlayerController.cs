using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20.0f;
    [SerializeField]
    private GameObject EndOFRoad;
    private float EndOfRoadZValue;
    private float turnspeed = 200.0f;
    private float horizontalInput;
    private float forwardInput;

    void Start()
    {
        Transform EndOfRoadTransform = EndOFRoad.GetComponent<Transform>();
        EndOfRoadZValue = EndOfRoadTransform.position.z;
    }

    void Update()
    {
        if (this.transform.position.z >= EndOfRoadZValue)
            return;

        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        transform.Rotate(Vector3.up, turnspeed * horizontalInput * Time.deltaTime);
    }
}
