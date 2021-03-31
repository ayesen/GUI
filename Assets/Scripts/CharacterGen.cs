﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterGen : MonoBehaviour
{
    [SerializeField]
    private Text Name;
    [SerializeField]
    private Text HPTxt;
    [SerializeField]
    private Text MPTxt;
    [SerializeField]
    private Text StrthTxt;
    [SerializeField]
    private Text ToughTxt;
    [SerializeField]
    private Text DexTxt;
    [SerializeField]
    private Text IQTxt;
    [SerializeField]
    private Text PowerTxt;
    [SerializeField]
    private Text CharmTxt;


    [SerializeField]
    private InputField NameInput;
    [SerializeField]
    private int HP;
    [SerializeField]
    private int MP;
    [SerializeField]
    private Slider StrthSld;
    [SerializeField]
    private Slider ToughSld;
    [SerializeField]
    private Slider DexSld;
    [SerializeField]
    private Slider IQSld;
    [SerializeField]
    private Slider PowerSld;
    [SerializeField]
    private Slider CharmSld;

    private void Awake()
    {
        SetHPMP();
    }


    void Update()
    {
        ConvertInput();
        ConvertSlidertoTxt();
    }

    public void SetHPMP()
    {
        HP = (int)ToughSld.value + (int)StrthSld.value;
        MP = (int)IQSld.value * 2;
        HPTxt.text = HP.ToString();
        MPTxt.text = MP.ToString();

    }
    void ConvertInput()
    {
        Name.text = NameInput.text;
    }
    void ConvertSlidertoTxt()
    {
        StrthTxt.text = ((int)StrthSld.value).ToString();
        ToughTxt.text = ((int)ToughSld.value).ToString();
        DexTxt.text = ((int)DexSld.value).ToString();
        IQTxt.text = ((int)IQSld.value).ToString();
        PowerTxt.text = ((int)PowerSld.value).ToString();
        CharmTxt.text = ((int)CharmSld.value).ToString();
    }


}