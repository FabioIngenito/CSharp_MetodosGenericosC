using System;
using System.Collections.Generic;


namespace wfaMetodosGenericos
{
    /// <summary>
    /// Macoratti.Net
    /// Apresentando e usando Métodos Genéricos (C#) - I
    /// Introducing and Using Generic Methods (C #) - I
    /// http://www.macoratti.net/15/04/c_mgen1.htm
    /// </summary>
    public class clsMetodosGenericos
    {
        /// <summary>
        /// Troca de Lugar os dois texto recebidos
        /// Change of Place the two texts received
        /// </summary>
        /// <typeparam name="T">Tipo de variável - Variable Type</typeparam>
        /// <param name="lhs">Texto recebido 1 - Received Text 1</param>
        /// <param name="rhs">Texto recebido 2 - Received Text 2</param>
        public void Trocar<T>(ref T lhs, ref T rhs)
        {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }

        /// <summary>
        /// Compara dois valores recebidos e retorna o maior.
        /// Compares two received values and returns the largest.
        /// </summary>
        /// <typeparam name="T">Tipo de variável - Variable Type</typeparam>
        /// <param name="valor1">Valor recebido 1 - Received Text 1</param>
        /// <param name="valor2">Valor recebido 2 - Received Text 2</param>
        /// <returns>O maior valor é retornado aqui - The highest value is returned here</returns>
        public T Maximo<T>(T valor1, T valor2) where T : IComparable
        {
            if (valor1.CompareTo(valor2) > 0) return valor1;
            return valor2;
        }

        /// <summary>
        /// Cria uma lista a partir dos valores recebidos
        /// Creates a list from received values
        /// </summary>
        /// <typeparam name="T">Tipo de variável - Variable Type</typeparam>
        /// <param name="pars">Lista de parâmetros separada por vírgula</param>
        /// <returns>A lista é devolvida aqui - The list is returned here</returns>
        public List<T> CriaLista<T>(params T[] pars)
        {
            List<T> lista = new List<T>();
            foreach (T elem in pars)
            {
                lista.Add(elem);
            }
            return lista;
        }
    }
}