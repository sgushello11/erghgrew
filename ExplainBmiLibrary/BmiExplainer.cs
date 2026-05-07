using System;

namespace ExplainBmiLibrary
{
    /// <summary>
    /// Класс для расшифровки и пояснения ИМТ
    /// </summary>
    public class BmiExplainer
    {
        /// <summary>
        /// Расшифровывает значение ИМТ и выводит пояснение
        /// </summary>
        /// <param name="bmi">Значение индекса массы тела</param>
        public static void Explain(double bmi)
        {
            Console.WriteLine("РАСШИФРОВКА ИМТ");

            if (bmi < 18.5)
                Console.WriteLine($"ИМТ {bmi:F2} - Недовес");
            else if (bmi < 25)
                Console.WriteLine($"ИМТ {bmi:F2} - Норма");
            else if (bmi < 30)
                Console.WriteLine($"ИМТ {bmi:F2} - Лишний вес");
            else
                Console.WriteLine($"ИМТ {bmi:F2} - Ожирение");

            Console.WriteLine("Норма: 18.5 - 25");
        }

        /// <summary>
        /// Возвращает категорию ИМТ в виде строки
        /// </summary>
        /// <param name="bmi">Значение индекса массы тела</param>
        /// <returns>Категория ИМТ</returns>
        public static string GetCategory(double bmi)
        {
            if (bmi < 18.5)
                return "Недовес";
            else if (bmi < 25)
                return "Норма";
            else if (bmi < 30)
                return "Лишний вес";
            else
                return "Ожирение";
        }
    }
}