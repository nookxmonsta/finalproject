using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class User : MonoBehaviour
{
    private string nameUser = "";
    private string gender = "";
    private int age = 0;
    private float weight = 0.0f;
    private float weightf = 0.0f;

    private float height = 0.0f;
    private float bMI = 0.0f;
    private float[] color_BMI = { 0f, 0f, 0f, 1f};
    private float desired_weight = 0.0f;


    public User(string name,string gender, int age, float weight, float height){
        this.nameUser = name;
        this.gender = gender;
        this.age = age;
        this.weight = weight;
        this.weightf = weight;
        this.height = height;
        this.bMI = weight/((height / 100) * (height / 100));
        if (this.bMI < 18.5f)
        {
            this.color_BMI[0] = 0.4549f;
            this.color_BMI[1] = 0.4392f;
            this.color_BMI[2] = 0.5059f;
        }
        else if (this.bMI < 23f)
        {
            this.color_BMI[0] = 0.5725f;
            this.color_BMI[1] = 0.8235f;
            this.color_BMI[2] = 0.7569f;
        }
        else if (this.bMI < 30f)
        {
            this.color_BMI[0] = 233/255f;
            this.color_BMI[1] = 212/255f;
            this.color_BMI[2] = 100/255f;
        }
        else if (this.bMI < 40f)
        {
            this.color_BMI[0] = 238/255f;
            this.color_BMI[1] = 157/255f;
            this.color_BMI[2] = 114/255f;
        }
        else
        {
            this.color_BMI[0] = 221/255f;
            this.color_BMI[1] = 46/255f;
            this.color_BMI[2] = 49/255f;
        }
    }

    public void SetWeight(float weight)
    {
        this.weight = weight;
    }

    public void SetBMI(float weight)
    {
        this.bMI = weight / ((height / 100) * (height / 100));
        if (this.bMI < 18.5f)
        {
            this.color_BMI[0] = 0.4549f;
            this.color_BMI[1] = 0.4392f;
            this.color_BMI[2] = 0.5059f;
        }
        else if (this.bMI < 23f)
        {
            this.color_BMI[0] = 0.5725f;
            this.color_BMI[1] = 0.8235f;
            this.color_BMI[2] = 0.7569f;
        }
        else if (this.bMI < 30f)
        {
            this.color_BMI[0] = 233 / 255f;
            this.color_BMI[1] = 212 / 255f;
            this.color_BMI[2] = 100 / 255f;
        }
        else if (this.bMI < 40f)
        {
            this.color_BMI[0] = 238 / 255f;
            this.color_BMI[1] = 157 / 255f;
            this.color_BMI[2] = 114 / 255f;
        }
        else
        {
            this.color_BMI[0] = 221 / 255f;
            this.color_BMI[1] = 46 / 255f;
            this.color_BMI[2] = 49 / 255f;
        }
    }

    public void SetDesiredWeight(float weight)
    {
        this.desired_weight = weight;

    }

    public void SetWeightf(float weight)
    {
        this.weightf = weight;

    }

    public void SetHeight(float height)
    {
        this.height = height;
    }

    public void SetAge(int age)
    {
        this.age = age;
    }

    public int GetAge()
    {
        return age;
    }

    public float GetBMI()
    {
        return bMI;
    }

    public float[] GetColor_BMI()
    {
        return color_BMI;
    }

    public float GetWeight()
    {
        return weight;
    }

    public float GetWeightf()
    {
        return weightf;
    }

    public float GetDesiredWeight()
    {
        return desired_weight;
    }

    public float GetHeight()
    {
        return height;
    }
    public string GetGender()
    {
        return gender;
    }

    public string GetName()
    {
        return nameUser;
    }

    public string toString(){
        return gender + " " + bMI;
    }



   
}
