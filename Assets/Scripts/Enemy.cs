using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private float _speed = 1f;

    private PlayerController _player;

    private void Awake()
    {
        _player = Object.FindObjectOfType<PlayerController>();
    }
    void Start()
    {
      
    }

    void Update()
    {
        EnemyMovement();
    }

    public void EnemyMovement()
    {
        float dir = _speed * Time.deltaTime;
        transform.position = Vector2.MoveTowards(transform.position, _player.transform.position, dir);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
        }
    }
}
