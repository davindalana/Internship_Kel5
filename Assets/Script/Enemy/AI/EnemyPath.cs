using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPath : MonoBehaviour
{
    [SerializeField]
    private float speed = 2f;

    private Rigidbody2D rb;
    private Vector2 moveDir;
    private KnockBack knockback;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        knockback = GetComponent<KnockBack>();
    }

    private void FixedUpdate()
    {
        if (knockback.gettingKnockedBack) { return; }
        rb.MovePosition(rb.position + moveDir * (speed * Time.fixedDeltaTime));
    }

    public void MoveTo(Vector2 targetPosition)
    {
        moveDir = targetPosition;
    }
}
