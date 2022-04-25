using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionTracker : MonoBehaviour
{
    public Text Text;
    private int damage;
    float color = 1;
    
    void Start()
    {
        Text.text = "";
    }

    void Update()
    {
        Text.text = "Damage: " + damage + "%";
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bang"))
        {
            Debug.Log("Don't reck my CAR!!");
            damage = damage + 1;
            color = color - 0.1f;
            gameObject.GetComponent<Renderer>().material.color = new Color(255, color, color);
            if (damage >= 100)
            {
                damage = 100;
            }
        }
    }
}
