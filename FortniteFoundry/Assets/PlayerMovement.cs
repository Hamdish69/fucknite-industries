using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private Transform tf;
    private bool isFacingRight;
    public float vel;
    private bool turn;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        tf = GetComponent<Transform>();

        Debug.Log("Hello World");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            tf.Translate(new Vector3(vel,0,0)*Time.deltaTime, Space.World);
            isFacingRight = true;
        }

        if (Input.GetKey(KeyCode.A))
        {
            tf.Translate(new Vector3(-vel, 0, 0) * Time.deltaTime, Space.World);
            isFacingRight = false;
            
        }
        // Put in extra/more complex if statements/booleans to make sure things dont repeat
        if(isFacingRight == true && turn == true)
        {
            tf.Rotate(Vector3.up * 180); // This should only run once before it turns off
            // Make it so that e.g. 'isFacingRight' is only true ONCE so that it doesnt keep rotating
            turn = false;

        }
        if(isFacingRight == false && turn == false)
        {
            tf.Rotate(Vector3.up * 180);
            turn = true;
        }
    }

    void FixedUpdate()
    {
        
    }
}
