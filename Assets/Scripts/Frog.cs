using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frog : MonoBehaviour
{
  private Rigidbody2D rig;
  private Animator anim;

  public float speed;

  public Transform rightCol;
  public Transform leftCol;

  public Transform headPoint;

  private bool colliding;

  public LayerMask layer;

  public BoxCollider2D boxCollider2D;
  public CircleCollider2D circleCollider2D;

  // Start is called before the first frame update
  void Start()
  {
    rig = GetComponent<Rigidbody2D>();
    anim = GetComponent<Animator>();
  }

  void Update()
  {
    rig.velocity = new Vector2(speed, rig.velocity.y);

    colliding = Physics2D.Linecast(rightCol.position, leftCol.position, layer);

    if(colliding)
    {
        transform.localScale = new Vector2(transform.localScale.x * -1f, transform.localScale.y);
        speed *= -1f;
    }
  }
  void OnTriggerEnter2D(Collider2D col)
  {
    if(col.gameObject.tag == "Player")
    {
       this.transform.gameObject.SetActive(false);

    }
  }





}
