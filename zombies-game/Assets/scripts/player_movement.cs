using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    public healthbar h;
    public score a;
    public FinalScore f;
    public float maxhealth = 100;
    public float currenthealth;
    public Transform traansform;
    public float movespeed = 5f;
    public Animator animator;
    public Rigidbody2D rb;
    public AudioSource dyingsound;
    Vector2 movement;
    Vector2 temp;

    public GameObject losingtext;
    private GameObject enemyprefab;
    private float spawnRate;
    float nextspawn;
    [SerializeField] float radiusforspawning = 5;

    private void OnCollisionEnter2D(Collision2D collision)
    {
       if (collision.gameObject.tag.Equals("enemy")) {

           
            this.gameObject.SetActive(false);
            enemyprefab.SetActive(false);
            dyingsound.Play();
            losingtext.SetActive(true);
            Debug.Log("hi");
            a.scored();

        }
    }
    void Start()
        
    {
        enemyprefab = GameObject.FindGameObjectWithTag("enemy");
        losingtext.SetActive(false);
        currenthealth = maxhealth;
        h.setmaxhealth(maxhealth);
    }

    void Update()
        
    {//if (Input.GetKeyDown(KeyCode.Space)) takedamage(20);
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        animator.SetFloat("horizontal", movement.x);
        animator.SetFloat("vertical", movement.y);
        animator.SetFloat("speed", movement.sqrMagnitude);

        if (movement.x == 0 && movement.y == 0 && pauseMenu.GameIsPaused == false)
        {
            temp = transform.localScale;
            temp.x = 3;
            temp.y = 3;
            transform.localScale = temp;
            
           takedamage(1);
        }
        else
        {
            temp = transform.localScale;
            temp.x = 5;
            temp.y = 5;
            transform.localScale = temp;

        }
        spawnRate = Random.Range(3, 9);
        if (Time.time>nextspawn)
        {
            nextspawn = Time.time + spawnRate;
            Vector3 randompos = Random.insideUnitCircle * radiusforspawning;
            Instantiate(enemyprefab,randompos,Quaternion.identity);


        }
    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * movespeed * Time.fixedDeltaTime);
    }
    void takedamage(float damage)
    {
        currenthealth -= damage* Time.fixedDeltaTime;
        if (currenthealth == 0) {
            
           
            
            losingtext.SetActive(true);
           
        }
        h.sethealth(currenthealth);
    }
}
