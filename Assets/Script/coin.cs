using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public int coinValue = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerMovement player = collision.GetComponent<PlayerMovement>();
        if (player != null)
        {
            player.addCoin(coinValue);
            Destroy(gameObject);
        }
    }
}

