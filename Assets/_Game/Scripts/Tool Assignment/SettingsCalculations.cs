using UnityEngine;


namespace Tool_Assignment
{
    public class SettingsCalculations : MonoBehaviour
    {
        public SettingsManager Manager;
        public int test;

        private void Start()
        {
            test = Manager.MaxHealth;
            //Manager.damageTaken = 0;
        }
        public void SetHealth()
        {
            test -= 1;
        }
    }
}
