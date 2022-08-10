using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowManager : MonoBehaviour
{
    public GameObject[] GuideSteps;
    public Transform StepHolder;

    private int currentStep = 0;

    void Start()
    {
        ResetFlow();
    }

    public void ChangeStep(bool isNext)
    {
        if(isNext)
        {
            if(currentStep >= GuideSteps.Length - 1)
            {
                return;
            }

            currentStep++;
        }
        else
        {
            if(currentStep <= 0)
            {
                return;
            }

            currentStep--;
        }

        HideAllSteps();
        GuideSteps[currentStep].SetActive(true);
    }

    public void ResetFlow()
    {
        HideAllSteps();
        currentStep = 0;
        GuideSteps[0].SetActive(true);
    }

    void HideAllSteps()
    {
        foreach(Transform child in StepHolder)
        {
            child.gameObject.SetActive(false);
        }
    }
}
