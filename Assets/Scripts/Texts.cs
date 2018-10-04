using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Texts : MonoBehaviour {

    public Text countText;
    public Text winText;
    public Text yourText;
    public Text yourCountText;
    private int count;

    private bool displayWinText = false;
    private bool displayCountText = false;

    void Start ()
    {
        SetCountText();
        winText.text = "";
        yourText.text = "";
        yourCountText.text = "";
        count = 0;
    }
	
	void Update ()
    {
		if(displayWinText == true)
        {
            winText.text = "You Won!";
            yourText.text = "Your score:";
            yourCountText.text = count.ToString();
        }

        if(displayCountText == true)
        {
            count = count + 1;
            SetCountText();
            displayCountText = false;
        }
	}

    public void winTextDisplay()
    {
        displayWinText = true;
    }

    public void countTextDisplay()
    {
        displayCountText = true;
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
    }
}
