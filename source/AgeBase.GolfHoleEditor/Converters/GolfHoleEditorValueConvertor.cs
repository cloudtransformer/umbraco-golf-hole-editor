using System.Collections.Generic;
using AgeBase.GolfHoleEditor.Models;
using Newtonsoft.Json;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Core.PropertyEditors;
using Umbraco.Web;

namespace AgeBase.GolfHoleEditor.Converters
{
    /// <summary>
    /// Value converter class to convert a json golf hole editor value object
    /// to a list of golf tees.
    /// </summary>
    [PropertyValueType(typeof(List<string>))]
    [PropertyValueCache(PropertyCacheValue.All, PropertyCacheLevel.Content)]
    public class GolfHoleEditorValueConvertor : PropertyValueConverterBase
    {
        /// <summary>
        /// Method to convert a property value to a list of golf tees.
        /// </summary>
        /// <param name="propertyType">The current published property
        /// type to convert.</param>
        /// <param name="source">The original property data.</param>
        /// <param name="preview">True if in preview mode.</param>
        /// <returns>A collection of golf tees.</returns>
        public override object ConvertDataToSource(PublishedPropertyType propertyType, object source, bool preview)
        {
            if (source == null)
                return null;

            var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            };

            return UmbracoContext.Current == null ? null : JsonConvert.DeserializeObject<GolfTees>(source.ToString(), settings);
        }

        /// <summary>
        /// Method to see if the current property type is of type
        /// golf hole editor.
        /// </summary>
        /// <param name="propertyType">The current property type.</param>
        /// <returns>True if the current property type is of type
        /// golf hole editor.</returns>
        public override bool IsConverter(PublishedPropertyType propertyType)
        {
            return propertyType.PropertyEditorAlias.Equals("AgeBase.GolfHoleEditor");
        }
    }
}