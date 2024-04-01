using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DialogueSystem : MonoBehaviour
{
    public Text txtName;
    public Text txtSentence;

    Queue<string> names = new Queue<string>();
    Queue<string> sentences = new Queue<string>();

    public void Begin(Dialogue info){
        sentences.Clear();
        
        foreach (var name in info.names)
        {
            names.Enqueue(name);
        }

        foreach (var sentence in info.sentences)
        {
            sentences.Enqueue(sentence);
        }
        
        Next();
    }

    public void Next(){
        if(sentences.Count == 0){
            End();
            return;
        }
        txtSentence.text = sentences.Dequeue();
        txtName.text = names.Dequeue();
    }

    private void End(){
        txtSentence.text = string.Empty;
        txtName.text = string.Empty;
    }
}

