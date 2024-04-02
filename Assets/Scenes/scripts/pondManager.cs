using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pond1 : MonoBehaviour
{

    public int bpm = 0;
    double currentTiem = 0d;

    [SerializeField] Transform tfNotcAppear = null;
    [SerializeField] GameObject goNote = null;

    // Update is called once per frame
    void Update()
    {
        currentTiem += Time.deltaTime;

        if (currentTiem >= 60d / bpm)
        {
            GameObject t_note = Instantiate(goNote, tfNotcAppear.position, Quaternion.identity);
            t_note.transform.SetParent(this.transform);
            currentTiem -= 60d / bpm;    //0���� ���ϴ� ���� ������� ������ ���� ���� ���� 
        }
    }
}
