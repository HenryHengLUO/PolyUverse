// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.SceneManagement;
// using UnityEngine.UI;
// using TMPro;
// using WebGLSupport;


// public class LoadScene : MonoBehaviour
// {

//     public static string userName;
//     public static int userGender;
//     public static string userWord;
//     public static string presidentName;
//     public static int num_paging;

//     private GameObject username;
//     private GameObject usergender;
//     private GameObject presidentname;
//     private GameObject userword;
//     private GameObject enterbutton;



//     // Start is called before the first frame update
//     void Start()
//     {
//         username = GameObject.Find("username");
//         usergender = GameObject.Find("usergender");
//         presidentname = GameObject.Find("presidentname");
//         userword = GameObject.Find("userword");
//         enterbutton = GameObject.Find("enterbutton");
        
//         userName = "PolyU Student";
//         userGender = 0;
//         userWord = "I love PolyU!!!";
//         presidentName = "Jin-Guang Teng";
//         num_paging = 0;
//         Debug.Log(userName);


//         enterbutton.GetComponent<Button>().onClick.AddListener(delegate() { 
//             LoadNextScene();
//             Debug.Log("Jumping to Scene1! ") ;
//             });

//         username.AddComponent<WebGLSupport.WebGLInput>();
//         presidentname.AddComponent<WebGLSupport.WebGLInput>();
//         userword.AddComponent<WebGLSupport.WebGLInput>();

       
//     }


//     public void LoadNextScene()
//     {
//         if (!string.IsNullOrEmpty(username.GetComponent<TMP_InputField>().text)){
//             userName = username.GetComponent<TMP_InputField>().text;
//         }
//         Debug.Log(userName);
//          Debug.Log("userName");

//         if (!string.IsNullOrEmpty(userword.GetComponent<TMP_InputField>().text)){
//             userWord = userword.GetComponent<TMP_InputField>().text;
//         }

//         if (!string.IsNullOrEmpty(presidentname.GetComponent<TMP_InputField>().text)){
//             presidentName = presidentname.GetComponent<TMP_InputField>().text;
//         }
        
//         userGender = usergender.GetComponent<TMP_Dropdown>().value;
        
//         num_paging = 1;
//         SceneManager.LoadScene(1);
//     }
// }




public class LoadScene
{
    public static string userName;
    public static int userGender;
    public static string userWord;
    public static string presidentName;
    public static int num_paging;

    public LoadScene(){
        userName = "PolyU Student";
        userGender = 0;
        userWord = "I love PolyU!!!";
        presidentName = "Jin-Guang Teng";
        num_paging = 0;
    }
}