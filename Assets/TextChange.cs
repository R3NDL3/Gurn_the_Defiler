using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextChange : MonoBehaviour
 
{
    public Text story;
    public GameObject Play;
    public GameObject brawl;
    public GameObject pickpocket;
    public GameObject con;
    public GameObject knight;
    public GameObject hunter;
    public GameObject wizard;
    public GameObject Title;
    // Start is called before the first frame update
    void Start()
    {
        story.text = "You are the hero of Canterburg, a town far away from the castle of Gurn.It is up to you to slay Gurn and his minions of darkness to bring Canterburg back into the graces of the gods.";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Change1()
    {
        story.text = "You awaken after a nights rest. Today you must accept your punishment, but why were you banished?";
        Play.SetActive (false);
        Title.SetActive (false);
        brawl.SetActive (true);
        pickpocket.SetActive (true);
        con.SetActive (true);
    }
    public void Brawl()
    {
        Change2();
        Stats.body += 1;
        Debug.Log(Stats.body);
    }
    public void Change2()
    {
        story.text = "Despite your criminality, you have found friends in high places. Who do you see before leaving?";
        brawl.SetActive(false);
        pickpocket.SetActive(false);
        con.SetActive(false);
        knight.SetActive(true);
        hunter.SetActive(true);
        wizard.SetActive(true);
    }
}
