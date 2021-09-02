using Domain.Enums;
using System.Drawing;

namespace CommonUIComponents
{
	/// <summary>
	/// Содержит сопоставление иконки с типом INode
	/// </summary>
	public interface INodeTypeCustomizer
	{
		Image GetIcon(NType t);
		Color GetColor(NType c);
	}
}