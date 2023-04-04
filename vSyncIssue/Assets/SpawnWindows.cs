using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class SpawnWindows : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI numDisplaysTxt;

    private int numDisplays;

    void Start()
    {
        if (!Application.isEditor)
        {
            StartCoroutine(DelayThenInitDisplays(2f));
        }

        numDisplays = Display.displays.Length;

        numDisplaysTxt.text = $"Num Displays: {numDisplays}";
    }

    IEnumerator DelayThenInitDisplays(float delaySec)
    {
        yield return new WaitForSeconds(delaySec);
        InitDisplays();
    }


    void InitDisplays()
    {
        for (var i = 0; i < numDisplays; i++)
        {
            var display = Display.displays[i];

            if (i == 0)
            {
                display.Activate(0, 0, 0);
            }
            else
            {
                display.Activate();
            }

            var w = display.systemWidth;
            var h = display.systemHeight;

            display.SetParams(w,h,0,0);
        }
    }
}
