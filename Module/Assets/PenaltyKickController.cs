using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenaltyKickController : MonoBehaviour
{
    public GameObject ball;
    public float forceMultiplier = 10f;

    private Rigidbody ballRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        ballRigidbody = ball.GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 forceDirection = (ball.transform.position - transform.position).normalized;
            ballRigidbody.AddForce(forceDirection * forceMultiplier, ForceMode.Impulse);
        }
    }
}