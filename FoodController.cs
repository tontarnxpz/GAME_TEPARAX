using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FoodController : MonoBehaviour
{

    public Image currentFood;//�Ҿ�ʴ�����
    public Text txt;//�ʴ���ͤ��� %
    public float food = 100;
    private float maxfood = 100; //���ʹ100%
    public static FoodController instance;

    // 100/100 = 1 
    // 99/100 = 0.99
    // 50/100 = 0.5


    void Start()
    {
        instance = this;
        InvokeRepeating("updateFoodHealth", 1.0f, 10f); //���¡��ҹ updateFoodeHealth
    }

    void Update()
    {
        float radio = food / maxfood; // = 100/100 = 1 
        currentFood.rectTransform.localScale = new Vector3(radio, 1, 1); //�Ǻ�������¹��᡹ x �͡��� 1
        txt.text = (radio * 100) + " % "; //�ʴ� %
    }

    void updateFoodHealth()
    {
        if (food > 0) //����ҡ���� 0 ��Ŵŧ������� ���� 1
        {
            food -= 1f;
        }
    }

    //�ж١���¡��ҹ�͹���� Item ����
    public void healingFood()
    {
        food += 10;  //����͡Թ�������ʹ�� +10
        if (food >= maxfood)
        {
            food = maxfood;
        }
    }
}
