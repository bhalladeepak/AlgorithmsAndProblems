using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SandBoxProject
{
    /// <summary>
    /// Providers extensions and helpers for enumerations.
    /// </summary>
    public static class EnumExtensions
    {

        public static string EnumToString<T>(object value)
        {
            //Type type = typeof(T);
            //string stringName = null;
            //if (!typeof(T).IsEnum)
            //{
            //    throw new ArgumentException("Type {0} is not a valid enumeration.", type.Name);
            //}

            //var valuesCount = Enum.GetNames(typeof(T)).Length;
            //if(valuesCount == 0)
            //{
            //    throw new ArgumentNullException("Enumeration pass is null");
            //}

            //if(value != null)
            //{
            //    stringName = Enum.GetName(typeof(T), value);
            //}

            //if(!string.IsNullOrEmpty(stringName))
            //{
            //    return stringName;
            //}
            //else
            //{
            //    throw new Exception("Value not found in enumeration");
            //}


            return ((Enum)value).ToDescription();

        }

        /// <summary>
        /// Gets the string representation of the enum value, substituting its
        /// description attribute value if set.
        /// </summary>
        /// <param name="value">The enum to get the description of.</param>
        /// <returns>An enum description.</returns>
        public static string ToDescription(this Enum value)
        {
            string text = value.ToString();
            Type type = value.GetType();

            if (type.GetCustomAttributes(typeof(FlagsAttribute), false).Count() > 0)
            {
                List<string> descriptions = new List<string>();
                int valueInt = Convert.ToInt32(value, CultureInfo.InvariantCulture);

                foreach (string name in Enum.GetNames(type))
                {
                    int val = (int)Enum.Parse(type, name);

                    if ((val & valueInt) == val)
                    {
                        MemberInfo info = type.GetMember(name).FirstOrDefault();

                        if (info != null)
                        {
                            DescriptionAttribute attr = (DescriptionAttribute)info.GetCustomAttributes(typeof(DescriptionAttribute), false).FirstOrDefault();

                            if (attr != null)
                            {
                                descriptions.Add(attr.Description);
                            }
                            else
                            {
                                descriptions.Add(name);
                            }
                        }
                        else
                        {
                            descriptions.Add(name);
                        }
                    }
                }

                text = string.Join(", ", descriptions.ToArray());
            }
            else
            {
                MemberInfo info = type.GetMember(text).FirstOrDefault();

                if (info != null)
                {
                    DescriptionAttribute attr = (DescriptionAttribute)info.GetCustomAttributes(typeof(DescriptionAttribute), false).FirstOrDefault();

                    if (attr != null)
                    {
                        text = attr.Description;
                    }
                }
            }

            return text;
        }
    }
}
