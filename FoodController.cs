using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FoodController : MonoBehaviour
{

    public Image currentFood;//ภาพแสดงบาร์
    public Text txt;//แสดงข้อความ %
    public float food = 100;
    private float maxfood = 100; //เลือด100%
    public static FoodController instance;

    // 100/100 = 1 
    // 99/100 = 0.99
    // 50/100 = 0.5


    void Start()
    {
        instance = this;
        InvokeRepeating("updateFoodHealth", 1.0f, 10f); //เรียกใช้งาน updateFoodeHealth
    }

    void Update()
    {
        float radio = food / maxfood; // = 100/100 = 1 
        currentFood.rectTransform.localScale = new Vector3(radio, 1, 1); //ควบคุมเปลี่ยนแค่แกน x นอกนั้น 1
        txt.text = (radio * 100) + " % "; //แสดง %
    }

    void updateFoodHealth()
    {
        if (food > 0) //ถ้ามากกว่า 0 จะลดลงเรื่อยๆ ทีละ 1
        {
            food -= 1f;
        }
    }

    //จะถูกเรียกใช้งานตอนกดใช้ Item เนื้อ
    public void healingFood()
    {
        food += 10;  //เมื่อกินเนื้อเลือดจะ +10
        if (food >= maxfood)
        {
            food = maxfood;
        }
    }
}
