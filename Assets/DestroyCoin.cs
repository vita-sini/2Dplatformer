using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCoin : MonoBehaviour
{
    [SerializeField] private GameObject _gameObject;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Players>(out Players player))
        {
            Destroy(gameObject);
        }
    }
}
