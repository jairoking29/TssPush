﻿using System;

namespace TssPush.Utils
{
    class Formatter
    {
        public static string FormatString( string str, int length )
        {
            if( str.Length > length )
            {
                str = str.Substring(0, length);
            }
            if( str.Length < length )
            {
                str = str.PadRight(length, ' ');
            }
            return str;
        }

        public static string FormatDate( DateTime date )
        {
            return date.ToString( "dd/MM/yyyy" );
        }

        public static string FormatNumber(decimal number, int lenght)
        {
            return number.ToString("0.00").Replace(".", "").PadLeft(lenght, '0');
        }

        public static string FormatNumber(int number, int lenght)
        {
            return number.ToString().PadLeft(lenght, '0');
        }
    }
}
