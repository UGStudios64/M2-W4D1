using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fight : MonoBehaviour
{
    [SerializeField] int danno;

    // Start is called before the first frame update
    void Start()
    {
        //----------PLAYERS----------//

        Player p1 = new Player();
        p1.nome = "Mario";
        p1.SetPunteggio(50);

        Player p2 = new Player();
        p2.nome = "Luigi";
        p2.SetPunteggio(0);

        //----------ENEMIES----------//

        Enemy e1 = new Enemy();
        e1.nome = "Goomba";
        e1.salute = 30;
        e1.livello = 1;

        //---------------------------------------------------------------

        Debug.Log($"Nome {p1.nome} Punteggio {p1.GetPunteggio()}");
        Debug.Log($"Nome {p2.nome} Punteggio {p2.GetPunteggio()}");

        p2.SetPunteggio(100);
        Debug.Log($"Nome {p2.nome} Punteggio {p2.GetPunteggio()}");


        if (p1.IsVincitore())
        {
            Debug.Log($"{p1.nome} IS THE WINNER");
        }
        else if (p2.IsVincitore())
        {
            Debug.Log($"{p2.nome} IS THE WINNER");
        }
        else
        {
            Debug.Log("NOBODY WINS");
        }

        //---------------------------------------------------------------

        p1.AttaccaNemico(e1, danno);

    }
}
