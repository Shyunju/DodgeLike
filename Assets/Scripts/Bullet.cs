using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BulletType
{
    players,
    monsters,
}

public class Bullet : MonoBehaviour
{
    [Header("Status")]
    public BulletType type;
    public int damage;
    public float speed;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Monster") && type == BulletType.players)
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
