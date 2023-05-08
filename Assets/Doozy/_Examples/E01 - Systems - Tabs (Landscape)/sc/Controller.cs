using Doozy.Runtime.Reactor.Animators;
using Doozy.Runtime.UIManager.Animators;
using Michsky.MUIP;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Controller : MonoBehaviour
{
    [SerializeField] GameObject register;
    [SerializeField] GameObject registerUser;
    [SerializeField] GameObject editWeight;
    [SerializeField] TMP_InputField name;
    [SerializeField] CustomDropdown genger;
    [SerializeField] TMP_InputField age;
    [SerializeField] TMP_InputField weight;
    [SerializeField] TMP_InputField height;
    [SerializeField] TMP_InputField editWeightText;
    [SerializeField] TMP_InputField editDesiredWeightText;

    [SerializeField] TMP_Text errorText;
    [SerializeField] TMP_Text weightText;
    [SerializeField] TMP_Text desiredWeightText;
    [SerializeField] TMP_Text bMI;
    [SerializeField] TMP_Text percentage;

    [SerializeField] TMP_Text[] dataUesr;



    int x = 0;
    User user1;
    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
       
         
    }

    public void RegisterUser()
    {
        if (!name.text.Equals("") && !age.text.Equals("") && !weight.text.Equals("") && !height.text.Equals(""))
        {
            
            
            int age1 = int.Parse(age.text);
            float w = float.Parse(weight.text);
            float h = float.Parse(height.text);
            string gen = "";
            if (genger.selectedItemIndex == 0)
            {
                gen = "ชาย";
            }
            else if (genger.selectedItemIndex == 1)
            {
                gen = "หญิง";
            }
            else if (genger.selectedItemIndex == 2) { gen = "อื่นๆ"; }
            user1 = new User(name.text, gen, age1, w, h);
            bMI.text = user1.GetBMI().ToString("F2");
            bMI.color = new Color(user1.GetColor_BMI()[0], user1.GetColor_BMI()[1], user1.GetColor_BMI()[2]);
            percentage.text = "0%";
            dataUesr[0].text = user1.GetName();
            dataUesr[1].text = user1.GetGender();
            dataUesr[2].text = user1.GetAge().ToString();  
            dataUesr[3].text = user1.GetWeight().ToString();
            dataUesr[4].text = user1.GetHeight().ToString();
            dataUesr[5].text = user1.GetBMI().ToString("F2");
            name.text = "";
            age.text = "";
            weight.text = "";
            height.text = "";
            //bMI.color = Color.white;
            x++;
            EditTextWeight();
            registerUser.GetComponent<UIContainerUIAnimator>().Hide();
            register.GetComponent<UIContainerUIAnimator>().Hide();
        }
        else
        {
            errorText.text = "กรุณากรอกข้อมูลให้ถูกต้อง";
        }

      
    }

    public void ActionShow()
    {
        name.text = user1.GetName();
        age.text = user1.GetAge().ToString();
        weight.text = user1.GetWeight().ToString();
        height.text = user1.GetHeight().ToString();
    }


    public void ActionShowEditWeight()
    {
        editWeightText.text = "";
        editDesiredWeightText.text = "";
    }

    public void ActionEditWeight()
    {
        if (editDesiredWeightText.text.Equals(""))
        {
            user1.SetDesiredWeight(user1.GetDesiredWeight());
            
        }
        else
        {
            user1.SetDesiredWeight(float.Parse(editDesiredWeightText.text));
            
        }

        if (editWeightText.text.Equals(""))
        {
            user1.SetWeight(user1.GetWeight());
        }
        else
        {
            user1.SetWeight(float.Parse(editWeightText.text));
            user1.SetBMI(float.Parse(editWeightText.text));
            bMI.text = user1.GetBMI().ToString("F2");
            bMI.color = new Color(user1.GetColor_BMI()[0], user1.GetColor_BMI()[1], user1.GetColor_BMI()[2]);
            dataUesr[3].text = user1.GetWeight().ToString();
            dataUesr[5].text = user1.GetBMI().ToString("F2");
        }

        if (user1.GetDesiredWeight() > 0) { percentage.text = ((((user1.GetDesiredWeight() - user1.GetWeightf()) - (user1.GetDesiredWeight() - user1.GetWeight())) * 100f)/ (user1.GetDesiredWeight() - user1.GetWeightf())).ToString("F2") + "%"; }
        //percentage.text = ((user1.GetWeight() / user1.GetDesiredWeight())*100f).ToString("F2") + "%" ;

        //editWeight.GetComponent<UIContainerUIAnimator>().Hide();
        EditTextWeight();
    }

    public void EditTextWeight()
    {
        weightText.text = (user1.GetWeight()).ToString();
        desiredWeightText.text = (user1.GetDesiredWeight()).ToString();
    }

    /*IEnumerator checkUser()
    {
       
    }*/
}
