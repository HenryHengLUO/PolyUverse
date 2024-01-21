using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using WebGLSupport;

public class prescene2 : MonoBehaviour
{
    private GameObject paging_button;
    private GameObject displayusername_text;
  
    // private Animator animator;

    private GameObject malecharater;
    private GameObject femalecharater;

    private GameObject userword;

    private Camera maincamera;


    //public GameObject inputUserWord;
    
    
   
    // Start is called before the first frame update
    void Start()
    {   
        maincamera = GameObject.Find("Main Camera").GetComponent<Camera>();
        maincamera.enabled = true;
        maincamera.depth = 0;
        
        Debug.Log("Enter PreSence2: userIfo");
       
        paging_button = GameObject.Find("paging_ps2");
        displayusername_text = GameObject.Find("displayusername_ps2");

        userword = GameObject.Find("userword");
        userword.AddComponent<WebGLSupport.WebGLInput>();
        
        malecharater = GameObject.Find("male_ps2");
        femalecharater = GameObject.Find("female_ps2");
        
        Debug.Log("gender");
        Debug.Log(LoadScene.userGender);

        if(LoadScene.userGender == 0){
            femalecharater.SetActive(false);
        }else if(LoadScene.userGender == 1){
            malecharater.SetActive(false);
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
        
        if (!string.IsNullOrEmpty(userword.GetComponent<TMP_InputField>().text)){
            LoadScene.userWord = userword.GetComponent<TMP_InputField>().text;
        }
        
        LoadScene.num_paging = 3;
        SceneManager.LoadScene(LoadScene.num_paging);

    }


}
