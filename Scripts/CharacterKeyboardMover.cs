using System.Collections;
using UnityEngine;


/**
 * This component moves a player controlled with a CharacterController using the keyboard.
 */
[RequireComponent(typeof(CharacterController))]
public class CharacterKeyboardMover: MonoBehaviour {
    [Tooltip("Speed of player keyboard-movement, in meters/second")]
    [SerializeField] float speed = 30f;
    [SerializeField] float gravity = 9.81f;
    private Animator animator;

    private CharacterController cc;
    void Start() {
        cc = GetComponent<CharacterController>();
        animator = GetComponentInChildren<Animator>();
    }

    Vector3 velocity;

    void Update()  {
        if (cc.isGrounded) {
            
            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");

            if(x != 0 || z != 0){
                animator.SetBool("walk", true);
            }
            else{
                animator.SetBool("walk", false);
            }
            velocity.x = x * speed;
            velocity.z = z * speed;

            if(Input.GetKey(KeyCode.Space)){
                animator.SetBool("dig", true);
            }
            else{
                animator.SetBool("dig", false);
            }
        } else {
           velocity.y -= gravity*Time.deltaTime;
        }

        //Move in the direction you look:
        //velocity = transform.TransformDirection(velocity);

        cc.Move(velocity * Time.deltaTime);
    }
}
