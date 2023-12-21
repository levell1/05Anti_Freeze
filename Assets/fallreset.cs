using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallreset : MonoBehaviour
{

    public GameObject player;

    public Transform spawn;
    private void OnTriggerEnter(Collider collision) // 채택, ontriggerenter는 자원을 캘 때 적합
    {
        if (collision.CompareTag("Player"))
        {
            player.transform.position = spawn.position;
        }
    }
}
