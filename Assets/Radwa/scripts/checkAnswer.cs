using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class checkAnswer : MonoBehaviour
{

    public GameObject lettreOne, lettreTwo, lettreThree, lettreFor, lettreFive, lettreSix, lettreSeven,
                      lettreEight, lettre9, lettre10, lettre11, lettre12, lettre13, lettre14, lettre15, lettre16, lettre17, BoxOne, BoxTwo, BoxThree, BoxFor, BoxFive, Box6, Box7, Box8, Box9, Box10, Box11, Box12, Box13, Box14, Box15, Box16, Box17;

    Vector3 lettreOneIni, lettreTwoIni, lettreThreeIni, lettreForIni, lettreFiveIni, lettreSixIni, lettreSevenIni, lettreEightIni, lettre9Ini, lettre10Ini, lettre11Ini, lettre12Ini, lettre13Ini, lettre14Ini, lettre15Ini, lettre16Ini, lettre17Ini;

    string str = "";
    public string word;

    public GameObject questionToHide, questionToShow;

    bool oneCorrect, twoCorrect, threeCorrect, forCorrect, fiveCorrect, sixCorrect, sevenCorrect, eightCorrect, nineCorrect, tenCorrect, elevenCorrect, tweleveCorrect, thirtCorrect, fortCorrect, fiftCorrect, sixtCorrect, seventCorrect = false;

    Vector3 iniScaleLettreOne, iniScaleLettreTwo, iniScaleLettreThree, iniScaleLettreFor, iniScaleLettreFive, iniScaleLettreSix,
            iniScaleLettreSeven, iniScaleLettreEight, iniScaleLettre9, iniScaleLettre10, iniScaleLettre11, iniScaleLettre12, iniScaleLettre13, iniScaleLettre14, iniScaleLettre15, iniScaleLettre16, iniScaleLettre17;

    public AudioSource source;
    public AudioClip[] correct;
    public AudioClip incorrect;
    public AudioClip buttonDrop;
    public AudioClip reload;

    void Start()
    {
        // Ini position

        lettreOneIni = lettreOne.transform.position;
        lettreTwoIni = lettreTwo.transform.position;
        lettreThreeIni = lettreThree.transform.position;
        lettreForIni = lettreFor.transform.position;
        lettreFiveIni = lettreFive.transform.position;
        lettreSixIni = lettreSix.transform.position;
        lettreSevenIni = lettreSeven.transform.position;
        lettreEightIni = lettreEight.transform.position;
        lettre9Ini = lettre9.transform.position;
        lettre10Ini = lettre10.transform.position;
        lettre11Ini = lettre11.transform.position;
        lettre12Ini = lettre12.transform.position;
        lettre13Ini = lettre13.transform.position;
        lettre14Ini = lettre14.transform.position;
        lettre15Ini = lettre15.transform.position;
        lettre16Ini = lettre16.transform.position;
        lettre17Ini = lettre17.transform.position;

        // Ini local scale
        iniScaleLettreOne = lettreOne.transform.localScale;
        iniScaleLettreTwo = lettreTwo.transform.localScale;
        iniScaleLettreThree = lettreThree.transform.localScale;
        iniScaleLettreFor = lettreFor.transform.localScale;
        iniScaleLettreFive = lettreFive.transform.localScale;
        iniScaleLettreSix = lettreSix.transform.localScale;
        iniScaleLettreSeven = lettreSeven.transform.localScale;
        iniScaleLettreEight = lettreEight.transform.localScale;
        iniScaleLettre9 = lettre9.transform.localScale;
        iniScaleLettre10 = lettre10.transform.localScale;
        iniScaleLettre11 = lettre11.transform.localScale;
        iniScaleLettre12 = lettre12.transform.localScale;
        iniScaleLettre13 = lettre13.transform.localScale;
        iniScaleLettre14 = lettre14.transform.localScale;
        iniScaleLettre15 = lettre15.transform.localScale;
        iniScaleLettre16 = lettre16.transform.localScale;
        iniScaleLettre17 = lettre17.transform.localScale;

        

    }




    //*****************************************Drag

    public void DragLettreOne()
    {
        lettreOne.transform.position = Input.mousePosition;
        
    }
    public void DragLettreTwo()
    {
        lettreTwo.transform.position = Input.mousePosition;
    }
    public void DragLettreThree()
    {
        lettreThree.transform.position = Input.mousePosition;
    }
    public void DragLettreFor()
    {
        lettreFor.transform.position = Input.mousePosition;
    }
    public void DragLettreFive()
    {
        lettreFive.transform.position = Input.mousePosition;
    }
    public void DragLettreSix()
    {
        lettreSix.transform.position = Input.mousePosition;
    }
    public void DragLettrSeven()
    {
        lettreSeven.transform.position = Input.mousePosition;
    }
    public void DragLettreEight()
    {
        lettreEight.transform.position = Input.mousePosition;
    }
    public void DragLettre9()
    {
        lettre9.transform.position = Input.mousePosition;
    }
    public void DragLettre10()
    {
        lettre10.transform.position = Input.mousePosition;
    }
    public void DragLettre11()
    {
        lettre11.transform.position = Input.mousePosition;
    }
    public void DragLettre12()
    {
        lettre12.transform.position = Input.mousePosition;
    }
    public void DragLettre13()
    {
        lettre13.transform.position = Input.mousePosition;
    }
    public void DragLettre14()
    {
        lettre14.transform.position = Input.mousePosition;
    }
    public void DragLettre15()
    {
        lettre15.transform.position = Input.mousePosition;
    }
    public void DragLettre16()
    {
        lettre16.transform.position = Input.mousePosition;
    }
    public void DragLettre17()
    {
        lettre17.transform.position = Input.mousePosition;
    }

    //****************************************Drop


    public void DropLettreOne()
    {
        float Distance = Vector3.Distance(lettreOne.transform.position, BoxOne.transform.position);
        float Distance2 = Vector3.Distance(lettreOne.transform.position, BoxTwo.transform.position);
        float Distance3 = Vector3.Distance(lettreOne.transform.position, BoxThree.transform.position);
        float Distance4 = Vector3.Distance(lettreOne.transform.position, BoxFor.transform.position);
        float Distance5 = Vector3.Distance(lettreOne.transform.position, BoxFive.transform.position);
        float Distance6 = Vector3.Distance(lettreOne.transform.position, Box6.transform.position);
        float Distance7 = Vector3.Distance(lettreOne.transform.position, Box7.transform.position);
        float Distance8 = Vector3.Distance(lettreOne.transform.position, Box8.transform.position);
        float Distance9 = Vector3.Distance(lettreOne.transform.position, Box9.transform.position);
        float Distance10 = Vector3.Distance(lettreOne.transform.position, Box10.transform.position);
        float Distance11 = Vector3.Distance(lettreOne.transform.position, Box11.transform.position);
        float Distance12 = Vector3.Distance(lettreOne.transform.position, Box12.transform.position);
        float Distance13 = Vector3.Distance(lettreOne.transform.position, Box13.transform.position);
        float Distance14 = Vector3.Distance(lettreOne.transform.position, Box14.transform.position);
        float Distance15 = Vector3.Distance(lettreOne.transform.position, Box15.transform.position);
        float Distance16 = Vector3.Distance(lettreOne.transform.position, Box16.transform.position);
        float Distance17 = Vector3.Distance(lettreOne.transform.position, Box17.transform.position);


        if (Distance < 50 && oneCorrect == false)
        {
            lettreOne.transform.localScale = BoxOne.transform.localScale;
            lettreOne.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = lettreOne.name;
            source.clip = buttonDrop;
            source.Play();


        }
        else if (Distance2 < 50 && twoCorrect == false)
        {
            lettreOne.transform.localScale = BoxTwo.transform.localScale;
            lettreOne.transform.position = BoxTwo.transform.position;
            twoCorrect = true;
            BoxTwo.name = lettreOne.name;
            source.clip = buttonDrop;
            source.Play();

        }
        else if (Distance3 < 50 && threeCorrect == false)
        {
            lettreOne.transform.localScale = BoxThree.transform.localScale;
            lettreOne.transform.position = BoxThree.transform.position;
            threeCorrect = true;
            BoxThree.name = lettreOne.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance4 < 50 && forCorrect == false)
        {
            lettreOne.transform.localScale = BoxFor.transform.localScale;
            lettreOne.transform.position = BoxFor.transform.position;
            forCorrect = true;
            BoxFor.name = lettreOne.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance5 < 50 && fiveCorrect == false)
        {
            lettreOne.transform.localScale = BoxFive.transform.localScale;
            lettreOne.transform.position = BoxFive.transform.position;
            fiveCorrect = true;
            BoxFive.name = lettreOne.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance6 < 50 && sixCorrect == false)
        {
            lettreOne.transform.localScale = Box6.transform.localScale;
            lettreOne.transform.position = Box6.transform.position;
            sixCorrect = true;
            Box6.name = lettreOne.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance7 < 50 && sixCorrect == false)
        {
            lettreOne.transform.localScale = Box7.transform.localScale;
            lettreOne.transform.position = Box7.transform.position;
            sevenCorrect = true;
            Box7.name = lettreOne.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance8 < 50 && eightCorrect == false)
        {
            lettreOne.transform.localScale = Box8.transform.localScale;
            lettreOne.transform.position = Box8.transform.position;
            eightCorrect = true;
            Box8.name = lettreOne.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance9 < 50 && nineCorrect == false)
        {
            lettreOne.transform.localScale = Box9.transform.localScale;
            lettreOne.transform.position = Box9.transform.position;
            nineCorrect = true;
            Box9.name = lettreOne.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance10 < 50 && tenCorrect == false)
        {
            lettreOne.transform.localScale = Box10.transform.localScale;
            lettreOne.transform.position = Box10.transform.position;
            tenCorrect = true;
            Box10.name = lettreOne.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance11 < 50 && elevenCorrect == false)
        {
            lettreOne.transform.localScale = Box11.transform.localScale;
            lettreOne.transform.position = Box11.transform.position;
            elevenCorrect = true;
            Box11.name = lettreOne.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance12 < 50 && tweleveCorrect == false)
        {
            lettreOne.transform.localScale = Box12.transform.localScale;
            lettreOne.transform.position = Box12.transform.position;
            tweleveCorrect = true;
            Box12.name = lettreOne.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance13 < 50 && thirtCorrect == false)
        {
            lettreOne.transform.localScale = Box13.transform.localScale;
            lettreOne.transform.position = Box13.transform.position;
            thirtCorrect = true;
            Box13.name = lettreOne.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance14 < 50 && fortCorrect == false)
        {
            lettreOne.transform.localScale = Box14.transform.localScale;
            lettreOne.transform.position = Box14.transform.position;
            fortCorrect = true;
            Box14.name = lettreOne.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance15 < 50 && fiftCorrect == false)
        {
            lettreOne.transform.localScale = Box15.transform.localScale;
            lettreOne.transform.position = Box15.transform.position;
            fiftCorrect = true;
            Box15.name = lettreOne.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance16 < 50 && sixtCorrect == false)
        {
            lettreOne.transform.localScale = Box16.transform.localScale;
            lettreOne.transform.position = Box16.transform.position;
            sixtCorrect = true;
            Box16.name = lettreOne.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance17 < 50 && tenCorrect == false)
        {
            lettreOne.transform.localScale = Box17.transform.localScale;
            lettreOne.transform.position = Box17.transform.position;
            seventCorrect = true;
            Box17.name = lettreOne.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else
        {
            lettreOne.transform.position = lettreOneIni;
           
     

            source.clip = reload;
            source.Play();
        }

    }

    public void DropLettreTwo()
    {
        float Distance = Vector3.Distance(lettreTwo.transform.position, BoxOne.transform.position);
        float Distance2 = Vector3.Distance(lettreTwo.transform.position, BoxTwo.transform.position);
        float Distance3 = Vector3.Distance(lettreTwo.transform.position, BoxThree.transform.position);
        float Distance4 = Vector3.Distance(lettreTwo.transform.position, BoxFor.transform.position);
        float Distance5 = Vector3.Distance(lettreTwo.transform.position, BoxFive.transform.position);
        float Distance6 = Vector3.Distance(lettreTwo.transform.position, Box6.transform.position);
        float Distance7 = Vector3.Distance(lettreTwo.transform.position, Box7.transform.position);
        float Distance8 = Vector3.Distance(lettreTwo.transform.position, Box8.transform.position);
        float Distance9 = Vector3.Distance(lettreTwo.transform.position, Box9.transform.position);
        float Distance10 = Vector3.Distance(lettreTwo.transform.position, Box10.transform.position);
        float Distance11 = Vector3.Distance(lettreTwo.transform.position, Box11.transform.position);
        float Distance12 = Vector3.Distance(lettreTwo.transform.position, Box12.transform.position);
        float Distance13 = Vector3.Distance(lettreTwo.transform.position, Box13.transform.position);
        float Distance14 = Vector3.Distance(lettreTwo.transform.position, Box14.transform.position);
        float Distance15 = Vector3.Distance(lettreTwo.transform.position, Box15.transform.position);
        float Distance16 = Vector3.Distance(lettreTwo.transform.position, Box16.transform.position);
        float Distance17 = Vector3.Distance(lettreTwo.transform.position, Box17.transform.position);

        if (Distance < 50 && oneCorrect == false)
        {
            lettreTwo.transform.localScale = BoxOne.transform.localScale;
            lettreTwo.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = lettreTwo.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance2 < 50 && twoCorrect == false)
        {
            lettreTwo.transform.localScale = BoxTwo.transform.localScale;
            lettreTwo.transform.position = BoxTwo.transform.position;
            twoCorrect = true;
            BoxTwo.name = lettreTwo.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance3 < 50 && threeCorrect == false)
        {
            lettreTwo.transform.localScale = BoxThree.transform.localScale;
            lettreTwo.transform.position = BoxThree.transform.position;
            threeCorrect = true;
            BoxThree.name = lettreTwo.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance4 < 50 && forCorrect == false)
        {
            lettreTwo.transform.localScale = BoxFor.transform.localScale;
            lettreTwo.transform.position = BoxFor.transform.position;
            forCorrect = true;
            BoxFor.name = lettreTwo.name;
            source.clip = buttonDrop;
            source.Play();

        }

        else if (Distance5 < 50 && fiveCorrect == false)
        {
            lettreTwo.transform.localScale = BoxFive.transform.localScale;
            lettreTwo.transform.position = BoxFive.transform.position;
            fiveCorrect = true;
            BoxFive.name = lettreTwo.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance6 < 50 && sixCorrect == false)
        {
            lettreTwo.transform.localScale = Box6.transform.localScale;
            lettreTwo.transform.position = Box6.transform.position;
            sixCorrect = true;
            Box6.name = lettreTwo.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance7 < 50 && sixCorrect == false)
        {
            lettreTwo.transform.localScale = Box7.transform.localScale;
            lettreTwo.transform.position = Box7.transform.position;
            sevenCorrect = true;
            Box7.name = lettreTwo.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance8 < 50 && eightCorrect == false)
        {
            lettreTwo.transform.localScale = Box8.transform.localScale;
            lettreTwo.transform.position = Box8.transform.position;
            eightCorrect = true;
            Box8.name = lettreTwo.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance9 < 50 && nineCorrect == false)
        {
            lettreTwo.transform.localScale = Box9.transform.localScale;
            lettreTwo.transform.position = Box9.transform.position;
            nineCorrect = true;
            Box9.name = lettreTwo.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance10 < 50 && tenCorrect == false)
        {
            lettreTwo.transform.localScale = Box10.transform.localScale;
            lettreTwo.transform.position = Box10.transform.position;
            tenCorrect = true;
            Box10.name = lettreTwo.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance11 < 50 && elevenCorrect == false)
        {
            lettreTwo.transform.localScale = Box11.transform.localScale;
            lettreTwo.transform.position = Box11.transform.position;
            elevenCorrect = true;
            Box11.name = lettreTwo.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance12 < 50 && tweleveCorrect == false)
        {
            lettreTwo.transform.localScale = Box12.transform.localScale;
            lettreTwo.transform.position = Box12.transform.position;
            tweleveCorrect = true;
            Box12.name = lettreTwo.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance13 < 50 && thirtCorrect == false)
        {
            lettreTwo.transform.localScale = Box13.transform.localScale;
            lettreTwo.transform.position = Box13.transform.position;
            thirtCorrect = true;
            Box13.name = lettreTwo.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance14 < 50 && fortCorrect == false)
        {
            lettreTwo.transform.localScale = Box14.transform.localScale;
            lettreTwo.transform.position = Box14.transform.position;
            fortCorrect = true;
            Box14.name = lettreTwo.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance15 < 50 && fiftCorrect == false)
        {
            lettreTwo.transform.localScale = Box15.transform.localScale;
            lettreTwo.transform.position = Box15.transform.position;
            fiftCorrect = true;
            Box15.name = lettreTwo.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance16 < 50 && sixtCorrect == false)
        {
            lettreTwo.transform.localScale = Box16.transform.localScale;
            lettreTwo.transform.position = Box16.transform.position;
            sixtCorrect = true;
            Box16.name = lettreTwo.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance17 < 50 && tenCorrect == false)
        {
            lettreTwo.transform.localScale = Box17.transform.localScale;
            lettreTwo.transform.position = Box17.transform.position;
            seventCorrect = true;
            Box17.name = lettreTwo.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else
        {
            lettreTwo.transform.position = lettreTwoIni;

           
            
            source.clip = reload;
            source.Play();
        }

    }

    public void DropLettreThree()
    {
        float Distance = Vector3.Distance(lettreThree.transform.position, BoxOne.transform.position);
        float Distance2 = Vector3.Distance(lettreThree.transform.position, BoxTwo.transform.position);
        float Distance3 = Vector3.Distance(lettreThree.transform.position, BoxThree.transform.position);
        float Distance4 = Vector3.Distance(lettreThree.transform.position, BoxFor.transform.position);
        float Distance5 = Vector3.Distance(lettreThree.transform.position, BoxFive.transform.position);
        float Distance6 = Vector3.Distance(lettreThree.transform.position, Box6.transform.position);
        float Distance7 = Vector3.Distance(lettreThree.transform.position, Box7.transform.position);
        float Distance8 = Vector3.Distance(lettreThree.transform.position, Box8.transform.position);
        float Distance9 = Vector3.Distance(lettreThree.transform.position, Box9.transform.position);
        float Distance10 = Vector3.Distance(lettreThree.transform.position, Box10.transform.position);
        float Distance11 = Vector3.Distance(lettreThree.transform.position, Box11.transform.position);
        float Distance12 = Vector3.Distance(lettreThree.transform.position, Box12.transform.position);
        float Distance13 = Vector3.Distance(lettreThree.transform.position, Box13.transform.position);
        float Distance14 = Vector3.Distance(lettreThree.transform.position, Box14.transform.position);
        float Distance15 = Vector3.Distance(lettreThree.transform.position, Box15.transform.position);
        float Distance16 = Vector3.Distance(lettreThree.transform.position, Box16.transform.position);
        float Distance17 = Vector3.Distance(lettreThree.transform.position, Box17.transform.position);

        if (Distance < 50 && oneCorrect == false)
        {
            lettreThree.transform.localScale = BoxOne.transform.localScale;
            lettreThree.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = lettreThree.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance2 < 50 && twoCorrect == false)
        {
            lettreThree.transform.localScale = BoxTwo.transform.localScale;
            lettreThree.transform.position = BoxTwo.transform.position;
            twoCorrect = true;
            BoxTwo.name = lettreThree.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance3 < 50 && threeCorrect == false)
        {
            lettreThree.transform.localScale = BoxThree.transform.localScale;
            lettreThree.transform.position = BoxThree.transform.position;
            threeCorrect = true;
            BoxThree.name = lettreThree.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance4 < 50 && forCorrect == false)
        {
            lettreThree.transform.localScale = BoxFor.transform.localScale;
            lettreThree.transform.position = BoxFor.transform.position;
            forCorrect = true;
            BoxFor.name = lettreThree.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance5 < 50 && fiveCorrect == false)
        {
            lettreThree.transform.localScale = BoxFive.transform.localScale;
            lettreThree.transform.position = BoxFive.transform.position;
            fiveCorrect = true;
            BoxFive.name = lettreThree.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance6 < 50 && sixCorrect == false)
        {
            lettreThree.transform.localScale = Box6.transform.localScale;
            lettreThree.transform.position = Box6.transform.position;
            sixCorrect = true;
            Box6.name = lettreThree.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance7 < 50 && sixCorrect == false)
        {
            lettreThree.transform.localScale = Box7.transform.localScale;
            lettreThree.transform.position = Box7.transform.position;
            sevenCorrect = true;
            Box7.name = lettreThree.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance8 < 50 && eightCorrect == false)
        {
            lettreThree.transform.localScale = Box8.transform.localScale;
            lettreThree.transform.position = Box8.transform.position;
            eightCorrect = true;
            Box8.name = lettreThree.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance9 < 50 && nineCorrect == false)
        {
            lettreThree.transform.localScale = Box9.transform.localScale;
            lettreThree.transform.position = Box9.transform.position;
            nineCorrect = true;
            Box9.name = lettreThree.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance10 < 50 && tenCorrect == false)
        {
            lettreThree.transform.localScale = Box10.transform.localScale;
            lettreThree.transform.position = Box10.transform.position;
            tenCorrect = true;
            Box10.name = lettreThree.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance11 < 50 && elevenCorrect == false)
        {
            lettreThree.transform.localScale = Box11.transform.localScale;
            lettreThree.transform.position = Box11.transform.position;
            elevenCorrect = true;
            Box11.name = lettreThree.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance12 < 50 && tweleveCorrect == false)
        {
            lettreThree.transform.localScale = Box12.transform.localScale;
            lettreThree.transform.position = Box12.transform.position;
            tweleveCorrect = true;
            Box12.name = lettreThree.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance13 < 50 && thirtCorrect == false)
        {
            lettreThree.transform.localScale = Box13.transform.localScale;
            lettreThree.transform.position = Box13.transform.position;
            thirtCorrect = true;
            Box13.name = lettreThree.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance14 < 50 && fortCorrect == false)
        {
            lettreThree.transform.localScale = Box14.transform.localScale;
            lettreThree.transform.position = Box14.transform.position;
            fortCorrect = true;
            Box14.name = lettreThree.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance15 < 50 && fiftCorrect == false)
        {
            lettreThree.transform.localScale = Box15.transform.localScale;
            lettreThree.transform.position = Box15.transform.position;
            fiftCorrect = true;
            Box15.name = lettreThree.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance16 < 50 && sixtCorrect == false)
        {
            lettreThree.transform.localScale = Box16.transform.localScale;
            lettreThree.transform.position = Box16.transform.position;
            sixtCorrect = true;
            Box16.name = lettreThree.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance17 < 50 && tenCorrect == false)
        {
            lettreThree.transform.localScale = Box17.transform.localScale;
            lettreThree.transform.position = Box17.transform.position;
            seventCorrect = true;
            Box17.name = lettreThree.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else
        {
            lettreThree.transform.position = lettreThreeIni;
           
            source.clip = reload;
            source.Play();
        }

    }

    public void DropLettreFor()
    {
        float Distance = Vector3.Distance(lettreFor.transform.position, BoxOne.transform.position);
        float Distance2 = Vector3.Distance(lettreFor.transform.position, BoxTwo.transform.position);
        float Distance3 = Vector3.Distance(lettreFor.transform.position, BoxThree.transform.position);
        float Distance4 = Vector3.Distance(lettreFor.transform.position, BoxFor.transform.position);
        float Distance5 = Vector3.Distance(lettreFor.transform.position, BoxFive.transform.position);
        float Distance6 = Vector3.Distance(lettreFor.transform.position, Box6.transform.position);
        float Distance7 = Vector3.Distance(lettreFor.transform.position, Box7.transform.position);
        float Distance8 = Vector3.Distance(lettreFor.transform.position, Box8.transform.position);
        float Distance9 = Vector3.Distance(lettreFor.transform.position, Box9.transform.position);
        float Distance10 = Vector3.Distance(lettreFor.transform.position, Box10.transform.position);
        float Distance11 = Vector3.Distance(lettreFor.transform.position, Box11.transform.position);
        float Distance12 = Vector3.Distance(lettreFor.transform.position, Box12.transform.position);
        float Distance13 = Vector3.Distance(lettreFor.transform.position, Box13.transform.position);
        float Distance14 = Vector3.Distance(lettreFor.transform.position, Box14.transform.position);
        float Distance15 = Vector3.Distance(lettreFor.transform.position, Box15.transform.position);
        float Distance16 = Vector3.Distance(lettreFor.transform.position, Box16.transform.position);
        float Distance17 = Vector3.Distance(lettreFor.transform.position, Box17.transform.position);

        if (Distance < 50 && oneCorrect == false)
        {
            lettreFor.transform.localScale = BoxOne.transform.localScale;
            lettreFor.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = lettreFor.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance2 < 50 && twoCorrect == false)
        {
            lettreFor.transform.localScale = BoxTwo.transform.localScale;
            lettreFor.transform.position = BoxTwo.transform.position;
            twoCorrect = true;
            BoxTwo.name = lettreFor.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance3 < 50 && threeCorrect == false)
        {
            lettreFor.transform.localScale = BoxThree.transform.localScale;
            lettreFor.transform.position = BoxThree.transform.position;
            threeCorrect = true;
            BoxThree.name = lettreFor.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance4 < 50 && forCorrect == false)
        {
            lettreFor.transform.localScale = BoxFor.transform.localScale;
            lettreFor.transform.position = BoxFor.transform.position;
            forCorrect = true;
            BoxFor.name = lettreFor.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance5 < 50 && fiveCorrect == false)
        {
            lettreFor.transform.localScale = BoxFive.transform.localScale;
            lettreFor.transform.position = BoxFive.transform.position;
            fiveCorrect = true;
            BoxFive.name = lettreFor.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance6 < 50 && sixCorrect == false)
        {
            lettreFor.transform.localScale = Box6.transform.localScale;
            lettreFor.transform.position = Box6.transform.position;
            sixCorrect = true;
            Box6.name = lettreFor.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance7 < 50 && sixCorrect == false)
        {
            lettreFor.transform.localScale = Box7.transform.localScale;
            lettreFor.transform.position = Box7.transform.position;
            sevenCorrect = true;
            Box7.name = lettreFor.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance8 < 50 && eightCorrect == false)
        {
            lettreFor.transform.localScale = Box8.transform.localScale;
            lettreFor.transform.position = Box8.transform.position;
            eightCorrect = true;
            Box8.name = lettreFor.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance9 < 50 && nineCorrect == false)
        {
            lettreFor.transform.localScale = Box9.transform.localScale;
            lettreFor.transform.position = Box9.transform.position;
            nineCorrect = true;
            Box9.name = lettreFor.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance10 < 50 && tenCorrect == false)
        {
            lettreFor.transform.localScale = Box10.transform.localScale;
            lettreFor.transform.position = Box10.transform.position;
            tenCorrect = true;
            Box10.name = lettreFor.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance11 < 50 && elevenCorrect == false)
        {
            lettreFor.transform.localScale = Box11.transform.localScale;
            lettreFor.transform.position = Box11.transform.position;
            elevenCorrect = true;
            Box11.name = lettreFor.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance12 < 50 && tweleveCorrect == false)
        {
            lettreFor.transform.localScale = Box12.transform.localScale;
            lettreFor.transform.position = Box12.transform.position;
            tweleveCorrect = true;
            Box12.name = lettreFor.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance13 < 50 && thirtCorrect == false)
        {
            lettreFor.transform.localScale = Box13.transform.localScale;
            lettreFor.transform.position = Box13.transform.position;
            thirtCorrect = true;
            Box13.name = lettreFor.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance14 < 50 && fortCorrect == false)
        {
            lettreFor.transform.localScale = Box14.transform.localScale;
            lettreFor.transform.position = Box14.transform.position;
            fortCorrect = true;
            Box14.name = lettreFor.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance15 < 50 && fiftCorrect == false)
        {
            lettreFor.transform.localScale = Box15.transform.localScale;
            lettreFor.transform.position = Box15.transform.position;
            fiftCorrect = true;
            Box15.name = lettreFor.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance16 < 50 && sixtCorrect == false)
        {
            lettreFor.transform.localScale = Box16.transform.localScale;
            lettreFor.transform.position = Box16.transform.position;
            sixtCorrect = true;
            Box16.name = lettreFor.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance17 < 50 && tenCorrect == false)
        {
            lettreFor.transform.localScale = Box17.transform.localScale;
            lettreFor.transform.position = Box17.transform.position;
            seventCorrect = true;
            Box17.name = lettreFor.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else
        {
            lettreFor.transform.position = lettreForIni;
          
           
            source.clip = reload;
            source.Play();
        }

    }

    public void DropLettreFive()
    {
        float Distance = Vector3.Distance(lettreFive.transform.position, BoxOne.transform.position);
        float Distance2 = Vector3.Distance(lettreFive.transform.position, BoxTwo.transform.position);
        float Distance3 = Vector3.Distance(lettreFive.transform.position, BoxThree.transform.position);
        float Distance4 = Vector3.Distance(lettreFive.transform.position, BoxFor.transform.position);
        float Distance5 = Vector3.Distance(lettreFive.transform.position, BoxFive.transform.position);
        float Distance6 = Vector3.Distance(lettreFive.transform.position, Box6.transform.position);
        float Distance7 = Vector3.Distance(lettreFive.transform.position, Box7.transform.position);
        float Distance8 = Vector3.Distance(lettreFive.transform.position, Box8.transform.position);
        float Distance9 = Vector3.Distance(lettreFive.transform.position, Box9.transform.position);
        float Distance10 = Vector3.Distance(lettreFive.transform.position, Box10.transform.position);
        float Distance11 = Vector3.Distance(lettreFive.transform.position, Box11.transform.position);
        float Distance12 = Vector3.Distance(lettreFive.transform.position, Box12.transform.position);
        float Distance13 = Vector3.Distance(lettreFive.transform.position, Box13.transform.position);
        float Distance14 = Vector3.Distance(lettreFive.transform.position, Box14.transform.position);
        float Distance15 = Vector3.Distance(lettreFive.transform.position, Box15.transform.position);
        float Distance16 = Vector3.Distance(lettreFive.transform.position, Box16.transform.position);
        float Distance17 = Vector3.Distance(lettreFive.transform.position, Box17.transform.position);

        if (Distance < 50 && oneCorrect == false)
        {
            lettreFive.transform.localScale = BoxOne.transform.localScale;
            lettreFive.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = lettreFive.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance2 < 50 && twoCorrect == false)
        {
            lettreFive.transform.localScale = BoxTwo.transform.localScale;
            lettreFive.transform.position = BoxTwo.transform.position;
            twoCorrect = true;
            BoxTwo.name = lettreFive.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance3 < 50 && threeCorrect == false)
        {
            lettreFive.transform.localScale = BoxThree.transform.localScale;
            lettreFive.transform.position = BoxThree.transform.position;
            threeCorrect = true;
            BoxThree.name = lettreFive.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance4 < 50 && forCorrect == false)
        {
            lettreFive.transform.localScale = BoxFor.transform.localScale;
            lettreFive.transform.position = BoxFor.transform.position;
            forCorrect = true;
            BoxFor.name = lettreFive.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance5 < 50 && fiveCorrect == false)
        {
            lettreFive.transform.localScale = BoxFive.transform.localScale;
            lettreFive.transform.position = BoxFive.transform.position;
            fiveCorrect = true;
            BoxFive.name = lettreFive.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance6 < 50 && sixCorrect == false)
        {
            lettreFive.transform.localScale = Box6.transform.localScale;
            lettreFive.transform.position = Box6.transform.position;
            sixCorrect = true;
            Box6.name = lettreFive.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance7 < 50 && sixCorrect == false)
        {
            lettreFive.transform.localScale = Box7.transform.localScale;
            lettreFive.transform.position = Box7.transform.position;
            sevenCorrect = true;
            Box7.name = lettreFive.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance8 < 50 && eightCorrect == false)
        {
            lettreFive.transform.localScale = Box8.transform.localScale;
            lettreFive.transform.position = Box8.transform.position;
            eightCorrect = true;
            Box8.name = lettreFive.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance9 < 50 && nineCorrect == false)
        {
            lettreFive.transform.localScale = Box9.transform.localScale;
            lettreFive.transform.position = Box9.transform.position;
            nineCorrect = true;
            Box9.name = lettreFive.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance10 < 50 && tenCorrect == false)
        {
            lettreFive.transform.localScale = Box10.transform.localScale;
            lettreFive.transform.position = Box10.transform.position;
            tenCorrect = true;
            Box10.name = lettreFive.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance11 < 50 && elevenCorrect == false)
        {
            lettreFive.transform.localScale = Box11.transform.localScale;
            lettreFive.transform.position = Box11.transform.position;
            elevenCorrect = true;
            Box11.name = lettreFive.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance12 < 50 && tweleveCorrect == false)
        {
            lettreFive.transform.localScale = Box12.transform.localScale;
            lettreFive.transform.position = Box12.transform.position;
            tweleveCorrect = true;
            Box12.name = lettreFive.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance13 < 50 && thirtCorrect == false)
        {
            lettreFive.transform.localScale = Box13.transform.localScale;
            lettreFive.transform.position = Box13.transform.position;
            thirtCorrect = true;
            Box13.name = lettreFive.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance14 < 50 && fortCorrect == false)
        {
            lettreFive.transform.localScale = Box14.transform.localScale;
            lettreFive.transform.position = Box14.transform.position;
            fortCorrect = true;
            Box14.name = lettreFive.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance15 < 50 && fiftCorrect == false)
        {
            lettreFive.transform.localScale = Box15.transform.localScale;
            lettreFive.transform.position = Box15.transform.position;
            fiftCorrect = true;
            Box15.name = lettreFive.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance16 < 50 && sixtCorrect == false)
        {
            lettreFive.transform.localScale = Box16.transform.localScale;
            lettreFive.transform.position = Box16.transform.position;
            sixtCorrect = true;
            Box16.name = lettreFive.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance17 < 50 && tenCorrect == false)
        {
            lettreFive.transform.localScale = Box17.transform.localScale;
            lettreFive.transform.position = Box17.transform.position;
            seventCorrect = true;
            Box17.name = lettreFive.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else
        {
            lettreFive.transform.position = lettreFiveIni;
            
           
            source.clip = reload;
            source.Play();
        }

    }

    public void DropLettreSix()
    {
        float Distance = Vector3.Distance(lettreSix.transform.position, BoxOne.transform.position);
        float Distance2 = Vector3.Distance(lettreSix.transform.position, BoxTwo.transform.position);
        float Distance3 = Vector3.Distance(lettreSix.transform.position, BoxThree.transform.position);
        float Distance4 = Vector3.Distance(lettreSix.transform.position, BoxFor.transform.position);
        float Distance5 = Vector3.Distance(lettreSix.transform.position, BoxFive.transform.position);
        float Distance6 = Vector3.Distance(lettreSix.transform.position, Box6.transform.position);
        float Distance7 = Vector3.Distance(lettreSix.transform.position, Box7.transform.position);
        float Distance8 = Vector3.Distance(lettreSix.transform.position, Box8.transform.position);
        float Distance9 = Vector3.Distance(lettreSix.transform.position, Box9.transform.position);
        float Distance10 = Vector3.Distance(lettreSix.transform.position, Box10.transform.position);
        float Distance11 = Vector3.Distance(lettreSix.transform.position, Box11.transform.position);
        float Distance12 = Vector3.Distance(lettreSix.transform.position, Box12.transform.position);
        float Distance13 = Vector3.Distance(lettreSix.transform.position, Box13.transform.position);
        float Distance14 = Vector3.Distance(lettreSix.transform.position, Box14.transform.position);
        float Distance15 = Vector3.Distance(lettreSix.transform.position, Box15.transform.position);
        float Distance16 = Vector3.Distance(lettreSix.transform.position, Box16.transform.position);
        float Distance17 = Vector3.Distance(lettreSix.transform.position, Box17.transform.position);

        if (Distance < 50 && oneCorrect == false)
        {
            lettreSix.transform.localScale = BoxOne.transform.localScale;
            lettreSix.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = lettreSix.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance2 < 50 && twoCorrect == false)
        {
            lettreSix.transform.localScale = BoxTwo.transform.localScale;
            lettreSix.transform.position = BoxTwo.transform.position;
            twoCorrect = true;
            BoxTwo.name = lettreSix.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance3 < 50 && threeCorrect == false)
        {
            lettreSix.transform.localScale = BoxThree.transform.localScale;
            lettreSix.transform.position = BoxThree.transform.position;
            threeCorrect = true;
            source.clip = buttonDrop;
            source.Play();
            BoxThree.name = lettreSix.name;
        }
        else if (Distance4 < 50 && forCorrect == false)
        {
            lettreSix.transform.localScale = BoxFor.transform.localScale;
            lettreSix.transform.position = BoxFor.transform.position;
            forCorrect = true;
            BoxFor.name = lettreSix.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance5 < 50 && fiveCorrect == false)
        {
            lettreSix.transform.localScale = BoxFive.transform.localScale;
            lettreSix.transform.position = BoxFive.transform.position;
            fiveCorrect = true;
            BoxFive.name = lettreSix.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance6 < 50 && sixCorrect == false)
        {
            lettreSix.transform.localScale = Box6.transform.localScale;
            lettreSix.transform.position = Box6.transform.position;
            sixCorrect = true;
            Box6.name = lettreSix.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance7 < 50 && sixCorrect == false)
        {
            lettreSix.transform.localScale = Box7.transform.localScale;
            lettreSix.transform.position = Box7.transform.position;
            sevenCorrect = true;
            Box7.name = lettreSix.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance8 < 50 && eightCorrect == false)
        {
            lettreSix.transform.localScale = Box8.transform.localScale;
            lettreSix.transform.position = Box8.transform.position;
            eightCorrect = true;
            Box8.name = lettreSix.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance9 < 50 && nineCorrect == false)
        {
            lettreSix.transform.localScale = Box9.transform.localScale;
            lettreSix.transform.position = Box9.transform.position;
            nineCorrect = true;
            Box9.name = lettreSix.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance10 < 50 && tenCorrect == false)
        {
            lettreSix.transform.localScale = Box10.transform.localScale;
            lettreSix.transform.position = Box10.transform.position;
            tenCorrect = true;
            Box10.name = lettreSix.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance11 < 50 && elevenCorrect == false)
        {
            lettreSix.transform.localScale = Box11.transform.localScale;
            lettreSix.transform.position = Box11.transform.position;
            elevenCorrect = true;
            Box11.name = lettreSix.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance12 < 50 && tweleveCorrect == false)
        {
            lettreSix.transform.localScale = Box12.transform.localScale;
            lettreSix.transform.position = Box12.transform.position;
            tweleveCorrect = true;
            Box12.name = lettreSix.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance13 < 50 && thirtCorrect == false)
        {
            lettreSix.transform.localScale = Box13.transform.localScale;
            lettreSix.transform.position = Box13.transform.position;
            thirtCorrect = true;
            Box13.name = lettreSix.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance14 < 50 && fortCorrect == false)
        {
            lettreSix.transform.localScale = Box14.transform.localScale;
            lettreSix.transform.position = Box14.transform.position;
            fortCorrect = true;
            Box14.name = lettreSix.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance15 < 50 && fiftCorrect == false)
        {
            lettreSix.transform.localScale = Box15.transform.localScale;
            lettreSix.transform.position = Box15.transform.position;
            fiftCorrect = true;
            Box15.name = lettreSix.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance16 < 50 && sixtCorrect == false)
        {
            lettreSix.transform.localScale = Box16.transform.localScale;
            lettreSix.transform.position = Box16.transform.position;
            sixtCorrect = true;
            Box16.name = lettreSix.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance17 < 50 && tenCorrect == false)
        {
            lettreSix.transform.localScale = Box17.transform.localScale;
            lettreSix.transform.position = Box17.transform.position;
            seventCorrect = true;
            Box17.name = lettreSix.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else
        {
            lettreSix.transform.position = lettreSixIni;
            
            source.clip = reload;
            source.Play();
        }

    }

    public void DropLettreSeven()
    {
        float Distance = Vector3.Distance(lettreSeven.transform.position, BoxOne.transform.position);
        float Distance2 = Vector3.Distance(lettreSeven.transform.position, BoxTwo.transform.position);
        float Distance3 = Vector3.Distance(lettreSeven.transform.position, BoxThree.transform.position);
        float Distance4 = Vector3.Distance(lettreSeven.transform.position, BoxFor.transform.position);
        float Distance5 = Vector3.Distance(lettreSeven.transform.position, BoxFive.transform.position);
        float Distance6 = Vector3.Distance(lettreSeven.transform.position, Box6.transform.position);
        float Distance7 = Vector3.Distance(lettreSeven.transform.position, Box7.transform.position);
        float Distance8 = Vector3.Distance(lettreSeven.transform.position, Box8.transform.position);
        float Distance9 = Vector3.Distance(lettreSeven.transform.position, Box9.transform.position);
        float Distance10 = Vector3.Distance(lettreSeven.transform.position, Box10.transform.position);
        float Distance11 = Vector3.Distance(lettreSeven.transform.position, Box11.transform.position);
        float Distance12 = Vector3.Distance(lettreSeven.transform.position, Box12.transform.position);
        float Distance13 = Vector3.Distance(lettreSeven.transform.position, Box13.transform.position);
        float Distance14 = Vector3.Distance(lettreSeven.transform.position, Box14.transform.position);
        float Distance15 = Vector3.Distance(lettreSeven.transform.position, Box15.transform.position);
        float Distance16 = Vector3.Distance(lettreSeven.transform.position, Box16.transform.position);
        float Distance17 = Vector3.Distance(lettreSeven.transform.position, Box17.transform.position);

        if (Distance < 50 && oneCorrect == false)
        {
            lettreSeven.transform.localScale = BoxOne.transform.localScale;
            lettreSeven.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = lettreSeven.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance2 < 50 && twoCorrect == false)
        {
            lettreSeven.transform.localScale = BoxTwo.transform.localScale;
            lettreSeven.transform.position = BoxTwo.transform.position;
            twoCorrect = true;
            BoxTwo.name = lettreSeven.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance3 < 50 && threeCorrect == false)
        {
            lettreSeven.transform.localScale = BoxThree.transform.localScale;
            lettreSeven.transform.position = BoxThree.transform.position;
            threeCorrect = true;
            BoxThree.name = lettreSeven.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance4 < 50 && forCorrect == false)
        {
            lettreSeven.transform.localScale = BoxFor.transform.localScale;
            lettreSeven.transform.position = BoxFor.transform.position;
            forCorrect = true;
            BoxFor.name = lettreSeven.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance5 < 50 && fiveCorrect == false)
        {
            lettreSeven.transform.localScale = BoxFive.transform.localScale;
            lettreSeven.transform.position = BoxFive.transform.position;
            fiveCorrect = true;
            BoxFive.name = lettreSeven.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance6 < 50 && sixCorrect == false)
        {
            lettreSeven.transform.localScale = Box6.transform.localScale;
            lettreSeven.transform.position = Box6.transform.position;
            sixCorrect = true;
            Box6.name = lettreSeven.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance7 < 50 && sixCorrect == false)
        {
            lettreSeven.transform.localScale = Box7.transform.localScale;
            lettreSeven.transform.position = Box7.transform.position;
            sevenCorrect = true;
            Box7.name = lettreSeven.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance8 < 50 && eightCorrect == false)
        {
            lettreSeven.transform.localScale = Box8.transform.localScale;
            lettreSeven.transform.position = Box8.transform.position;
            eightCorrect = true;
            Box8.name = lettreSeven.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance9 < 50 && nineCorrect == false)
        {
            lettreSeven.transform.localScale = Box9.transform.localScale;
            lettreSeven.transform.position = Box9.transform.position;
            nineCorrect = true;
            Box9.name = lettreSeven.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance10 < 50 && tenCorrect == false)
        {
            lettreSeven.transform.localScale = Box10.transform.localScale;
            lettreSeven.transform.position = Box10.transform.position;
            tenCorrect = true;
            Box10.name = lettreSeven.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance11 < 50 && elevenCorrect == false)
        {
            lettreSeven.transform.localScale = Box11.transform.localScale;
            lettreSeven.transform.position = Box11.transform.position;
            elevenCorrect = true;
            Box11.name = lettreSeven.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance12 < 50 && tweleveCorrect == false)
        {
            lettreSeven.transform.localScale = Box12.transform.localScale;
            lettreSeven.transform.position = Box12.transform.position;
            tweleveCorrect = true;
            Box12.name = lettreSeven.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance13 < 50 && thirtCorrect == false)
        {
            lettreSeven.transform.localScale = Box13.transform.localScale;
            lettreSeven.transform.position = Box13.transform.position;
            thirtCorrect = true;
            Box13.name = lettreSeven.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance14 < 50 && fortCorrect == false)
        {
            lettreSeven.transform.localScale = Box14.transform.localScale;
            lettreSeven.transform.position = Box14.transform.position;
            fortCorrect = true;
            Box14.name = lettreSeven.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance15 < 50 && fiftCorrect == false)
        {
            lettreSeven.transform.localScale = Box15.transform.localScale;
            lettreSeven.transform.position = Box15.transform.position;
            fiftCorrect = true;
            Box15.name = lettreSeven.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance16 < 50 && sixtCorrect == false)
        {
            lettreSeven.transform.localScale = Box16.transform.localScale;
            lettreSeven.transform.position = Box16.transform.position;
            sixtCorrect = true;
            Box16.name = lettreSeven.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance17 < 50 && tenCorrect == false)
        {
            lettreSeven.transform.localScale = Box17.transform.localScale;
            lettreSeven.transform.position = Box17.transform.position;
            seventCorrect = true;
            Box17.name = lettreSeven.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else
        {
            lettreSeven.transform.position = lettreSevenIni;
            
            source.clip = reload;
            source.Play();
        }

    }

    public void DropLettreEight()
    {
        float Distance = Vector3.Distance(lettreEight.transform.position, BoxOne.transform.position);
        float Distance2 = Vector3.Distance(lettreEight.transform.position, BoxTwo.transform.position);
        float Distance3 = Vector3.Distance(lettreEight.transform.position, BoxThree.transform.position);
        float Distance4 = Vector3.Distance(lettreEight.transform.position, BoxFor.transform.position);
        float Distance5 = Vector3.Distance(lettreEight.transform.position, BoxFive.transform.position);
        float Distance6 = Vector3.Distance(lettreEight.transform.position, Box6.transform.position);
        float Distance7 = Vector3.Distance(lettreEight.transform.position, Box7.transform.position);
        float Distance8 = Vector3.Distance(lettreEight.transform.position, Box8.transform.position);
        float Distance9 = Vector3.Distance(lettreEight.transform.position, Box9.transform.position);
        float Distance10 = Vector3.Distance(lettreEight.transform.position, Box10.transform.position);
        float Distance11 = Vector3.Distance(lettreEight.transform.position, Box11.transform.position);
        float Distance12 = Vector3.Distance(lettreEight.transform.position, Box12.transform.position);
        float Distance13 = Vector3.Distance(lettreEight.transform.position, Box13.transform.position);
        float Distance14 = Vector3.Distance(lettreEight.transform.position, Box14.transform.position);
        float Distance15 = Vector3.Distance(lettreEight.transform.position, Box15.transform.position);
        float Distance16 = Vector3.Distance(lettreEight.transform.position, Box16.transform.position);
        float Distance17 = Vector3.Distance(lettreEight.transform.position, Box17.transform.position);

        if (Distance < 50 && oneCorrect == false)
        {
            lettreEight.transform.localScale = BoxOne.transform.localScale;
            lettreEight.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = lettreEight.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance2 < 50 && twoCorrect == false)
        {
            lettreEight.transform.localScale = BoxTwo.transform.localScale;
            lettreEight.transform.position = BoxTwo.transform.position;
            twoCorrect = true;
            BoxTwo.name = lettreEight.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance3 < 50 && threeCorrect == false)
        {
            lettreEight.transform.localScale = BoxThree.transform.localScale;
            lettreEight.transform.position = BoxThree.transform.position;
            threeCorrect = true;
            BoxThree.name = lettreEight.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance4 < 50 && forCorrect == false)
        {
            lettreEight.transform.localScale = BoxFor.transform.localScale;
            lettreEight.transform.position = BoxFor.transform.position;
            forCorrect = true;
            BoxFor.name = lettreEight.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance5 < 50 && fiveCorrect == false)
        {
            lettreEight.transform.localScale = BoxFive.transform.localScale;
            lettreEight.transform.position = BoxFive.transform.position;
            fiveCorrect = true;
            BoxFive.name = lettreEight.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance6 < 50 && sixCorrect == false)
        {
            lettreEight.transform.localScale = Box6.transform.localScale;
            lettreEight.transform.position = Box6.transform.position;
            sixCorrect = true;
            Box6.name = lettreEight.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance7 < 50 && sixCorrect == false)
        {
            lettreEight.transform.localScale = Box7.transform.localScale;
            lettreEight.transform.position = Box7.transform.position;
            sevenCorrect = true;
            Box7.name = lettreEight.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance8 < 50 && eightCorrect == false)
        {
            lettreEight.transform.localScale = Box8.transform.localScale;
            lettreEight.transform.position = Box8.transform.position;
            eightCorrect = true;
            Box8.name = lettreEight.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance9 < 50 && nineCorrect == false)
        {
            lettreEight.transform.localScale = Box9.transform.localScale;
            lettreEight.transform.position = Box9.transform.position;
            nineCorrect = true;
            Box9.name = lettreEight.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance10 < 50 && tenCorrect == false)
        {
            lettreEight.transform.localScale = Box10.transform.localScale;
            lettreEight.transform.position = Box10.transform.position;
            tenCorrect = true;
            Box10.name = lettreEight.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance11 < 50 && elevenCorrect == false)
        {
            lettreEight.transform.localScale = Box11.transform.localScale;
            lettreEight.transform.position = Box11.transform.position;
            elevenCorrect = true;
            Box11.name = lettreEight.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance12 < 50 && tweleveCorrect == false)
        {
            lettreEight.transform.localScale = Box12.transform.localScale;
            lettreEight.transform.position = Box12.transform.position;
            tweleveCorrect = true;
            Box12.name = lettreEight.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance13 < 50 && thirtCorrect == false)
        {
            lettreEight.transform.localScale = Box13.transform.localScale;
            lettreEight.transform.position = Box13.transform.position;
            thirtCorrect = true;
            Box13.name = lettreEight.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance14 < 50 && fortCorrect == false)
        {
            lettreEight.transform.localScale = Box14.transform.localScale;
            lettreEight.transform.position = Box14.transform.position;
            fortCorrect = true;
            Box14.name = lettreEight.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance15 < 50 && fiftCorrect == false)
        {
            lettreEight.transform.localScale = Box15.transform.localScale;
            lettreEight.transform.position = Box15.transform.position;
            fiftCorrect = true;
            Box15.name = lettreEight.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance16 < 50 && sixtCorrect == false)
        {
            lettreEight.transform.localScale = Box16.transform.localScale;
            lettreEight.transform.position = Box16.transform.position;
            sixtCorrect = true;
            Box16.name = lettreEight.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance17 < 50 && tenCorrect == false)
        {
            lettreEight.transform.localScale = Box17.transform.localScale;
            lettreEight.transform.position = Box17.transform.position;
            seventCorrect = true;
            Box17.name = lettreEight.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else
        {
            lettreEight.transform.position = lettreEightIni;
         
            source.clip = reload;
            source.Play();
        }

    }

    public void DropLettre9()
    {
        float Distance = Vector3.Distance(lettre9.transform.position, BoxOne.transform.position);
        float Distance2 = Vector3.Distance(lettre9.transform.position, BoxTwo.transform.position);
        float Distance3 = Vector3.Distance(lettre9.transform.position, BoxThree.transform.position);
        float Distance4 = Vector3.Distance(lettre9.transform.position, BoxFor.transform.position);
        float Distance5 = Vector3.Distance(lettre9.transform.position, BoxFive.transform.position);
        float Distance6 = Vector3.Distance(lettre9.transform.position, Box6.transform.position);
        float Distance7 = Vector3.Distance(lettre9.transform.position, Box7.transform.position);
        float Distance8 = Vector3.Distance(lettre9.transform.position, Box8.transform.position);
        float Distance9 = Vector3.Distance(lettre9.transform.position, Box9.transform.position);
        float Distance10 = Vector3.Distance(lettre9.transform.position, Box10.transform.position);
        float Distance11 = Vector3.Distance(lettre9.transform.position, Box11.transform.position);
        float Distance12 = Vector3.Distance(lettre9.transform.position, Box12.transform.position);
        float Distance13 = Vector3.Distance(lettre9.transform.position, Box13.transform.position);
        float Distance14 = Vector3.Distance(lettre9.transform.position, Box14.transform.position);
        float Distance15 = Vector3.Distance(lettre9.transform.position, Box15.transform.position);
        float Distance16 = Vector3.Distance(lettre9.transform.position, Box16.transform.position);
        float Distance17 = Vector3.Distance(lettre9.transform.position, Box17.transform.position);


        if (Distance < 50 && oneCorrect == false)
        {
            lettre9.transform.localScale = BoxOne.transform.localScale;
            lettre9.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = lettre9.name;
            source.clip = buttonDrop;
            source.Play();


        }
        else if (Distance2 < 50 && twoCorrect == false)
        {
            lettre9.transform.localScale = BoxTwo.transform.localScale;
            lettre9.transform.position = BoxTwo.transform.position;
            twoCorrect = true;
            BoxTwo.name = lettre9.name;
            source.clip = buttonDrop;
            source.Play();

        }
        else if (Distance3 < 50 && threeCorrect == false)
        {
            lettre9.transform.localScale = BoxThree.transform.localScale;
            lettre9.transform.position = BoxThree.transform.position;
            threeCorrect = true;
            BoxThree.name = lettre9.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance4 < 50 && forCorrect == false)
        {
            lettre9.transform.localScale = BoxFor.transform.localScale;
            lettre9.transform.position = BoxFor.transform.position;
            forCorrect = true;
            BoxFor.name = lettre9.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance5 < 50 && fiveCorrect == false)
        {
            lettre9.transform.localScale = BoxFive.transform.localScale;
            lettre9.transform.position = BoxFive.transform.position;
            fiveCorrect = true;
            BoxFive.name = lettre9.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance6 < 50 && sixCorrect == false)
        {
            lettre9.transform.localScale = Box6.transform.localScale;
            lettre9.transform.position = Box6.transform.position;
            sixCorrect = true;
            Box6.name = lettre9.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance7 < 50 && sixCorrect == false)
        {
            lettre9.transform.localScale = Box7.transform.localScale;
            lettre9.transform.position = Box7.transform.position;
            sevenCorrect = true;
            Box7.name = lettre9.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance8 < 50 && eightCorrect == false)
        {
            lettre9.transform.localScale = Box8.transform.localScale;
            lettre9.transform.position = Box8.transform.position;
            eightCorrect = true;
            Box8.name = lettre9.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance9 < 50 && nineCorrect == false)
        {
            lettre9.transform.localScale = Box9.transform.localScale;
            lettre9.transform.position = Box9.transform.position;
            nineCorrect = true;
            Box9.name = lettre9.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance10 < 50 && tenCorrect == false)
        {
            lettre9.transform.localScale = Box10.transform.localScale;
            lettre9.transform.position = Box10.transform.position;
            tenCorrect = true;
            Box10.name = lettre9.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance11 < 50 && elevenCorrect == false)
        {
            lettre9.transform.localScale = Box11.transform.localScale;
            lettre9.transform.position = Box11.transform.position;
            elevenCorrect = true;
            Box11.name = lettre9.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance12 < 50 && tweleveCorrect == false)
        {
            lettre9.transform.localScale = Box12.transform.localScale;
            lettre9.transform.position = Box12.transform.position;
            tweleveCorrect = true;
            Box12.name = lettre9.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance13 < 50 && thirtCorrect == false)
        {
            lettre9.transform.localScale = Box13.transform.localScale;
            lettre9.transform.position = Box13.transform.position;
            thirtCorrect = true;
            Box13.name = lettre9.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance14 < 50 && fortCorrect == false)
        {
            lettre9.transform.localScale = Box14.transform.localScale;
            lettre9.transform.position = Box14.transform.position;
            fortCorrect = true;
            Box14.name = lettre9.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance15 < 50 && fiftCorrect == false)
        {
            lettre9.transform.localScale = Box15.transform.localScale;
            lettre9.transform.position = Box15.transform.position;
            fiftCorrect = true;
            Box15.name = lettre9.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance16 < 50 && sixtCorrect == false)
        {
            lettre9.transform.localScale = Box16.transform.localScale;
            lettre9.transform.position = Box16.transform.position;
            sixtCorrect = true;
            Box16.name = lettre9.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance17 < 50 && tenCorrect == false)
        {
            lettre9.transform.localScale = Box17.transform.localScale;
            lettre9.transform.position = Box17.transform.position;
            seventCorrect = true;
            Box17.name = lettre9.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else
        {
            lettre9.transform.position = lettre9Ini;
            
            source.clip = reload;
            source.Play();
        }

    }

    public void DropLettre10()
    {
        float Distance = Vector3.Distance(lettre10.transform.position, BoxOne.transform.position);
        float Distance2 = Vector3.Distance(lettre10.transform.position, BoxTwo.transform.position);
        float Distance3 = Vector3.Distance(lettre10.transform.position, BoxThree.transform.position);
        float Distance4 = Vector3.Distance(lettre10.transform.position, BoxFor.transform.position);
        float Distance5 = Vector3.Distance(lettre10.transform.position, BoxFive.transform.position);
        float Distance6 = Vector3.Distance(lettre10.transform.position, Box6.transform.position);
        float Distance7 = Vector3.Distance(lettre10.transform.position, Box7.transform.position);
        float Distance8 = Vector3.Distance(lettre10.transform.position, Box8.transform.position);
        float Distance9 = Vector3.Distance(lettre10.transform.position, Box9.transform.position);
        float Distance10 = Vector3.Distance(lettre10.transform.position, Box10.transform.position);
        float Distance11 = Vector3.Distance(lettre10.transform.position, Box11.transform.position);
        float Distance12 = Vector3.Distance(lettre10.transform.position, Box12.transform.position);
        float Distance13 = Vector3.Distance(lettre10.transform.position, Box13.transform.position);
        float Distance14 = Vector3.Distance(lettre10.transform.position, Box14.transform.position);
        float Distance15 = Vector3.Distance(lettre10.transform.position, Box15.transform.position);
        float Distance16 = Vector3.Distance(lettre10.transform.position, Box16.transform.position);
        float Distance17 = Vector3.Distance(lettre10.transform.position, Box17.transform.position);


        if (Distance < 50 && oneCorrect == false)
        {
            lettre10.transform.localScale = BoxOne.transform.localScale;
            lettre10.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = lettre10.name;
            source.clip = buttonDrop;
            source.Play();


        }
        else if (Distance2 < 50 && twoCorrect == false)
        {
            lettre10.transform.localScale = BoxTwo.transform.localScale;
            lettre10.transform.position = BoxTwo.transform.position;
            twoCorrect = true;
            BoxTwo.name = lettre10.name;
            source.clip = buttonDrop;
            source.Play();

        }
        else if (Distance3 < 50 && threeCorrect == false)
        {
            lettre10.transform.localScale = BoxThree.transform.localScale;
            lettre10.transform.position = BoxThree.transform.position;
            threeCorrect = true;
            BoxThree.name = lettre10.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance4 < 50 && forCorrect == false)
        {
            lettre10.transform.localScale = BoxFor.transform.localScale;
            lettre10.transform.position = BoxFor.transform.position;
            forCorrect = true;
            BoxFor.name = lettre10.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance5 < 50 && fiveCorrect == false)
        {
            lettre10.transform.localScale = BoxFive.transform.localScale;
            lettre10.transform.position = BoxFive.transform.position;
            fiveCorrect = true;
            BoxFive.name = lettre10.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance6 < 50 && sixCorrect == false)
        {
            lettre10.transform.localScale = Box6.transform.localScale;
            lettre10.transform.position = Box6.transform.position;
            sixCorrect = true;
            Box6.name = lettre10.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance7 < 50 && sixCorrect == false)
        {
            lettre10.transform.localScale = Box7.transform.localScale;
            lettre10.transform.position = Box7.transform.position;
            sevenCorrect = true;
            Box7.name = lettre10.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance8 < 50 && eightCorrect == false)
        {
            lettre10.transform.localScale = Box8.transform.localScale;
            lettre10.transform.position = Box8.transform.position;
            eightCorrect = true;
            Box8.name = lettre10.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance9 < 50 && nineCorrect == false)
        {
            lettre10.transform.localScale = Box9.transform.localScale;
            lettre10.transform.position = Box9.transform.position;
            nineCorrect = true;
            Box9.name = lettre10.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance10 < 50 && tenCorrect == false)
        {
            lettre10.transform.localScale = Box10.transform.localScale;
            lettre10.transform.position = Box10.transform.position;
            tenCorrect = true;
            Box10.name = lettre10.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance11 < 50 && elevenCorrect == false)
        {
            lettre10.transform.localScale = Box11.transform.localScale;
            lettre10.transform.position = Box11.transform.position;
            elevenCorrect = true;
            Box11.name = lettre10.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance12 < 50 && tweleveCorrect == false)
        {
            lettre10.transform.localScale = Box12.transform.localScale;
            lettre10.transform.position = Box12.transform.position;
            tweleveCorrect = true;
            Box12.name = lettre10.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance13 < 50 && thirtCorrect == false)
        {
            lettre10.transform.localScale = Box13.transform.localScale;
            lettre10.transform.position = Box13.transform.position;
            thirtCorrect = true;
            Box13.name = lettre10.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance14 < 50 && fortCorrect == false)
        {
            lettre10.transform.localScale = Box14.transform.localScale;
            lettre10.transform.position = Box14.transform.position;
            fortCorrect = true;
            Box14.name = lettre10.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance15 < 50 && fiftCorrect == false)
        {
            lettre10.transform.localScale = Box15.transform.localScale;
            lettre10.transform.position = Box15.transform.position;
            fiftCorrect = true;
            Box15.name = lettre10.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance16 < 50 && sixtCorrect == false)
        {
            lettre10.transform.localScale = Box16.transform.localScale;
            lettre10.transform.position = Box16.transform.position;
            sixtCorrect = true;
            Box16.name = lettre10.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance17 < 50 && tenCorrect == false)
        {
            lettre10.transform.localScale = Box17.transform.localScale;
            lettre10.transform.position = Box17.transform.position;
            seventCorrect = true;
            Box17.name = lettre10.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else
        {
            lettre10.transform.position = lettre10Ini;
           
            source.clip = reload;
            source.Play();
        }

    }

    public void DropLettre11()
    {
        float Distance = Vector3.Distance(lettre11.transform.position, BoxOne.transform.position);
        float Distance2 = Vector3.Distance(lettre11.transform.position, BoxTwo.transform.position);
        float Distance3 = Vector3.Distance(lettre11.transform.position, BoxThree.transform.position);
        float Distance4 = Vector3.Distance(lettre11.transform.position, BoxFor.transform.position);
        float Distance5 = Vector3.Distance(lettre11.transform.position, BoxFive.transform.position);
        float Distance6 = Vector3.Distance(lettre11.transform.position, Box6.transform.position);
        float Distance7 = Vector3.Distance(lettre11.transform.position, Box7.transform.position);
        float Distance8 = Vector3.Distance(lettre11.transform.position, Box8.transform.position);
        float Distance9 = Vector3.Distance(lettre11.transform.position, Box9.transform.position);
        float Distance10 = Vector3.Distance(lettre11.transform.position, Box10.transform.position);
        float Distance11 = Vector3.Distance(lettre11.transform.position, Box11.transform.position);
        float Distance12 = Vector3.Distance(lettre11.transform.position, Box12.transform.position);
        float Distance13 = Vector3.Distance(lettre11.transform.position, Box13.transform.position);
        float Distance14 = Vector3.Distance(lettre11.transform.position, Box14.transform.position);
        float Distance15 = Vector3.Distance(lettre11.transform.position, Box15.transform.position);
        float Distance16 = Vector3.Distance(lettre11.transform.position, Box16.transform.position);
        float Distance17 = Vector3.Distance(lettre11.transform.position, Box17.transform.position);


        if (Distance < 50 && oneCorrect == false)
        {
            lettre11.transform.localScale = BoxOne.transform.localScale;
            lettre11.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = lettre11.name;
            source.clip = buttonDrop;
            source.Play();


        }
        else if (Distance2 < 50 && twoCorrect == false)
        {
            lettre11.transform.localScale = BoxTwo.transform.localScale;
            lettre11.transform.position = BoxTwo.transform.position;
            twoCorrect = true;
            BoxTwo.name = lettre11.name;
            source.clip = buttonDrop;
            source.Play();

        }
        else if (Distance3 < 50 && threeCorrect == false)
        {
            lettre11.transform.localScale = BoxThree.transform.localScale;
            lettre11.transform.position = BoxThree.transform.position;
            threeCorrect = true;
            BoxThree.name = lettre11.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance4 < 50 && forCorrect == false)
        {
            lettre11.transform.localScale = BoxFor.transform.localScale;
            lettre11.transform.position = BoxFor.transform.position;
            forCorrect = true;
            BoxFor.name = lettre11.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance5 < 50 && fiveCorrect == false)
        {
            lettre11.transform.localScale = BoxFive.transform.localScale;
            lettre11.transform.position = BoxFive.transform.position;
            fiveCorrect = true;
            BoxFive.name = lettre11.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance6 < 50 && sixCorrect == false)
        {
            lettre11.transform.localScale = Box6.transform.localScale;
            lettre11.transform.position = Box6.transform.position;
            sixCorrect = true;
            Box6.name = lettre11.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance7 < 50 && sixCorrect == false)
        {
            lettre11.transform.localScale = Box7.transform.localScale;
            lettre11.transform.position = Box7.transform.position;
            sevenCorrect = true;
            Box7.name = lettre11.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance8 < 50 && eightCorrect == false)
        {
            lettre11.transform.localScale = Box8.transform.localScale;
            lettre11.transform.position = Box8.transform.position;
            eightCorrect = true;
            Box8.name = lettre11.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance9 < 50 && nineCorrect == false)
        {
            lettre11.transform.localScale = Box9.transform.localScale;
            lettre11.transform.position = Box9.transform.position;
            nineCorrect = true;
            Box9.name = lettre11.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance10 < 50 && tenCorrect == false)
        {
            lettre11.transform.localScale = Box10.transform.localScale;
            lettre11.transform.position = Box10.transform.position;
            tenCorrect = true;
            Box10.name = lettre11.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance11 < 50 && elevenCorrect == false)
        {
            lettre11.transform.localScale = Box11.transform.localScale;
            lettre11.transform.position = Box11.transform.position;
            elevenCorrect = true;
            Box11.name = lettre11.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance12 < 50 && tweleveCorrect == false)
        {
            lettre11.transform.localScale = Box12.transform.localScale;
            lettre11.transform.position = Box12.transform.position;
            tweleveCorrect = true;
            Box12.name = lettre11.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance13 < 50 && thirtCorrect == false)
        {
            lettre11.transform.localScale = Box13.transform.localScale;
            lettre11.transform.position = Box13.transform.position;
            thirtCorrect = true;
            Box13.name = lettre11.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance14 < 50 && fortCorrect == false)
        {
            lettre11.transform.localScale = Box14.transform.localScale;
            lettre11.transform.position = Box14.transform.position;
            fortCorrect = true;
            Box14.name = lettre11.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance15 < 50 && fiftCorrect == false)
        {
            lettre11.transform.localScale = Box15.transform.localScale;
            lettre11.transform.position = Box15.transform.position;
            fiftCorrect = true;
            Box15.name = lettre11.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance16 < 50 && sixtCorrect == false)
        {
            lettre11.transform.localScale = Box16.transform.localScale;
            lettre11.transform.position = Box16.transform.position;
            sixtCorrect = true;
            Box16.name = lettre11.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance17 < 50 && tenCorrect == false)
        {
            lettre11.transform.localScale = Box17.transform.localScale;
            lettre11.transform.position = Box17.transform.position;
            seventCorrect = true;
            Box17.name = lettre11.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else
        {
            lettre11.transform.position = lettre11Ini;
           
            source.clip = reload;
            source.Play();
        }

    }
    public void DropLettre12()
    {
        float Distance = Vector3.Distance(lettre12.transform.position, BoxOne.transform.position);
        float Distance2 = Vector3.Distance(lettre12.transform.position, BoxTwo.transform.position);
        float Distance3 = Vector3.Distance(lettre12.transform.position, BoxThree.transform.position);
        float Distance4 = Vector3.Distance(lettre12.transform.position, BoxFor.transform.position);
        float Distance5 = Vector3.Distance(lettre12.transform.position, BoxFive.transform.position);
        float Distance6 = Vector3.Distance(lettre12.transform.position, Box6.transform.position);
        float Distance7 = Vector3.Distance(lettre12.transform.position, Box7.transform.position);
        float Distance8 = Vector3.Distance(lettre12.transform.position, Box8.transform.position);
        float Distance9 = Vector3.Distance(lettre12.transform.position, Box9.transform.position);
        float Distance10 = Vector3.Distance(lettre12.transform.position, Box10.transform.position);
        float Distance11 = Vector3.Distance(lettre12.transform.position, Box11.transform.position);
        float Distance12 = Vector3.Distance(lettre12.transform.position, Box12.transform.position);
        float Distance13 = Vector3.Distance(lettre12.transform.position, Box13.transform.position);
        float Distance14 = Vector3.Distance(lettre12.transform.position, Box14.transform.position);
        float Distance15 = Vector3.Distance(lettre12.transform.position, Box15.transform.position);
        float Distance16 = Vector3.Distance(lettre12.transform.position, Box16.transform.position);
        float Distance17 = Vector3.Distance(lettre12.transform.position, Box17.transform.position);


        if (Distance < 50 && oneCorrect == false)
        {
            lettre12.transform.localScale = BoxOne.transform.localScale;
            lettre12.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = lettre12.name;
            source.clip = buttonDrop;
            source.Play();


        }
        else if (Distance2 < 50 && twoCorrect == false)
        {
            lettre12.transform.localScale = BoxTwo.transform.localScale;
            lettre12.transform.position = BoxTwo.transform.position;
            twoCorrect = true;
            BoxTwo.name = lettre12.name;
            source.clip = buttonDrop;
            source.Play();

        }
        else if (Distance3 < 50 && threeCorrect == false)
        {
            lettre12.transform.localScale = BoxThree.transform.localScale;
            lettre12.transform.position = BoxThree.transform.position;
            threeCorrect = true;
            BoxThree.name = lettre12.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance4 < 50 && forCorrect == false)
        {
            lettre12.transform.localScale = BoxFor.transform.localScale;
            lettre12.transform.position = BoxFor.transform.position;
            forCorrect = true;
            BoxFor.name = lettre12.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance5 < 50 && fiveCorrect == false)
        {
            lettre12.transform.localScale = BoxFive.transform.localScale;
            lettre12.transform.position = BoxFive.transform.position;
            fiveCorrect = true;
            BoxFive.name = lettre12.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance6 < 50 && sixCorrect == false)
        {
            lettre12.transform.localScale = Box6.transform.localScale;
            lettre12.transform.position = Box6.transform.position;
            sixCorrect = true;
            Box6.name = lettre12.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance7 < 50 && sixCorrect == false)
        {
            lettre12.transform.localScale = Box7.transform.localScale;
            lettre12.transform.position = Box7.transform.position;
            sevenCorrect = true;
            Box7.name = lettre12.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance8 < 50 && eightCorrect == false)
        {
            lettre12.transform.localScale = Box8.transform.localScale;
            lettre12.transform.position = Box8.transform.position;
            eightCorrect = true;
            Box8.name = lettre12.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance9 < 50 && nineCorrect == false)
        {
            lettre12.transform.localScale = Box9.transform.localScale;
            lettre12.transform.position = Box9.transform.position;
            nineCorrect = true;
            Box9.name = lettre12.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance10 < 50 && tenCorrect == false)
        {
            lettre12.transform.localScale = Box10.transform.localScale;
            lettre12.transform.position = Box10.transform.position;
            tenCorrect = true;
            Box10.name = lettre12.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance11 < 50 && elevenCorrect == false)
        {
            lettre12.transform.localScale = Box11.transform.localScale;
            lettre12.transform.position = Box11.transform.position;
            elevenCorrect = true;
            Box11.name = lettre12.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance12 < 50 && tweleveCorrect == false)
        {
            lettre12.transform.localScale = Box12.transform.localScale;
            lettre12.transform.position = Box12.transform.position;
            tweleveCorrect = true;
            Box12.name = lettre12.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance13 < 50 && thirtCorrect == false)
        {
            lettre12.transform.localScale = Box13.transform.localScale;
            lettre12.transform.position = Box13.transform.position;
            thirtCorrect = true;
            Box13.name = lettre12.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance14 < 50 && fortCorrect == false)
        {
            lettre12.transform.localScale = Box14.transform.localScale;
            lettre12.transform.position = Box14.transform.position;
            fortCorrect = true;
            Box14.name = lettre12.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance15 < 50 && fiftCorrect == false)
        {
            lettre12.transform.localScale = Box15.transform.localScale;
            lettre12.transform.position = Box15.transform.position;
            fiftCorrect = true;
            Box15.name = lettre12.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance16 < 50 && sixtCorrect == false)
        {
            lettre12.transform.localScale = Box16.transform.localScale;
            lettre12.transform.position = Box16.transform.position;
            sixtCorrect = true;
            Box16.name = lettre12.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance17 < 50 && tenCorrect == false)
        {
            lettre12.transform.localScale = Box17.transform.localScale;
            lettre12.transform.position = Box17.transform.position;
            seventCorrect = true;
            Box17.name = lettre12.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else
        {
            lettre12.transform.position = lettre12Ini;
            
            source.clip = reload;
            source.Play();
        }

    }
    public void DropLettre13()
    {
        float Distance = Vector3.Distance(lettre13.transform.position, BoxOne.transform.position);
        float Distance2 = Vector3.Distance(lettre13.transform.position, BoxTwo.transform.position);
        float Distance3 = Vector3.Distance(lettre13.transform.position, BoxThree.transform.position);
        float Distance4 = Vector3.Distance(lettre13.transform.position, BoxFor.transform.position);
        float Distance5 = Vector3.Distance(lettre13.transform.position, BoxFive.transform.position);
        float Distance6 = Vector3.Distance(lettre13.transform.position, Box6.transform.position);
        float Distance7 = Vector3.Distance(lettre13.transform.position, Box7.transform.position);
        float Distance8 = Vector3.Distance(lettre13.transform.position, Box8.transform.position);
        float Distance9 = Vector3.Distance(lettre13.transform.position, Box9.transform.position);
        float Distance10 = Vector3.Distance(lettre13.transform.position, Box10.transform.position);
        float Distance11 = Vector3.Distance(lettre13.transform.position, Box11.transform.position);
        float Distance12 = Vector3.Distance(lettre13.transform.position, Box12.transform.position);
        float Distance13 = Vector3.Distance(lettre13.transform.position, Box13.transform.position);
        float Distance14 = Vector3.Distance(lettre13.transform.position, Box14.transform.position);
        float Distance15 = Vector3.Distance(lettre13.transform.position, Box15.transform.position);
        float Distance16 = Vector3.Distance(lettre13.transform.position, Box16.transform.position);
        float Distance17 = Vector3.Distance(lettre13.transform.position, Box17.transform.position);


        if (Distance < 50 && oneCorrect == false)
        {
            lettre13.transform.localScale = BoxOne.transform.localScale;
            lettre13.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = lettre13.name;
            source.clip = buttonDrop;
            source.Play();


        }
        else if (Distance2 < 50 && twoCorrect == false)
        {
            lettre13.transform.localScale = BoxTwo.transform.localScale;
            lettre13.transform.position = BoxTwo.transform.position;
            twoCorrect = true;
            BoxTwo.name = lettre13.name;
            source.clip = buttonDrop;
            source.Play();

        }
        else if (Distance3 < 50 && threeCorrect == false)
        {
            lettre13.transform.localScale = BoxThree.transform.localScale;
            lettre13.transform.position = BoxThree.transform.position;
            threeCorrect = true;
            BoxThree.name = lettre13.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance4 < 50 && forCorrect == false)
        {
            lettre13.transform.localScale = BoxFor.transform.localScale;
            lettre13.transform.position = BoxFor.transform.position;
            forCorrect = true;
            BoxFor.name = lettre13.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance5 < 50 && fiveCorrect == false)
        {
            lettre13.transform.localScale = BoxFive.transform.localScale;
            lettre13.transform.position = BoxFive.transform.position;
            fiveCorrect = true;
            BoxFive.name = lettre13.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance6 < 50 && sixCorrect == false)
        {
            lettre13.transform.localScale = Box6.transform.localScale;
            lettre13.transform.position = Box6.transform.position;
            sixCorrect = true;
            Box6.name = lettre13.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance7 < 50 && sixCorrect == false)
        {
            lettre13.transform.localScale = Box7.transform.localScale;
            lettre13.transform.position = Box7.transform.position;
            sevenCorrect = true;
            Box7.name = lettre13.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance8 < 50 && eightCorrect == false)
        {
            lettre13.transform.localScale = Box8.transform.localScale;
            lettre13.transform.position = Box8.transform.position;
            eightCorrect = true;
            Box8.name = lettre13.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance9 < 50 && nineCorrect == false)
        {
            lettre13.transform.localScale = Box9.transform.localScale;
            lettre13.transform.position = Box9.transform.position;
            nineCorrect = true;
            Box9.name = lettre13.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance10 < 50 && tenCorrect == false)
        {
            lettre13.transform.localScale = Box10.transform.localScale;
            lettre13.transform.position = Box10.transform.position;
            tenCorrect = true;
            Box10.name = lettre13.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance11 < 50 && elevenCorrect == false)
        {
            lettre13.transform.localScale = Box11.transform.localScale;
            lettre13.transform.position = Box11.transform.position;
            elevenCorrect = true;
            Box11.name = lettre13.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance12 < 50 && tweleveCorrect == false)
        {
            lettre13.transform.localScale = Box12.transform.localScale;
            lettre13.transform.position = Box12.transform.position;
            tweleveCorrect = true;
            Box12.name = lettre13.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance13 < 50 && thirtCorrect == false)
        {
            lettre13.transform.localScale = Box13.transform.localScale;
            lettre13.transform.position = Box13.transform.position;
            thirtCorrect = true;
            Box13.name = lettre13.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance14 < 50 && fortCorrect == false)
        {
            lettre13.transform.localScale = Box14.transform.localScale;
            lettre13.transform.position = Box14.transform.position;
            fortCorrect = true;
            Box14.name = lettre13.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance15 < 50 && fiftCorrect == false)
        {
            lettre13.transform.localScale = Box15.transform.localScale;
            lettre13.transform.position = Box15.transform.position;
            fiftCorrect = true;
            Box15.name = lettre13.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance16 < 50 && sixtCorrect == false)
        {
            lettre13.transform.localScale = Box16.transform.localScale;
            lettre13.transform.position = Box16.transform.position;
            sixtCorrect = true;
            Box16.name = lettre13.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance17 < 50 && tenCorrect == false)
        {
            lettre13.transform.localScale = Box17.transform.localScale;
            lettre13.transform.position = Box17.transform.position;
            seventCorrect = true;
            Box17.name = lettre13.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else
        {
            lettre13.transform.position = lettre13Ini;
            
            source.clip = reload;
            source.Play();
        }

    }
    public void DropLettre14()
    {
        float Distance = Vector3.Distance(lettre14.transform.position, BoxOne.transform.position);
        float Distance2 = Vector3.Distance(lettre14.transform.position, BoxTwo.transform.position);
        float Distance3 = Vector3.Distance(lettre14.transform.position, BoxThree.transform.position);
        float Distance4 = Vector3.Distance(lettre14.transform.position, BoxFor.transform.position);
        float Distance5 = Vector3.Distance(lettre14.transform.position, BoxFive.transform.position);
        float Distance6 = Vector3.Distance(lettre14.transform.position, Box6.transform.position);
        float Distance7 = Vector3.Distance(lettre14.transform.position, Box7.transform.position);
        float Distance8 = Vector3.Distance(lettre14.transform.position, Box8.transform.position);
        float Distance9 = Vector3.Distance(lettre14.transform.position, Box9.transform.position);
        float Distance10 = Vector3.Distance(lettre14.transform.position, Box10.transform.position);
        float Distance11 = Vector3.Distance(lettre14.transform.position, Box11.transform.position);
        float Distance12 = Vector3.Distance(lettre14.transform.position, Box12.transform.position);
        float Distance13 = Vector3.Distance(lettre14.transform.position, Box13.transform.position);
        float Distance14 = Vector3.Distance(lettre14.transform.position, Box14.transform.position);
        float Distance15 = Vector3.Distance(lettre14.transform.position, Box15.transform.position);
        float Distance16 = Vector3.Distance(lettre14.transform.position, Box16.transform.position);
        float Distance17 = Vector3.Distance(lettre14.transform.position, Box17.transform.position);


        if (Distance < 50 && oneCorrect == false)
        {
            lettre14.transform.localScale = BoxOne.transform.localScale;
            lettre14.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = lettre14.name;
            source.clip = buttonDrop;
            source.Play();


        }
        else if (Distance2 < 50 && twoCorrect == false)
        {
            lettre14.transform.localScale = BoxTwo.transform.localScale;
            lettre14.transform.position = BoxTwo.transform.position;
            twoCorrect = true;
            BoxTwo.name = lettre14.name;
            source.clip = buttonDrop;
            source.Play();

        }
        else if (Distance3 < 50 && threeCorrect == false)
        {
            lettre14.transform.localScale = BoxThree.transform.localScale;
            lettre14.transform.position = BoxThree.transform.position;
            threeCorrect = true;
            BoxThree.name = lettre14.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance4 < 50 && forCorrect == false)
        {
            lettre14.transform.localScale = BoxFor.transform.localScale;
            lettre14.transform.position = BoxFor.transform.position;
            forCorrect = true;
            BoxFor.name = lettre14.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance5 < 50 && fiveCorrect == false)
        {
            lettre14.transform.localScale = BoxFive.transform.localScale;
            lettre14.transform.position = BoxFive.transform.position;
            fiveCorrect = true;
            BoxFive.name = lettre14.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance6 < 50 && sixCorrect == false)
        {
            lettre14.transform.localScale = Box6.transform.localScale;
            lettre14.transform.position = Box6.transform.position;
            sixCorrect = true;
            Box6.name = lettre14.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance7 < 50 && sixCorrect == false)
        {
            lettre14.transform.localScale = Box7.transform.localScale;
            lettre14.transform.position = Box7.transform.position;
            sevenCorrect = true;
            Box7.name = lettre14.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance8 < 50 && eightCorrect == false)
        {
            lettre14.transform.localScale = Box8.transform.localScale;
            lettre14.transform.position = Box8.transform.position;
            eightCorrect = true;
            Box8.name = lettre14.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance9 < 50 && nineCorrect == false)
        {
            lettre14.transform.localScale = Box9.transform.localScale;
            lettre14.transform.position = Box9.transform.position;
            nineCorrect = true;
            Box9.name = lettre14.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance10 < 50 && tenCorrect == false)
        {
            lettre14.transform.localScale = Box10.transform.localScale;
            lettre14.transform.position = Box10.transform.position;
            tenCorrect = true;
            Box10.name = lettre14.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance11 < 50 && elevenCorrect == false)
        {
            lettre14.transform.localScale = Box11.transform.localScale;
            lettre14.transform.position = Box11.transform.position;
            elevenCorrect = true;
            Box11.name = lettre14.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance12 < 50 && tweleveCorrect == false)
        {
            lettre14.transform.localScale = Box12.transform.localScale;
            lettre14.transform.position = Box12.transform.position;
            tweleveCorrect = true;
            Box12.name = lettre14.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance13 < 50 && thirtCorrect == false)
        {
            lettre14.transform.localScale = Box13.transform.localScale;
            lettre14.transform.position = Box13.transform.position;
            thirtCorrect = true;
            Box13.name = lettre14.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance14 < 50 && fortCorrect == false)
        {
            lettre14.transform.localScale = Box14.transform.localScale;
            lettre14.transform.position = Box14.transform.position;
            fortCorrect = true;
            Box14.name = lettre14.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance15 < 50 && fiftCorrect == false)
        {
            lettre14.transform.localScale = Box15.transform.localScale;
            lettre14.transform.position = Box15.transform.position;
            fiftCorrect = true;
            Box15.name = lettre14.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance16 < 50 && sixtCorrect == false)
        {
            lettre14.transform.localScale = Box16.transform.localScale;
            lettre14.transform.position = Box16.transform.position;
            sixtCorrect = true;
            Box16.name = lettre14.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance17 < 50 && tenCorrect == false)
        {
            lettre14.transform.localScale = Box17.transform.localScale;
            lettre14.transform.position = Box17.transform.position;
            seventCorrect = true;
            Box17.name = lettre14.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else
        {
            lettre14.transform.position = lettre14Ini;
            
            source.clip = reload;
            source.Play();
        }

    }
    public void DropLettre15()
    {
        float Distance = Vector3.Distance(lettre15.transform.position, BoxOne.transform.position);
        float Distance2 = Vector3.Distance(lettre15.transform.position, BoxTwo.transform.position);
        float Distance3 = Vector3.Distance(lettre15.transform.position, BoxThree.transform.position);
        float Distance4 = Vector3.Distance(lettre15.transform.position, BoxFor.transform.position);
        float Distance5 = Vector3.Distance(lettre15.transform.position, BoxFive.transform.position);
        float Distance6 = Vector3.Distance(lettre15.transform.position, Box6.transform.position);
        float Distance7 = Vector3.Distance(lettre15.transform.position, Box7.transform.position);
        float Distance8 = Vector3.Distance(lettre15.transform.position, Box8.transform.position);
        float Distance9 = Vector3.Distance(lettre15.transform.position, Box9.transform.position);
        float Distance10 = Vector3.Distance(lettre15.transform.position, Box10.transform.position);
        float Distance11 = Vector3.Distance(lettre15.transform.position, Box11.transform.position);
        float Distance12 = Vector3.Distance(lettre15.transform.position, Box12.transform.position);
        float Distance13 = Vector3.Distance(lettre15.transform.position, Box13.transform.position);
        float Distance14 = Vector3.Distance(lettre15.transform.position, Box14.transform.position);
        float Distance15 = Vector3.Distance(lettre15.transform.position, Box15.transform.position);
        float Distance16 = Vector3.Distance(lettre15.transform.position, Box16.transform.position);
        float Distance17 = Vector3.Distance(lettre15.transform.position, Box17.transform.position);


        if (Distance < 50 && oneCorrect == false)
        {
            lettre15.transform.localScale = BoxOne.transform.localScale;
            lettre15.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = lettre15.name;
            source.clip = buttonDrop;
            source.Play();


        }
        else if (Distance2 < 50 && twoCorrect == false)
        {
            lettre15.transform.localScale = BoxTwo.transform.localScale;
            lettre15.transform.position = BoxTwo.transform.position;
            twoCorrect = true;
            BoxTwo.name = lettre15.name;
            source.clip = buttonDrop;
            source.Play();

        }
        else if (Distance3 < 50 && threeCorrect == false)
        {
            lettre15.transform.localScale = BoxThree.transform.localScale;
            lettre15.transform.position = BoxThree.transform.position;
            threeCorrect = true;
            BoxThree.name = lettre15.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance4 < 50 && forCorrect == false)
        {
            lettre15.transform.localScale = BoxFor.transform.localScale;
            lettre15.transform.position = BoxFor.transform.position;
            forCorrect = true;
            BoxFor.name = lettre15.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance5 < 50 && fiveCorrect == false)
        {
            lettre15.transform.localScale = BoxFive.transform.localScale;
            lettre15.transform.position = BoxFive.transform.position;
            fiveCorrect = true;
            BoxFive.name = lettre15.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance6 < 50 && sixCorrect == false)
        {
            lettre15.transform.localScale = Box6.transform.localScale;
            lettre15.transform.position = Box6.transform.position;
            sixCorrect = true;
            Box6.name = lettre15.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance7 < 50 && sixCorrect == false)
        {
            lettre15.transform.localScale = Box7.transform.localScale;
            lettre15.transform.position = Box7.transform.position;
            sevenCorrect = true;
            Box7.name = lettre15.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance8 < 50 && eightCorrect == false)
        {
            lettre15.transform.localScale = Box8.transform.localScale;
            lettre15.transform.position = Box8.transform.position;
            eightCorrect = true;
            Box8.name = lettre15.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance9 < 50 && nineCorrect == false)
        {
            lettre15.transform.localScale = Box9.transform.localScale;
            lettre15.transform.position = Box9.transform.position;
            nineCorrect = true;
            Box9.name = lettre15.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance10 < 50 && tenCorrect == false)
        {
            lettre15.transform.localScale = Box10.transform.localScale;
            lettre15.transform.position = Box10.transform.position;
            tenCorrect = true;
            Box10.name = lettre15.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance11 < 50 && elevenCorrect == false)
        {
            lettre15.transform.localScale = Box11.transform.localScale;
            lettre15.transform.position = Box11.transform.position;
            elevenCorrect = true;
            Box11.name = lettre15.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance12 < 50 && tweleveCorrect == false)
        {
            lettre15.transform.localScale = Box12.transform.localScale;
            lettre15.transform.position = Box12.transform.position;
            tweleveCorrect = true;
            Box12.name = lettre15.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance13 < 50 && thirtCorrect == false)
        {
            lettre15.transform.localScale = Box13.transform.localScale;
            lettre15.transform.position = Box13.transform.position;
            thirtCorrect = true;
            Box13.name = lettre15.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance14 < 50 && fortCorrect == false)
        {
            lettre15.transform.localScale = Box14.transform.localScale;
            lettre15.transform.position = Box14.transform.position;
            fortCorrect = true;
            Box14.name = lettre15.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance15 < 50 && fiftCorrect == false)
        {
            lettre15.transform.localScale = Box15.transform.localScale;
            lettre15.transform.position = Box15.transform.position;
            fiftCorrect = true;
            Box15.name = lettre15.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance16 < 50 && sixtCorrect == false)
        {
            lettre15.transform.localScale = Box16.transform.localScale;
            lettre15.transform.position = Box16.transform.position;
            sixtCorrect = true;
            Box16.name = lettre15.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance17 < 50 && tenCorrect == false)
        {
            lettre15.transform.localScale = Box17.transform.localScale;
            lettre15.transform.position = Box17.transform.position;
            seventCorrect = true;
            Box17.name = lettre15.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else
        {
            lettre15.transform.position = lettre15Ini;
           
            source.clip = reload;
            source.Play();
        }

    }
    public void DropLettre16()
    {
        float Distance = Vector3.Distance(lettre16.transform.position, BoxOne.transform.position);
        float Distance2 = Vector3.Distance(lettre16.transform.position, BoxTwo.transform.position);
        float Distance3 = Vector3.Distance(lettre16.transform.position, BoxThree.transform.position);
        float Distance4 = Vector3.Distance(lettre16.transform.position, BoxFor.transform.position);
        float Distance5 = Vector3.Distance(lettre16.transform.position, BoxFive.transform.position);
        float Distance6 = Vector3.Distance(lettre16.transform.position, Box6.transform.position);
        float Distance7 = Vector3.Distance(lettre16.transform.position, Box7.transform.position);
        float Distance8 = Vector3.Distance(lettre16.transform.position, Box8.transform.position);
        float Distance9 = Vector3.Distance(lettre16.transform.position, Box9.transform.position);
        float Distance10 = Vector3.Distance(lettre16.transform.position, Box10.transform.position);
        float Distance11 = Vector3.Distance(lettre16.transform.position, Box11.transform.position);
        float Distance12 = Vector3.Distance(lettre16.transform.position, Box12.transform.position);
        float Distance13 = Vector3.Distance(lettre16.transform.position, Box13.transform.position);
        float Distance14 = Vector3.Distance(lettre16.transform.position, Box14.transform.position);
        float Distance15 = Vector3.Distance(lettre16.transform.position, Box15.transform.position);
        float Distance16 = Vector3.Distance(lettre16.transform.position, Box16.transform.position);
        float Distance17 = Vector3.Distance(lettre16.transform.position, Box17.transform.position);


        if (Distance < 50 && oneCorrect == false)
        {
            lettre16.transform.localScale = BoxOne.transform.localScale;
            lettre16.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = lettre16.name;
            source.clip = buttonDrop;
            source.Play();


        }
        else if (Distance2 < 50 && twoCorrect == false)
        {
            lettre16.transform.localScale = BoxTwo.transform.localScale;
            lettre16.transform.position = BoxTwo.transform.position;
            twoCorrect = true;
            BoxTwo.name = lettre16.name;
            source.clip = buttonDrop;
            source.Play();

        }
        else if (Distance3 < 50 && threeCorrect == false)
        {
            lettre16.transform.localScale = BoxThree.transform.localScale;
            lettre16.transform.position = BoxThree.transform.position;
            threeCorrect = true;
            BoxThree.name = lettre16.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance4 < 50 && forCorrect == false)
        {
            lettre16.transform.localScale = BoxFor.transform.localScale;
            lettre16.transform.position = BoxFor.transform.position;
            forCorrect = true;
            BoxFor.name = lettre16.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance5 < 50 && fiveCorrect == false)
        {
            lettre16.transform.localScale = BoxFive.transform.localScale;
            lettre16.transform.position = BoxFive.transform.position;
            fiveCorrect = true;
            BoxFive.name = lettre16.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance6 < 50 && sixCorrect == false)
        {
            lettre16.transform.localScale = Box6.transform.localScale;
            lettre16.transform.position = Box6.transform.position;
            sixCorrect = true;
            Box6.name = lettre16.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance7 < 50 && sixCorrect == false)
        {
            lettre16.transform.localScale = Box7.transform.localScale;
            lettre16.transform.position = Box7.transform.position;
            sevenCorrect = true;
            Box7.name = lettre16.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance8 < 50 && eightCorrect == false)
        {
            lettre16.transform.localScale = Box8.transform.localScale;
            lettre16.transform.position = Box8.transform.position;
            eightCorrect = true;
            Box8.name = lettre16.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance9 < 50 && nineCorrect == false)
        {
            lettre16.transform.localScale = Box9.transform.localScale;
            lettre16.transform.position = Box9.transform.position;
            nineCorrect = true;
            Box9.name = lettre16.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance10 < 50 && tenCorrect == false)
        {
            lettre16.transform.localScale = Box10.transform.localScale;
            lettre16.transform.position = Box10.transform.position;
            tenCorrect = true;
            Box10.name = lettre16.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance11 < 50 && elevenCorrect == false)
        {
            lettre16.transform.localScale = Box11.transform.localScale;
            lettre16.transform.position = Box11.transform.position;
            elevenCorrect = true;
            Box11.name = lettre16.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance12 < 50 && tweleveCorrect == false)
        {
            lettre16.transform.localScale = Box12.transform.localScale;
            lettre16.transform.position = Box12.transform.position;
            tweleveCorrect = true;
            Box12.name = lettre16.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance13 < 50 && thirtCorrect == false)
        {
            lettre16.transform.localScale = Box13.transform.localScale;
            lettre16.transform.position = Box13.transform.position;
            thirtCorrect = true;
            Box13.name = lettre16.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance14 < 50 && fortCorrect == false)
        {
            lettre16.transform.localScale = Box14.transform.localScale;
            lettre16.transform.position = Box14.transform.position;
            fortCorrect = true;
            Box14.name = lettre16.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance15 < 50 && fiftCorrect == false)
        {
            lettre16.transform.localScale = Box15.transform.localScale;
            lettre16.transform.position = Box15.transform.position;
            fiftCorrect = true;
            Box15.name = lettre16.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance16 < 50 && sixtCorrect == false)
        {
            lettre16.transform.localScale = Box16.transform.localScale;
            lettre16.transform.position = Box16.transform.position;
            sixtCorrect = true;
            Box16.name = lettre16.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance17 < 50 && tenCorrect == false)
        {
            lettre16.transform.localScale = Box17.transform.localScale;
            lettre16.transform.position = Box17.transform.position;
            seventCorrect = true;
            Box17.name = lettre16.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else
        {
            lettre16.transform.position = lettre16Ini;
             
            source.clip = reload;
            source.Play();
        }

    }
    public void DropLettre17()
    {
        float Distance = Vector3.Distance(lettre17.transform.position, BoxOne.transform.position);
        float Distance2 = Vector3.Distance(lettre17.transform.position, BoxTwo.transform.position);
        float Distance3 = Vector3.Distance(lettre17.transform.position, BoxThree.transform.position);
        float Distance4 = Vector3.Distance(lettre17.transform.position, BoxFor.transform.position);
        float Distance5 = Vector3.Distance(lettre17.transform.position, BoxFive.transform.position);
        float Distance6 = Vector3.Distance(lettre17.transform.position, Box6.transform.position);
        float Distance7 = Vector3.Distance(lettre17.transform.position, Box7.transform.position);
        float Distance8 = Vector3.Distance(lettre17.transform.position, Box8.transform.position);
        float Distance9 = Vector3.Distance(lettre17.transform.position, Box9.transform.position);
        float Distance10 = Vector3.Distance(lettre17.transform.position, Box10.transform.position);
        float Distance11 = Vector3.Distance(lettre17.transform.position, Box11.transform.position);
        float Distance12 = Vector3.Distance(lettre17.transform.position, Box12.transform.position);
        float Distance13 = Vector3.Distance(lettre17.transform.position, Box13.transform.position);
        float Distance14 = Vector3.Distance(lettre17.transform.position, Box14.transform.position);
        float Distance15 = Vector3.Distance(lettre17.transform.position, Box15.transform.position);
        float Distance16 = Vector3.Distance(lettre17.transform.position, Box16.transform.position);
        float Distance17 = Vector3.Distance(lettre17.transform.position, Box17.transform.position);


        if (Distance < 50 && oneCorrect == false)
        {
            lettre17.transform.localScale = BoxOne.transform.localScale;
            lettre17.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = lettre17.name;
            source.clip = buttonDrop;
            source.Play();


        }
        else if (Distance2 < 50 && twoCorrect == false)
        {
            lettre17.transform.localScale = BoxTwo.transform.localScale;
            lettre17.transform.position = BoxTwo.transform.position;
            twoCorrect = true;
            BoxTwo.name = lettre17.name;
            source.clip = buttonDrop;
            source.Play();

        }
        else if (Distance3 < 50 && threeCorrect == false)
        {
            lettre17.transform.localScale = BoxThree.transform.localScale;
            lettre17.transform.position = BoxThree.transform.position;
            threeCorrect = true;
            BoxThree.name = lettre17.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance4 < 50 && forCorrect == false)
        {
            lettre17.transform.localScale = BoxFor.transform.localScale;
            lettre17.transform.position = BoxFor.transform.position;
            forCorrect = true;
            BoxFor.name = lettre17.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distance5 < 50 && fiveCorrect == false)
        {
            lettre17.transform.localScale = BoxFive.transform.localScale;
            lettre17.transform.position = BoxFive.transform.position;
            fiveCorrect = true;
            BoxFive.name = lettre17.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance6 < 50 && sixCorrect == false)
        {
            lettre17.transform.localScale = Box6.transform.localScale;
            lettre17.transform.position = Box6.transform.position;
            sixCorrect = true;
            Box6.name = lettre17.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance7 < 50 && sixCorrect == false)
        {
            lettre17.transform.localScale = Box7.transform.localScale;
            lettre17.transform.position = Box7.transform.position;
            sevenCorrect = true;
            Box7.name = lettre17.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance8 < 50 && eightCorrect == false)
        {
            lettre17.transform.localScale = Box8.transform.localScale;
            lettre17.transform.position = Box8.transform.position;
            eightCorrect = true;
            Box8.name = lettre17.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance9 < 50 && nineCorrect == false)
        {
            lettre17.transform.localScale = Box9.transform.localScale;
            lettre17.transform.position = Box9.transform.position;
            nineCorrect = true;
            Box9.name = lettre17.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance10 < 50 && tenCorrect == false)
        {
            lettre17.transform.localScale = Box10.transform.localScale;
            lettre17.transform.position = Box10.transform.position;
            tenCorrect = true;
            Box10.name = lettre17.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance11 < 50 && elevenCorrect == false)
        {
            lettre17.transform.localScale = Box11.transform.localScale;
            lettre17.transform.position = Box11.transform.position;
            elevenCorrect = true;
            Box11.name = lettre17.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance12 < 50 && tweleveCorrect == false)
        {
            lettre17.transform.localScale = Box12.transform.localScale;
            lettre17.transform.position = Box12.transform.position;
            tweleveCorrect = true;
            Box12.name = lettre17.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance13 < 50 && thirtCorrect == false)
        {
            lettre17.transform.localScale = Box13.transform.localScale;
            lettre17.transform.position = Box13.transform.position;
            thirtCorrect = true;
            Box13.name = lettre17.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance14 < 50 && fortCorrect == false)
        {
            lettre17.transform.localScale = Box14.transform.localScale;
            lettre17.transform.position = Box14.transform.position;
            fortCorrect = true;
            Box14.name = lettre17.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance15 < 50 && fiftCorrect == false)
        {
            lettre17.transform.localScale = Box15.transform.localScale;
            lettre17.transform.position = Box15.transform.position;
            fiftCorrect = true;
            Box15.name = lettre17.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance16 < 50 && sixtCorrect == false)
        {
            lettre17.transform.localScale = Box16.transform.localScale;
            lettre17.transform.position = Box16.transform.position;
            sixtCorrect = true;
            Box16.name = lettre17.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance17 < 50 && tenCorrect == false)
        {
            lettre17.transform.localScale = Box17.transform.localScale;
            lettre17.transform.position = Box17.transform.position;
            seventCorrect = true;
            Box17.name = lettre17.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else
        {
            lettre17.transform.position = lettre17Ini;
           
            source.clip = reload;
            source.Play();
        }

    }


    //Button

    public void Check()
    {


        
        str = Box17.name + Box16.name + Box15.name + Box14.name + Box13.name + Box12.name + Box11.name + Box10.name + Box9.name + Box8.name + Box7.name + Box6.name + BoxFive.name + BoxFor.name + BoxThree.name + BoxTwo.name + BoxOne.name; 

        if (word == str)
        {

           
            StartCoroutine(LoadNextPanel());

        }
        else
      {
          source.clip = incorrect;
          source.Play();

      }

    }

    public void Reload()
    {
        str = "";

       source.clip = reload;
       source.Play();

        oneCorrect = false;
        twoCorrect = false;
        threeCorrect = false;
        forCorrect = false;
        fiveCorrect=false;
        sixCorrect = false;
        sevenCorrect = false;
        eightCorrect = false;
        nineCorrect = false;
        tenCorrect = false;
        elevenCorrect = false;
        tweleveCorrect = false;
        thirtCorrect = false;
        fortCorrect = false;
        fiftCorrect = false;
        sixtCorrect = false;
        seventCorrect = false;


        BoxOne.name = "";
        BoxTwo.name = "";
        BoxThree.name = "";
        BoxFor.name = "";
        BoxFive.name = "";
        Box6.name = "";
        Box7.name = "";
        Box8.name = "";
        Box9.name = "";
        Box10.name = "";
        Box11.name = "";
        Box12.name = "";
        Box13.name = "";
        Box14.name = "";
        Box15.name = "";
        Box16.name = "";
        Box17.name = "";

        lettreOne.transform.position = lettreOneIni;
        lettreTwo.transform.position = lettreTwoIni;
        lettreThree.transform.position = lettreThreeIni;
        lettreFor.transform.position = lettreForIni;
        lettreFive.transform.position = lettreFiveIni;
        lettreSix.transform.position = lettreSixIni;
        lettreSeven.transform.position = lettreSevenIni;
        lettreEight.transform.position = lettreEightIni;
        lettre9.transform.position = lettre9Ini ;
        lettre10.transform.position= lettre10Ini;
        lettre11.transform.position= lettre11Ini;
        lettre12.transform.position= lettre12Ini;
        lettre13.transform.position= lettre13Ini;
        lettre14.transform.position= lettre14Ini;
        lettre15.transform.position= lettre15Ini;
        lettre16.transform.position= lettre16Ini;
        lettre17.transform.position= lettre17Ini;


        lettreOne.transform.localScale = iniScaleLettreOne;
        lettreTwo.transform.localScale = iniScaleLettreTwo;
        lettreThree.transform.localScale = iniScaleLettreThree;
        lettreFor.transform.localScale = iniScaleLettreFor;
        lettreFive.transform.localScale = iniScaleLettreFive;
        lettreSix.transform.localScale = iniScaleLettreSix;
        lettreSeven.transform.localScale = iniScaleLettreSeven;
        lettreEight.transform.localScale = iniScaleLettreEight;
        lettre9.transform.localScale = iniScaleLettre9;
        lettre10.transform.localScale = iniScaleLettre10;
        lettre11.transform.localScale = iniScaleLettre11;
        lettre12.transform.localScale = iniScaleLettre12;
        lettre13.transform.localScale = iniScaleLettre13;
        lettre14.transform.localScale = iniScaleLettre14;
        lettre15.transform.localScale = iniScaleLettre15;
        lettre16.transform.localScale = iniScaleLettre16;
        lettre17.transform.localScale = iniScaleLettre17;


    }

    IEnumerator LoadNextPanel()
    {
        yield return new WaitForSeconds(1f);
        questionToHide.SetActive(false);
        questionToShow.SetActive(true);
    }

}


