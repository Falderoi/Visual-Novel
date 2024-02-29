using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Unity.VisualScripting;

public class controller : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    private int compte = 0;
    private int route = 0;
    public GameObject Choix1;
    public TextMeshProUGUI Choix1Txt;
    public GameObject Choix2;
    public TextMeshProUGUI Choix2Txt;
    public Texte_Data Route0;
    public Texte_Data Route1;
    public Texte_Data Route2;
    public Texte_Data Route3;
    public Texte_Data Route4;
    public Texte_Data Route5;
    public Texte_Data Route6;
    public Texte_Data Route7;
    public Texte_Data Route8;
    public Texte_Data Route9;
    public Texte_Data Route10;
    public Texte_Data Route11;
    public Texte_Data Route12;

    bool AToiDeJouer = false;
    public float delai = 0.01f;
    string originaltxt;
    AudioSource audiosource;
    private int bam = 0;
    private IEnumerator ChangerTexte()
    {
        //route 0
        if (compte == 0 && route == 0)
        {
            textComponent.text = Route0.Phrase1;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 1 && route == 0)
        {
            textComponent.text = Route0.Phrase2;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 2 && route == 0)
        {
            textComponent.text = Route0.Phrase3;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 3 && route == 0)
        {
            textComponent.text = Route0.Phrase4;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 4 && route == 0)
        {
            textComponent.text = Route0.Phrase5;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 5 && route == 0)
        {
            textComponent.text = Route0.Phrase6;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
            Choix1.SetActive(true);
            Choix1Txt.text = "Aller en cours";
            Choix2.SetActive(true);
            Choix2Txt.text = "Ne pas participer à la rentrée";
            AToiDeJouer = true;
        }

        //route 1
        if (compte == 0 && route == 1)
        {
            Choix1.SetActive(false);
            Choix2.SetActive(false);
            AToiDeJouer = false;
            textComponent.text = Route1.Phrase1;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 1 && route == 1)
        {
            textComponent.text = Route1.Phrase2;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 2 && route == 1)
        {
            textComponent.text = Route1.Phrase3;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 3 && route == 1)
        {
            textComponent.text = Route1.Phrase4;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 4 && route == 1)
        {
            textComponent.text = Route1.Phrase5;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 5 && route == 1)
        {
            textComponent.text = Route1.Phrase6;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
            Choix1.SetActive(true);
            Choix1Txt.text = "Ne pas aller la voir";
            Choix2.SetActive(true);
            Choix2Txt.text = "Aller lui parler";
            AToiDeJouer = true;
        }

        //route 2
        if (compte == 0 && route == 2)
        {
            Choix1.SetActive(false);
            Choix2.SetActive(false);
            AToiDeJouer = false;
            textComponent.text = Route2.Phrase1;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 1 && route == 2)
        {
            textComponent.text = Route2.Phrase2;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 2 && route == 2)
        {
            textComponent.text = Route2.Phrase3;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 3 && route == 2)
        {
            textComponent.text = Route2.Phrase4;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 4 && route == 2)
        {
            textComponent.text = Route2.Phrase5;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 5 && route == 2)
        {
            textComponent.text = Route2.Phrase6;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 6 && route == 2)
        {
            textComponent.text = Route2.Phrase7;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
            Choix1.SetActive(true);
            Choix1Txt.text = "Aller en cours";
            Choix2.SetActive(true);
            Choix2Txt.text = "Ne pas participer à la rentrée";
            AToiDeJouer = true;
        }

        //route 3
        if (compte == 0 && route == 3)
        {
            Choix1.SetActive(false);
            Choix2.SetActive(false);
            AToiDeJouer = false;
            textComponent.text = Route3.Phrase1;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 1 && route == 3)
        {
            textComponent.text = Route3.Phrase2;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
            route = 0;
            compte = 0;
        }

        //route 4
        if (compte == 0 && route == 4)
        {
            Choix1.SetActive(false);
            Choix2.SetActive(false);
            AToiDeJouer = false;
            textComponent.text = Route4.Phrase1;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 1 && route == 4)
        {
            textComponent.text = Route4.Phrase2;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 2 && route == 4)
        {
            textComponent.text = Route4.Phrase3;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 3 && route == 4)
        {
            textComponent.text = Route4.Phrase4;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 4 && route == 4)
        {
            textComponent.text = Route4.Phrase5;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 5 && route == 4)
        {
            textComponent.text = Route4.Phrase6;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 6 && route == 4)
        {
            textComponent.text = Route4.Phrase7;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 7 && route == 4)
        {
            textComponent.text = Route4.Phrase8;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 8 && route == 4)
        {
            textComponent.text = Route4.Phrase9;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 9 && route == 4)
        {
            textComponent.text = Route4.Phrase10;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 10 && route == 4)
        {
            textComponent.text = Route4.Phrase11;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
            Choix1.SetActive(true);
            Choix1Txt.text = "Lui donner rendez vous au cerisier";
            Choix2.SetActive(true);
            Choix2Txt.text = "Lui donner rendez vous chez Navet";
            AToiDeJouer = true;
        }

        //route 5
        if (compte == 0 && route == 5)
        {
            Choix1.SetActive(false);
            Choix2.SetActive(false);
            AToiDeJouer = false;
            textComponent.text = Route5.Phrase1;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 1 && route == 5)
        {
            textComponent.text = Route5.Phrase2;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 2 && route == 5)
        {
            textComponent.text = Route5.Phrase3;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 3 && route == 5)
        {
            textComponent.text = Route5.Phrase4;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 4 && route == 5)
        {
            textComponent.text = Route5.Phrase5;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 5 && route == 5)
        {
            textComponent.text = Route5.Phrase6;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
            Choix1.SetActive(true);
            Choix1Txt.text = "Prendre son courage à deux mains et y aller";
            Choix2.SetActive(true);
            Choix2Txt.text = "Se dégonfler";
            AToiDeJouer = true;
        }

        //route 6
        if (compte == 0 && route == 6)
        {
            Choix1.SetActive(false);
            Choix2.SetActive(false);
            AToiDeJouer = false;
            textComponent.text = Route6.Phrase1;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 1 && route == 6)
        {
            textComponent.text = Route6.Phrase2;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 2 && route == 6)
        {
            textComponent.text = Route6.Phrase3;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 3 && route == 6)
        {
            textComponent.text = Route6.Phrase4;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 4 && route == 6)
        {
            textComponent.text = Route6.Phrase5;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 5 && route == 6)
        {
            textComponent.text = Route6.Phrase6;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
            Choix1.SetActive(true);
            Choix1Txt.text = "Prendre son courage à deux mains et y aller";
            Choix2.SetActive(true);
            Choix2Txt.text = "Se dégonfler";
            AToiDeJouer = true;
        }

        //route 7
        if (compte == 0 && route == 7)
        {
            Choix1.SetActive(false);
            Choix2.SetActive(false);
            AToiDeJouer = false;
            textComponent.text = Route7.Phrase1;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 1 && route == 7)
        {
            textComponent.text = Route7.Phrase2;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 2 && route == 7)
        {
            textComponent.text = Route7.Phrase3;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 3 && route == 7)
        {
            textComponent.text = Route7.Phrase4;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 4 && route == 7)
        {
            textComponent.text = Route7.Phrase5;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 5 && route == 7)
        {
            textComponent.text = Route7.Phrase6;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 6 && route == 7)
        {
            textComponent.text = Route7.Phrase7;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 7 && route == 7)
        {
            textComponent.text = Route7.Phrase8;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 8 && route == 7)
        {
            textComponent.text = Route7.Phrase9;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
            Choix1.SetActive(true);
            Choix1Txt.text = "Au cinéma";
            Choix2.SetActive(true);
            Choix2Txt.text = "Au café perchoir";
            AToiDeJouer = true;
        }

        //route 8
        if (compte == 0 && route == 8)
        {
            Choix1.SetActive(false);
            Choix2.SetActive(false);
            AToiDeJouer = false;
            textComponent.text = Route8.Phrase1;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 1 && route == 8)
        {
            textComponent.text = Route8.Phrase2;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 2 && route == 8)
        {
            textComponent.text = Route8.Phrase3;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 3 && route == 8)
        {
            textComponent.text = Route8.Phrase4;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 4 && route == 8)
        {
            textComponent.text = Route8.Phrase5;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
            route = 0;
            compte = 0;
        }

        //route 9
        if (compte == 0 && route == 9)
        {
            Choix1.SetActive(false);
            Choix2.SetActive(false);
            AToiDeJouer = false;
            textComponent.text = Route9.Phrase1;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 1 && route == 9)
        {
            textComponent.text = Route9.Phrase2;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 2 && route == 9)
        {
            textComponent.text = Route9.Phrase3;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 3 && route == 9)
        {
            textComponent.text = Route9.Phrase4;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 4 && route == 9)
        {
            textComponent.text = Route9.Phrase5;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 5 && route == 9)
        {
            textComponent.text = Route9.Phrase6;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 6 && route == 9)
        {
            textComponent.text = Route9.Phrase7;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 7 && route == 9)
        {
            textComponent.text = Route9.Phrase8;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 8 && route == 9)
        {
            textComponent.text = Route9.Phrase9;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 9 && route == 9)
        {
            textComponent.text = Route9.Phrase10;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 10 && route == 9)
        {
            textComponent.text = Route9.Phrase11;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 11 && route == 9)
        {
            textComponent.text = Route9.Phrase12;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 12 && route == 9)
        {
            textComponent.text = Route9.Phrase13;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
            Choix1.SetActive(true);
            Choix1Txt.text = "Lui révéler ses sentiments";
            Choix2.SetActive(true);
            Choix2Txt.text = "Les garder pour soi";
            AToiDeJouer = true;
        }

        //Route 10
        if (compte == 0 && route == 10)
        {
            Choix1.SetActive(false);
            Choix2.SetActive(false);
            AToiDeJouer = false;
            textComponent.text = Route10.Phrase1;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 1 && route == 10)
        {
            textComponent.text = Route10.Phrase2;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 2 && route == 10)
        {
            textComponent.text = Route10.Phrase3;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 3 && route == 10)
        {
            textComponent.text = Route10.Phrase4;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 4 && route == 10)
        {
            textComponent.text = Route10.Phrase5;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 5 && route == 10)
        {
            textComponent.text = Route10.Phrase6;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 6 && route == 10)
        {
            textComponent.text = Route10.Phrase7;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 7 && route == 10)
        {
            textComponent.text = Route10.Phrase8;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 8 && route == 10)
        {
            textComponent.text = Route10.Phrase9;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 9 && route == 10)
        {
            textComponent.text = Route10.Phrase10;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 10 && route == 10)
        {
            textComponent.text = Route10.Phrase11;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 11 && route == 10)
        {
            textComponent.text = Route10.Phrase12;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 12 && route == 10)
        {
            textComponent.text = Route10.Phrase12;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
            Choix1.SetActive(true);
            Choix1Txt.text = "Lui révéler ses sentiments";
            Choix2.SetActive(true);
            Choix2Txt.text = "Les garder pour soi";
            AToiDeJouer = true;
        }

        //route 11
        if (compte == 0 && route == 11)
        {
            Choix1.SetActive(false);
            Choix2.SetActive(false);
            AToiDeJouer = false;
            textComponent.text = Route11.Phrase1;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 1 && route == 11)
        {
            textComponent.text = Route11.Phrase2;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 2 && route == 11)
        {
            textComponent.text = Route11.Phrase3;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 3 && route == 11)
        {
            textComponent.text = Route11.Phrase4;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 4 && route == 11)
        {
            textComponent.text = Route11.Phrase5;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 5 && route == 11)
        {
            textComponent.text = Route11.Phrase6;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 6 && route == 11)
        {
            textComponent.text = Route11.Phrase7;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 7 && route == 11)
        {
            textComponent.text = Route11.Phrase8;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 8 && route == 11)
        {
            textComponent.text = Route11.Phrase9;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 9 && route == 11)
        {
            textComponent.text = Route11.Phrase10;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 10 && route == 11)
        {
            textComponent.text = Route11.Phrase11;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 11 && route == 11)
        {
            textComponent.text = Route11.Phrase12;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
            route = 0;
            compte = 0;
        }

        //route 12
        if (compte == 0 && route == 12)
        {
            Choix1.SetActive(false);
            Choix2.SetActive(false);
            AToiDeJouer = false;
            textComponent.text = Route12.Phrase1;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 1 && route == 12)
        {
            textComponent.text = Route12.Phrase2;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 2 && route == 12)
        {
            textComponent.text = Route12.Phrase3;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 3 && route == 12)
        {
            textComponent.text = Route12.Phrase4;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 4 && route == 12)
        {
            textComponent.text = Route12.Phrase5;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 5 && route == 12)
        {
            textComponent.text = Route12.Phrase6;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 6 && route == 12)
        {
            textComponent.text = Route12.Phrase7;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 7 && route == 12)
        {
            textComponent.text = Route12.Phrase8;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 8 && route == 12)
        {
            textComponent.text = Route12.Phrase9;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }

        if (compte == 9 && route == 12)
        {
            textComponent.text = Route12.Phrase10;
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
            compte = 0;
            route = 0;
        }




        compte += 1;
        yield return null;
    }

    private IEnumerator AnimTxt()
    { 
        for (int i = 0; i < originaltxt.Length; i++)
        {
            textComponent.text = originaltxt.Substring(0,i+1);

            if(originaltxt.Substring(i,1) != " ")
            {
                if(bam  == 3)
                {
                    audiosource.pitch = Random.Range(0.95f, 1.05f);
                    audiosource.Play();
                    bam = 0;
                }
                else
                {
                    bam += 1;
                }
            
                
            }
            

            yield return new WaitForSeconds(delai);
        }
    }
        // Start is called before the first frame update
        void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if (AToiDeJouer == false)
            {
                StartCoroutine(ChangerTexte());
            }


        }

        if (Input.GetButtonDown("Fire1"))
        {
            if (AToiDeJouer == true && route == 0)
            {
                route = 1;
                compte = 0;
                StartCoroutine(ChangerTexte());
            }

            if (AToiDeJouer == true && route == 1 || AToiDeJouer == true && route == 2)
            {
                route = 3;
                compte = 0;
                StartCoroutine(ChangerTexte());
            }

            if (AToiDeJouer == true && route == 4)
            {
                route = 5;
                compte = 0;
                StartCoroutine(ChangerTexte());
            }

            if (AToiDeJouer == true && route == 5 || AToiDeJouer == true && route == 6)
            {
                route = 7;
                compte = 0;
                StartCoroutine(ChangerTexte());
            }

            if (AToiDeJouer == true && route == 7)
            {
                route = 9;
                compte = 0;
                StartCoroutine(ChangerTexte());
            }
        }

        if (AToiDeJouer == true && route == 9 || AToiDeJouer == true && route == 10)
        {
            route = 11;
            compte = 0;
            StartCoroutine(ChangerTexte());
        }
        if (Input.GetButtonDown("Fire2"))
        {
            if (AToiDeJouer == true && route == 0)
            {
                route = 2;
                compte = 0;
                StartCoroutine(ChangerTexte());
            }

            if (AToiDeJouer == true && route == 1 || AToiDeJouer == true && route == 2)
            {
                route = 4;
                compte = 0;
                StartCoroutine(ChangerTexte());
            }

            if (AToiDeJouer == true && route == 4)
            {
                route = 6;
                compte = 0;
                StartCoroutine(ChangerTexte());
            }

            if (AToiDeJouer == true && route == 5 || AToiDeJouer == true && route == 6)
            {
                route = 8;
                compte = 0;
                StartCoroutine(ChangerTexte());
            }

            if (AToiDeJouer == true && route == 7)
            {
                route = 10;
                compte = 0;
                StartCoroutine(ChangerTexte());
            }

            if (AToiDeJouer == true && route == 9 || AToiDeJouer == true && route == 10)
            {
                route = 12;
                compte = 0;
                StartCoroutine(ChangerTexte());
            }
        }
    }
}
