using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvp_base
{
	/// <summary>
	/// Объект для события с возвратом значения.
	/// </summary>
	/// <typeparam name="TRequestParams">Параметр запроса</typeparam>
	/// <typeparam name="TResult">Результат запроса</typeparam>
	public class ViewRequest<TRequestParams, TResult>
	{
		public TRequestParams Parameter { get; set; }
		public ViewResponse<TResult> Response { get; set; }
	}
}