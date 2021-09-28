using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour
{
    public float speed = 10f;
    public float jumpForce = 8f;
    public float gravity = 30f;
    public Vector3 moveDir = Vector3.zero;
    private Animator anim;
    public AudioSource son;
   

    void Start()
    {
        anim = GetComponent<Animator>();
    
    }

    void Update()
    {
        CharacterController controller = gameObject.GetComponent<CharacterController>();

        if (controller.isGrounded)
        {
            moveDir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

            moveDir = transform.TransformDirection(moveDir);

            moveDir *= speed;

            if (Input.GetButtonDown("Jump"))
            {
                moveDir.y = jumpForce;
            }

            if (moveDir.x < 0)
            {
                transform.localScale = new Vector3(-0.5f, 0.5f, 0.5f);
            }
            else if (moveDir.x > 0)
            {
                transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            }

            /*if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow))
            {
                anim.Play("Walk", -1, 0f);
            }
            else if (Input.GetKeyUp(KeyCode.RightArrow) && Input.GetKeyUp(KeyCode.LeftArrow) && Input.GetKeyUp(KeyCode.UpArrow) && Input.GetKeyUp(KeyCode.DownArrow))
            {
                anim.enabled= false;
            }*/

            if (moveDir.x != 0 || moveDir.z != 0)
            {
                anim.SetBool("SiCamina", true);
                son.Play();
            }
            else
            {
                anim.SetBool("SiCamina", false);
                son.Stop();
            }

           
        }   
            




        moveDir.y -= gravity * Time.deltaTime;
        controller.Move(moveDir * Time.deltaTime);

    }
}