using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    public string nome;
    private int punteggio;


    public int GetPunteggio()
    {
        return punteggio;
    }

    public void SetPunteggio(int valore)
    {
        if (valore < 0)
        {
            punteggio = 0;
            Debug.Log("Il punteggio non puó essere negativo");
        }
        else
        {
            punteggio = valore;
        }
    }

    public bool IsVincitore()
    {
        if (punteggio >= 100)
        {
            return true;
        }
        return false;
    }

    public void AttaccaNemico(Enemy target, int danno)
    {
        target.SubisciDanno(danno);
        Debug.Log($"Il Giocatore {nome} ha inflitto {danno} danni al nemico {target.nome}");

        if (target.salute == 0)
        {
            Debug.Log($"{target.nome} é stato sconfitto");
        }
        else
        {
            Debug.Log($"{target.nome} é rimasto con {target.salute}hp");
        }

    }
}
