using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(this.gameObject);
    }

    // �߻�ü�� ���������� �߻�
    private void FixedUpdate()
    {
        transform.Translate(speed * Time.deltaTime * Vector2.up);
    }
}
