using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class scene2 : MonoBehaviour
{
    private GameObject moving_button;
    private GameObject cheering_button;
    private GameObject paging_button;
    private GameObject displayusername_text;
    private GameObject displaypresidentname_text;
    private GameObject easterEgg;

    private int num_moving;
    private int num_cheering;
    

    private Animator animator;

    // private GameObject cheerimage;

    // private Sprite newimage;
    // private int num_newimage;

    private GameObject malecharater;
    private GameObject femalecharater;

    private Camera maincamera;

    //public GameObject inputUserWord;
    
    
   
    // Start is called before the first frame update
    void Start()
    {

        maincamera = GameObject.Find("Main Camera").GetComponent<Camera>();
        maincamera.enabled = true;
        maincamera.depth = 0;

        Debug.Log("Enter Sence2: userIfo");
        Debug.Log(LoadScene.userName);
        Debug.Log(LoadScene.userGender);
        Debug.Log(LoadScene.userWord);
        Debug.Log(LoadScene.presidentName);



        moving_button = GameObject.Find("moving_s2");
        cheering_button = GameObject.Find("cheering_s2");
        paging_button = GameObject.Find("paging_s2");
        displayusername_text = GameObject.Find("displayusername_s2");
        displaypresidentname_text = GameObject.Find("displaypresidentname_s2");
        easterEgg = GameObject.Find("easterEgg_s2");


        // cheerimage = GameObject.Find("cheerimages_s2");
        // cheerimage.SetActive(false);
        // Debug.Log(cheerimage);

        
        malecharater = GameObject.Find("male_s2");
        femalecharater = GameObject.Find("female_s2");
        
        Debug.Log("gender");
        Debug.Log(LoadScene.userGender);

        if(LoadScene.userGender == 0){
            femalecharater.SetActive(false);
        }else if(LoadScene.userGender == 1){
            malecharater.SetActive(false);
        } 
        
        animator = GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>();

        if (!string.IsNullOrEmpty(LoadScene.userName))
        {
            displayusername_text.GetComponent<TMP_Text>().text = LoadScene.userName;
        }

        if (!string.IsNullOrEmpty(LoadScene.presidentName)){

            displaypresidentname_text.GetComponent<TMP_Text>().text = LoadScene.presidentName;
        }
        

        moving_button.SetActive(true);
        cheering_button.SetActive(true);
        paging_button.SetActive(true);

        moving_button.GetComponent<Button>().onClick.AddListener(delegate() { 
            MovingButtonClick();
            Debug.Log("moving! " + num_moving.ToString()) ;
            });

        cheering_button.GetComponent<Button>().onClick.AddListener(delegate() { 
            CheeringButtonClick();
            Debug.Log("cheering! " + num_cheering.ToString()) ;
            });

        paging_button.GetComponent<Button>().onClick.AddListener(delegate() { 
            PagingButtonClick();
            Debug.Log("paging! " + LoadScene.num_paging.ToString()) ;
            });

    }

    private void MovingButtonClick()
    {
        num_moving = Random.Range(1, 4);
        if (num_moving == 1)
        {
            animator.SetBool("petting", true);
            animator.SetBool("pointing", false);
            animator.SetBool("waving", false);
        }
        else if (num_moving == 2)
        {
            animator.SetBool("petting", false);
            animator.SetBool("pointing", true);
            animator.SetBool("waving", false);
        }
        else
        {
            animator.SetBool("petting", false);
            animator.SetBool("pointing", false);
            animator.SetBool("waving", true);
        }
        Debug.Log("moving! " + num_moving.ToString());
        
    }



    private void CheeringButtonClick()
    {
        int posx = Random.Range(-210, 210);
        int posy = Random.Range(472, 1042);
        float mutiplier = Random.Range(0.5f, 3f);
        easterEgg.SetActive(true);
        easterEgg.GetComponent<RectTransform>().anchoredPosition = new Vector2(posx, posy);
        easterEgg.transform.localScale = new Vector3(7, 4.5f,4.5f)*mutiplier;
       
        
        // cheerimage.SetActive(false);
        // num_newimage = Random.Range(1, 7);
        // string path = "cheerimages/";
        // path = path + num_newimage.ToString();
        // newimage = Resources.Load<Sprite> (path);
        // int posx_image = Random.Range(-182, 450);
        // int posy_image = Random.Range(-1100, -300);
        // cheerimage.GetComponent<RectTransform>().anchoredPosition = new Vector2(posx_image, posy_image);
        // cheerimage.GetComponent<Image>().sprite = newimage;
        // cheerimage.GetComponent<RectTransform>().SetAsLastSibling ();
    
   
    }

    private void PagingButtonClick(){
        LoadScene.num_paging = 6;
        SceneManager.LoadScene(LoadScene.num_paging);
     
    }


}
