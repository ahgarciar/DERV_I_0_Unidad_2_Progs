using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogo_SO : MonoBehaviour
{
    [SerializeField]
    Dialogo dialogo;

    public int indexActual;


    public GameObject contenedorImagen;
    public Image image;

    private void Awake()
    {
        contenedorImagen = GameObject.Find("Contenedor");
        image = contenedorImagen.GetComponentInChildren<Image>();
    }

    // Start is called before the first frame update
    void Start()
    {
        indexActual = -1;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(dialogo.getCantidadMensajes());

        if (Input.GetKeyDown(KeyCode.F)) //atras
        {
            if (indexActual > 0)
            {
                indexActual--;
                image.sprite = dialogo.getDatosPersonaje(indexActual).personaje.imagen;  //la forma más correcta es esta
                //image.sprite = dialogo.mensaje[indexActual].personaje.imagen;
            }
            else {
                    //de momento, no se hace nada
            }
        }

        if (Input.GetKeyDown(KeyCode.G)) //adelante
        {
            if (indexActual < dialogo.getCantidadMensajes()-1)
            {
                indexActual++;
                image.sprite = dialogo.getDatosPersonaje(indexActual).personaje.imagen;
            }
            else {
                //de momento, no se hace nada
            }
        }

    }
}
