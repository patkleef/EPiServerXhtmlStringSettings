using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Cms.Shell.UI.ObjectEditing.EditorDescriptors;
using EPiServer.Core;
using EPiServer.Shell.ObjectEditing.EditorDescriptors;

namespace EPiServerXhtmlStringSettings.Business.EditorDescriptors
{
    [EditorDescriptorRegistration(TargetType = typeof (XhtmlString), UIHint = "custom-xhtmlstring")]
    public class CustomXhtmlStringEditorDescriptor : XhtmlStringEditorDescriptor
    {
        public CustomXhtmlStringEditorDescriptor() : base()
        {

        }

        public override void ModifyMetadata(EPiServer.Shell.ObjectEditing.ExtendedMetadata metadata,
            IEnumerable<Attribute> attributes)
        {
            base.ModifyMetadata(metadata, attributes);

            dynamic data = metadata.CustomEditorSettings["uiParams"];
            var dictionary = (Dictionary<string, object>) data.GetType().GetProperty("inlineSettings").GetValue(data, null);
            //dictionary["body_class"] = dictionary["body_class"] + " container";
        }
    }
}