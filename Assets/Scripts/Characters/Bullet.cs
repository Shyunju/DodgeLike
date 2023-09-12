using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [Header("Status")]
    public int damage;
    public float speed;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Player") && !collision.CompareTag("Item"))
        {
            Destroy(this.gameObject);
        }
    }

    // �߻�ü�� ���������� �߻�
    private void FixedUpdate()
    {
        transform.Translate(speed * Time.deltaTime * Vector2.up);
    }
}
