namespace Contour.Configuration
{
    using System.Collections.Generic;
    using System.Linq;

    using Contour.Helpers;

    /// <summary>
    /// The bus component tracker.
    /// </summary>
    internal class BusComponentTracker : IBusComponentTracker
    {
        #region Fields

        /// <summary>
        /// The components.
        /// </summary>
        private readonly IList<IBusComponent> components = new List<IBusComponent>();

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// The all of.
        /// </summary>
        /// <typeparam name="T">
        /// </typeparam>
        /// <returns>
        /// The <see cref="IEnumerable{T}"/>.
        /// </returns>
        public IEnumerable<T> AllOf<T>() where T : class, IBusComponent
        {
            return this.components.OfType<T>();
        }

        /// <summary>
        /// The register.
        /// </summary>
        /// <param name="component">
        /// The component.
        /// </param>
        public void Register(IBusComponent component)
        {
            this.components.Add(component);
        }

        /// <summary>
        /// The restart all.
        /// </summary>
        public void RestartAll()
        {
            this.StopAll();
            this.StartAll();
        }

        /// <summary>
        /// The start all.
        /// </summary>
        public void StartAll()
        {
            this.components.ForEach(c => c.Start());
        }

        /// <summary>
        /// The stop all.
        /// </summary>
        public void StopAll()
        {
            this.components.ForEach(c => c.Stop());
        }

        public bool CheckHealth()
        {
            return this.components.All(c => c.IsHealthy);
        }

        #endregion
    }
}
