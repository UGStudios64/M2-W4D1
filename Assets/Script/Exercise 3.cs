using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise3 : MonoBehaviour
{
    [SerializeField] public int numeroMax;
    List<int> numeri = new List<int>();

    // Start is called before the first frame update
    void Start()
    {
        int numPosition = 0;

        for (int i = 0; i <= numeroMax; i++)
        {
            if (numPosition == 0)
            {
                numeri.Insert(0, i);
            }
            else if (numPosition == 1)
            {
                numeri.Add(i);
            }
            else if (numPosition == 2)
            {
                int mid = numeri.Count / 2;
                numeri.Insert(mid, i);
            }

            Debug.Log($"Contenuto Lista {string.Join(", ", numeri)}");

            numPosition = (numPosition + 1) % 3;
            Debug.Log(numPosition);
        }
    }
}
