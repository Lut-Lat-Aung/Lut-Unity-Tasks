using UnityEngine;

public class PlayerWeaponController : MonoBehaviour
{
    [SerializeField] private Weapon currentWeapon;
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (currentWeapon != null)
                currentWeapon.Fire();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            if (currentWeapon != null)
                currentWeapon.Reload();
        }
    }


}
