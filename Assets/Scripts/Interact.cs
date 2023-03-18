using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    private MeshRenderer malha;
    private Color corori;

    // Start is called before the first frame update
    void Start()
    {
        malha = GetComponent<MeshRenderer>();
        corori = malha.material.color;
    }

    public void Selected()
    {
        malha.material.color = Color.white;
    }

    public void NotSelected()
    {
        malha.material.color = corori;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
