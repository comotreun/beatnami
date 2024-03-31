using UnityEngine;
using System.Collections; // 추가

public class RotateImage : MonoBehaviour
{
    public KeyCode rotateKey = KeyCode.Space; //스페이스
    public float rotationAngle = 35f; // 돌아가는 도

    private bool isRotating = false;

    void Start()
    {
         GameObject pondAfter = GameObject.Find("pondAfter");
        SpriteRenderer pondAfterRenderer = pondAfter.GetComponent<SpriteRenderer>();
        Color color = pondAfterRenderer.color;
        color.a = 0f; 
        pondAfterRenderer.color = color;
    }

    void Update()
    {
        if (Input.GetKeyDown(rotateKey) && !isRotating)
        {
            // 가운데 중심 35도 돌아감
            transform.Rotate(Vector3.forward, rotationAngle);
            isRotating = true;
            StartCoroutine(ReverseRotation());
        }
    }

    // 투명도 조절
    public void ChangeTransparencyPond(float transparency)
    {
        // 박기 전 못
        GameObject pond = GameObject.Find("pond");
        SpriteRenderer pondRenderer = pond.GetComponent<SpriteRenderer>();
        Color pondColor = pondRenderer.color;
        pondColor.a = transparency; 
        pondRenderer.color = pondColor;
    }

      public void ChangeTransparencyAfterPond(float transparency)
    {
       // 박은 후 못
        GameObject pondAfter = GameObject.Find("pondAfter");
        SpriteRenderer pondAfterRenderer = pondAfter.GetComponent<SpriteRenderer>();
        Color pondAfterColor = pondAfterRenderer.color;
        pondAfterColor.a = transparency; 
        pondAfterRenderer.color = pondAfterColor; 
    }

    IEnumerator ReverseRotation()
    {
        yield return new WaitForSeconds(0.25f); //기다리는 시간
        // -35도 이동
        transform.Rotate(Vector3.forward, -rotationAngle);
        isRotating = false;

        // pond 스크립트 투명 함수
        ChangeTransparencyPond(0f);
        ChangeTransparencyAfterPond(1f);
    }

}

