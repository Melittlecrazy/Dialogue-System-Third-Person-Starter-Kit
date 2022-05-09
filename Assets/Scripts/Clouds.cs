using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clouds : MonoBehaviour
{
    Vector3 location;
    Vector3 acceleration;
    Vector3 velocity;

    float topSpeed;
    float maxX, maxY, maxZ, minX, minY, minZ;

    void Start()
    {
        maxX = 250f;
        minX = -250f;
        maxY = 50f;
        minY = 20f;
        maxZ = 250f;
        minZ = -250f;


        location = this.gameObject.transform.position;
        velocity = Vector3.zero;
        acceleration = new Vector3(-0.1f, 0f, -1f);
        topSpeed = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        velocity += acceleration * Time.deltaTime;

        velocity = Vector3.ClampMagnitude(velocity, topSpeed);

        location += velocity * Time.deltaTime;
        checkEdges();
        this.gameObject.transform.position = new Vector3(location.x, location.y, location.z);


    }
    void checkEdges()
    {
        if (location.x > maxX)
        {
            location.x -= maxX - minX;
        }
        else if (location.x < minX)
        {
            location.x += maxX - minX;
        }
        if (location.y > maxY)
        {
            location.y -= maxY - minY;
        }
        else if (location.y < minY)
        {
            location.y += minY - minY;
        }
        if (location.z > maxZ)
        {
            location.z -= maxZ - minZ;
        }
        else if (location.z < minZ)
        {
            location.z += maxZ - minZ;
        }
    }
}
