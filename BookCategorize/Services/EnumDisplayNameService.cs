using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace BookCategorize.Services
{
    public static class EnumDisplayNameService
    {
        public static string GetDisplayName(this Enum enumValue)
        {
            return enumValue.GetType()
                            .GetMember(enumValue.ToString())
                            .First()
                            .GetCustomAttribute<DisplayAttribute>()
                            .GetName();
        }
    }
}
