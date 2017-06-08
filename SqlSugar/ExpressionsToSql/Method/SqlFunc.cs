﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlSugar
{
    public class SqlFunc
    {
        public static bool HasNumber(object thisValue)
        {
            return thisValue.ObjToInt() > 0;
        }
        public static bool HasValue(object thisValue)
        {
            return thisValue.IsValuable();
        }
        public static bool IsNullOrEmpty(object thisValue)
        {
            return thisValue.IsNullOrEmpty();
        }
        public static string ToLower(object thisValue)
        {
            return thisValue == null ? null : thisValue.ToString().ToLower();
        }
        public static string ToUpper(object thisValue)
        {
            return thisValue == null ? null : thisValue.ToString().ToUpper();
        }
        public static string Trim(object thisValue)
        {
            return thisValue == null ? null : thisValue.ToString().Trim();
        }
        public static bool Contains(string thisValue, string parameterValue)
        {
            return thisValue.Contains(parameterValue);
        }
        public static bool ContainsArray<T>(T[] thisValue, object parameterValue)
        {
            return thisValue.Contains((T)parameterValue);
        }
        public static bool StartsWith(string thisValue, string parameterValue)
        {
            return thisValue.StartsWith(parameterValue);
        }
        public static bool EndsWith(object thisValue, string parameterValue) { throw new NotImplementedException(); }
        public new static bool Equals(object thisValue, object parameterValue) { throw new NotImplementedException(); }
        public static bool DateIsSame(DateTime date1, DateTime date2) { throw new NotImplementedException(); }
        public static bool DateIsSame(DateTime? date1, DateTime? date2) { throw new NotImplementedException(); }
        public static bool DateIsSame(DateTime date1, DateTime date2, DateType dataType) { throw new NotImplementedException(); }
        public static DateTime DateAdd(DateTime date, int addValue, DateType dataType) { throw new NotImplementedException(); }
        public static DateTime DateAdd(DateTime date, int addValue) { throw new NotImplementedException(); }
        public static int DateValue(DateTime date, DateType dataType) { throw new NotImplementedException(); }
        public static bool Between(object value, object start, object end) { throw new NotImplementedException(); }
        public static int ToInt32(object value) { throw new NotImplementedException(); }
        public static long ToInt64(object value) { throw new NotImplementedException(); }
        public static DateTime ToDate(object value) { throw new NotImplementedException(); }
        public static string ToString(object value) { throw new NotImplementedException(); }
        public static decimal ToDecimal(object value) { throw new NotImplementedException(); }
        public static Guid ToGuid(object value) { throw new NotImplementedException(); }
        public static double ToDouble(object value) { throw new NotImplementedException(); }
        public static bool ToBool(object value) { throw new NotImplementedException(); }
        public static string Substring(object value, int index, int length) { throw new NotImplementedException(); }
        public static string Replace(object value, string oldChar, string newChar) { throw new NotImplementedException(); }
        public static int Length(object value) { throw new NotImplementedException(); }
        public static TResult AggregateSum<TResult>(TResult thisValue) { throw new NotImplementedException(); }
        public static TResult AggregateAvg<TResult>(TResult thisValue) { throw new NotImplementedException(); }
        public static TResult AggregateMin<TResult>(TResult thisValue) { throw new NotImplementedException(); }
        public static TResult AggregateMax<TResult>(TResult thisValue) { throw new NotImplementedException(); }
        public static TResult AggregateCount<TResult>(TResult thisValue) { throw new NotImplementedException(); }
    }
}
