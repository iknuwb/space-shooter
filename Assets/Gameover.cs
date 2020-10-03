using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gameover : MonoBehaviour
{
   public void restart(){SceneManager.LoadScene(0);}
   public void quit(){Application.Quit();}
}
