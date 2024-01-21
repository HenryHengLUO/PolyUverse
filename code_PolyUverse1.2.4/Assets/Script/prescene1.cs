using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using WebGLSupport;

public class prescene1 : MonoBehaviour
{

    private GameObject paging_button;
    private GameObject displayusername_text;
  
    // private Animator animator;

    private GameObject malecharater;
    private GameObject femalecharater;

    private GameObject username;
    private GameObject usergender;

   
    private Camera maincamera;


    //public GameObject inputUserWord;
    
    
   
    // Start is called before the first frame update
    void Start()
    {   
        maincamera = GameObject.Find("Main Camera").GetComponent<Camera>();
        maincamera.enabled = true;
        maincamera.depth = 0;

        Debug.Log("Enter PreSence1: userIfo");
       
        paging_button = GameObject.Find("paging_ps1");
        displayusername_text = GameObject.Find("displayusername_ps1");

        username = GameObject.Find("username");
        username.AddComponent<WebGLSupport.WebGLInput>();
        
        usergender = GameObject.Find("usergender");
        
        malecharater = GameObject.Find("male_ps1");
        femalecharater = GameObject.Find("female_ps1");



        
        Debug.Log("gender");
        Debug.Log(LoadScene.userGender);

        if(LoadScene.userGender == 0){
            // femalecharater.SetActive(false);
            femalecharater.transform.position *= -1;
            Debug.Log(femalecharater.transform.position);
            // malecharater.transform.position  = new Vector3(549, 707, 0);
        }else if(LoadScene.userGender == 1){
            // malecharater.SetActive(false);
            malecharater.transform.position *= -1;
            Debug.Log(malecharater.transform.position);
            // femalecharater.transform.position = new Vector3(549, 707, 0);
        }
        
        // animator = GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>();

       if (!string.IsNullOrEmpty(LoadScene.userName))
        {
            displayusername_text.GetComponent<TMP_Text>().text = LoadScene.userName;
        
        }

        paging_button.SetActive(true);

        paging_button.GetComponent<Button>().onClick.AddListener(delegate() { 
            PagingButtonClick();
            Debug.Log("paging! " + LoadScene.num_paging.ToString()) ;
            });

    }


    private void PagingButtonClick(){
        if (!string.IsNullOrEmpty(username.GetComponent<TMP_InputField>().text)){
            LoadScene.userName = username.GetComponent<TMP_InputField>().text;
            displayusername_text.GetComponent<TMP_Text>().text = LoadScene.userName;
        }

        LoadScene.userGender = usergender.GetComponent<TMP_Dropdown>().value;

        LoadScene.num_paging = 2;
        SceneManager.LoadScene(LoadScene.num_paging);

    }



 private void Update() {
    
        if (!string.IsNullOrEmpty(username.GetComponent<TMP_InputField>().text)){
            // LoadScene.userName = username.GetComponent<TMP_InputField>().text;
            displayusername_text.GetComponent<TMP_Text>().text = username.GetComponent<TMP_InputField>().text;
        }

        
        if (usergender.GetComponent<TMP_Dropdown>().value != LoadScene.userGender){
            LoadScene.userGender = usergender.GetComponent<TMP_Dropdown>().value;
            malecharater.transform.position *= -1;
            femalecharater.transform.position *= -1;
            
            
        }

        //     if(LoadScene.userGender == 0){
        //     // femalecharater.SetActive(false);
        //     femalecharater.transform.position *= -1;
        //     Debug.Log(femalecharater.transform.position);
        //     // malecharater.transform.position  = new Vector3(549, 707, 0);
        // }else if(LoadScene.userGender == 1){
        //     // malecharater.SetActive(false);
        //     malecharater.transform.position *= -1;
        //     Debug.Log(malecharater.transform.position);
        //     // femalecharater.transform.position = new Vector3(549, 707, 0);
        // }
        // }
        

        // if(LoadScene.userGender == 0){
        //     // femalecharater.SetActive(false);
        //     femalecharater.transform.position *= -1;
        //     Debug.Log(femalecharater.transform.position);
        //     // malecharater.transform.position  = new Vector3(549, 707, 0);
        // }else if(LoadScene.userGender == 1){
        //     // malecharater.SetActive(false);
        //     malecharater.transform.position *= -1;
        //     Debug.Log(malecharater.transform.position);
        //     // femalecharater.transform.position = new Vector3(549, 707, 0);
        // }

 }

}
