using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject player;
    public Rigidbody2D PlayerRigid;
    public float speed;
    public float jumpspeed;
    private bool jumping;
    public bool death;
    public bool isGround;
    public Animator animator;
    public bool left = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        animator.speed = 0;
        if (Input.GetKey(KeyCode.D)) {
            animator.speed = 1;
            left = false;
            PlayerRigid.velocity=new Vector2(speed,PlayerRigid.velocity.y);          
        }
        else if (Input.GetKey(KeyCode.A))
        {
            animator.speed = 1;
            left = true;
            PlayerRigid.velocity = new Vector2(-speed, PlayerRigid.velocity.y);           
        }
        animator.SetBool("left", left);
        if (Input.GetKeyDown(KeyCode.W)&&isGround)
        {
            PlayerRigid.AddForce(new Vector2(0,jumpspeed));
            isGround = false;
        }
        if (death == true)
        {
            death = false;
            player.transform.position = new Vector2(0, 0);
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("OnCollisionEnter2D: " + collision.gameObject.name);
        if(collision.gameObject.tag=="Needle")death = true;
        if (collision.gameObject.tag == "Ground") { isGround = true; }
    }
    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground") isGround = true;
    }
}
