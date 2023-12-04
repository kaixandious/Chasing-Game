using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.UI;

public class DialogueTrigger : MonoBehaviour
{
    public Message[] messages;
    public Actor[] actors;

    public Message[] GetMessages()
    {
        return messages;
    }

    public void StartDialogue(Message[] messages)
    {
        FindObjectOfType<DialogueManager>().OpenDialogue(messages, actors);
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
}
