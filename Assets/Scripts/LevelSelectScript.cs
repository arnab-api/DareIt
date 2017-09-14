using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class LevelSelectScript : MonoBehaviour
{

    public float x_back, y_back, x1, y1, x2, y2, x3, y3, x4, y4, x5, y5, x6, y6, x7, y7, x8, y8, x9, y9, x10, y10, x11, y11;
    public float x12, y12, x13, y13, x14, y14, x15, y15, x16, y16, x17, y17, x18, y18, x19, y19, x20, y20;
    public GUISkin theSkin;
    public Texture2D star1, star2, star3, lockedImage, unlockedImage;

    GUIContent content1 = new GUIContent();
    GUIContent content2 = new GUIContent();
    GUIContent content3 = new GUIContent();
    GUIContent content4 = new GUIContent();
    GUIContent content5 = new GUIContent();
    GUIContent content6 = new GUIContent();
    GUIContent content7 = new GUIContent();
    GUIContent content8 = new GUIContent();
    GUIContent content9 = new GUIContent();
    GUIContent content10 = new GUIContent();
    GUIContent content11 = new GUIContent();
    GUIContent content12 = new GUIContent();
    GUIContent content13 = new GUIContent();
    GUIContent content14 = new GUIContent();
    GUIContent content15 = new GUIContent();
    GUIContent content16 = new GUIContent();
    GUIContent content17 = new GUIContent();
    GUIContent content18 = new GUIContent();
    GUIContent content19 = new GUIContent();

    bool locked2 = true;
    bool locked3 = true;
    bool locked4 = true;
    bool locked5 = true;
    bool locked6 = true;
    bool locked7 = true;
    bool locked8 = true;
    bool locked9 = true;
    bool locked10 = true;
    bool locked11 = true;
    bool locked12 = true;
    bool locked13 = true;
    bool locked14 = true;
    bool locked15 = true;
    bool locked16 = true;
    bool locked17 = true;
    bool locked18 = true;
    bool locked19 = true;

    void Start()
    {
        //Debug.Log()
        content1.image = (Texture2D)unlockedImage;
        PlayerPrefs.SetInt("PrevTime", 0);

        content2.image = (Texture2D)lockedImage;
        if (PlayerPrefs.GetInt("Level1Passed") == 10)
        {
            //Debug.Log("lev1 p called");
            if (PlayerPrefs.GetInt("Level1Score") == 1) content1.image = (Texture2D)star1;
            if (PlayerPrefs.GetInt("Level1Score") == 2) content1.image = (Texture2D)star2;
            if (PlayerPrefs.GetInt("Level1Score") == 3) content1.image = (Texture2D)star3;

            content2.image = (Texture2D)unlockedImage;
        }

        content3.image = (Texture2D)lockedImage;
        if (PlayerPrefs.GetInt("Level2Passed") == 10)
        {
            if (PlayerPrefs.GetInt("Level2Score") == 1) content2.image = (Texture2D)star1;
            if (PlayerPrefs.GetInt("Level2Score") == 2) content2.image = (Texture2D)star2;
            if (PlayerPrefs.GetInt("Level2Score") == 3) content2.image = (Texture2D)star3;

            content3.image = (Texture2D)unlockedImage;
        }

        content4.image = (Texture2D)lockedImage;
        if (PlayerPrefs.GetInt("Level3Passed") == 10)
        {
            if (PlayerPrefs.GetInt("Level3Score") == 1) content3.image = (Texture2D)star1;
            if (PlayerPrefs.GetInt("Level3Score") == 2) content3.image = (Texture2D)star2;
            if (PlayerPrefs.GetInt("Level3Score") == 3) content3.image = (Texture2D)star3;

            content4.image = (Texture2D)unlockedImage;
        }

        content5.image = (Texture2D)lockedImage;
        if (PlayerPrefs.GetInt("Level4Passed") == 10)
        {
            if (PlayerPrefs.GetInt("Level4Score") == 1) content4.image = (Texture2D)star1;
            if (PlayerPrefs.GetInt("Level4Score") == 2) content4.image = (Texture2D)star2;
            if (PlayerPrefs.GetInt("Level4Score") == 3) content4.image = (Texture2D)star3;

            content5.image = (Texture2D)unlockedImage;
        }

        content6.image = (Texture2D)lockedImage;
        if (PlayerPrefs.GetInt("Level5Passed") == 10)
        {
            if (PlayerPrefs.GetInt("Level5Score") == 1) content5.image = (Texture2D)star1;
            if (PlayerPrefs.GetInt("Level5Score") == 2) content5.image = (Texture2D)star2;
            if (PlayerPrefs.GetInt("Level5Score") == 3) content5.image = (Texture2D)star3;

            content6.image = (Texture2D)unlockedImage;
        }

        content7.image = (Texture2D)lockedImage;
        if (PlayerPrefs.GetInt("Level6Passed") == 10)
        {
            if (PlayerPrefs.GetInt("Level6Score") == 1) content6.image = (Texture2D)star1;
            if (PlayerPrefs.GetInt("Level6Score") == 2) content6.image = (Texture2D)star2;
            if (PlayerPrefs.GetInt("Level6Score") == 3) content6.image = (Texture2D)star3;

            content7.image = (Texture2D)unlockedImage;
        }


        content8.image = (Texture2D)lockedImage;
        if (PlayerPrefs.GetInt("Level7Passed") == 10)
        {
            if (PlayerPrefs.GetInt("Level7Score") == 1) content7.image = (Texture2D)star1;
            if (PlayerPrefs.GetInt("Level7Score") == 2) content7.image = (Texture2D)star2;
            if (PlayerPrefs.GetInt("Level7Score") == 3) content7.image = (Texture2D)star3;

            content8.image = (Texture2D)unlockedImage;
        }

        content9.image = (Texture2D)lockedImage;
        if (PlayerPrefs.GetInt("Level8Passed") == 10)
        {
            if (PlayerPrefs.GetInt("Level8Score") == 1) content8.image = (Texture2D)star1;
            if (PlayerPrefs.GetInt("Level8Score") == 2) content8.image = (Texture2D)star2;
            if (PlayerPrefs.GetInt("Level8Score") == 3) content8.image = (Texture2D)star3;

            content9.image = (Texture2D)unlockedImage;
        }

        content10.image = (Texture2D)lockedImage;
        if (PlayerPrefs.GetInt("Level9Passed") == 10)
        {
            if (PlayerPrefs.GetInt("Level9Score") == 1) content9.image = (Texture2D)star1;
            if (PlayerPrefs.GetInt("Level9Score") == 2) content9.image = (Texture2D)star2;
            if (PlayerPrefs.GetInt("Level9Score") == 3) content9.image = (Texture2D)star3;

            content10.image = (Texture2D)unlockedImage;
        }

        content11.image = (Texture2D)lockedImage;
        if (PlayerPrefs.GetInt("Level10Passed") == 10)
        {
            if (PlayerPrefs.GetInt("Level10Score") == 1) content10.image = (Texture2D)star1;
            if (PlayerPrefs.GetInt("Level10Score") == 2) content10.image = (Texture2D)star2;
            if (PlayerPrefs.GetInt("Level10Score") == 3) content10.image = (Texture2D)star3;

            content11.image = (Texture2D)unlockedImage;
        }

        content12.image = (Texture2D)lockedImage;
        if (PlayerPrefs.GetInt("Level11Passed") == 10)
        {
            if (PlayerPrefs.GetInt("Level11Score") == 1) content11.image = (Texture2D)star1;
            if (PlayerPrefs.GetInt("Level11Score") == 2) content11.image = (Texture2D)star2;
            if (PlayerPrefs.GetInt("Level11Score") == 3) content11.image = (Texture2D)star3;

            content12.image = (Texture2D)unlockedImage;
        }

        content13.image = (Texture2D)lockedImage;
        if (PlayerPrefs.GetInt("Level12Passed") == 10)
        {
            if (PlayerPrefs.GetInt("Level12Score") == 1) content12.image = (Texture2D)star1;
            if (PlayerPrefs.GetInt("Level12Score") == 2) content12.image = (Texture2D)star2;
            if (PlayerPrefs.GetInt("Level12Score") == 3) content12.image = (Texture2D)star3;

            content13.image = (Texture2D)unlockedImage;
        }

        content14.image = (Texture2D)lockedImage;
        if (PlayerPrefs.GetInt("Level13Passed") == 10)
        {
            if (PlayerPrefs.GetInt("Level13Score") == 1) content13.image = (Texture2D)star1;
            if (PlayerPrefs.GetInt("Level13Score") == 2) content13.image = (Texture2D)star2;
            if (PlayerPrefs.GetInt("Level13Score") == 3) content13.image = (Texture2D)star3;

            content14.image = (Texture2D)unlockedImage;
        }

        content15.image = (Texture2D)lockedImage;
        if (PlayerPrefs.GetInt("Level14Passed") == 10)
        {
            if (PlayerPrefs.GetInt("Level14Score") == 1) content14.image = (Texture2D)star1;
            if (PlayerPrefs.GetInt("Level14Score") == 2) content14.image = (Texture2D)star2;
            if (PlayerPrefs.GetInt("Level14Score") == 3) content14.image = (Texture2D)star3;

            content15.image = (Texture2D)unlockedImage;
        }

        content16.image = (Texture2D)lockedImage;
        if (PlayerPrefs.GetInt("Level15Passed") == 10)
        {
            if (PlayerPrefs.GetInt("Level15Score") == 1) content15.image = (Texture2D)star1;
            if (PlayerPrefs.GetInt("Level15Score") == 2) content15.image = (Texture2D)star2;
            if (PlayerPrefs.GetInt("Level15Score") == 3) content15.image = (Texture2D)star3;

            content16.image = (Texture2D)unlockedImage;
        }

        content17.image = (Texture2D)lockedImage;
        if (PlayerPrefs.GetInt("Level16Passed") == 10)
        {
            if (PlayerPrefs.GetInt("Level16Score") == 1) content16.image = (Texture2D)star1;
            if (PlayerPrefs.GetInt("Level16Score") == 2) content16.image = (Texture2D)star2;
            if (PlayerPrefs.GetInt("Level16Score") == 3) content16.image = (Texture2D)star3;

            content17.image = (Texture2D)unlockedImage;
        }

        content18.image = (Texture2D)lockedImage;
        if (PlayerPrefs.GetInt("Level17Passed") == 10)
        {
            if (PlayerPrefs.GetInt("Level17Score") == 1) content17.image = (Texture2D)star1;
            if (PlayerPrefs.GetInt("Level17Score") == 2) content17.image = (Texture2D)star2;
            if (PlayerPrefs.GetInt("Level17Score") == 3) content17.image = (Texture2D)star3;

            content18.image = (Texture2D)unlockedImage;
        }

        content19.image = (Texture2D)lockedImage;
        if (PlayerPrefs.GetInt("Level18Passed") == 10)
        {
            if (PlayerPrefs.GetInt("Level18Score") == 1) content18.image = (Texture2D)star1;
            if (PlayerPrefs.GetInt("Level18Score") == 2) content18.image = (Texture2D)star2;
            if (PlayerPrefs.GetInt("Level18Score") == 3) content18.image = (Texture2D)star3;

            content19.image = (Texture2D)unlockedImage;
        }

        if (PlayerPrefs.GetInt("Level19Passed") == 10)
        {
            if (PlayerPrefs.GetInt("Level19Score") == 1) content19.image = (Texture2D)star1;
            if (PlayerPrefs.GetInt("Level19Score") == 2) content19.image = (Texture2D)star2;
            if (PlayerPrefs.GetInt("Level19Score") == 3) content19.image = (Texture2D)star3;
        }
    }

    void OnGUI()
    {
        GUI.skin = theSkin;

        if (GUI.Button(new Rect(Screen.width * x1, Screen.height * y1, Screen.width * .15f, Screen.height * .1f), content1))
        {
            SceneManager.LoadScene("Level1");
        }

        if (GUI.Button(new Rect(Screen.width * x2, Screen.height * y2, Screen.width * .15f, Screen.height * .1f), content2))
        {
            if (PlayerPrefs.GetInt("Level1Passed") == 10) locked2 = false;
            if (locked2 == false)
            {
                SceneManager.LoadScene("Level2");
            }
        }

        if (GUI.Button(new Rect(Screen.width * x3, Screen.height * y3, Screen.width * .15f, Screen.height * .1f), content3))
        {
            //if (PlayerPrefs.GetInt("Level2Passed") == 10) SceneManager.LoadScene("Level3");
            if (PlayerPrefs.GetInt("Level2Passed") == 10) locked3 = false;
            if (locked3 == false)
            {
                SceneManager.LoadScene("Level3");
            }
        }

        if (GUI.Button(new Rect(Screen.width * x4, Screen.height * y4, Screen.width * .15f, Screen.height * .1f), content4))
        {
            //if (PlayerPrefs.GetInt("Level3Passed") == 10) SceneManager.LoadScene("Level4");
            if (PlayerPrefs.GetInt("Level3Passed") == 10) locked4 = false;
            if (locked4 == false)
            {
                SceneManager.LoadScene("Level4");
            }
        }

        if (GUI.Button(new Rect(Screen.width * x5, Screen.height * y5, Screen.width * .15f, Screen.height * .1f), content5))
        {
            //SceneManager.LoadScene("Level5");
            if (PlayerPrefs.GetInt("Level4Passed") == 10) locked5 = false;
            if (locked5 == false)
            {
                SceneManager.LoadScene("Level5");
            }
        }

        if (GUI.Button(new Rect(Screen.width * x6, Screen.height * y6, Screen.width * .15f, Screen.height * .1f), content6))
        {
            //SceneManager.LoadScene("Level6");
            if (PlayerPrefs.GetInt("Level5Passed") == 10) locked6 = false;
            if (locked6 == false)
            {
                SceneManager.LoadScene("Level6");
            }
        }

        if (GUI.Button(new Rect(Screen.width * x7, Screen.height * y7, Screen.width * .15f, Screen.height * .1f), content7))
        {
            //SceneManager.LoadScene("Level7");
            if (PlayerPrefs.GetInt("Level6Passed") == 10) locked7 = false;
            if (locked7 == false)
            {
                SceneManager.LoadScene("Level7");
            }
        }

        if (GUI.Button(new Rect(Screen.width * x8, Screen.height * y8, Screen.width * .15f, Screen.height * .1f), content8))
        {
            //SceneManager.LoadScene("Level8");
            if (PlayerPrefs.GetInt("Level7Passed") == 10) locked8 = false;
            if (locked8 == false)
            {
                SceneManager.LoadScene("Level8");
            }
        }

        if (GUI.Button(new Rect(Screen.width * x9, Screen.height * y9, Screen.width * .15f, Screen.height * .1f), content9))
        {
            //SceneManager.LoadScene("Level9");
            if (PlayerPrefs.GetInt("Level8Passed") == 10) locked9 = false;
            if (locked9 == false)
            {
                SceneManager.LoadScene("Level9");
            }
        }

        if (GUI.Button(new Rect(Screen.width * x10, Screen.height * y10, Screen.width * .15f, Screen.height * .1f), content10))
        {
            //SceneManager.LoadScene("Level10");
            if (PlayerPrefs.GetInt("Level9Passed") == 10) locked10 = false;
            if (locked10 == false)
            {
                SceneManager.LoadScene("Level10");
            }
        }

        if (GUI.Button(new Rect(Screen.width * x11, Screen.height * y11, Screen.width * .15f, Screen.height * .1f), content11))
        {
            //SceneManager.LoadScene("Level11");
            if (PlayerPrefs.GetInt("Level10Passed") == 10) locked11 = false;
            if (locked11 == false)
            {
                SceneManager.LoadScene("Level11");
            }
        }

        if (GUI.Button(new Rect(Screen.width * x12, Screen.height * y12, Screen.width * .15f, Screen.height * .1f), content12))
        {
            //SceneManager.LoadScene("Level12");
            if (PlayerPrefs.GetInt("Level11Passed") == 10) locked12 = false;
            if (locked12 == false)
            {
                SceneManager.LoadScene("Level12");
            }
        }

        if (GUI.Button(new Rect(Screen.width * x13, Screen.height * y13, Screen.width * .15f, Screen.height * .1f), content13))
        {
            //SceneManager.LoadScene("Level13");
            if (PlayerPrefs.GetInt("Level12Passed") == 10) locked13 = false;
            if (locked13 == false)
            {
                SceneManager.LoadScene("Level13");
            }
        }

        if (GUI.Button(new Rect(Screen.width * x14, Screen.height * y14, Screen.width * .15f, Screen.height * .1f), content14))
        {
            //SceneManager.LoadScene("Level14");
            if (PlayerPrefs.GetInt("Level13Passed") == 10) locked14 = false;
            if (locked14 == false)
            {
                SceneManager.LoadScene("Level14");
            }
        }

        if (GUI.Button(new Rect(Screen.width * x15, Screen.height * y15, Screen.width * .15f, Screen.height * .1f), content15))
        {
            //SceneManager.LoadScene("Level15");
            if (PlayerPrefs.GetInt("Level14Passed") == 10) locked15 = false;
            if (locked15 == false)
            {
                SceneManager.LoadScene("Level15");
            }
        }

        if (GUI.Button(new Rect(Screen.width * x16, Screen.height * y16, Screen.width * .15f, Screen.height * .1f), content16))
        {
            // SceneManager.LoadScene("Level16");
            if (PlayerPrefs.GetInt("Level15Passed") == 10) locked16 = false;
            if (locked16 == false)
            {
                SceneManager.LoadScene("Level16");
            }
        }

        if (GUI.Button(new Rect(Screen.width * x17, Screen.height * y17, Screen.width * .15f, Screen.height * .1f), content17))
        {
            //SceneManager.LoadScene("Level17");
            if (PlayerPrefs.GetInt("Level16Passed") == 10) locked17 = false;
            if (locked17 == false)
            {
                SceneManager.LoadScene("Level17");
            }
        }

        if (GUI.Button(new Rect(Screen.width * x18, Screen.height * y18, Screen.width * .15f, Screen.height * .1f), content18))
        {
            //SceneManager.LoadScene("Level18");
            if (PlayerPrefs.GetInt("Level17Passed") == 10) locked18 = false;
            if (locked18 == false)
            {
                SceneManager.LoadScene("Level18");
            }
        }

        if (GUI.Button(new Rect(Screen.width * x19, Screen.height * y19, Screen.width * .15f, Screen.height * .1f), content19))
        {
            // SceneManager.LoadScene("Level19");
            if (PlayerPrefs.GetInt("Level18Passed") == 10) locked19 = false;
            if (locked19 == false)
            {
                SceneManager.LoadScene("Level19");
            }
        }

        if (GUI.Button(new Rect(Screen.width * x_back, Screen.height * y_back, Screen.width * .15f, Screen.height * .1f), "Back"))
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
