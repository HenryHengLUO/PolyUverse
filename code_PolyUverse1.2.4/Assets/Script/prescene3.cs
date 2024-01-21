using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using WebGLSupport;

public class prescene3 : MonoBehaviour
{
    private GameObject paging_button;
    private GameObject displaypresidentname_text;
  
    // private Animator animator;

    private GameObject malecharater;
    private GameObject femalecharater;

    private GameObject presidentname;

    private Camera maincamera;

   

    //public GameObject inputUserWord;
    
    
   
    // Start is called before the first frame update
    void Start()
    {   
        
        maincamera = GameObject.Find("Main Camera").GetComponent<Camera>();
        maincamera.enabled = true;
        maincamera.depth = 0;
        
        Debug.Log("Enter PreSence3: userIfo");
       
        paging_button = GameObject.Find("paging_ps3");
        displaypresidentname_text = GameObject.Find("displaypresidentname_ps3");

        presidentname = GameObject.Find("presidentname");
        presidentname.AddComponent<WebGLSupport.WebGLInput>();
        

        paging_button.SetActive(true);

        paging_button.GetComponent<Button>().onClick.AddListener(delegate() { 
            PagingButtonClick();
            Debug.Log("paging! " + LoadScene.num_paging.ToString()) ;
            });

    }


    private void PagingButtonClick(){

        if (!string.IsNullOrEmpty(presidentname.GetComponent<TMP_InputField>().text)){
            LoadScene.presidentName = presidentname.GetComponent<TMP_InputField>().text;
        }
        
        LoadScene.num_paging = 4;
        SceneManager.LoadScene(LoadScene.num_paging);

    }

    private void Update() {
        if (!string.IsNullOrEmpty(presidentname.GetComponent<TMP_InputField>().text)){
            LoadScene.presidentName = presidentname.GetComponent<TMP_InputField>().text;
            displaypresidentname_text.GetComponent<TMP_Text>().text = LoadScene.presidentName;
        
        }

    }


}
