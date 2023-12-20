using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Colliderenviron : MonoBehaviour
{
    public GameObject itself;
    public void OnTriggerEnter(Collider collision) // 채택, ontriggerenter는 자원을 캘 때 적합
    {
        
    }

    private void OnTriggerStay(Collider collision)
    {
        if (Input.GetKeyUp(KeyCode.Alpha1)) // 임시로 바위 제거
        {
            if (collision.CompareTag("pickax"))
            {
                Debug.Log("임시로 제거");
                this.gameObject.SetActive(false); // 자원 비활성화

                //위까지가 taehyeong 브랜치 안 코드고, 이 밑으로 다른 분들 코드 추가하면 됩니다.
            }

            Debug.Log("자원 채광 중");
        }
    }
}


