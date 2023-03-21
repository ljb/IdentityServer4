namespace IdentityServer4.Configuration
{
    /// <summary>
    /// Options for form post response mode
    /// </summary>
    public class FormPostResponseModeOptions
    {
        /// <summary>
        /// Extra HTML content that will be included at the end of the head element on the redirect page if FormPost is used as the response mode
        /// </summary>
        public string ExtraBodyHtmlContent { get; set; }

        /// <summary>
        /// Extra HTML content that will be included at the start of the body element on the redirect page if FormPost is used as the response mode
        /// </summary>
        public string ExtraHeadHtmlContent { get; set; }
    }
}
