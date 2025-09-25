using UnityEngine;
using UnityEngine.InputSystem; // new Input System

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength = 10f;

    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame) // new system
        {
            myRigidbody.linearVelocity = Vector2.up * flapStrength;
        }
    }
}
