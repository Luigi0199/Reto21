using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CambioScenas : MonoBehaviour
{

    public int escena;
    public void CambiarEscena()
    {
        SceneManager.LoadScene(escena);
    }
    public void CambiarEscenaNombre(string nombreEscena)
    {
        SceneManager.LoadScene(nombreEscena);
    }

    public void salir()
    {
        Application.Quit();
        Debug.Log("Se ha salido");
    }
}
