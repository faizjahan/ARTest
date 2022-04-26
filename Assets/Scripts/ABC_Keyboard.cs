using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ABC_Keyboard : MonoBehaviour
{
    [SerializeField] private Button abc_Button;
    [SerializeField] private Sprite[] buttonImages;
    [SerializeField] private GameObject[] buttonObject;

    [SerializeField] private Sprite[] alphabetImage;
    private string[] alphabetText = {"Apple", "Ball", "Cat", "Dog", "Elephant","Fish", "Giraffee","Horse", "Icecream", "Joker",
                                                      "Kite", "Lion", "Monkey", "Nest","Owl","Penquin","Queen", "Rainbow", "Sun",
                                                      "Train","Umbrella","Violin","Watch","Xray","Yak","Zebra"};
    public Image imageContainer;
    public GameObject textPanel;
    public Text textContainer;
    public GameObject objectContainer;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 26; i++)
        {
            createButton(i);
        }
    }
    void createButton(int i)
    {
        Button btn = Instantiate(abc_Button, this.transform);
        btn.onClick.AddListener(() => TaskOnClick(i));
        btn.image.sprite = buttonImages[i];
    }
    private void TaskOnClick(int i)
    {
        //Destroy(objectContainer.transform.GetChild(0).gameObject);
        GameObject obj = Instantiate(buttonObject[i], objectContainer.transform);

        imageContainer.gameObject.SetActive(true);
        textPanel.gameObject.SetActive(true);

        imageContainer.sprite = alphabetImage[i];
        textContainer.text = alphabetText[i];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
