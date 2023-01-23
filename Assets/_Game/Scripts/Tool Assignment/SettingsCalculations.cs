using UnityEngine;


namespace Tool_Assignment
{
    public class SettingsCalculations : MonoBehaviour
    {
        public SettingsManager Manager;
        public int CurrentHealth;

        private void Start()
        {
            CurrentHealth = Manager.MaxHealth;
        }
        //Call this variable where the damage of the ship is inflicted
        public void SetHealth()
        {
            CurrentHealth -= 1;
        }
    }
}
