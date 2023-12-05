using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.UI;
using static DialogueTrigger;

public class DialogueManager : MonoBehaviour
{
    public Image actorImage;
    public Text actorName;
    public Text messageText;
    public RectTransform backgroundBox;

    Message[] currentMessages;
    Actor[] currentActors;
    int ActiveMessage = 0;
    public static bool isActive = false;

    public void OpenDialogue(Message[] messages, Actor[] actors)
    {
        currentMessages = messages;
        currentActors = actors;
        ActiveMessage = 0;
        isActive = true;
        Debug.Log("Started Dialogue. Loaded Message: " + messages.Length);
        DisplayMessage();
    }

    public void DisplayMessage()
    {
        Message MessageToDisplay = currentMessages[ActiveMessage];
        messageText.text = MessageToDisplay.message; ;

        Actor ActorToDisplay = currentActors[ActiveMessage];
        actorName.text = ActorToDisplay.name;
        actorImage.sprite = actorImage.sprite;
    }

    public void NextMessage()
    {
        ActiveMessage++;
        if (ActiveMessage >= currentMessages.Length)
        {
            DisplayMessage();
        }
        else
        {
            Debug.Log("Conversation ended.");
            isActive = false;
        }
    }
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isActive == true)
        {
            NextMessage();
        }
    }
}
