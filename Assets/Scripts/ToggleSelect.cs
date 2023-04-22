using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class ToggleSelect : MonoBehaviour
{
    public Toggle togglebutton;
    private MeshRenderer malha;
    private Color corori;
    public Image circleProgress;
    public float totalTime = 3;
    private bool gvrStatus;
    private float gvrTimer;
    private bool isChecked;
    public UnityEvent GvrClick;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        if (gvrStatus == true)
        {
            gvrTimer += Time.deltaTime;
            circleProgress.fillAmount = gvrTimer / totalTime;
            if(gvrTimer > totalTime)
            {
                GvrClick.Invoke();

                // a parada q importa
                PlayerPrefs.SetInt("Gun", 1);
            }
        }
        else
        {
            gvrTimer = 0;
            circleProgress.fillAmount = 0;
        }
    }
    public void Selected()
    {
        gvrStatus = true;
    }

    public void NotSelected()
    {
        gvrStatus = false;
    }
}
