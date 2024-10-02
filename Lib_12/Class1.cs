
namespace Lib_12
{
    public class ClassSum
    {
        /// <summary>
        /// Метод для генерации случайных значений
        /// </summary>
        /// <param name="quant"></param>
        /// <returns>Случайное число от 0 до n</returns>
        public static string GenRandom(string quant)
        {            
            int quantConv = Convert.ToInt32(quant);            
            Random random = new Random();
            string rowNumber = "";
            for (int i = 0; i < quantConv; i++)
            {
                int num = random.Next(quantConv);
                rowNumber += num.ToString() + " ";
            }
            return rowNumber;
        }
        /// <summary>
        /// Метод для вычисления суммы
        /// </summary>
        /// <param name="row"></param>
        /// <returns>Сумма чисел из tbNumbers</returns>
        public static int Summa(string row)
        {
            int sum = 0;
            for (int i = 0; i < row.Length; i++)
            {
                string numberString = "";
                while (Int32.TryParse(row[i].ToString(), out int temper))
                {
                    numberString += temper.ToString();
                    i++;
                }               
                sum += Convert.ToInt32(numberString);
            }
            return sum;
        }
    }
}
