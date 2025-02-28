using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 6.0f; // Speed of movement
    private Rigidbody rigidBody; // Reference to the RigidBody component: THE PLAYER MUST HAVE THIS

    void Start() {
        rigidBody = GetComponent<Rigidbody>();
    }

    void Update() {
        // Input to move the character
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Calculate the direction of the movement
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        // Use the rigidbody  method Move to move
        rigidBody.MovePosition(transform.position + movement * speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name.StartsWith("Coin"))
        {
            Destroy(other.gameObject);
        }
    }
}
