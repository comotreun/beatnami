using System.Collections;
using UnityEngine;

public class HammerAnimation : MonoBehaviour
{
    public float rotationAngle = 90f; // 90�� ȸ��
    public float rotationDuration = 0.1f; // 0.1�ʾ� ������
    public float pauseDuration = 0.2f; // 0.2�ʸ���

    private Quaternion originalRotation;

    void Start()
    {
        originalRotation = transform.rotation;
        StartCoroutine(RotateHammer());
    }

    IEnumerator RotateHammer()
    {
        while (true)
        {
            // Rotate to the right
            Quaternion targetRotation = originalRotation * Quaternion.Euler(0f, 0f, -rotationAngle);
            float t = 0f;
            while (t < 1f)
            {
                t += Time.deltaTime / rotationDuration;
                transform.rotation = Quaternion.Lerp(originalRotation, targetRotation, t);
                yield return null;
            }

            yield return new WaitForSeconds(pauseDuration);

            // Rotate back to original rotation
            t = 0f;
            while (t < 1f)
            {
                t += Time.deltaTime / rotationDuration;
                transform.rotation = Quaternion.Lerp(targetRotation, originalRotation, t);
                yield return null;
            }

            yield return new WaitForSeconds(pauseDuration);
        }
    }
}