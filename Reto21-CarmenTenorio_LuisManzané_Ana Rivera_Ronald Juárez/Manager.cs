using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{

    public GameObject[] Levels;
    public GameObject ResetScreen, End;

    int NivelAct, cont=0;



    public void respIncorret()
    {
        ResetScreen.SetActive(true);
        if (NivelAct + 1 != Levels.Length)
        {
            Levels[NivelAct].SetActive(false);

            NivelAct++;
            Levels[NivelAct].SetActive(true);
        }
        else
        {
            End.SetActive(true);
            Levels[NivelAct].SetActive(false);
        }
    }

    public void ResetGame()
    {
        
        ResetScreen.SetActive(false);
      
    }




    public void respCorrect()
    {

        if (NivelAct + 1 != Levels.Length)
        {
            Levels[NivelAct].SetActive(false);

            NivelAct++;
            Levels[NivelAct].SetActive(true);

            StartCoroutine(DelayAction());
        }
        else
        {
            End.SetActive(true);
            Levels[NivelAct].SetActive(false);
        }

        cont = cont + 1;
    }

    public void Siguiente()
    {
        if (NivelAct + 1 != Levels.Length)
        {
            Levels[NivelAct].SetActive(false);

            NivelAct++;
            Levels[NivelAct].SetActive(true);

            StartCoroutine(DelayAction());
        }
        else
        {
            End.SetActive(true);
            Levels[NivelAct].SetActive(false);
        }
    }


    IEnumerator DelayAction()
    {
        yield return new WaitForSeconds(5);
    }

    public void salir()
    {
        Application.Quit();
        Debug.Log("Se ha salido");
    }

}
