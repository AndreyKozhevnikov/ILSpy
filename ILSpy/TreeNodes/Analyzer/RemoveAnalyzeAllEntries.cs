using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICSharpCode.ILSpy.TreeNodes.Analyzer
{
	[ExportContextMenuEntry(Header = "RemoveAll", Icon = "images/Delete.png", Category = "Analyze", Order = 200)]
	internal sealed class RemoveAnalyzeAllEntries : IContextMenuEntry
	{
		public bool IsVisible(TextViewContext context)
		{
			if (context.TreeView is AnalyzerTreeView && context.SelectedTreeNodes != null && context.SelectedTreeNodes.All(n => n.Parent.IsRoot))
				return true;
			return false;
		}

		public bool IsEnabled(TextViewContext context)
		{
			return true;
		}

		public void Execute(TextViewContext context)
		{
			context.TreeView.Root.Children.Clear();
			//if (context.SelectedTreeNodes != null) {
			//	foreach (var node in context.SelectedTreeNodes) {
			//		node.Parent.Children.Remove(node);
			//	}
			//}
		}
	}
}
