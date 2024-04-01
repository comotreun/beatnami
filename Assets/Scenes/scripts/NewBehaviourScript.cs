using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private float moveSpeed = 50f;

    void Update()
    {
        // 화면이 왼쪽에서 오른쪽으로 이동
        transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        
        // 화면이 지나가면 처음 화면으로 다시 이동하도록
        if(transform.position.x < -10) {
            transform.position += new Vector3(0, 20f, 0);
        }
    }
}