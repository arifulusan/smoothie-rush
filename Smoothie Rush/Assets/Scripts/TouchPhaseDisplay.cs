using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TouchPhaseDisplay : MonoBehaviour
{
    // Start is called before the first frame update
    public Text phaseDisplayText;
    private Touch theTouch;
    private float timeTouchEnded;
    private float displayTime = 0.5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            theTouch = Input.GetTouch(0);
            if (theTouch.phase == TouchPhase.Ended)
            {
                phaseDisplayText.text = theTouch.phase.ToString();
                timeTouchEnded = Time.time;
            }

            else if (Time.time - timeTouchEnded > displayTime)
            {
                phaseDisplayText.text = theTouch.phase.ToString();
                timeTouchEnded = Time.time;
            }
        }

        else if (Time.time - timeTouchEnded > displayTime)
        {
            phaseDisplayText.text = "";
        }
    }
}
