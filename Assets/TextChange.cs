using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextChange : MonoBehaviour
{
    public Text story;
    // Start is called before the first frame update
    void Start()
    {
        story.text = "You are the hero of Canterburg, a town far away from the castle of Gurn.It is up to you to slay Gurn and his minions of darkness to bring Canterburg back into the graces of the gods.";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Change()
    {
        story.text = "Choose your class";
    }
}
