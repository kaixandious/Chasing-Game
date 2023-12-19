using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    public Queue<string> sentences;

    public void StartDialogue (Dialogue dialogue)
    {
        Debug.Log("Starting dialogue with " + dialogue.name);
        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        //DisplayNextSentences();
    }    
   /* public void DisplayNextSentences()
    {
        if(sentences.Count > 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        Debug.Log(sentence);
    }   
    
    void EndDialogue()
    {
        Debug.Log("End of Dialogue");
    }    */
}
