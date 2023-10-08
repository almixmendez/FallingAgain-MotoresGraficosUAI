using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ballControl : MonoBehaviour
{

    [SerializeField] private float force;
    [SerializeField] Rigidbody rb;
    [SerializeField] private float pointQuantity;
    [SerializeField] private Score score;
    public float jumpingStrength = 10f;
    public bool touchingGronund = true;


    private void Update()
    {
       if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * jumpingStrength, ForceMode.Impulse);
        }
       touchingGronund = false;
    }

    private void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3 (horizontalInput, 0f, verticalInput);

        rb.AddForce(direction * force, ForceMode.Force);
    }

    private void OnCollisionEnter(Collision ballCollision)
    {

        if(ballCollision.gameObject.CompareTag("Item"))
        {
            Destroy(ballCollision.gameObject);
            score.GainPoints(pointQuantity);
        }

        if (ballCollision.gameObject.CompareTag("Fallen Objects"))
        {
            SceneManager.LoadScene(0);
        }

        if (ballCollision.gameObject.CompareTag("Death"))
        {
            SceneManager.LoadScene(0);
        }

        if (ballCollision.gameObject.CompareTag("Win"))
        {
            SceneManager.LoadScene(0);
        }
    }
}
