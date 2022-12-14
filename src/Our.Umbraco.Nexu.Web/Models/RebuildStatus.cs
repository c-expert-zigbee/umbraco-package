namespace Our.Umbraco.Nexu.Web.Models
{
    /// <summary>
    /// Represents the rebuild status.
    /// </summary>
    public class RebuildStatus
    {
        /// <summary>
        /// Gets or sets a value indicating whether is processing.
        /// </summary>
        public bool IsProcessing { get; set; }

        /// <summary>
        /// Gets or sets the item name.
        /// </summary>
        public string ItemName { get; set; }

        /// <summary>
        /// Gets or sets the items processed.
        /// </summary>
        public int ItemsProcessed { get; set; }
    }
}
