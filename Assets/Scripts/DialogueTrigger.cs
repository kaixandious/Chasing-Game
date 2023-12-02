using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Message[] messages;
    public ActorID[] actors;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    [System.Serializable]
    public class Message
    {
        public int actorID;
        public string message;
    }
    [System.Serializable]
    public class ActorID
    {
        public string name;
        public Sprite sprite;
    }
}
