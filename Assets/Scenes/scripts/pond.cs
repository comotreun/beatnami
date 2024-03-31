using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pond : MonoBehaviour
{

     public SpriteRenderer pondRenderer; // Pond의 SpriteRenderer 컴포넌트 저장 변수
    // Start is called before the first frame update
    void Start()
    {
         pondRenderer = this.GetComponent<SpriteRenderer>(); // pond 스크립트에 연결된 SpriteRenderer 가져오도록 수정
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void A(){
        Console.WriteLine("sfwe");
    }

}
