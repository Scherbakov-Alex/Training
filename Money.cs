using System;
using System.Collections.Generic;


namespace ConsoleConverter
{
    public class Money
    {
        decimal moneyValue;
        decimal moneyCounts;
        public string m_currency;
        public decimal finalValue;
        Dictionary<string, int> valut = new Dictionary<string, int>
        {
            ["RUB"] = 1,
            ["USD"] = 76,
            ["EUR"] = 89,
        };
        public Money()
        {
        }

        public Money(decimal value, string currency)
        {
            moneyValue = value;
            moneyCounts = valut[currency];
            m_currency = currency;
            finalValue = moneyValue * moneyCounts;
        }

        public static Money operator +(Money m1, Money m2)
        {
            Money mn = new Money
            {
                finalValue = Math.Round((m1.finalValue + m2.finalValue) / m1.moneyCounts, 2),
                m_currency = m1.m_currency
            };
            return mn;
        }
        public static Money operator -(Money m1, Money m2)
        {
            Money mn = new Money
            {
                finalValue = Math.Round((m1.finalValue - m2.finalValue) / m1.moneyCounts, 2),
                m_currency = m1.m_currency
            };
            return mn;
        }
        public static Money operator *(Money m1, Money m2)
        {
            Money mn = new Money
            {
                finalValue = Math.Round((m1.finalValue * m2.finalValue) / (m1.moneyCounts * m2.moneyCounts), 6),
                m_currency = m1.m_currency
            };
            return mn;
        }
        public static Money operator /(Money m1, Money m2)
        {
            Money mn = new Money
            {
                finalValue = Math.Round((m1.finalValue / m2.finalValue) / (m1.moneyCounts * m2.moneyCounts), 2),
                m_currency = m1.m_currency
            };
            return mn;
        }
        public static bool operator <(Money m1, Money m2)
        {
            if (m1.finalValue < m2.finalValue)
                return true;
            else
                return false;
        }
        public static bool operator >(Money m1, Money m2)
        {
            if (m1.finalValue > m2.finalValue)
                return true;
            else
                return false;
        }
        public static bool operator ==(Money m1, Money m2)
        {
            if (m1.finalValue == m2.finalValue)
                return true;
            else
                return false;
        }
        public static bool operator !=(Money m1, Money m2)
        {
            if (m1.finalValue != m2.finalValue)
                return true;
            else
                return false;
        }
        public static bool operator >=(Money m1, Money m2)
        {
            if (m1.finalValue >= m2.finalValue)
                return true;
            else
                return false;
        }
        public static bool operator <=(Money m1, Money m2)
        {
            if (m1.finalValue <= m2.finalValue)
                return true;
            else
                return false;
        }
    }
}
