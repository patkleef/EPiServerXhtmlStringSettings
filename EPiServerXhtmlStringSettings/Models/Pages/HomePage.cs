using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace EPiServerXhtmlStringSettings.Models.Pages
{
    [ContentType(DisplayName = "HomePage", GUID = "492924e5-7d6d-4757-8411-79a2b722ac78", Description = "")]
    public class HomePage : PageData
    {
        [UIHint("custom-xhtmlstring")]
        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString MainBody { get; set; }
    }
}