
namespace SimpleBackend.ViewModels
{
    static public class Extensions
    {
        static public TDestination To<TDestination>(this object source, TDestination destination = null)
            where TDestination : class, new()
        {
            foreach (var item in source.GetType().GetProperties())
            {
                var value = item.GetValue(source);

                if (value == null)
                    continue;

                var property = typeof(TDestination).GetProperty(item.Name);

                if (property != null && property.PropertyType == item.PropertyType)
                {
                    if (destination == null)
                    {
                        destination = new TDestination();
                    }

                    property.SetValue(destination, value);

                }

            }

            return destination;
        }
    }
}

namespace SimpleBackend.Areas.App.Models
{
    static public class Extensions
    {
        static public TDestination To<TDestination>(this object source, TDestination destination = null)
            where TDestination : class, new()
        {
            foreach (var item in source.GetType().GetProperties())
            {
                var value = item.GetValue(source);

                if (value == null)
                    continue;

                var property = typeof(TDestination).GetProperty(item.Name);

                if (property != null && property.PropertyType == item.PropertyType)
                {
                    if (destination == null)
                    {
                        destination = new TDestination();
                    }

                    property.SetValue(destination, value);

                }

            }

            return destination;
        }
    }
}