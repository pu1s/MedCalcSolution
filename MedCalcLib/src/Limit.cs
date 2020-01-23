using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedCalc
{
    #region Пределы
    /// <summary>
    /// Предел
    /// </summary>
    public class Limit
    {
        /// <summary>
        /// Нижний предел
        /// </summary>
        public float Lower { get; private set; }

        /// <summary>
        /// Верхний предел
        /// </summary>
        public float Upper { get; private set; }

        /// <summary>
        /// Создает новый предел
        /// </summary>
        public Limit()
        {
            Lower = 0.0f;
            Upper = 0.0f;
        }

        /// <summary>
        /// Создает новый предел
        /// </summary>
        /// <param name="lower">Нижний предел</param>
        /// <param name="upper">Верхний предел</param>
        public Limit(float lower, float upper)
        {
            if (lower > upper) throw new ArgumentOutOfRangeException(@"Неверно указан входной параметр!");
            Lower = lower;
            Upper = upper;
        }

        /// <summary>
        /// Пустой предел
        /// </summary>
        public static readonly Limit Empty = new Limit();

        /// <summary>
        /// Определяет пустой-ли предел
        /// </summary>
        public bool IsEmpty => this.Upper == 0.0f && this.Lower == 0.0f;
    }

#endregion

}
