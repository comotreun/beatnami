using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DialogueTrigger : MonoBehaviour
{
    public Dialogue info;

    public void Tigger(){
       var system =  FindObjectOfType<DialogueSystem>();
       system.Begin(info);
    }

    void Start() {
    DialogueTrigger dialogueTrigger = GetComponent<DialogueTrigger>();
    dialogueTrigger.Tigger();
}
}