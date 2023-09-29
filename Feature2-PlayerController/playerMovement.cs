using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class playerMovement : MonoBehaviour
{
    public Animator animator;
    public GameObject theNpc;
    private void Update()
    {
        float speed = Input.GetAxisRaw("Horizontal");
        animator.SetFloat("Speed",Mathf.Abs(speed));

        Vector3 scale = transform.localScale;

        if (speed < 0)
        {
            scale.x = -1f * Mathf.Abs(scale.x);
        }

        else if (speed > 0)
        {
            scale.x = Mathf.Abs(scale.x);
        }
        transform.localScale = scale;

        if (Input.GetButtonDown("Jump"))
        {
            theNpc.GetComponent<Animator>().Play("Player_Jump");
        }
        else if (Input.GetButtonUp("Jump"))
        {
            theNpc.GetComponent<Animator>().Play("Player_Idle");
        }

        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            theNpc.GetComponent<Animator>().Play("Player_Crouch");
        }
        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            theNpc.GetComponent<Animator>().Play("Player_Idle");
        }
    }
}
