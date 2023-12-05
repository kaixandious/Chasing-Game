using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Message[] messages;
    public Actor[] actors;
    public void StartDialogue()
    {
        FindObjectOfType<DialogueManager>().OpenDialogue(messages, actors);
    }


}

[System.Serializable]
public class Message
{
    public int ActorId;
    public string message;
}

[System.Serializable]
public class Actor
{
    public string name;
    public Sprite sprite;
}
