using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class prescene0 : MonoBehaviour
{
    private GameObject paging_button;
    private GameObject displayusername_text;
  
    // private Animator animator;

    private GameObject malecharater;
    private GameObject femalecharater;

    private GameObject username;
    private GameObject usergender;

   



    //public GameObject inputUserWord;
    
    
   
    // Start is called before the first frame update
    void Start()
    {   
        var loadscene = new LoadScene();

        Debug.Log("Enter PreSence0: userIfo");
       
        paging_button = GameObject.Find("paging_ps1");
        
        paging_button.SetActive(true);

        paging_button.GetComponent<Button>().onClick.AddListener(delegate() { 
            PagingButtonClick();
            Debug.Log("paging! " + LoadScene.num_paging.ToString()) ;
            });

    }


    private void PagingButtonClick(){
 
        LoadScene.num_paging = 1;
        SceneManager.LoadScene(LoadScene.num_paging);

    }


}
