using UnityEngine;

public class OtoparkSistemi : MonoBehaviour
{

int time = 2;

void Start()

{
switch (time)
{
    case 1:
        Debug.Log("Otoparkta kalınan süre: 1 saat\nÖdenecek Ücret: 120TL");
        break;
    case 2:
        Debug.Log("Otoparkta kalınan süre: 2 saat\nÖdenecek Ücret: 200TL");
        break;
    case 3:
        Debug.Log("Otoparkta kalınan süre: 3 saat \nÖdenecek Ücret: 300TL");
        break;
    case 4:
        Debug.Log("Otoparkta kalınan süre: 4 saat \nÖdenecek Ücret: 400TL ");
        break;
    case >= 5:
        Debug.Log($"Otoparkta kalınan süre: {time} saat \nÖdenecek Ücret: 550TL ");
        break;
    default:
        Debug.Log("https://www.youtube.com/watch?v=xS5aALEWDj8");
        break;
}
}
}
