using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HudManager : MonoBehaviour
{
    public GameObject menuPausa;
    
    // Boton de jugar en el menu principal
    public void BotonJugar()
    {
        SceneManager.LoadScene("Nivel 1");
    }
    
    // Botones en el menu de pausa
    // Boton de pausa
    public void MenuPausa()
    {
        Time.timeScale = 0;
        menuPausa.SetActive(true);
    }
    
    // Boton de renaudar
    public void Renaudar()
    {
        Time.timeScale = 1;
        menuPausa.SetActive(false);
    }
    
    // Boton para ir al menu principal
    public void IrMenuPrincipal()
    {
        SceneManager.LoadScene("MainMenu");
    }

    // Boton para salir del juego
    public void SalirJuego()
    {
        Application.Quit();
    }
}
