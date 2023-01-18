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
        public void SetHealth()
        {
            CurrentHealth -= 1;
        }
    }
}
