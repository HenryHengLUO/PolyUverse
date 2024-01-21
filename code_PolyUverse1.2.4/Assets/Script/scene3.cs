using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class scene3 : MonoBehaviour
{

    private GameObject moving_button;
    private GameObject cheering_button;
    private GameObject paging_button;
    private GameObject displayusername_text;
    private GameObject displayuserword_text;
    private GameObject easterEgg;
    
    private GameObject malecharater;
    private GameObject femalecharater;

    private Animator animator;

    private Camera maincamera;

    // Start is called before the first frame update
    void Start()
    {

        maincamera = GameObject.Find("Main Camera").GetComponent<Camera>();
        maincamera.enabled = true;
        maincamera.depth = 0;

        Debug.Log("Enter Sence3: userIfo");
        Debug.Log(LoadScene.userName);
        Debug.Log(LoadScene.userGender);
        Debug.Log(LoadScene.userWord);
        Debug.Log(LoadScene.presidentName);

        moving_button = GameObject.Find("moving_s3");
        cheering_button = GameObject.Find("cheering_s3");
        paging_button = GameObject.Find("paging_s3");
        displayusername_text = GameObject.Find("displayusername_s3");
        displayuserword_text = GameObject.Find("displayuserword_s3");
        easterEgg = GameObject.Find("easterEgg_s3");

        malecharater = GameObject.Find("male_s3");
        femalecharater = GameObject.Find("female_s3");
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

        if (!string.IsNullOrEmpty(LoadScene.userWord))
        {
            displayuserword_text.GetComponent<TMP_Text>().text = LoadScene.userWord;
        }

        
        
        moving_button.SetActive(true);
        cheering_button.SetActive(true);
        paging_button.SetActive(true);

        moving_button.GetComponent<Button>().onClick.AddListener(delegate() { 
            MovingButtonClick();
            // Debug.Log("moving! " + num_moving.ToString()) ;
            });

        cheering_button.GetComponent<Button>().onClick.AddListener(delegate() { 
            CheeringButtonClick();
            // Debug.Log("cheering! " + num_cheering.ToString()) ;
            });

        paging_button.GetComponent<Button>().onClick.AddListener(delegate() { 
            PagingButtonClick();
            // Debug.Log("paging! " + LoadScene.num_paging.ToString()) ;
            });

    }

    private void MovingButtonClick()
    {   
        animator.SetBool("run", true);
        
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
        LoadScene.num_paging = 0;
        SceneManager.LoadScene(LoadScene.num_paging);
     
    }



    



}
