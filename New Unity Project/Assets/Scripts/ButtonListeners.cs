using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class ButtonListeners:MonoBehaviour
{
    public static bool IsNavigating;

    [SerializeField]
    private GameObject _panel;

    [SerializeField]
    private Image _imgBuilding;
    [SerializeField]
    private Image _imgName;

    [SerializeField]
    private GameObject _btnClub;
    [SerializeField]
    private GameObject _btnRestaurant;
    [SerializeField]
    private GameObject _btnBuilding;

    [SerializeField]
    private GameObject _questionMark;

    [SerializeField]
    private Image _imgBtnNavigating;

    [SerializeField]
    private GameObject _ssungMaTelling;

    [SerializeField]
    private GameObject _navigatingObject;

    [SerializeField]
    private GameObject _nextButton;
    [SerializeField]
    private GameObject _previousButton;

    private bool _isOpened;
    private Vector3 _ssungPos;

    [SerializeField]
    private Text _text;
    [SerializeField]
    private Text _text2;

    //[SerializeField]
    private string[] _speechTexts = { "", "", "", "", "" };

    public void OnClickExit()
    {
        Animator animator = _panel.GetComponent<Animator>();
        if(animator != null)
            animator.SetBool("open", false);
    }

    public void OnClickOpenBuildingInfo()
    {
        //_panel = 건물 정보 패널
        Animator animator = _panel.GetComponent<Animator>();
        _text = GameObject.FindGameObjectWithTag("BuildingInformationText").GetComponent<Text>();

        if(animator != null)
        {
            _imgBuilding.sprite = Resources.Load<Sprite>("UI/Buildings/" + name);
            _imgName.sprite = Resources.Load<Sprite>("UI/Building Names/" + name + "UI");

            //StreamReader sr = new StreamReader("Assets/Resources/Building Informations/" + name + ".txt", System.Text.Encoding.Default);
            TextAsset asset = Resources.Load<TextAsset>("Building Informations/" + name);
            StringReader sr = new StringReader(asset.text);
            _text.text = sr.ReadLine();

            animator.SetBool("open", true);
        }
    }

    

    public void OnClickStart()
    {
        // _panel = 시작 화면
        Animator animator = _panel.GetComponent<Animator>();

        if(animator != null)
        {
            animator.SetBool("start", true);
        }
    }

    public void OnClickStudent()
    {
        _isOpened = !_isOpened;

        Animator animClub = _btnClub.GetComponent<Animator>();
        Animator animRestaurant = _btnRestaurant.GetComponent<Animator>();
        Animator animBuilding = _btnBuilding.GetComponent<Animator>();

        animClub.SetBool("open", _isOpened);
        animRestaurant.SetBool("open", _isOpened);
        animBuilding.SetBool("open", _isOpened);
    }

    


    


    

    

    

    

    
}
