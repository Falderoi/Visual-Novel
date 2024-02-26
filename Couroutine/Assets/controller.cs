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

    bool AToiDeJouer = false;
    public float delai = 0.01f;
    string originaltxt;
    AudioSource audiosource;
    private int bam = 0;
    private IEnumerator ChangerTexte()
    {

        if (compte == 0)
        {
            textComponent.text = "Navet : \"La rentr�e... encore une fois. Une nouvelle ann�e qui commence, de nouveaux visages � rencontrer, de nouveaux d�fis � affronter... et moi, toujours ce m�me vieux Navet, coinc� dans ma bulle. ";
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }
            

        if (compte == 1)
        {
            textComponent.text = "Je me demande parfois si les autres pensent que je suis �trange.\r\nPeut-�tre le suis-je vraiment. Apr�s tout, je pr�f�re la compagnie de mes livres et de mes crayons � celle des gens. Les interactions sociales me semblent souvent si... compliqu�es.";
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
        }
            

        if (compte == 2)
        {
            AToiDeJouer = true;
            textComponent.text = "Alors tu m'aime ?";
            originaltxt = textComponent.text;
            textComponent.text = null;
            StartCoroutine(AnimTxt());
            Choix1.SetActive(true);
            Choix1Txt.text = "Oui";
            Choix2.SetActive(true);
            Choix2Txt.text = "Non";

        }
        if (compte == 3)
        {
            Choix1.SetActive(false);
            Choix2.SetActive(false);
            AToiDeJouer = false;
            if (route == 1)
            {
                textComponent.text = "G�nial";
                originaltxt = textComponent.text;
                textComponent.text = null;
                StartCoroutine(AnimTxt());
            }

            if (route == 2)
            {
                textComponent.text = "Bah nique ta m�re alors !";
                originaltxt = textComponent.text;
                textComponent.text = null;
                StartCoroutine(AnimTxt());
            }

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
            if (AToiDeJouer == true)
            {
                route = 1;
                StartCoroutine(ChangerTexte());
            }
        }

        if (Input.GetButtonDown("Fire2"))
        {
            if (AToiDeJouer == true)
            {
                route = 2;
                StartCoroutine(ChangerTexte());
            }
            
        }

    }
}
