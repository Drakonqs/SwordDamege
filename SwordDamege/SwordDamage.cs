using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwordDamege
{
    /// <summary>
    /// Класс Подсчёт урона мечём
    /// </summary>
    class SwordDamage
    {
        private const int BASE_DAMAGE = 3;
        private const int FLAME_DAMAGE = 2;
        /// <summary>
        /// Содержит расчетный урон.
        /// </summary>
        public int Damage { get; private set; }
        private int roll;
        /// <summary>
        /// Устанавливает или получает бросок 3d6.
        /// </summary>
        public int Roll
        {
            get { return roll; }
            set
            {
                roll = value;
                CalculateDamage();
            }
        }
        private bool magic;
        /// <summary>
        /// True, если меч волшебный; false в противном случае.
        /// </summary>
        public bool Magic
        {
            get { return magic; }
            set
            {
                magic = value;
                CalculateDamage();
            }
        }
        private bool flaming;
        /// <summary>
        /// True, если меч огненный; false в противном случае.
        /// </summary>
        public bool Flaming
        {
            get { return flaming; }
            set
            {
                flaming = value;
                CalculateDamage();
            }
        }
        /// <summary>
        /// Вычисляет повреждения в зависимости от текущих значений свойств.
        /// </summary>
        private void CalculateDamage()
        {
            decimal magicMultiplier = 1M;
            if (Magic) magicMultiplier = 1.75M;
            Damage = BASE_DAMAGE;
            Damage = (int)(Roll * magicMultiplier) + BASE_DAMAGE;
            if (Flaming) Damage += FLAME_DAMAGE;
        }
        /// <summary>
        /// Конструктор вычисляет повреждения для значений Magic и Flaming по умолчанию 
        /// и начального броска 3d6.
        /// </summary>
        /// <param name="startingRoll">Начальный бросок 3d6</param>
        public SwordDamage(int startingRoll)
        {
            roll = startingRoll;
            CalculateDamage();
        }
    }
}
//class SwordDamage
    //{
    //    public const int BASE_DAMAGE = 3;
    //    public const int FLAME_DAMAGE = 2;
    //    public int Roll;
    //    public decimal MagicMultiplier = 1M;

    //    public int Damage;
    //    public void CalculateDamage()//Считаем урон мечём
    //    {
    //        Damage = (int)(Roll * MagicMultiplier) + BASE_DAMAGE;
    //    }
    //    public void SetMagic(bool isMagic)//Магический или нет
    //    {
    //        if (isMagic)
    //        {
    //            MagicMultiplier = 1.75M;
    //        }
    //        else
    //        {
    //            MagicMultiplier = 1M;
    //        }
    //        CalculateDamage();
    //    }
    //    public void SetFlaming(bool isFlaming)//Огненый или нет
    //    {
    //        CalculateDamage();
    //        if (isFlaming)
    //        {
    //            Damage += FLAME_DAMAGE;
    //        }
    //    }
