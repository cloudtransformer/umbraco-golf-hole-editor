using Umbraco.Core.PropertyEditors;

namespace AgeBase.GolfHoleEditor
{
    internal class GolfHoleEditorPreValueEditor : PreValueEditor
    {
        public GolfHoleEditorPreValueEditor()
        {
            Fields.Add(new PreValueField
            {
                Description = "Enter a comma separated list of tees available for each hole. For example: White,Yellow,Red. Default set to White, Yellow and Red.",
                Key = "tees",
                View = "requiredfield",
                Name = "Tees"
            });

            Fields.Add(new PreValueField
            {
                Description = "Enter a comma separated list of tees available for each hole. For example: 1,2,3,4,5,6,7,8,9. Default set to 1 to 18 holes.",
                Key = "holes",
                View = "requiredfield",
                Name = "Holes"
            });

            Fields.Add(new PreValueField
            {
                Description = "Enter a comma separated list of pars available for each hole. For example: 3,4,5. Default set to pars 3, 4 and 5.",
                Key = "pars",
                View = "requiredfield",
                Name = "Pars"
            });
        }
    }
}