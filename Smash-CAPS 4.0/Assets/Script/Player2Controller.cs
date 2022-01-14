using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player2Controller : MonoBehaviour
{
    public Rigidbody2D rbu;
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
    public PlayerController pc;
    public Transform rp;
    public Transform attackpoint;
    public float attackrange = 0.5f;
    public LayerMask enemyLayers;
    public ParticleSystem Dust;
    bool hashit;
    public Text score;
    public float pscore;
    public Transform sp;
    public Transform bp;
    public GameObject sprite;
    // Start is called before the first frame update
    void Start()
    {
        charmanger myObject = FindObjectOfType<charmanger>();
        sprite.GetComponent<SpriteRenderer>().sprite = myObject.p2s;
    }

    // Update is called once per frame
    void Update()
    {
        moveHorizontal = Input.GetAxisRaw("PlayerHorizontal");
        moveVertical = Input.GetAxisRaw("PlayerVertical");

        if (SwordReload >= 0f)
        {
            SwordReload -= Time.deltaTime;
        }
        if (SwordReload <= 0f)
        {
            canswing = true;
            hashit = false;
        }
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space) && canswing == true)
        {
            SwingAnim.SetTrigger("Swing");
            canswing = false;
            SwordReload = 3f;
            Collider2D[] hitenemies = Physics2D.OverlapCircleAll(attackpoint.position, attackrange, enemyLayers);
            foreach (Collider2D enemy in hitenemies)
            {
                Debug.Log("we hit");
                if (hashit == false)
                {
                    pc = enemy.gameObject.GetComponentInParent<PlayerController>();
                    pc.CreateDust();
                    if (pc.Damage() == true)
                    {
                        pscore += 1;
                        rbu.transform.position = rp.position;
                        score.text = " " + pscore;
                        hp = 3;
                    }
                    hashit = true;
                }

            }

        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            attackpoint = bp;
            SwingAnim.gameObject.transform.position = bp.transform.position;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        { attackpoint = sp; SwingAnim.gameObject.transform.position = sp.transform.position;  }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        if (moveHorizontal > 0.1f || moveHorizontal < -0.1f)
            {
                rbu.AddForce(new Vector2(moveHorizontal * MoveSpeed, 0f), ForceMode2D.Impulse);
            }
        if (!isJumping && moveVertical > 0.1f)
        {
            squashStretchAnimator.SetTrigger("Jump");
            rbu.AddForce(new Vector2(0f, moveVertical * JumpForce), ForceMode2D.Impulse);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            isJumping = false;
        }
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            isJumping = true;
        }
    }
    public bool Damage()
    {
        hp -= 1;
        if(hp <= 0)
        {
            rbu.transform.position = rp.position;
            hp = 3;
            return true;
        }
        return false;
    }
    public void CreateDust()
    {
        Dust.Play();
    }
}
