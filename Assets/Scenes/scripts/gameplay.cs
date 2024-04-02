using UnityEngine;

public class ImageMovement : MonoBehaviour
{
    public float pondSpeed = 400;

    private void Update()
    {
        transform.localPosition += Vector3.right * pondSpeed * Time.deltaTime;
    }

}
