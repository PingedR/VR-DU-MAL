using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interact : MonoBehaviour
{
    private MeshRenderer malha;
    private Color corori;
    public Image circleProgress;
    public float totalTime = 3;
    private bool gvrStatus;
    private float gvrTimer;

    // Start is called before the first frame update
    void Start()
    {
        malha = GetComponent<MeshRenderer>();
        corori = malha.material.color;
    }

    void Update()
    {
        if (gvrStatus == true)
        {
            gvrTimer += Time.deltaTime;
            circleProgress.fillAmount = gvrTimer / totalTime;
        }
        else
        {
            gvrTimer = 0;
            circleProgress.fillAmount = 0;
        }
    }
    public void Selected()
    {
        malha.material.color = Color.white;
        gvrStatus = true;
    }

    public void NotSelected()
    {
        malha.material.color = corori;
        gvrStatus = false;
    }
}
