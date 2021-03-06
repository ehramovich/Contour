namespace Contour
{
    using System;

    /// <summary>
    /// The message attribute.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class MessageAttribute : Attribute
    {
        #region Fields

        /// <summary>
        /// The label.
        /// </summary>
        public readonly string Label;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// �������������� ����� ��������� ������ <see cref="MessageAttribute"/>.
        /// </summary>
        /// <param name="label">
        /// The label.
        /// </param>
        public MessageAttribute(string label)
        {
            this.Label = label;
        }

        #endregion
    }
}
