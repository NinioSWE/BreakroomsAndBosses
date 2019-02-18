using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionTrigger : MonoBehaviour {

    [SerializeField] TriggerType triggerType;

    [SerializeField] public GameObject targetObject;
    [SerializeField] string targetName;

    enum TriggerType
    {
        ChangeScene, StartDialog, AddItem, AddTopic
    }

    public void Hover ()
    {
        Debug.Log("I AM HIGHLIGHTED!");
    }

    public void Interact()
    {
        Debug.Log(name + " has Interacted");
        if (triggerType == TriggerType.ChangeScene)
        {
            ChangeScene();
        }
        else if (triggerType == TriggerType.StartDialog)
        {
            StartDialog();
        }
        else if (triggerType == TriggerType.AddItem)
        {
            AddItem();
        }
        else if (triggerType == TriggerType.AddTopic)
        {
            AddTopic();
        }
        else
        {
            Debug.Log("Incorrect parameter for " + this);
        }
    }

    void ChangeScene ()
    {
        FindObjectOfType<MenuLogic>().ChangeScene(targetName);
    }

    void StartDialog ()
    {
        //START FUNGUS DIALOG
    }

    void AddItem ()
    {
        FindObjectOfType<Inventory>().
            AddItem(targetObject);
    }

    void AddTopic ()
    {
        FindObjectOfType<Inventory>().AddTopic(targetObject);
    }
}
