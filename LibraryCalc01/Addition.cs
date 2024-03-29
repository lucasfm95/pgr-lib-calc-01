﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryCalc01
{
    /// <summary>
    /// Classe concreta para adição
    /// </summary>
    public class Addition : IOperation
    {
        /// <summary>
        /// Método que realiza a adição
        /// </summary>
        /// <param name="firstNumber">Primeiro número para somar</param>
        /// <param name="secondNumber">Segundo número para somar</param>
        /// <returns>Resultado da adição</returns>
        public double Calculate( double firstNumber, double secondNumber )
        {
            try
            {
                return firstNumber + secondNumber;
            }
            catch ( Exception ex )
            {
                throw new Exception( "Error calculate addition", ex );
            }
        }

        public double Calculate(params double[] values )
        {
            try
            {
                double result = 0;

                for ( int i = 0; i < values.Length; i++ )
                {
                    result += values[i]; 
                }

                return result;
            }
            catch ( Exception ex)
            {
                throw new Exception( "Error calculate addition", ex ); ;
            }
        }
    }
}
