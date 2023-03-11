using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Counter : MonoBehaviour
{
    public int contador;
    public TMP_Text Numba;

    void Start()
    {
        contador = 0;
    }

    public void IncrementContador()
    {
        contador++;
        Debug.Log("Contou"+contador);
        Numba.text = contador.ToString();
    }

}
