using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    private float JumpForce = 50f;
    private float MoveSpeed = 5f;
    private bool isJumping = false;
    private float moveHorizontal;
    private float moveVertical;
    public Animator squashStretchAnimator;
    private bool canswing = true;
    public float SwordReload = 0f;
    public Animator SwingAnim;
    public float hp = 3;
    public Player2Controller pc;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        moveHorizontal = Input.GetAxisRaw("Horizontal");
        moveVertical = Input.GetAxisRaw("Vertical");
        
        if (SwordReload >= 0f)
        {
            SwordReload -= Time.deltaTime;
            Debug.Log(SwordReload);
        }
        if (SwordReload <= 0f)
        {
            canswing = true;
        }
    }
    
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Q) && canswing == true)
        {
            SwingAnim.SetTrigger("Swing");
            canswing = false;
            SwordReload = 3f;

        }
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        if (moveHorizontal > 0.1f || moveHorizontal < -0.1f)
        {
            rb.AddForce(new Vector2(moveHorizontal * MoveSpeed, 0f), ForceMode2D.Impulse);
        }
        if (!isJumping && moveVertical > 0.1f )
        {
            squashStretchAnimator.SetTrigger("Jump");
            rb.AddForce(new Vector2(0f, moveVertical * JumpForce), ForceMode2D.Impulse);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            isJumping = false;
        }
        if(collision.gameObject.tag == "sword")
        {
            pc = collision.gameObject.GetComponentInParent<Player2Controller>();
            if (pc.Damage(hp))
            {
                //do things put a reset player script here
                hp = 3;
            }
            else { hp -= 1; }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            isJumping = true;
        }
    }
    public bool Damage(float hp)
    {
        hp -= 1;
        if(hp<=0)
        {
            return true;
        }
        return false;
    }
}
