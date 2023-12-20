using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class death : MonoBehaviour
{
    public GameObject player;

    public Transform spawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
      
    }

    private void OnTriggerEnter(Collider collision) // 채택, ontriggerenter는 자원을 캘 때 적합
    {
        if (collision.CompareTag("Player"))
        {
            player.transform.position = spawn.position;
        }
    }
}
