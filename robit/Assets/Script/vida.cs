using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using UnityEngine.SceneManagement;

public class vida : MonoBehaviour
{
    // Declarar una variable de vida estática
    public static int vidaActual = 100;


    public GameObject vida1;
    public GameObject vida2;
    public GameObject vida3;
    public GameObject vida4;

    public GameObject muertevida;
    public GameObject canwa;
    // Start is called before the first frame update
    void Start()
    {
        vida1 = GameObject.FindWithTag("vida1");
        vida2 = GameObject.FindWithTag("vida2");
        vida3 = GameObject.FindWithTag("vida3");
        vida4 = GameObject.FindWithTag("vida4");
        // Inicializar la vida actual, por ejemplo a 100
        vidaActual = 100;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(vidaActual);

        UpdateVidaVisual();
    }

    void UpdateVidaVisual()
    {
        // Actualizar el estado de los GameObjects de vida basándose en el valor de vidaActual
        if (vidaActual >= 100)
        {
            vida1.SetActive(true);
            vida2.SetActive(true);
            vida3.SetActive(true);
            vida4.SetActive(true);
        }
        else if (vidaActual >= 75)
        {
            vida1.SetActive(false);
            vida2.SetActive(true);
            vida3.SetActive(true);
            vida4.SetActive(true);
        }
        else if (vidaActual >= 50)
        {
            vida1.SetActive(false);
            vida2.SetActive(false);
            vida3.SetActive(true);
            vida4.SetActive(true);
        }
        else if (vidaActual >= 25)
        {
            vida1.SetActive(false);
            vida2.SetActive(false);
            vida3.SetActive(false);
            vida4.SetActive(true);
        }
        else if (vidaActual < 25)
        {
            vida1.SetActive(false);
            vida2.SetActive(false);
            vida3.SetActive(false);
            vida4.SetActive(false);

            muertevida.SetActive(true);
            canwa.SetActive(false);

            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;

            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(1);
                vidaActual = 100;
                cordura.coordura = 100;
            }
            //Destroy(gameObject);

        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("bala"))
        {
            vidaActual = vidaActual-25;
        }
    }
}