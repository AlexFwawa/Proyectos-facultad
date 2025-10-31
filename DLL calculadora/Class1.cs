using System;

namespace DLL_calculadora
{
    public static class Calculadora
    {
        public static double Sumar(double a, double b) => a + b;
        public static double Restar(double a, double b) => a - b;
        public static double Multiplicar(double a, double b) => a * b;

        public static double Dividir(double a, double b)
        {
            if (b == 0) throw new DivideByZeroException("No se puede dividir por cero");
            return a / b;
        }

        public static double Porcentaje(double baseNumero, double porcentaje) =>
            (baseNumero * porcentaje) / 100.0;

        public static double Calcular(double num1, double num2, string operacion)
        {
            switch (operacion)
            {
                case "+": return Sumar(num1, num2);
                case "-": return Restar(num1, num2);
                case "×":
                case "*": return Multiplicar(num1, num2);
                case "÷":
                case "/": return Dividir(num1, num2);
                case "%": return Porcentaje(num1, num2);
                default: throw new ArgumentException("Operación no válida: " + operacion);
            }
        }
    }
}
