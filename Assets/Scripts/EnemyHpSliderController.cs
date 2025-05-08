using UnityEngine;
using UnityEngine.UI;

public class EnemyHpSliderController : MonoBehaviour
{
    public GameObject target;
    public Slider hpSlider;

    private void Update()
    {
        hpSlider.transform.position = transform.position + new Vector3(0, 25f, 0);
    }
}
