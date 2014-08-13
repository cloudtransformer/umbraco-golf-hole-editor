using Umbraco.Core.PropertyEditors;

namespace AgeBase.GolfHoleEditor
{
    public class GolfHoleEditorPropertyEditor : PropertyEditor
    {
        protected override PreValueEditor CreatePreValueEditor()
        {
            return new GolfHoleEditorPreValueEditor();
        }
    }
}