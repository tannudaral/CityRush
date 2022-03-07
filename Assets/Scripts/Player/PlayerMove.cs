using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 5;
    public float leftRightSpeed = 4;
    // public float jumpSpeed = 5;
    public Animator anims;

    void Start() {
        anims = GetComponent<Animator>();
    }
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);

        if((Input.GetKey(KeyCode.A)) || (Input.GetKey(KeyCode.LeftArrow)))
        {
            if(this.gameObject.transform.position.x > LevelBoundary.leftSide)
            {
                transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed);
            }
        }

        if((Input.GetKey(KeyCode.D)) || (Input.GetKey(KeyCode.RightArrow)))
        {
            if(this.gameObject.transform.position.x < LevelBoundary.rightSide)
            {
                transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed * -1);
            }
        }

        if((Input.GetKey(KeyCode.W)) || (Input.GetKey(KeyCode.UpArrow) || (Input.GetKey("space"))))
        {
            // transform.Translate(Vector3.up * Time.deltaTime * jumpSpeed);
            anims.SetBool("Jumping", true);
            Invoke("stop_jumping", 0.1f);
        }
    }

    void stop_jumping()
    {
        anims.SetBool("Jumping", false);
        // yield return new WaitForSeconds(0.5f);
        // transform.Translate(Vector3.down * Time.deltaTime * jumpSpeed * -1);
        // yield return new WaitForSeconds(0.5f);
    }
}
