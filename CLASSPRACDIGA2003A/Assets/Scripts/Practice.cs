using UnityEngine;

public class Practice : MonoBehaviour
{
    int a = 8;
    int b = 5;
    int decade = 10;
   public int age;
    public int dayCount;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Question 1
        Debug.Log(a + b);
        
        //Question 2
        if (age >= 18)
            Debug.Log("Adult");
        else Debug.Log("Minor");
        
        //Question 3
        for (int years = 1; years <= decade; years ++)
        {
            Debug.Log("This is year " + years);
        }

        //Question 4
        switch (dayCount)
        {
            case 0:
                Debug.Log("Monday");
                break;
            case 1:
                Debug.Log("Tuesday");
                break;
            case 2:
                Debug.Log("Wednesday");
                break;
            case 3:
                Debug.Log("Thursday");
                break;
            case 4:
                Debug.Log("Friday");
                break;
            case 5:
                Debug.Log("Saturday");
                break;
            case 6:
                Debug.Log("Sunday");
                break;
        }

        //Question 5
        string[] names = { "Steve", "Emily", "Thabo", "Leratho", "Tiaan" };

            foreach(string name in names)
                Debug.Log(name);

        //Question 6    
        int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        foreach (int num in nums)
            if (num % 2 == 0)
                Debug.Log("Even");
            else
                Debug.Log("ODD");
    }

    }

