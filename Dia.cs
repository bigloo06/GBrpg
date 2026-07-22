using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Dia : MonoBehaviour
{
    public TextMeshProUGUI txt;
    public TextMeshProUGUI speakerTxt;
    public string[] lines;
    public string[] speakers;
    public float textspeed;
    private int index;
    private bool active = false;
    void Start()
    {
        txt.text = string.Empty;
        gameObject.SetActive(false);
    }
    void Update()
    {
        if (!active)
        {
            return;
        }
        if (Input.GetMouseButtonDown(0))
        {
            if (txt.text == lines[index])
            {
                nextLine();
            }
            else
            {
                StopAllCoroutines();
                txt.text = lines[index];
            }
        }
    }

    public void startDia()
    {
        active = true;
        index = 0;
        txt.text = string.Empty;
        updateSpeaker();
        StopAllCoroutines();
        StartCoroutine(TypeLine());
    }
    IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            txt.text += c;
            yield return new WaitForSeconds(textspeed);
        }
    }

    void nextLine()
    {
        if (index < lines.Length - 1)
        {
            index++;
            updateSpeaker();
            txt.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            active = false;
            gameObject.SetActive(false);
        }
    }
    void updateSpeaker()
    {
        if (index < speakers.Length)
        {
            speakerTxt.text = speakers[index];
        }
        else
        {
            speakerTxt.text = "";
        }
    }
}
