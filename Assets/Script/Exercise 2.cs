using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Exercise2 : MonoBehaviour
{
    [SerializeField] string stringa;

    void Start()
    {
        int indice = stringa.IndexOf(")") + 1;
        int indicend = stringa.Length - (indice + 1);

        if (indice <= 0 || stringa.IndexOf("(") < 0)
        {
            Debug.LogError("La stringa non é scritta correttamente");
            Debug.Log("Segui la seguente struttura");
            Debug.Log("(A;B;ecc) FRASE");
        }
        else
        {
            string stringend = stringa.Substring(indice + 1, indicend);

            string stringstart = stringa.Substring(1, indice - 1);
            string[] stringarray = stringstart.Split(';');

            for (int i = 0; i < stringarray.Length; i++)
            {
                Debug.Log(stringarray[i]);
            }
            Debug.Log(stringend);
        }
    }
}
