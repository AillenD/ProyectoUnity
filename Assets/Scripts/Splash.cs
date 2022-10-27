using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Splash : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake()
    {
        StartCoroutine(InicializaParaMainMenu());
    }

    private IEnumerator InicializaParaMainMenu()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("Mainmenu");
    }

}
