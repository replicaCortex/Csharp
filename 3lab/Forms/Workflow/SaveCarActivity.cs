using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;

namespace Forms.Workflow
{

	public sealed class SaveCarActivity : CodeActivity
	{
		// Определите входной аргумент действия типа string
		public InArgument<string> Text { get; set; }

		// Если действие возвращает значение, создайте класс, производный от CodeActivity<TResult>
		// и верните значение из метода Execute.
		protected override void Execute(CodeActivityContext context)
		{
			// Получите значение входного аргумента Text во время выполнения
			string text = context.GetValue(this.Text);
		}
	}
}
